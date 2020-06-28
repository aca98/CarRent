using System.Windows.Forms;

namespace CarRent
{
    partial class FormReservations
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
            this.LstVeCustomer = new System.Windows.Forms.ListView();
            this.CustomerIDs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FormReservation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.lstVeDeals = new System.Windows.Forms.ListView();
            this.DealID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.From = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.To = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PricePerDay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnUpdateReser = new System.Windows.Forms.Button();
            this.btnDeleteReser = new System.Windows.Forms.Button();
            this.lbLstVeCustomer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblAResTo = new System.Windows.Forms.Label();
            this.lblAResFrom = new System.Windows.Forms.Label();
            this.btnAddReservation = new System.Windows.Forms.Button();
            this.dtpAddResTo = new System.Windows.Forms.DateTimePicker();
            this.dtpAddResFrom = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstVeReservation = new System.Windows.Forms.ListView();
            this.ReservationID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idDeal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CarId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateFrom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LstVeCustomer
            // 
            this.LstVeCustomer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CustomerIDs,
            this.FormReservation,
            this.Surname,
            this.Email,
            this.Phone,
            this.Adress});
            this.LstVeCustomer.FullRowSelect = true;
            this.LstVeCustomer.GridLines = true;
            this.LstVeCustomer.HideSelection = false;
            this.LstVeCustomer.Location = new System.Drawing.Point(5, 32);
            this.LstVeCustomer.Name = "LstVeCustomer";
            this.LstVeCustomer.Size = new System.Drawing.Size(708, 113);
            this.LstVeCustomer.TabIndex = 1;
            this.LstVeCustomer.UseCompatibleStateImageBehavior = false;
            this.LstVeCustomer.View = System.Windows.Forms.View.Details;
            this.LstVeCustomer.SelectedIndexChanged += new System.EventHandler(this.LstVeCustomer_SelectedIndexChanged);
            // 
            // CustomerIDs
            // 
            this.CustomerIDs.Text = "CustomerID";
            this.CustomerIDs.Width = 118;
            // 
            // FormReservation
            // 
            this.FormReservation.Name = "FormReservations";
            this.FormReservation.Text = "Name";
            this.FormReservation.Width = 118;
            // 
            // Surname
            // 
            this.Surname.Text = "Surname";
            this.Surname.Width = 118;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 118;
            // 
            // Phone
            // 
            this.Phone.Text = "Phone";
            this.Phone.Width = 114;
            // 
            // Adress
            // 
            this.Adress.Text = "Adress";
            this.Adress.Width = 118;
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
            this.lstVeCar.Location = new System.Drawing.Point(4, 252);
            this.lstVeCar.Name = "lstVeCar";
            this.lstVeCar.Size = new System.Drawing.Size(708, 70);
            this.lstVeCar.TabIndex = 26;
            this.lstVeCar.UseCompatibleStateImageBehavior = false;
            this.lstVeCar.View = System.Windows.Forms.View.Details;
            this.lstVeCar.SelectedIndexChanged += new System.EventHandler(this.listView3_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 41;
            // 
            // Brand
            // 
            this.Brand.Text = "Brand";
            this.Brand.Width = 84;
            // 
            // Model
            // 
            this.Model.Text = "Model";
            this.Model.Width = 79;
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
            this.Drive.Width = 83;
            // 
            // Gearbox
            // 
            this.Gearbox.Text = "GearBox";
            this.Gearbox.Width = 83;
            // 
            // lstVeDeals
            // 
            this.lstVeDeals.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DealID,
            this.columnHeader1,
            this.From,
            this.To,
            this.PricePerDay});
            this.lstVeDeals.FullRowSelect = true;
            this.lstVeDeals.GridLines = true;
            this.lstVeDeals.HideSelection = false;
            this.lstVeDeals.Location = new System.Drawing.Point(4, 39);
            this.lstVeDeals.Name = "lstVeDeals";
            this.lstVeDeals.Size = new System.Drawing.Size(705, 119);
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
            // columnHeader1
            // 
            this.columnHeader1.Text = "CarID";
            this.columnHeader1.Width = 68;
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
            this.PricePerDay.Width = 268;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(5, 314);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(348, 20);
            this.dtpFrom.TabIndex = 36;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(394, 314);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(319, 20);
            this.dtpTo.TabIndex = 37;
            this.dtpTo.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // btnUpdateReser
            // 
            this.btnUpdateReser.Location = new System.Drawing.Point(5, 340);
            this.btnUpdateReser.Name = "btnUpdateReser";
            this.btnUpdateReser.Size = new System.Drawing.Size(354, 40);
            this.btnUpdateReser.TabIndex = 40;
            this.btnUpdateReser.Text = "Update Reservation";
            this.btnUpdateReser.UseVisualStyleBackColor = true;
            this.btnUpdateReser.Click += new System.EventHandler(this.btnUpdateReser_Click);
            // 
            // btnDeleteReser
            // 
            this.btnDeleteReser.Location = new System.Drawing.Point(359, 340);
            this.btnDeleteReser.Name = "btnDeleteReser";
            this.btnDeleteReser.Size = new System.Drawing.Size(354, 40);
            this.btnDeleteReser.TabIndex = 41;
            this.btnDeleteReser.Text = "Delete Reservation";
            this.btnDeleteReser.UseVisualStyleBackColor = true;
            this.btnDeleteReser.Click += new System.EventHandler(this.btnDeleteReser_Click);
            // 
            // lbLstVeCustomer
            // 
            this.lbLstVeCustomer.AutoSize = true;
            this.lbLstVeCustomer.Location = new System.Drawing.Point(2, 14);
            this.lbLstVeCustomer.Name = "lbLstVeCustomer";
            this.lbLstVeCustomer.Size = new System.Drawing.Size(90, 13);
            this.lbLstVeCustomer.TabIndex = 42;
            this.lbLstVeCustomer.Text = "List of Customers:";
            this.lbLstVeCustomer.Click += new System.EventHandler(this.lbLstVeCustomer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "List of Reservations:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(2, 298);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(33, 13);
            this.lblFrom.TabIndex = 44;
            this.lblFrom.Text = "From:";
            this.lblFrom.Click += new System.EventHandler(this.lblFrom_Click);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(356, 298);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(23, 13);
            this.lblTo.TabIndex = 45;
            this.lblTo.Text = "To:";
            this.lblTo.Click += new System.EventHandler(this.lblTo_Click);
            // 
            // lblAResTo
            // 
            this.lblAResTo.AutoSize = true;
            this.lblAResTo.Location = new System.Drawing.Point(352, 164);
            this.lblAResTo.Name = "lblAResTo";
            this.lblAResTo.Size = new System.Drawing.Size(23, 13);
            this.lblAResTo.TabIndex = 51;
            this.lblAResTo.Text = "To:";
            this.lblAResTo.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblAResFrom
            // 
            this.lblAResFrom.AutoSize = true;
            this.lblAResFrom.Location = new System.Drawing.Point(1, 164);
            this.lblAResFrom.Name = "lblAResFrom";
            this.lblAResFrom.Size = new System.Drawing.Size(33, 13);
            this.lblAResFrom.TabIndex = 50;
            this.lblAResFrom.Text = "From:";
            this.lblAResFrom.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnAddReservation
            // 
            this.btnAddReservation.Location = new System.Drawing.Point(4, 206);
            this.btnAddReservation.Name = "btnAddReservation";
            this.btnAddReservation.Size = new System.Drawing.Size(345, 40);
            this.btnAddReservation.TabIndex = 48;
            this.btnAddReservation.Text = "Add Reservation";
            this.btnAddReservation.UseVisualStyleBackColor = true;
            this.btnAddReservation.Click += new System.EventHandler(this.btnAddReservation_Click);
            // 
            // dtpAddResTo
            // 
            this.dtpAddResTo.Location = new System.Drawing.Point(355, 180);
            this.dtpAddResTo.Name = "dtpAddResTo";
            this.dtpAddResTo.Size = new System.Drawing.Size(354, 20);
            this.dtpAddResTo.TabIndex = 47;
            this.dtpAddResTo.ValueChanged += new System.EventHandler(this.dtpAddResTo_ValueChanged);
            // 
            // dtpAddResFrom
            // 
            this.dtpAddResFrom.Location = new System.Drawing.Point(4, 180);
            this.dtpAddResFrom.Name = "dtpAddResFrom";
            this.dtpAddResFrom.Size = new System.Drawing.Size(345, 20);
            this.dtpAddResFrom.TabIndex = 46;
            this.dtpAddResFrom.ValueChanged += new System.EventHandler(this.dtpAddResFrom_ValueChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(355, 206);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(354, 40);
            this.btnSave.TabIndex = 52;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "List of Deals:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstVeReservation);
            this.groupBox1.Controls.Add(this.LstVeCustomer);
            this.groupBox1.Controls.Add(this.dtpFrom);
            this.groupBox1.Controls.Add(this.dtpTo);
            this.groupBox1.Controls.Add(this.btnUpdateReser);
            this.groupBox1.Controls.Add(this.btnDeleteReser);
            this.groupBox1.Controls.Add(this.lbLstVeCustomer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblTo);
            this.groupBox1.Controls.Add(this.lblFrom);
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(716, 385);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Reservation";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lstVeReservation
            // 
            this.lstVeReservation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ReservationID,
            this.idDeal,
            this.CarId,
            this.CustomerID,
            this.dateFrom,
            this.dateTo,
            this.price});
            this.lstVeReservation.FullRowSelect = true;
            this.lstVeReservation.GridLines = true;
            this.lstVeReservation.HideSelection = false;
            this.lstVeReservation.Location = new System.Drawing.Point(5, 176);
            this.lstVeReservation.Name = "lstVeReservation";
            this.lstVeReservation.Size = new System.Drawing.Size(708, 119);
            this.lstVeReservation.TabIndex = 46;
            this.lstVeReservation.UseCompatibleStateImageBehavior = false;
            this.lstVeReservation.View = System.Windows.Forms.View.Details;
            this.lstVeReservation.SelectedIndexChanged += new System.EventHandler(this.lstVeReservation_SelectedIndexChanged_1);
            // 
            // ReservationID
            // 
            this.ReservationID.Text = "ReservationID";
            this.ReservationID.Width = 101;
            // 
            // idDeal
            // 
            this.idDeal.Text = "DealID";
            this.idDeal.Width = 101;
            // 
            // CarId
            // 
            this.CarId.Text = "CarID";
            this.CarId.Width = 101;
            // 
            // CustomerID
            // 
            this.CustomerID.Text = "CustomerID";
            this.CustomerID.Width = 101;
            // 
            // dateFrom
            // 
            this.dateFrom.Text = "From";
            this.dateFrom.Width = 101;
            // 
            // dateTo
            // 
            this.dateTo.Text = "To";
            this.dateTo.Width = 101;
            // 
            // price
            // 
            this.price.Text = "Price";
            this.price.Width = 101;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lstVeCar);
            this.groupBox2.Controls.Add(this.lstVeDeals);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.dtpAddResFrom);
            this.groupBox2.Controls.Add(this.lblAResTo);
            this.groupBox2.Controls.Add(this.dtpAddResTo);
            this.groupBox2.Controls.Add(this.lblAResFrom);
            this.groupBox2.Controls.Add(this.btnAddReservation);
            this.groupBox2.Location = new System.Drawing.Point(16, 403);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(716, 329);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Reservation";
            // 
            // FormReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(744, 744);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Load += new System.EventHandler(this.FormReservation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView LstVeCustomer;
        private System.Windows.Forms.ColumnHeader CustomerIDs;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Surname;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader Phone;
        private System.Windows.Forms.ColumnHeader Adress;
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
        private System.Windows.Forms.ListView lstVeDeals;
        private System.Windows.Forms.ColumnHeader DealID;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader From;
        private System.Windows.Forms.ColumnHeader To;
        private System.Windows.Forms.ColumnHeader PricePerDay;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button btnUpdateReser;
        private System.Windows.Forms.Button btnDeleteReser;
        private System.Windows.Forms.Label lbLstVeCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblAResTo;
        private System.Windows.Forms.Label lblAResFrom;
        private System.Windows.Forms.Button btnAddReservation;
        private System.Windows.Forms.DateTimePicker dtpAddResTo;
        private System.Windows.Forms.DateTimePicker dtpAddResFrom;
        private System.Windows.Forms.ColumnHeader FormReservation;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private ListView lstVeReservation;
        private ColumnHeader idDeal;
        private ColumnHeader CarId;
        private ColumnHeader CustomerID;
        private ColumnHeader dateFrom;
        private ColumnHeader dateTo;
        private ColumnHeader ReservationID;
        private ColumnHeader price;
    }
}