using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstPassYield
{
    public partial class FirstPassYield : Form
    {
        public static string bldrsql = "Data Source=172.16.4.27;Initial Catalog=MfgTraveler;Persist Security Info=True;User ID=travelmfg;Password=Tr@vel@mfg";
        public string XT = "All";
        public string sqlFPY = @"




; with  x as
(
    Select 
		    [Serial Number], 
		    o.Product, 
		    Operation, 
		    Resolution,
		    Reasons, 
		    CASE
                WHEN (
                        d.SvcDate IS NULL
                        OR d.SvcDate = ''
                    )
                    OR o.DateTime
                    BETWEEN d.CreateDate AND d.SvcDate THEN
                    'New'
                ELSE
                    'Service'
            END AS Status,
            Datetime
	    From 
		    Operations o with (NoLock)
	    Inner Join
		    DeviceInfo d
		    On d.SerialNumber = o.[Serial Number]
        Where
		    (@prod = 'All' OR (o.Product = @prod))
		    and Datetime between @start and  DATEADD(dd,1, @end)
            and (@XT = 'All' OR (@XT = 'LC'  And [Serial Number] < '1600000') OR (@XT = 'XT'  And [Serial Number] >= '1600000'))
                                 
)


,FailedRetest as
(
	Select
		Product, substring(Operation,10,50) as operation, COUNT([Serial Number]) as count
	from 
		x
	Where
        (@stat = 'All' OR (Status = @stat)) and
		Operation like 'Retest%' and
		Resolution = 'Fail' and
		[Serial Number] in (select [Serial Number] from 
								    x x2
							    Where
                                    (@op = 'All' OR (Operation = @op)) and
		                            Operation not like 'Retest%' and
		                            Resolution = 'Pass' and
								    x.Operation like '%'+x2.Operation and
								    Cast(x.DateTime as date) = Cast(x2.DateTime as date))
	Group By
		Product, Operation

)

, FirstPass as
(
	Select
		x.Product, x.Operation, COUNT(x.[Serial Number]) as count, COUNT(x.[Serial Number]) - ISNULL(r.count,0) as net 
	from 
        x
    Left Join
	    FailedRetest r
	    on r.operation = x.Operation and r.Product = x.Product
    
	Where
        (@stat = 'All' OR (x.Status = @stat)) and
        (@op = 'All' OR (x.Operation = @op)) and
		x.Operation not like 'Retest%' and
		Resolution = 'Pass'
	Group By
		x.Product, x.Operation, r.count
)


, total as
(
	Select
		Product, Operation, Count([Serial Number]) as count
	from 
		x
	Where
        (@op = 'All' OR (Operation = @op)) and
        (@stat = 'All' OR (Status = @stat)) and
		Operation not like 'Retest%' 
	Group by 
		Product, Operation

)

Select 
    p.Product,
	p.Operation, 
	p.count [grossFirstPass], 
	ISNULL(r.count,0) [failedRetest], 
	p.net [netFirstPass], 
	t.count [total], 
	Cast(Cast(p.net as decimal) /Cast(t.count as decimal)*100 as decimal(10,2)) [firstPassYield]
From 
	FirstPass p
Left Join
	FailedRetest r
	on r.operation = p.Operation and r.Product = p.Product
Left Join
	total t
	on t.Operation = p.Operation and t.Product = p.Product
Where
    (p.Operation IN ('Programming','Activation','Pre-Glue Test', 'Post-Glue Test','Leak Test','Initial','Initial Inspection'))

";
        public string sqlFailAnalysis = @"

                    ;with x as
                    (
	                    Select 
		                        [Serial Number], 
		                        o.Product, 
		                        Operation, 
		                        Resolution,
		                        Reasons, 
		                        CASE
                                    WHEN (
                                            d.SvcDate IS NULL
                                            OR d.SvcDate = ''
                                        )
                                        OR o.DateTime
                                        BETWEEN d.CreateDate AND d.SvcDate THEN
                                        'New'
                                    ELSE
                                        'Service'
                                END AS Status,
                                Datetime
	                        From 
		                        Operations o
	                        Inner Join
		                        DeviceInfo d
		                        On d.SerialNumber = o.[Serial Number]
                            Where
		                        (@prod = 'All' OR (o.Product = @prod))
		                        and Datetime between @start and  DATEADD(dd,1, @end)
                                and (@XT = 'All' OR (@XT = 'LC'  And [Serial Number] < '1600000') OR (@XT = 'XT'  And [Serial Number] >= '1600000'))
                    )
                    ,FailedRetest as
                    (
	                    Select
		                    Product, substring(Operation,10,50) as operation, Reasons, COUNT([Serial Number]) as count
	                    from 
		                    x
	                    Where
                            (@stat = 'All' OR (Status = @stat)) and
		                    Operation like 'Retest%' and
		                    Resolution = 'Fail' and
		                    [Serial Number] in (select [Serial Number] from 
								                        x x2
							                        Where
                                                        --(@op = 'All' OR (Operation = @op)) and
		                                                Operation not like 'Retest%' and
		                                                Resolution = 'Pass' and
								                        x.Operation like '%'+x2.Operation and
								                        Cast(x.DateTime as date) = Cast(x2.DateTime as date))
	                    Group By
		                    Product, Operation, Reasons

                    )
                    , Failures as
                    (
                    Select
		                    x.Product, x.Operation, x.Reasons, COUNT(x.[Serial Number]) as count, COUNT(x.[Serial Number]) + ISNULL(r.count,0) as net 
	                    from 
                            x
                        Left Join
	                        FailedRetest r
	                        on r.operation = x.Operation and r.Product = x.Product and r.Reasons = x.Reasons
    
	                    Where
                            (@stat = 'All' OR (x.Status = @stat)) and
                            --(@op = 'All' OR (x.Operation = @op)) and
		                    (x.Operation not like 'Retest%' ) and
		                    Resolution = 'Fail'
	                    Group By
		                    x.Product, x.Operation, x.Reasons, r.count
                    )
                    , total as
                    (
	                    Select
		                    Product, Operation, Count([Serial Number]) as count
	                    from 
		                    x
	                    Where
                            --(@op = 'All' OR (Operation = @op)) and
                            (@stat = 'All' OR (Status = @stat)) and
		                    Operation not like 'Retest%' 
	                    Group by 
		                    Product, Operation
                    )

                    , failurePercents as
                    (
	                    Select 
		                    f.*, t.count [total], Cast(Cast(f.net as decimal)/Cast(t.count as decimal)*100 as decimal(10,2)) [percent]
	                    From 
		                    failures f
	                    Inner Join 
		                    total t
		                    on f.Product = t.Product and f.Operation = t.Operation
                    )
                    Select 
	                    * 
                    From 
	                    failurePercents
                    Where
	                    [percent] > 0.5
                        and (Operation IN ('Programming','Activation','Pre-Glue Test', 'Post-Glue Test','Leak Test','Initial','Initial Inspection'))";
        public FirstPassYield()
        {
            InitializeComponent();
        }

        private void FirstPassYield_Load(object sender, EventArgs e)
        {
            LoadComboOptions();
        }

        private void LoadComboOptions()
        {
            SqlConnection con = new SqlConnection(bldrsql);
            SqlCommand cmd = new SqlCommand(@"
                    Select * from (select distinct Product from Processes WITH (nolock) where LEN(Product) > 1
                    UNION
                    Select 'All') t(val)
                    Where ISNULL(t.val, '') != ''
                    Order by case when t.val = 'All' Then 1 else 0 END DESC, t.val ASC

                    --Select* from(select distinct Process[Operation] from Processes WITH (nolock) where LEN(Process) > 1
                    --UNION
                    --Select 'All') t(val)
                    --Where ISNULL(t.val, '') != ''
                    --Order by case when t.val = 'All' Then 1 else 0 END DESC, t.val ASC
                    ",con);

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            cmbProduct.DataSource = DS.Tables[0];
            cmbProduct.DisplayMember = "val";
            cmbProduct.ValueMember = "val";
            cmbProduct.SelectedIndex = 0;

            //cmbOperation.DataSource = DS.Tables[1];
            //cmbOperation.DisplayMember = "val";
            //cmbOperation.ValueMember = "val";
            cmbOperation.SelectedIndex = 0;

            cmbStatus.SelectedIndex = 0;
        }

        private void GetFPY()
        {
            SqlConnection con = new SqlConnection(bldrsql);
            SqlCommand cmd = new SqlCommand("dbo.getFPY", con);
            cmd.CommandType = CommandType.StoredProcedure;

            //cmd.Parameters.AddWithValue("@Start", dtStart.Value.ToShortDateString());
            //cmd.Parameters.AddWithValue("@End", dtEnd.Value.ToShortDateString());
            cmd.Parameters.AddWithValue("@Start", dtStart.Value);
            cmd.Parameters.AddWithValue("@End", dtEnd.Value);
            cmd.Parameters.AddWithValue("@prod", cmbProduct.Text);
            cmd.Parameters.AddWithValue("@op", cmbOperation.Text);
            cmd.Parameters.AddWithValue("@stat", cmbStatus.Text);
            cmd.Parameters.AddWithValue("@XT", XT);

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataTable DT = new DataTable();
            DA.Fill(DT);
            dgvFPY.DataSource = DT;
        }


        private void GetFA()
        {
            SqlConnection con = new SqlConnection(bldrsql);
            SqlCommand cmd = new SqlCommand("dbo.getFA", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Start", dtStart.Value);
            cmd.Parameters.AddWithValue("@End", dtEnd.Value);
            cmd.Parameters.AddWithValue("@prod", cmbProduct.Text);
            cmd.Parameters.AddWithValue("@op", cmbOperation.Text);
            cmd.Parameters.AddWithValue("@stat", cmbStatus.Text);
            cmd.Parameters.AddWithValue("@XT", XT);

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataTable DT = new DataTable();
            DA.SelectCommand.CommandTimeout = 180;
            DA.Fill(DT);
            dgvFailures.DataSource = DT;
            dgvFailures.Columns[2].FillWeight = 200;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {

            GetFA();
            GetFPY();


        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbProduct.Text == "LOC8")
            {
                chkLC.Visible = true;
                chkXT.Visible = true;
                chkLC.Checked = true;
                chkXT.Checked = false;
            }
            else
            {
                chkLC.Visible = false;
                chkXT.Visible = false;
                XT = "All";
            }
        }

        private void chkLC_CheckedChanged(object sender, EventArgs e)
        {
            if (chkXT.Checked && chkLC.Checked) XT = "All";
            else if (chkXT.Checked) XT = "XT";
            else if (chkLC.Checked) XT = "LC";
            else chkXT.Checked = true;
        }

        private void chkXT_CheckedChanged(object sender, EventArgs e)
        {
            if (chkXT.Checked && chkLC.Checked) XT = "All";
            else if (chkXT.Checked) XT = "XT";
            else if (chkLC.Checked) XT = "LC";
            else chkLC.Checked = true;
        }

        private void btnFPY_Click(object sender, EventArgs e)
        {
            dgvFailures.Visible = false;
            dgvFPY.Visible = true;
            GetFPY();
        }
    }
}
