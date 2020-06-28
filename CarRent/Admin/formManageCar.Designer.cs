namespace CarRent
{
    partial class FormManageCar
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
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtEngine = new System.Windows.Forms.TextBox();
            this.txtFuel = new System.Windows.Forms.TextBox();
            this.txtDoors = new System.Windows.Forms.TextBox();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.txtDrive = new System.Windows.Forms.TextBox();
            this.txtGearbox = new System.Windows.Forms.TextBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblEngine = new System.Windows.Forms.Label();
            this.lblBody = new System.Windows.Forms.Label();
            this.lblDoors = new System.Windows.Forms.Label();
            this.lblFuel = new System.Windows.Forms.Label();
            this.lblGearbox = new System.Windows.Forms.Label();
            this.lblManudate = new System.Windows.Forms.Label();
            this.lblDrive = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.listView1 = new System.Windows.Forms.ListView();
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
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(22, 32);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(202, 20);
            this.txtBrand.TabIndex = 0;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(250, 32);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(194, 20);
            this.txtModel.TabIndex = 1;
            // 
            // txtEngine
            // 
            this.txtEngine.Location = new System.Drawing.Point(465, 32);
            this.txtEngine.Name = "txtEngine";
            this.txtEngine.Size = new System.Drawing.Size(194, 20);
            this.txtEngine.TabIndex = 2;
            this.txtEngine.TextChanged += new System.EventHandler(this.txtEngine_TextChanged);
            // 
            // txtFuel
            // 
            this.txtFuel.Location = new System.Drawing.Point(465, 85);
            this.txtFuel.Name = "txtFuel";
            this.txtFuel.Size = new System.Drawing.Size(194, 20);
            this.txtFuel.TabIndex = 5;
            // 
            // txtDoors
            // 
            this.txtDoors.Location = new System.Drawing.Point(250, 85);
            this.txtDoors.Name = "txtDoors";
            this.txtDoors.Size = new System.Drawing.Size(194, 20);
            this.txtDoors.TabIndex = 4;
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(22, 85);
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(202, 20);
            this.txtBody.TabIndex = 3;
            // 
            // txtDrive
            // 
            this.txtDrive.Location = new System.Drawing.Point(465, 135);
            this.txtDrive.Name = "txtDrive";
            this.txtDrive.Size = new System.Drawing.Size(194, 20);
            this.txtDrive.TabIndex = 8;
            // 
            // txtGearbox
            // 
            this.txtGearbox.Location = new System.Drawing.Point(22, 135);
            this.txtGearbox.Name = "txtGearbox";
            this.txtGearbox.Size = new System.Drawing.Size(202, 20);
            this.txtGearbox.TabIndex = 6;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(19, 16);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(60, 13);
            this.lblBrand.TabIndex = 9;
            this.lblBrand.Text = "Add Brand:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(247, 16);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(61, 13);
            this.lblModel.TabIndex = 10;
            this.lblModel.Text = "Add Model:";
            // 
            // lblEngine
            // 
            this.lblEngine.AutoSize = true;
            this.lblEngine.Location = new System.Drawing.Point(462, 16);
            this.lblEngine.Name = "lblEngine";
            this.lblEngine.Size = new System.Drawing.Size(65, 13);
            this.lblEngine.TabIndex = 11;
            this.lblEngine.Text = "Add Engine:";
            // 
            // lblBody
            // 
            this.lblBody.AutoSize = true;
            this.lblBody.Location = new System.Drawing.Point(19, 69);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(56, 13);
            this.lblBody.TabIndex = 12;
            this.lblBody.Text = "Add Body:";
            // 
            // lblDoors
            // 
            this.lblDoors.AutoSize = true;
            this.lblDoors.Location = new System.Drawing.Point(247, 69);
            this.lblDoors.Name = "lblDoors";
            this.lblDoors.Size = new System.Drawing.Size(94, 13);
            this.lblDoors.TabIndex = 13;
            this.lblDoors.Text = "Add Door Amount:";
            // 
            // lblFuel
            // 
            this.lblFuel.AutoSize = true;
            this.lblFuel.Location = new System.Drawing.Point(462, 69);
            this.lblFuel.Name = "lblFuel";
            this.lblFuel.Size = new System.Drawing.Size(79, 13);
            this.lblFuel.TabIndex = 14;
            this.lblFuel.Text = "Add Fuel Type:";
            // 
            // lblGearbox
            // 
            this.lblGearbox.AutoSize = true;
            this.lblGearbox.Location = new System.Drawing.Point(19, 122);
            this.lblGearbox.Name = "lblGearbox";
            this.lblGearbox.Size = new System.Drawing.Size(72, 13);
            this.lblGearbox.TabIndex = 15;
            this.lblGearbox.Text = "Add Gearbox:";
            // 
            // lblManudate
            // 
            this.lblManudate.AutoSize = true;
            this.lblManudate.Location = new System.Drawing.Point(247, 119);
            this.lblManudate.Name = "lblManudate";
            this.lblManudate.Size = new System.Drawing.Size(123, 13);
            this.lblManudate.TabIndex = 16;
            this.lblManudate.Text = "Add Manufacturing Date";
            // 
            // lblDrive
            // 
            this.lblDrive.AutoSize = true;
            this.lblDrive.Location = new System.Drawing.Point(462, 119);
            this.lblDrive.Name = "lblDrive";
            this.lblDrive.Size = new System.Drawing.Size(57, 13);
            this.lblDrive.TabIndex = 17;
            this.lblDrive.Text = "Add Drive:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 42);
            this.button1.TabIndex = 18;
            this.button1.Text = "Add Vehicle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(181, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 42);
            this.button2.TabIndex = 19;
            this.button2.Text = "Update Vehicle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(340, 173);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 42);
            this.button3.TabIndex = 20;
            this.button3.Text = "Remove Vehicle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(499, 173);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(160, 42);
            this.button4.TabIndex = 21;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(250, 135);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(194, 20);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
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
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(22, 268);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(637, 168);
            this.listView1.TabIndex = 25;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
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
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(22, 221);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(318, 31);
            this.button5.TabIndex = 28;
            this.button5.Text = "Clear Text Boxes";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(341, 221);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(318, 31);
            this.button6.TabIndex = 29;
            this.button6.Text = "Reset";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // FormManageCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 474);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblDrive);
            this.Controls.Add(this.lblManudate);
            this.Controls.Add(this.lblGearbox);
            this.Controls.Add(this.lblFuel);
            this.Controls.Add(this.lblDoors);
            this.Controls.Add(this.lblBody);
            this.Controls.Add(this.lblEngine);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.txtDrive);
            this.Controls.Add(this.txtGearbox);
            this.Controls.Add(this.txtFuel);
            this.Controls.Add(this.txtDoors);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.txtEngine);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtBrand);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormManageCar";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "formManageCar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formManageCar_FormClosing);
            this.Load += new System.EventHandler(this.formManageCar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtEngine;
        private System.Windows.Forms.TextBox txtFuel;
        private System.Windows.Forms.TextBox txtDoors;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.TextBox txtDrive;
        private System.Windows.Forms.TextBox txtGearbox;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblEngine;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.Label lblDoors;
        private System.Windows.Forms.Label lblFuel;
        private System.Windows.Forms.Label lblGearbox;
        private System.Windows.Forms.Label lblManudate;
        private System.Windows.Forms.Label lblDrive;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListView listView1;
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
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}