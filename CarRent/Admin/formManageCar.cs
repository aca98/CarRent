using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRent
{
    public partial class FormManageCar : Form
    {
        private int CarID;
        private Database db;
        private List<Vehicle> VehicleList;
        private Thread thread;
        private FormControle FormControle;
        private int lastCarId;
        private delegate void InvokeVehicleListBox();

        public List<Vehicle> VehicleList1 { get => VehicleList; set => VehicleList = value; }

        public FormManageCar()
        {
            InitializeComponent();
            db = new Database();
            this.Dock = DockStyle.Fill;
            FormControle = new FormControle(this);
            
        }

        private void formManageCar_Load(object sender, EventArgs e)
        {
            FormControle.RefreshDatabase(GetData);
          
        }
        
        public void GetData()
        {
            VehicleList = db.GetVehicles();
            this.Invoke(new InvokeVehicleListBox(LoadVehicles));
            lastCarId = VehicleList.Last().CarID1;
            lastCarId++;


        }
        public void LoadVehicles()
        {
            FormControle.AddVehicleListBoxToForm(VehicleList,listView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] s;

            
            if (FormControle.CheckTextBox())
            {
                lastCarId++;
                Vehicle ve = new Vehicle( lastCarId, txtBrand.Text.Trim(), txtModel.Text.Trim(), txtEngine.Text.Trim(), txtBody.Text.Trim(), dateTimePicker1.Value, int.Parse(txtDoors.Text.Trim()), txtFuel.Text.Trim(), txtDrive.Text.Trim(), txtGearbox.Text.Trim());
                s = ve.NoIDToString().Trim().Split(',');
                VehicleList.Add(ve);
                ListViewItem item = new ListViewItem(ve.CarID1.ToString());
                item.SubItems.AddRange(s);
                listView1.Items.Add(item);
                FormControle.WhiteTextBoxes();
                formMain.MadeChanges = true;
                lastCarId++;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vehicle ve = null;
            Vehicle v = null;
            if (CarID != -1 )
            {
                if (FormControle.CheckTextBox())
                {
                    ve = new Vehicle(CarID, txtBrand.Text.Trim(), txtModel.Text.Trim(), txtEngine.Text.Trim(),
                    txtBody.Text.Trim(), dateTimePicker1.Value, int.Parse(txtDoors.Text.Trim()),
                    txtFuel.Text.Trim(), txtDrive.Text.Trim(), txtGearbox.Text.Trim());
                    foreach (Vehicle item in VehicleList)
                    {
                        if (item.CarID1 == CarID)
                        {
                            v = item;
                        }
                    }
                    listView1.SelectedItems[0].SubItems[1].Text = txtBrand.Text.Trim();
                    listView1.SelectedItems[0].SubItems[2].Text = txtModel.Text.Trim();
                    listView1.SelectedItems[0].SubItems[3].Text = txtEngine.Text.Trim();
                    listView1.SelectedItems[0].SubItems[4].Text = txtBody.Text.Trim();
                    listView1.SelectedItems[0].SubItems[5].Text = dateTimePicker1.Value.ToShortDateString();
                    listView1.SelectedItems[0].SubItems[6].Text = txtDoors.Text.Trim();
                    listView1.SelectedItems[0].SubItems[7].Text = txtFuel.Text.Trim();
                    listView1.SelectedItems[0].SubItems[8].Text = txtDrive.Text.Trim();
                    listView1.SelectedItems[0].SubItems[9].Text = txtGearbox.Text.Trim();

                    VehicleList[VehicleList.IndexOf(v)].Brand1 = txtBrand.Text.Trim();
                    VehicleList[VehicleList.IndexOf(v)].Model1 = txtModel.Text.Trim();
                    VehicleList[VehicleList.IndexOf(v)].Engine1 = txtEngine.Text.Trim();
                    VehicleList[VehicleList.IndexOf(v)].Body1 = txtBody.Text.Trim();
                    VehicleList[VehicleList.IndexOf(v)].ManuDate1 = dateTimePicker1.Value;
                    VehicleList[VehicleList.IndexOf(v)].Doors1 = int.Parse(txtDoors.Text.Trim());
                    VehicleList[VehicleList.IndexOf(v)].Fuel1 = txtFuel.Text.Trim();
                    VehicleList[VehicleList.IndexOf(v)].Drive1 = txtDrive.Text.Trim();
                    VehicleList[VehicleList.IndexOf(v)].Gearbox1 = txtGearbox.Text.Trim();
                    FormControle.WhiteTextBoxes();
                    formMain.MadeChanges = true;
                }
                else
                {
                    MessageBox.Show("Textbox is empty");
                }
            }
            else
            {
                MessageBox.Show("Vehicle not selected");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CarID != -1)
            {
                for (int i = 0; i < VehicleList.Count; i++)
                {
                    {
                        if (VehicleList[i].CarID1 == CarID)
                        {
                            VehicleList.RemoveAt(i);
                            formMain.MadeChanges = true;
                        }
                    }
                }
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            CarID = -1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Save();
        }

        public void Save()
        {
            formMain.MadeChanges = false;
            FormControle.SaveToDatabaseVehicle(VehicleList);
            FormControle.RefreshDatabase(GetData);

        }
        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] subitems = FormControle.ListViewSelectedItemToString(listView1);
            if (subitems.Length > 1)
            {
                CarID = int.Parse(subitems[0]);
                txtBrand.Text = subitems[1];
                txtModel.Text = subitems[2];
                txtEngine.Text = subitems[3];
                txtBody.Text = subitems[4];
                dateTimePicker1.Value = DateTime.Parse(subitems[5]);
                txtDoors.Text = subitems[6];
                txtFuel.Text = subitems[7];
                txtDrive.Text = subitems[8];
                txtGearbox.Text = subitems[9];
            }
        }
        public void ClearTextBoxes()
        {
            txtBrand.Text = "";
            txtModel.Text = "";
            txtEngine.Text = "";
            txtBody.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            txtDoors.Text = "";
            txtFuel.Text = "";
            txtDrive.Text = "";
            txtGearbox.Text = "";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            CarID = -1;
        }

        private void formManageCar_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Are you sure you want to reset?" + Environment.NewLine + "Any changes will be lost","Warning",MessageBoxButtons.YesNo);
            if(DialogResult == DialogResult.Yes)
            {
                FormControle.RefreshDatabase(GetData);
                formMain.MadeChanges = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEngine_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
