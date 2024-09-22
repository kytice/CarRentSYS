namespace CarRentSYS
{
    partial class frmProcessReturn
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPayment = new System.Windows.Forms.Button();
            this.lblCostInfo = new System.Windows.Forms.Label();
            this.lblResInfo = new System.Windows.Forms.Label();
            this.grpResInfo = new System.Windows.Forms.GroupBox();
            this.grdVehicles = new System.Windows.Forms.DataGridView();
            this.reservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reservationBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.grpResInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVehicles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource2)).BeginInit();
            this.SuspendLayout();
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
            this.menuStrip1.TabIndex = 1;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 28);
            this.label1.TabIndex = 40;
            this.label1.Text = "Process Return";
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayment.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.White;
            this.btnPayment.Location = new System.Drawing.Point(318, 67);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(173, 39);
            this.btnPayment.TabIndex = 40;
            this.btnPayment.Text = "Process Payment";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // lblCostInfo
            // 
            this.lblCostInfo.AutoSize = true;
            this.lblCostInfo.Font = new System.Drawing.Font("Consolas", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostInfo.Location = new System.Drawing.Point(315, 10);
            this.lblCostInfo.Name = "lblCostInfo";
            this.lblCostInfo.Size = new System.Drawing.Size(16, 17);
            this.lblCostInfo.TabIndex = 43;
            this.lblCostInfo.Text = "0";
            // 
            // lblResInfo
            // 
            this.lblResInfo.AutoSize = true;
            this.lblResInfo.Font = new System.Drawing.Font("Consolas", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResInfo.Location = new System.Drawing.Point(22, 10);
            this.lblResInfo.Name = "lblResInfo";
            this.lblResInfo.Size = new System.Drawing.Size(16, 17);
            this.lblResInfo.TabIndex = 42;
            this.lblResInfo.Text = "0";
            // 
            // grpResInfo
            // 
            this.grpResInfo.Controls.Add(this.lblResInfo);
            this.grpResInfo.Controls.Add(this.lblCostInfo);
            this.grpResInfo.Controls.Add(this.btnPayment);
            this.grpResInfo.Location = new System.Drawing.Point(136, 385);
            this.grpResInfo.Name = "grpResInfo";
            this.grpResInfo.Size = new System.Drawing.Size(500, 121);
            this.grpResInfo.TabIndex = 46;
            this.grpResInfo.TabStop = false;
            this.grpResInfo.Visible = false;
            // 
            // grdVehicles
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.grdVehicles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdVehicles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVehicles.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdVehicles.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdVehicles.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grdVehicles.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grdVehicles.Location = new System.Drawing.Point(23, 104);
            this.grdVehicles.Margin = new System.Windows.Forms.Padding(2);
            this.grdVehicles.Name = "grdVehicles";
            this.grdVehicles.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdVehicles.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdVehicles.RowHeadersWidth = 82;
            this.grdVehicles.RowTemplate.Height = 33;
            this.grdVehicles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdVehicles.Size = new System.Drawing.Size(740, 240);
            this.grdVehicles.TabIndex = 47;
            this.grdVehicles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdVehicles_CellContentClick);
            // 
            // reservationBindingSource
            // 
            this.reservationBindingSource.DataSource = typeof(CarRentSYS.Reservation);
            // 
            // reservationBindingSource1
            // 
            this.reservationBindingSource1.DataSource = typeof(CarRentSYS.Reservation);
            // 
            // reservationBindingSource2
            // 
            this.reservationBindingSource2.DataSource = typeof(CarRentSYS.Reservation);
            // 
            // frmProcessReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.grdVehicles);
            this.Controls.Add(this.grpResInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmProcessReturn";
            this.Load += new System.EventHandler(this.frmProcessReturn_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpResInfo.ResumeLayout(false);
            this.grpResInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVehicles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource reservationBindingSource;
        private System.Windows.Forms.BindingSource reservationBindingSource1;
        private System.Windows.Forms.BindingSource reservationBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Label lblCostInfo;
        private System.Windows.Forms.Label lblResInfo;
        private System.Windows.Forms.GroupBox grpResInfo;
        private System.Windows.Forms.DataGridView grdVehicles;
    }
}