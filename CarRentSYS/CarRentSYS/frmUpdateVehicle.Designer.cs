namespace CarRentSYS
{
    partial class frmUpdateVehicle
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRegNumSearch = new System.Windows.Forms.TextBox();
            this.cboMake = new System.Windows.Forms.ComboBox();
            this.cboTypeCode = new System.Windows.Forms.ComboBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpUpdateVehicle = new System.Windows.Forms.GroupBox();
            this.cboFuel = new System.Windows.Forms.ComboBox();
            this.cboModel = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRegNum = new System.Windows.Forms.TextBox();
            this.cboTransmission = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grdVehicles = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.grpUpdateVehicle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVehicles)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSubmit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubmit.Location = new System.Drawing.Point(304, 167);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 37);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Make";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(407, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Vehicle Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Registration Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "Update Vehicle";
            // 
            // txtRegNumSearch
            // 
            this.txtRegNumSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRegNumSearch.Location = new System.Drawing.Point(245, 90);
            this.txtRegNumSearch.MaxLength = 9;
            this.txtRegNumSearch.Name = "txtRegNumSearch";
            this.txtRegNumSearch.Size = new System.Drawing.Size(129, 26);
            this.txtRegNumSearch.TabIndex = 14;
            // 
            // cboMake
            // 
            this.cboMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMake.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMake.FormattingEnabled = true;
            this.cboMake.Location = new System.Drawing.Point(137, 77);
            this.cboMake.Margin = new System.Windows.Forms.Padding(1);
            this.cboMake.Name = "cboMake";
            this.cboMake.Size = new System.Drawing.Size(167, 26);
            this.cboMake.TabIndex = 1;
            this.cboMake.SelectedIndexChanged += new System.EventHandler(this.cboMake_SelectedIndexChanged);
            // 
            // cboTypeCode
            // 
            this.cboTypeCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTypeCode.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTypeCode.FormattingEnabled = true;
            this.cboTypeCode.Location = new System.Drawing.Point(526, 34);
            this.cboTypeCode.Margin = new System.Windows.Forms.Padding(1);
            this.cboTypeCode.Name = "cboTypeCode";
            this.cboTypeCode.Size = new System.Drawing.Size(166, 26);
            this.cboTypeCode.TabIndex = 3;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnFind.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(380, 88);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(97, 30);
            this.btnFind.TabIndex = 21;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(784, 37);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.backToolStripMenuItem.Size = new System.Drawing.Size(86, 35);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // grpUpdateVehicle
            // 
            this.grpUpdateVehicle.Controls.Add(this.cboFuel);
            this.grpUpdateVehicle.Controls.Add(this.cboModel);
            this.grpUpdateVehicle.Controls.Add(this.label8);
            this.grpUpdateVehicle.Controls.Add(this.txtRegNum);
            this.grpUpdateVehicle.Controls.Add(this.cboTransmission);
            this.grpUpdateVehicle.Controls.Add(this.label6);
            this.grpUpdateVehicle.Controls.Add(this.cboTypeCode);
            this.grpUpdateVehicle.Controls.Add(this.label7);
            this.grpUpdateVehicle.Controls.Add(this.btnSubmit);
            this.grpUpdateVehicle.Controls.Add(this.label5);
            this.grpUpdateVehicle.Controls.Add(this.label4);
            this.grpUpdateVehicle.Controls.Add(this.label3);
            this.grpUpdateVehicle.Controls.Add(this.cboMake);
            this.grpUpdateVehicle.Location = new System.Drawing.Point(12, 345);
            this.grpUpdateVehicle.Name = "grpUpdateVehicle";
            this.grpUpdateVehicle.Size = new System.Drawing.Size(742, 210);
            this.grpUpdateVehicle.TabIndex = 24;
            this.grpUpdateVehicle.TabStop = false;
            this.grpUpdateVehicle.Visible = false;
            // 
            // cboFuel
            // 
            this.cboFuel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFuel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFuel.FormattingEnabled = true;
            this.cboFuel.Items.AddRange(new object[] {
            "Petrol",
            "Diesel",
            "Hybrid",
            "Electric"});
            this.cboFuel.Location = new System.Drawing.Point(525, 119);
            this.cboFuel.Margin = new System.Windows.Forms.Padding(1);
            this.cboFuel.Name = "cboFuel";
            this.cboFuel.Size = new System.Drawing.Size(167, 26);
            this.cboFuel.TabIndex = 5;
            // 
            // cboModel
            // 
            this.cboModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboModel.FormattingEnabled = true;
            this.cboModel.Location = new System.Drawing.Point(139, 124);
            this.cboModel.Margin = new System.Windows.Forms.Padding(1);
            this.cboModel.Name = "cboModel";
            this.cboModel.Size = new System.Drawing.Size(167, 26);
            this.cboModel.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(428, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 18);
            this.label8.TabIndex = 27;
            this.label8.Text = "Fuel Type";
            // 
            // txtRegNum
            // 
            this.txtRegNum.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegNum.Location = new System.Drawing.Point(137, 28);
            this.txtRegNum.Margin = new System.Windows.Forms.Padding(1);
            this.txtRegNum.Name = "txtRegNum";
            this.txtRegNum.ReadOnly = true;
            this.txtRegNum.Size = new System.Drawing.Size(167, 27);
            this.txtRegNum.TabIndex = 0;
            // 
            // cboTransmission
            // 
            this.cboTransmission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTransmission.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTransmission.FormattingEnabled = true;
            this.cboTransmission.Items.AddRange(new object[] {
            "Manual",
            "Automatic"});
            this.cboTransmission.Location = new System.Drawing.Point(525, 77);
            this.cboTransmission.Margin = new System.Windows.Forms.Padding(1);
            this.cboTransmission.Name = "cboTransmission";
            this.cboTransmission.Size = new System.Drawing.Size(167, 26);
            this.cboTransmission.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 18);
            this.label6.TabIndex = 24;
            this.label6.Text = "RegNum";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(407, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 18);
            this.label7.TabIndex = 25;
            this.label7.Text = "Transmission";
            // 
            // grdVehicles
            // 
            this.grdVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVehicles.Location = new System.Drawing.Point(37, 122);
            this.grdVehicles.Margin = new System.Windows.Forms.Padding(1);
            this.grdVehicles.Name = "grdVehicles";
            this.grdVehicles.ReadOnly = true;
            this.grdVehicles.RowHeadersWidth = 82;
            this.grdVehicles.RowTemplate.Height = 33;
            this.grdVehicles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdVehicles.Size = new System.Drawing.Size(698, 219);
            this.grdVehicles.TabIndex = 45;
            this.grdVehicles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdVehicles_CellContentClick);
            // 
            // frmUpdateVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.grdVehicles);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRegNumSearch);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.grpUpdateVehicle);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmUpdateVehicle";
            this.Text = "frmUpdateVehicle";
            this.Load += new System.EventHandler(this.frmUpdateVehicle_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpUpdateVehicle.ResumeLayout(false);
            this.grpUpdateVehicle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVehicles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRegNumSearch;
        private System.Windows.Forms.ComboBox cboMake;
        private System.Windows.Forms.ComboBox cboTypeCode;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpUpdateVehicle;
        private System.Windows.Forms.TextBox txtRegNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboModel;
        private System.Windows.Forms.ComboBox cboFuel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboTransmission;
        private System.Windows.Forms.Label label7;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView grdVehicles;
    }
}