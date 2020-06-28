namespace CarRent
{
    partial class FormCustomerReservation
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTo = new System.Windows.Forms.Label();
            this.dateFrom = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddReservation = new System.Windows.Forms.Button();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lstVeDeals = new System.Windows.Forms.ListView();
            this.DealID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CarID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.From = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.To = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PricePerDay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstVeCar = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Brand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Engine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Body = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ManuDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Doors = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fuel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Drive = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gearbox = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblDrive = new System.Windows.Forms.Label();
            this.lblFuel = new System.Windows.Forms.Label();
            this.lblEngine = new System.Windows.Forms.Label();
            this.cbxDrive = new System.Windows.Forms.ComboBox();
            this.cbxFuel = new System.Windows.Forms.ComboBox();
            this.cbxEngine = new System.Windows.Forms.ComboBox();
            this.lblManufactionDate = new System.Windows.Forms.Label();
            this.lblDoorAmount = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.cbxManufacturingDate = new System.Windows.Forms.ComboBox();
            this.cbxDoorAmount = new System.Windows.Forms.ComboBox();
            this.cbxModel = new System.Windows.Forms.ComboBox();
            this.lblGearbox = new System.Windows.Forms.Label();
            this.lblBody = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.cbxGearbox = new System.Windows.Forms.ComboBox();
            this.cbxBody = new System.Windows.Forms.ComboBox();
            this.cbxBrand = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTo);
            this.groupBox1.Controls.Add(this.dateFrom);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnAddReservation);
            this.groupBox1.Controls.Add(this.dtpTo);
            this.groupBox1.Controls.Add(this.dtpFrom);
            this.groupBox1.Controls.Add(this.lstVeDeals);
            this.groupBox1.Controls.Add(this.lstVeCar);
            this.groupBox1.Controls.Add(this.lblDrive);
            this.groupBox1.Controls.Add(this.lblFuel);
            this.groupBox1.Controls.Add(this.lblEngine);
            this.groupBox1.Controls.Add(this.cbxDrive);
            this.groupBox1.Controls.Add(this.cbxFuel);
            this.groupBox1.Controls.Add(this.cbxEngine);
            this.groupBox1.Controls.Add(this.lblManufactionDate);
            this.groupBox1.Controls.Add(this.lblDoorAmount);
            this.groupBox1.Controls.Add(this.lblModel);
            this.groupBox1.Controls.Add(this.cbxManufacturingDate);
            this.groupBox1.Controls.Add(this.cbxDoorAmount);
            this.groupBox1.Controls.Add(this.cbxModel);
            this.groupBox1.Controls.Add(this.lblGearbox);
            this.groupBox1.Controls.Add(this.lblBody);
            this.groupBox1.Controls.Add(this.lblBrand);
            this.groupBox1.Controls.Add(this.cbxGearbox);
            this.groupBox1.Controls.Add(this.cbxBody);
            this.groupBox1.Controls.Add(this.cbxBrand);
            this.groupBox1.Location = new System.Drawing.Point(3, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(651, 569);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rent a Car";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dateTo
            // 
            this.dateTo.AutoSize = true;
            this.dateTo.Location = new System.Drawing.Point(329, 483);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(20, 13);
            this.dateTo.TabIndex = 40;
            this.dateTo.Text = "To";
            // 
            // dateFrom
            // 
            this.dateFrom.AutoSize = true;
            this.dateFrom.Location = new System.Drawing.Point(6, 483);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(30, 13);
            this.dateFrom.TabIndex = 39;
            this.dateFrom.Text = "From";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(221, 525);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 36);
            this.btnSave.TabIndex = 38;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddReservation
            // 
            this.btnAddReservation.Location = new System.Drawing.Point(7, 525);
            this.btnAddReservation.Name = "btnAddReservation";
            this.btnAddReservation.Size = new System.Drawing.Size(200, 36);
            this.btnAddReservation.TabIndex = 37;
            this.btnAddReservation.Text = "Add Reservation";
            this.btnAddReservation.UseVisualStyleBackColor = true;
            this.btnAddReservation.Click += new System.EventHandler(this.btnAddReservation_Click);
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(332, 499);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(311, 20);
            this.dtpTo.TabIndex = 36;
            // 
            // dtpFrom
            // 
            this.dtpFrom.CalendarMonthBackground = System.Drawing.Color.Maroon;
            this.dtpFrom.Location = new System.Drawing.Point(6, 499);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(312, 20);
            this.dtpFrom.TabIndex = 1;
            // 
            // lstVeDeals
            // 
            this.lstVeDeals.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DealID,
            this.CarID,
            this.From,
            this.To,
            this.PricePerDay});
            this.lstVeDeals.FullRowSelect = true;
            this.lstVeDeals.GridLines = true;
            this.lstVeDeals.HideSelection = false;
            this.lstVeDeals.Location = new System.Drawing.Point(6, 349);
            this.lstVeDeals.Name = "lstVeDeals";
            this.lstVeDeals.Size = new System.Drawing.Size(637, 131);
            this.lstVeDeals.TabIndex = 35;
            this.lstVeDeals.UseCompatibleStateImageBehavior = false;
            this.lstVeDeals.View = System.Windows.Forms.View.Details;
            this.lstVeDeals.SelectedIndexChanged += new System.EventHandler(this.lstVeDeals_SelectedIndexChanged);
            // 
            // DealID
            // 
            this.DealID.Text = "ID";
            this.DealID.Width = 40;
            // 
            // CarID
            // 
            this.CarID.Text = "CarID";
            this.CarID.Width = 68;
            // 
            // From
            // 
            this.From.Text = "From";
            this.From.Width = 130;
            // 
            // To
            // 
            this.To.Text = "To";
            this.To.Width = 194;
            // 
            // PricePerDay
            // 
            this.PricePerDay.Text = "PricePerDay";
            this.PricePerDay.Width = 200;
            // 
            // lstVeCar
            // 
            this.lstVeCar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Brand,
            this.Model,
            this.Engine,
            this.Body,
            this.ManuDate,
            this.Doors,
            this.Fuel,
            this.Drive,
            this.Gearbox});
            this.lstVeCar.FullRowSelect = true;
            this.lstVeCar.GridLines = true;
            this.lstVeCar.HideSelection = false;
            this.lstVeCar.Location = new System.Drawing.Point(6, 180);
            this.lstVeCar.Name = "lstVeCar";
            this.lstVeCar.Size = new System.Drawing.Size(637, 146);
            this.lstVeCar.TabIndex = 27;
            this.lstVeCar.UseCompatibleStateImageBehavior = false;
            this.lstVeCar.View = System.Windows.Forms.View.Details;
            this.lstVeCar.SelectedIndexChanged += new System.EventHandler(this.lstVeCar_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 41;
            // 
            // Brand
            // 
            this.Brand.Text = "Brand";
            this.Brand.Width = 70;
            // 
            // Model
            // 
            this.Model.Text = "Model";
            this.Model.Width = 68;
            // 
            // Engine
            // 
            this.Engine.Text = "Engine";
            // 
            // Body
            // 
            this.Body.Text = "Body";
            this.Body.Width = 65;
            // 
            // ManuDate
            // 
            this.ManuDate.Text = "Manufacturing Date";
            this.ManuDate.Width = 107;
            // 
            // Doors
            // 
            this.Doors.Text = "Doors";
            this.Doors.Width = 46;
            // 
            // Fuel
            // 
            this.Fuel.Text = "Fuel";
            this.Fuel.Width = 55;
            // 
            // Drive
            // 
            this.Drive.Text = "Drive";
            this.Drive.Width = 58;
            // 
            // Gearbox
            // 
            this.Gearbox.Text = "GearBox";
            this.Gearbox.Width = 63;
            // 
            // lblDrive
            // 
            this.lblDrive.AutoSize = true;
            this.lblDrive.Location = new System.Drawing.Point(428, 117);
            this.lblDrive.Name = "lblDrive";
            this.lblDrive.Size = new System.Drawing.Size(32, 13);
            this.lblDrive.TabIndex = 17;
            this.lblDrive.Text = "Drive";
            // 
            // lblFuel
            // 
            this.lblFuel.AutoSize = true;
            this.lblFuel.Location = new System.Drawing.Point(427, 69);
            this.lblFuel.Name = "lblFuel";
            this.lblFuel.Size = new System.Drawing.Size(27, 13);
            this.lblFuel.TabIndex = 16;
            this.lblFuel.Text = "Fuel";
            // 
            // lblEngine
            // 
            this.lblEngine.AutoSize = true;
            this.lblEngine.Location = new System.Drawing.Point(427, 22);
            this.lblEngine.Name = "lblEngine";
            this.lblEngine.Size = new System.Drawing.Size(40, 13);
            this.lblEngine.TabIndex = 15;
            this.lblEngine.Text = "Engine";
            // 
            // cbxDrive
            // 
            this.cbxDrive.FormattingEnabled = true;
            this.cbxDrive.Location = new System.Drawing.Point(431, 133);
            this.cbxDrive.Name = "cbxDrive";
            this.cbxDrive.Size = new System.Drawing.Size(209, 21);
            this.cbxDrive.TabIndex = 14;
            // 
            // cbxFuel
            // 
            this.cbxFuel.FormattingEnabled = true;
            this.cbxFuel.Location = new System.Drawing.Point(430, 85);
            this.cbxFuel.Name = "cbxFuel";
            this.cbxFuel.Size = new System.Drawing.Size(209, 21);
            this.cbxFuel.TabIndex = 13;
            // 
            // cbxEngine
            // 
            this.cbxEngine.FormattingEnabled = true;
            this.cbxEngine.Location = new System.Drawing.Point(430, 37);
            this.cbxEngine.Name = "cbxEngine";
            this.cbxEngine.Size = new System.Drawing.Size(209, 21);
            this.cbxEngine.TabIndex = 12;
            // 
            // lblManufactionDate
            // 
            this.lblManufactionDate.AutoSize = true;
            this.lblManufactionDate.Location = new System.Drawing.Point(215, 117);
            this.lblManufactionDate.Name = "lblManufactionDate";
            this.lblManufactionDate.Size = new System.Drawing.Size(101, 13);
            this.lblManufactionDate.TabIndex = 11;
            this.lblManufactionDate.Text = "Manufacturing Date";
            // 
            // lblDoorAmount
            // 
            this.lblDoorAmount.AutoSize = true;
            this.lblDoorAmount.Location = new System.Drawing.Point(215, 69);
            this.lblDoorAmount.Name = "lblDoorAmount";
            this.lblDoorAmount.Size = new System.Drawing.Size(69, 13);
            this.lblDoorAmount.TabIndex = 10;
            this.lblDoorAmount.Text = "Door Amount";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(216, 22);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(36, 13);
            this.lblModel.TabIndex = 9;
            this.lblModel.Text = "Model";
            // 
            // cbxManufacturingDate
            // 
            this.cbxManufacturingDate.FormattingEnabled = true;
            this.cbxManufacturingDate.Location = new System.Drawing.Point(219, 133);
            this.cbxManufacturingDate.Name = "cbxManufacturingDate";
            this.cbxManufacturingDate.Size = new System.Drawing.Size(209, 21);
            this.cbxManufacturingDate.TabIndex = 8;
            // 
            // cbxDoorAmount
            // 
            this.cbxDoorAmount.FormattingEnabled = true;
            this.cbxDoorAmount.Location = new System.Drawing.Point(218, 85);
            this.cbxDoorAmount.Name = "cbxDoorAmount";
            this.cbxDoorAmount.Size = new System.Drawing.Size(209, 21);
            this.cbxDoorAmount.TabIndex = 7;
            // 
            // cbxModel
            // 
            this.cbxModel.FormattingEnabled = true;
            this.cbxModel.Location = new System.Drawing.Point(218, 37);
            this.cbxModel.Name = "cbxModel";
            this.cbxModel.Size = new System.Drawing.Size(209, 21);
            this.cbxModel.TabIndex = 6;
            // 
            // lblGearbox
            // 
            this.lblGearbox.AutoSize = true;
            this.lblGearbox.Location = new System.Drawing.Point(3, 117);
            this.lblGearbox.Name = "lblGearbox";
            this.lblGearbox.Size = new System.Drawing.Size(47, 13);
            this.lblGearbox.TabIndex = 5;
            this.lblGearbox.Text = "Gearbox";
            // 
            // lblBody
            // 
            this.lblBody.AutoSize = true;
            this.lblBody.Location = new System.Drawing.Point(3, 69);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(31, 13);
            this.lblBody.TabIndex = 4;
            this.lblBody.Text = "Body";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(3, 22);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(35, 13);
            this.lblBrand.TabIndex = 3;
            this.lblBrand.Text = "Brand";
            // 
            // cbxGearbox
            // 
            this.cbxGearbox.FormattingEnabled = true;
            this.cbxGearbox.Location = new System.Drawing.Point(7, 133);
            this.cbxGearbox.Name = "cbxGearbox";
            this.cbxGearbox.Size = new System.Drawing.Size(209, 21);
            this.cbxGearbox.TabIndex = 2;
            // 
            // cbxBody
            // 
            this.cbxBody.FormattingEnabled = true;
            this.cbxBody.Location = new System.Drawing.Point(6, 85);
            this.cbxBody.Name = "cbxBody";
            this.cbxBody.Size = new System.Drawing.Size(209, 21);
            this.cbxBody.TabIndex = 1;
            // 
            // cbxBrand
            // 
            this.cbxBrand.FormattingEnabled = true;
            this.cbxBrand.Location = new System.Drawing.Point(6, 37);
            this.cbxBrand.Name = "cbxBrand";
            this.cbxBrand.Size = new System.Drawing.Size(209, 21);
            this.cbxBrand.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "List of Deals";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "List of Cars";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(435, 525);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(208, 36);
            this.btnRefresh.TabIndex = 43;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormCustomerReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 577);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCustomerReservation";
            this.Text = "FormCustomerReservation";
            this.Load += new System.EventHandler(this.FormCustomerReservation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDrive;
        private System.Windows.Forms.Label lblFuel;
        private System.Windows.Forms.Label lblEngine;
        private System.Windows.Forms.ComboBox cbxDrive;
        private System.Windows.Forms.ComboBox cbxFuel;
        private System.Windows.Forms.ComboBox cbxEngine;
        private System.Windows.Forms.Label lblManufactionDate;
        private System.Windows.Forms.Label lblDoorAmount;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.ComboBox cbxManufacturingDate;
        private System.Windows.Forms.ComboBox cbxDoorAmount;
        private System.Windows.Forms.ComboBox cbxModel;
        private System.Windows.Forms.Label lblGearbox;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.ComboBox cbxGearbox;
        private System.Windows.Forms.ComboBox cbxBody;
        private System.Windows.Forms.ComboBox cbxBrand;
        private System.Windows.Forms.ListView lstVeCar;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Brand;
        private System.Windows.Forms.ColumnHeader Model;
        private System.Windows.Forms.ColumnHeader Engine;
        private System.Windows.Forms.ColumnHeader Body;
        private System.Windows.Forms.ColumnHeader ManuDate;
        private System.Windows.Forms.ColumnHeader Doors;
        private System.Windows.Forms.ColumnHeader Fuel;
        private System.Windows.Forms.ColumnHeader Drive;
        private System.Windows.Forms.ColumnHeader Gearbox;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddReservation;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.ListView lstVeDeals;
        private System.Windows.Forms.ColumnHeader DealID;
        private System.Windows.Forms.ColumnHeader CarID;
        private System.Windows.Forms.ColumnHeader From;
        private System.Windows.Forms.ColumnHeader To;
        private System.Windows.Forms.ColumnHeader PricePerDay;
        private System.Windows.Forms.Label dateTo;
        private System.Windows.Forms.Label dateFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefresh;
    }
}