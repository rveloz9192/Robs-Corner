namespace FirstPassYield
{
    partial class FirstPassYield
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstPassYield));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.chkXT = new System.Windows.Forms.CheckBox();
            this.chkLC = new System.Windows.Forms.CheckBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbOperation = new System.Windows.Forms.ComboBox();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.dgvFPY = new System.Windows.Forms.DataGridView();
            this.dgvFailures = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbFPY = new System.Windows.Forms.TabPage();
            this.tbFA = new System.Windows.Forms.TabPage();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFPY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFailures)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tbFPY.SuspendLayout();
            this.tbFA.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnlHeader.Controls.Add(this.picLogo);
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1261, 50);
            this.pnlHeader.TabIndex = 2;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(220, 50);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 2;
            this.picLogo.TabStop = false;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.DimGray;
            this.lblHeader.Location = new System.Drawing.Point(226, 17);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(195, 33);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "First Pass Yield";
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.pnlLeft.Controls.Add(this.chkXT);
            this.pnlLeft.Controls.Add(this.chkLC);
            this.pnlLeft.Controls.Add(this.btnStart);
            this.pnlLeft.Controls.Add(this.dtEnd);
            this.pnlLeft.Controls.Add(this.dtStart);
            this.pnlLeft.Controls.Add(this.label3);
            this.pnlLeft.Controls.Add(this.label2);
            this.pnlLeft.Controls.Add(this.label4);
            this.pnlLeft.Controls.Add(this.label5);
            this.pnlLeft.Controls.Add(this.label1);
            this.pnlLeft.Controls.Add(this.cmbStatus);
            this.pnlLeft.Controls.Add(this.cmbOperation);
            this.pnlLeft.Controls.Add(this.cmbProduct);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 50);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(220, 481);
            this.pnlLeft.TabIndex = 3;
            // 
            // chkXT
            // 
            this.chkXT.AutoSize = true;
            this.chkXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkXT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chkXT.Location = new System.Drawing.Point(119, 88);
            this.chkXT.Name = "chkXT";
            this.chkXT.Size = new System.Drawing.Size(44, 20);
            this.chkXT.TabIndex = 4;
            this.chkXT.Text = "XT";
            this.chkXT.UseVisualStyleBackColor = true;
            this.chkXT.Visible = false;
            this.chkXT.CheckedChanged += new System.EventHandler(this.chkXT_CheckedChanged);
            // 
            // chkLC
            // 
            this.chkLC.AutoSize = true;
            this.chkLC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chkLC.Location = new System.Drawing.Point(70, 88);
            this.chkLC.Name = "chkLC";
            this.chkLC.Size = new System.Drawing.Size(43, 20);
            this.chkLC.TabIndex = 4;
            this.chkLC.Text = "LC";
            this.chkLC.UseVisualStyleBackColor = true;
            this.chkLC.Visible = false;
            this.chkLC.CheckedChanged += new System.EventHandler(this.chkLC_CheckedChanged);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(124, 230);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(90, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Go";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // dtEnd
            // 
            this.dtEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEnd.Location = new System.Drawing.Point(5, 65);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(209, 21);
            this.dtEnd.TabIndex = 2;
            // 
            // dtStart
            // 
            this.dtStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtStart.Location = new System.Drawing.Point(5, 22);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(209, 21);
            this.dtStart.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(3, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(3, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Operation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Start:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(3, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "End:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product";
            // 
            // cmbStatus
            // 
            this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "All",
            "New",
            "Service"});
            this.cmbStatus.Location = new System.Drawing.Point(5, 200);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(209, 24);
            this.cmbStatus.TabIndex = 0;
            // 
            // cmbOperation
            // 
            this.cmbOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOperation.FormattingEnabled = true;
            this.cmbOperation.Items.AddRange(new object[] {
            "All",
            "Activation",
            "Initial",
            "Initial Inspection",
            "Leak Test",
            "Post-Glue Test",
            "Pre-Glue Test",
            "Programming",
            "QC"});
            this.cmbOperation.Location = new System.Drawing.Point(6, 154);
            this.cmbOperation.Name = "cmbOperation";
            this.cmbOperation.Size = new System.Drawing.Size(208, 24);
            this.cmbOperation.TabIndex = 0;
            // 
            // cmbProduct
            // 
            this.cmbProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(5, 108);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(209, 24);
            this.cmbProduct.TabIndex = 0;
            this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
            // 
            // dgvFPY
            // 
            this.dgvFPY.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFPY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFPY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFPY.Location = new System.Drawing.Point(3, 3);
            this.dgvFPY.Name = "dgvFPY";
            this.dgvFPY.Size = new System.Drawing.Size(1027, 449);
            this.dgvFPY.TabIndex = 4;
            // 
            // dgvFailures
            // 
            this.dgvFailures.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFailures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFailures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFailures.Location = new System.Drawing.Point(3, 3);
            this.dgvFailures.Name = "dgvFailures";
            this.dgvFailures.Size = new System.Drawing.Size(566, 368);
            this.dgvFailures.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbFPY);
            this.tabControl1.Controls.Add(this.tbFA);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(220, 50);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1041, 481);
            this.tabControl1.TabIndex = 4;
            // 
            // tbFPY
            // 
            this.tbFPY.Controls.Add(this.dgvFPY);
            this.tbFPY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFPY.Location = new System.Drawing.Point(4, 22);
            this.tbFPY.Name = "tbFPY";
            this.tbFPY.Padding = new System.Windows.Forms.Padding(3);
            this.tbFPY.Size = new System.Drawing.Size(1033, 455);
            this.tbFPY.TabIndex = 0;
            this.tbFPY.Text = "First Pass Yield";
            this.tbFPY.UseVisualStyleBackColor = true;
            // 
            // tbFA
            // 
            this.tbFA.Controls.Add(this.dgvFailures);
            this.tbFA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFA.Location = new System.Drawing.Point(4, 22);
            this.tbFA.Name = "tbFA";
            this.tbFA.Padding = new System.Windows.Forms.Padding(3);
            this.tbFA.Size = new System.Drawing.Size(572, 374);
            this.tbFA.TabIndex = 1;
            this.tbFA.Text = "Failure Analysis";
            this.tbFA.UseVisualStyleBackColor = true;
            // 
            // FirstPassYield
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(1261, 531);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlHeader);
            this.Name = "FirstPassYield";
            this.Load += new System.EventHandler(this.FirstPassYield_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFPY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFailures)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tbFPY.ResumeLayout(false);
            this.tbFA.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbOperation;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.DataGridView dgvFPY;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.CheckBox chkXT;
        private System.Windows.Forms.CheckBox chkLC;
        private System.Windows.Forms.DataGridView dgvFailures;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbFPY;
        private System.Windows.Forms.TabPage tbFA;
    }
}

