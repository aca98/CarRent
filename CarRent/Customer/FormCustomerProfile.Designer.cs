namespace CarRent
{
    partial class FormCustomerProfile
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
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lstVeReservation = new System.Windows.Forms.ListView();
            this.ReservationID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idDeal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CarId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IDCustomer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateFrom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.lstVeCar.Location = new System.Drawing.Point(13, 234);
            this.lstVeCar.Name = "lstVeCar";
            this.lstVeCar.Size = new System.Drawing.Size(700, 91);
            this.lstVeCar.TabIndex = 28;
            this.lstVeCar.UseCompatibleStateImageBehavior = false;
            this.lstVeCar.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 70;
            // 
            // Brand
            // 
            this.Brand.Text = "Brand";
            this.Brand.Width = 70;
            // 
            // Model
            // 
            this.Model.Text = "Model";
            this.Model.Width = 70;
            // 
            // Engine
            // 
            this.Engine.Text = "Engine";
            this.Engine.Width = 70;
            // 
            // Body
            // 
            this.Body.Text = "Body";
            this.Body.Width = 70;
            // 
            // ManuDate
            // 
            this.ManuDate.Text = "Manufacturing Date";
            this.ManuDate.Width = 70;
            // 
            // Doors
            // 
            this.Doors.Text = "Doors";
            this.Doors.Width = 70;
            // 
            // Fuel
            // 
            this.Fuel.Text = "Fuel";
            this.Fuel.Width = 70;
            // 
            // Drive
            // 
            this.Drive.Text = "Drive";
            this.Drive.Width = 70;
            // 
            // Gearbox
            // 
            this.Gearbox.Text = "GearBox";
            this.Gearbox.Width = 70;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(13, 331);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(226, 42);
            this.btnRemove.TabIndex = 37;
            this.btnRemove.Text = "Remove Reservation";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(250, 331);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(226, 42);
            this.btnSave.TabIndex = 38;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lstVeReservation
            // 
            this.lstVeReservation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ReservationID,
            this.idDeal,
            this.CarId,
            this.IDCustomer,
            this.dateFrom,
            this.dateTo,
            this.price,
            this.totalPrice});
            this.lstVeReservation.FullRowSelect = true;
            this.lstVeReservation.GridLines = true;
            this.lstVeReservation.HideSelection = false;
            this.lstVeReservation.Location = new System.Drawing.Point(13, 26);
            this.lstVeReservation.Name = "lstVeReservation";
            this.lstVeReservation.Size = new System.Drawing.Size(700, 174);
            this.lstVeReservation.TabIndex = 47;
            this.lstVeReservation.UseCompatibleStateImageBehavior = false;
            this.lstVeReservation.View = System.Windows.Forms.View.Details;
            this.lstVeReservation.SelectedIndexChanged += new System.EventHandler(this.lstVeReservation_SelectedIndexChanged);
            // 
            // ReservationID
            // 
            this.ReservationID.Text = "ReservationID";
            this.ReservationID.Width = 85;
            // 
            // idDeal
            // 
            this.idDeal.Text = "DealID";
            this.idDeal.Width = 85;
            // 
            // CarId
            // 
            this.CarId.Text = "CarID";
            this.CarId.Width = 85;
            // 
            // IDCustomer
            // 
            this.IDCustomer.Text = "CustomerID";
            this.IDCustomer.Width = 85;
            // 
            // dateFrom
            // 
            this.dateFrom.Text = "From";
            this.dateFrom.Width = 85;
            // 
            // dateTo
            // 
            this.dateTo.Text = "To";
            this.dateTo.Width = 85;
            // 
            // price
            // 
            this.price.Text = "Price";
            this.price.Width = 86;
            // 
            // totalPrice
            // 
            this.totalPrice.Text = "Total Price";
            this.totalPrice.Width = 99;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(487, 331);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(226, 42);
            this.btnRefresh.TabIndex = 48;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FormCustomerProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 387);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lstVeReservation);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lstVeCar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCustomerProfile";
            this.Text = "FormCustomerProfile";
            this.Load += new System.EventHandler(this.FormCustomerProfile_Load);
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListView lstVeReservation;
        private System.Windows.Forms.ColumnHeader ReservationID;
        private System.Windows.Forms.ColumnHeader idDeal;
        private System.Windows.Forms.ColumnHeader CarId;
        private System.Windows.Forms.ColumnHeader IDCustomer;
        private System.Windows.Forms.ColumnHeader dateFrom;
        private System.Windows.Forms.ColumnHeader dateTo;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader totalPrice;
        private System.Windows.Forms.Button btnRefresh;
    }
}