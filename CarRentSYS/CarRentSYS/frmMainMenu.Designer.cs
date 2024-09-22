namespace CarRentSYS
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.mnuRates = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddVehicleType = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateVehicleType = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFleet = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddVehicle = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateVehicle = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDiscontinueVehicle = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRentals = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCreateReservation = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCancelReservation = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProcessRental = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProcessReturn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDataAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuYearlyCarTypeAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuYearlyRevenueAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.lblResInfo = new System.Windows.Forms.Label();
            this.mnuMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMenu
            // 
            this.mnuMenu.BackColor = System.Drawing.Color.White;
            this.mnuMenu.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRates,
            this.mnuFleet,
            this.mnuRentals,
            this.mnuDataAnalysis});
            this.mnuMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Padding = new System.Windows.Forms.Padding(5);
            this.mnuMenu.Size = new System.Drawing.Size(784, 52);
            this.mnuMenu.TabIndex = 0;
            // 
            // mnuRates
            // 
            this.mnuRates.BackColor = System.Drawing.Color.Transparent;
            this.mnuRates.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddVehicleType,
            this.mnuUpdateVehicleType});
            this.mnuRates.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuRates.Name = "mnuRates";
            this.mnuRates.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.mnuRates.Size = new System.Drawing.Size(99, 42);
            this.mnuRates.Text = "Rates";
            // 
            // mnuAddVehicleType
            // 
            this.mnuAddVehicleType.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuAddVehicleType.Name = "mnuAddVehicleType";
            this.mnuAddVehicleType.Size = new System.Drawing.Size(242, 22);
            this.mnuAddVehicleType.Text = "Add Vehicle Type";
            this.mnuAddVehicleType.Click += new System.EventHandler(this.mnuAddVehicleType_Click);
            // 
            // mnuUpdateVehicleType
            // 
            this.mnuUpdateVehicleType.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuUpdateVehicleType.Name = "mnuUpdateVehicleType";
            this.mnuUpdateVehicleType.Size = new System.Drawing.Size(242, 22);
            this.mnuUpdateVehicleType.Text = "Update Vehicle Type";
            this.mnuUpdateVehicleType.Click += new System.EventHandler(this.mnuUpdateVehicleType_Click);
            // 
            // mnuFleet
            // 
            this.mnuFleet.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddVehicle,
            this.mnuUpdateVehicle,
            this.mnuDiscontinueVehicle});
            this.mnuFleet.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuFleet.Name = "mnuFleet";
            this.mnuFleet.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.mnuFleet.Size = new System.Drawing.Size(93, 42);
            this.mnuFleet.Text = "Fleet";
            // 
            // mnuAddVehicle
            // 
            this.mnuAddVehicle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuAddVehicle.Name = "mnuAddVehicle";
            this.mnuAddVehicle.Size = new System.Drawing.Size(236, 22);
            this.mnuAddVehicle.Text = "Add Vehicle";
            this.mnuAddVehicle.Click += new System.EventHandler(this.mnuAddVehicle_Click);
            // 
            // mnuUpdateVehicle
            // 
            this.mnuUpdateVehicle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuUpdateVehicle.Name = "mnuUpdateVehicle";
            this.mnuUpdateVehicle.Size = new System.Drawing.Size(236, 22);
            this.mnuUpdateVehicle.Text = "Update Vehicle";
            this.mnuUpdateVehicle.Click += new System.EventHandler(this.mnuUpdateVehicle_Click);
            // 
            // mnuDiscontinueVehicle
            // 
            this.mnuDiscontinueVehicle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuDiscontinueVehicle.Name = "mnuDiscontinueVehicle";
            this.mnuDiscontinueVehicle.Size = new System.Drawing.Size(236, 22);
            this.mnuDiscontinueVehicle.Text = "Discontinue Vehicle";
            this.mnuDiscontinueVehicle.Click += new System.EventHandler(this.mnuDiscontinueVehicle_Click);
            // 
            // mnuRentals
            // 
            this.mnuRentals.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCreateReservation,
            this.mnuCancelReservation,
            this.mnuProcessRental,
            this.mnuProcessReturn});
            this.mnuRentals.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuRentals.Name = "mnuRentals";
            this.mnuRentals.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.mnuRentals.Size = new System.Drawing.Size(114, 42);
            this.mnuRentals.Text = "Rentals";
            // 
            // mnuCreateReservation
            // 
            this.mnuCreateReservation.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuCreateReservation.Name = "mnuCreateReservation";
            this.mnuCreateReservation.Size = new System.Drawing.Size(233, 22);
            this.mnuCreateReservation.Text = "Create Reservation";
            this.mnuCreateReservation.Click += new System.EventHandler(this.mnuCreateReservation_Click);
            // 
            // mnuCancelReservation
            // 
            this.mnuCancelReservation.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuCancelReservation.Name = "mnuCancelReservation";
            this.mnuCancelReservation.Size = new System.Drawing.Size(233, 22);
            this.mnuCancelReservation.Text = "Cancel Reservation";
            this.mnuCancelReservation.Click += new System.EventHandler(this.mnuCancelReservation_Click);
            // 
            // mnuProcessRental
            // 
            this.mnuProcessRental.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuProcessRental.Name = "mnuProcessRental";
            this.mnuProcessRental.Size = new System.Drawing.Size(233, 22);
            this.mnuProcessRental.Text = "Process Rental";
            this.mnuProcessRental.Click += new System.EventHandler(this.mnuProcessRental_Click);
            // 
            // mnuProcessReturn
            // 
            this.mnuProcessReturn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuProcessReturn.Name = "mnuProcessReturn";
            this.mnuProcessReturn.Size = new System.Drawing.Size(233, 22);
            this.mnuProcessReturn.Text = "Process Return";
            this.mnuProcessReturn.Click += new System.EventHandler(this.mnuProcessReturn_Click);
            // 
            // mnuDataAnalysis
            // 
            this.mnuDataAnalysis.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuYearlyCarTypeAnalysis,
            this.mnuYearlyRevenueAnalysis});
            this.mnuDataAnalysis.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuDataAnalysis.Name = "mnuDataAnalysis";
            this.mnuDataAnalysis.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.mnuDataAnalysis.Size = new System.Drawing.Size(165, 42);
            this.mnuDataAnalysis.Text = "Data Analysis";
            // 
            // mnuYearlyCarTypeAnalysis
            // 
            this.mnuYearlyCarTypeAnalysis.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuYearlyCarTypeAnalysis.Name = "mnuYearlyCarTypeAnalysis";
            this.mnuYearlyCarTypeAnalysis.Size = new System.Drawing.Size(307, 22);
            this.mnuYearlyCarTypeAnalysis.Text = "Yearly Vehicle Type Analysis";
            this.mnuYearlyCarTypeAnalysis.Click += new System.EventHandler(this.mnuYearlyCarTypeAnalysis_Click);
            // 
            // mnuYearlyRevenueAnalysis
            // 
            this.mnuYearlyRevenueAnalysis.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuYearlyRevenueAnalysis.Name = "mnuYearlyRevenueAnalysis";
            this.mnuYearlyRevenueAnalysis.Size = new System.Drawing.Size(307, 22);
            this.mnuYearlyRevenueAnalysis.Text = "Yearly Revenue Analysis";
            this.mnuYearlyRevenueAnalysis.Click += new System.EventHandler(this.mnuYearlyRevenueAnalysis_Click);
            // 
            // lblResInfo
            // 
            this.lblResInfo.AutoSize = true;
            this.lblResInfo.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResInfo.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblResInfo.Location = new System.Drawing.Point(247, 169);
            this.lblResInfo.Name = "lblResInfo";
            this.lblResInfo.Size = new System.Drawing.Size(0, 56);
            this.lblResInfo.TabIndex = 43;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblResInfo);
            this.Controls.Add(this.mnuMenu);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.mnuMenu;
            this.Name = "frmMainMenu";
            this.Text = "frmMainMenu";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuRates;
        private System.Windows.Forms.ToolStripMenuItem mnuAddVehicleType;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateVehicleType;
        private System.Windows.Forms.ToolStripMenuItem mnuFleet;
        private System.Windows.Forms.ToolStripMenuItem mnuAddVehicle;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateVehicle;
        private System.Windows.Forms.ToolStripMenuItem mnuDiscontinueVehicle;
        private System.Windows.Forms.ToolStripMenuItem mnuRentals;
        private System.Windows.Forms.ToolStripMenuItem mnuCreateReservation;
        private System.Windows.Forms.ToolStripMenuItem mnuCancelReservation;
        private System.Windows.Forms.ToolStripMenuItem mnuProcessRental;
        private System.Windows.Forms.ToolStripMenuItem mnuProcessReturn;
        private System.Windows.Forms.ToolStripMenuItem mnuDataAnalysis;
        private System.Windows.Forms.ToolStripMenuItem mnuYearlyCarTypeAnalysis;
        private System.Windows.Forms.ToolStripMenuItem mnuYearlyRevenueAnalysis;
        private System.Windows.Forms.Label lblResInfo;
    }
}