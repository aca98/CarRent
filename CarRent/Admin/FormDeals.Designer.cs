namespace CarRent
{
    partial class FormDeals
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
            this.txtPricePerDay = new System.Windows.Forms.TextBox();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnAddDeal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lstVeDeals = new System.Windows.Forms.ListView();
            this.DealID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CarID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.From = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.To = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PricePerDay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblListCars = new System.Windows.Forms.Label();
            this.lblListDeals = new System.Windows.Forms.Label();
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
            this.lstVeCar.Location = new System.Drawing.Point(15, 27);
            this.lstVeCar.Name = "lstVeCar";
            this.lstVeCar.Size = new System.Drawing.Size(637, 146);
            this.lstVeCar.TabIndex = 26;
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
            // txtPricePerDay
            // 
            this.txtPricePerDay.Location = new System.Drawing.Point(15, 205);
            this.txtPricePerDay.Name = "txtPricePerDay";
            this.txtPricePerDay.Size = new System.Drawing.Size(100, 20);
            this.txtPricePerDay.TabIndex = 27;
            // 
            // dtpFrom
            // 
            this.dtpFrom.CalendarForeColor = System.Drawing.Color.Maroon;
            this.dtpFrom.CalendarMonthBackground = System.Drawing.Color.DarkRed;
            this.dtpFrom.CalendarTitleBackColor = System.Drawing.Color.DarkRed;
            this.dtpFrom.CalendarTitleForeColor = System.Drawing.Color.DarkRed;
            this.dtpFrom.CalendarTrailingForeColor = System.Drawing.Color.DarkRed;
            this.dtpFrom.Location = new System.Drawing.Point(131, 205);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(202, 20);
            this.dtpFrom.TabIndex = 28;
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(339, 205);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 20);
            this.dtpTo.TabIndex = 29;
            // 
            // btnAddDeal
            // 
            this.btnAddDeal.Location = new System.Drawing.Point(15, 401);
            this.btnAddDeal.Name = "btnAddDeal";
            this.btnAddDeal.Size = new System.Drawing.Size(212, 41);
            this.btnAddDeal.TabIndex = 30;
            this.btnAddDeal.Text = "Add Deal";
            this.btnAddDeal.UseVisualStyleBackColor = true;
            this.btnAddDeal.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Price per Day:";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(128, 189);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(33, 13);
            this.lblFrom.TabIndex = 32;
            this.lblFrom.Text = "From:";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(336, 189);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(23, 13);
            this.lblTo.TabIndex = 33;
            this.lblTo.Text = "To:";
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
            this.lstVeDeals.Location = new System.Drawing.Point(15, 249);
            this.lstVeDeals.Name = "lstVeDeals";
            this.lstVeDeals.Size = new System.Drawing.Size(637, 146);
            this.lstVeDeals.TabIndex = 34;
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
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(333, 442);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(319, 41);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(439, 401);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(213, 41);
            this.btnRemove.TabIndex = 36;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(227, 401);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(212, 41);
            this.btnUpdate.TabIndex = 37;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(545, 184);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(107, 41);
            this.btnReset.TabIndex = 38;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 442);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(318, 41);
            this.button2.TabIndex = 40;
            this.button2.Text = "Show All Deals";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblListCars
            // 
            this.lblListCars.AutoSize = true;
            this.lblListCars.Location = new System.Drawing.Point(12, 11);
            this.lblListCars.Name = "lblListCars";
            this.lblListCars.Size = new System.Drawing.Size(62, 13);
            this.lblListCars.TabIndex = 41;
            this.lblListCars.Text = "List of Cars:";
            // 
            // lblListDeals
            // 
            this.lblListDeals.AutoSize = true;
            this.lblListDeals.Location = new System.Drawing.Point(12, 233);
            this.lblListDeals.Name = "lblListDeals";
            this.lblListDeals.Size = new System.Drawing.Size(65, 13);
            this.lblListDeals.TabIndex = 42;
            this.lblListDeals.Text = "List of Deals";
            // 
            // FormDeals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 493);
            this.Controls.Add(this.lblListDeals);
            this.Controls.Add(this.lblListCars);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lstVeDeals);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddDeal);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.txtPricePerDay);
            this.Controls.Add(this.lstVeCar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDeals";
            this.Text = "FormDeals";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDeals_FormClosing);
            this.Load += new System.EventHandler(this.FormDeals_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox txtPricePerDay;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button btnAddDeal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.ListView lstVeDeals;
        private System.Windows.Forms.ColumnHeader DealID;
        private System.Windows.Forms.ColumnHeader From;
        private System.Windows.Forms.ColumnHeader To;
        private System.Windows.Forms.ColumnHeader PricePerDay;
        private System.Windows.Forms.ColumnHeader CarID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblListCars;
        private System.Windows.Forms.Label lblListDeals;
    }
}