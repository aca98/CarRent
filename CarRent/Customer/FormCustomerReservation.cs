using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRent;

namespace CarRent
{


    public partial class FormCustomerReservation : Form
    {
        Database db;
        List<Vehicle> VehicleList;
        List<Vehicle> tempVehicles;
        List<Deal> DealList;
        List<Customer> CustomerList;
        List<Reservation> ReservationList;
        List<ComboBox> emptyComboBoxes;
        List<ComboBox> fullComboBoxes;

        FormControle formControle;
        public FormCustomerReservation()
        {
            emptyComboBoxes = new List<ComboBox>();
            fullComboBoxes = new List<ComboBox>();
            tempVehicles = new List<Vehicle>();
            DealList = new List<Deal>();
            ReservationList = new List<Reservation>();

            db = new Database();
            formControle = new FormControle(this);
            InitializeComponent();
        }

        private void FormCustomerReservation_Load(object sender, EventArgs e)
        {
            comboBoxSetUp();
            formControle.RefreshDatabase(GetData);

        }

        public void comboBoxSetUp()
        {
            emptyComboBoxes.Add(cbxBrand);
            emptyComboBoxes.Add(cbxModel);
            emptyComboBoxes.Add(cbxEngine);
            emptyComboBoxes.Add(cbxBody);
            emptyComboBoxes.Add(cbxManufacturingDate);
            emptyComboBoxes.Add(cbxDoorAmount);
            emptyComboBoxes.Add(cbxFuel);
            emptyComboBoxes.Add(cbxDrive);
            emptyComboBoxes.Add(cbxGearbox);
            foreach (ComboBox box in emptyComboBoxes)
            {
                box.SelectedIndexChanged += onCbxChange;
            }
        }


        public void GetData()
        {
            VehicleList = db.GetVehicles();
            DealList = db.GetDeals();
            ReservationList = db.GetReservations();
            this.Invoke(new FormControle.InvokeFunction(fillComboBoxes));
        }

        public void fillComboBoxes()
        {
            string[] temp;
            string vehicles = "";
            foreach (Vehicle item in VehicleList)
            {
                temp = item.NoIDToString().Split(',');
                if (!vehicles.Contains(temp[0]))
                {
                    cbxBrand.Items.Add(temp[0]);
                }
                if (!vehicles.Contains(temp[1]))
                {
                    cbxModel.Items.Add(temp[1]);
                }
                if (!vehicles.Contains(temp[2]))
                {
                    cbxEngine.Items.Add(temp[2]);
                }
                if (!vehicles.Contains(temp[3]))
                {
                    cbxBody.Items.Add(temp[3]);
                }
                if (!vehicles.Contains(temp[4]))
                {
                    cbxManufacturingDate.Items.Add(temp[4]);
                }
                if (!vehicles.Contains(temp[5]))
                {
                    cbxDoorAmount.Items.Add(temp[5]);
                }
                if (!vehicles.Contains(temp[6]))
                {
                    cbxFuel.Items.Add(temp[6]);
                }
                if (!vehicles.Contains(temp[7]))
                {
                    cbxDrive.Items.Add(temp[7]);
                }
                if (!vehicles.Contains(temp[8]))
                {
                    cbxGearbox.Items.Add(temp[8]);

                }

                vehicles += item.ToString();
            }
        }
        public void onCbxChange(object other, EventArgs e)
        {
            int count = 0;
            lstVeCar.Items.Clear();
            tempVehicles.Clear();
            if (((ComboBox)other).Text != "")
            {
                fullComboBoxes.Add(((ComboBox)other));
                emptyComboBoxes.Remove(((ComboBox)other));
            }
            else
            {
                emptyComboBoxes.Add(((ComboBox)other));
                fullComboBoxes.Remove(((ComboBox)other));
            }

            foreach (Vehicle vehicle in VehicleList)
            {
                foreach (ComboBox box in fullComboBoxes)
                {
                    if (vehicle.ToString().Contains(box.Text))
                    {
                        count++;
                    }
                    if (count == fullComboBoxes.Count)
                    {
                        tempVehicles.Add(vehicle);
                    }
                }

                count = 0;
            }
            formControle.AddVehicleListBoxToForm(tempVehicles, lstVeCar);
        }

        private void lstVeCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] temp;
            lstVeDeals.Items.Clear();
            
            if (lstVeCar.SelectedItems.Count > 0)
            {
                temp = formControle.ListViewSelectedItemToString(lstVeCar);
                foreach (Deal deal in DealList)
                {
                    if (deal.CarID == int.Parse(temp[0]))
                    {
                        formControle.Add1VehicleListBoxToForm2<Deal>(deal, lstVeDeals);
                    }
                }
            }
        }

        private void lstVeDeals_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstVeDeals.SelectedItems.Count > 0)
            {

                string[] temp = formControle.ListViewSelectedItemToString(lstVeDeals);
                dtpFrom.Value = DateTime.Parse(temp[2]).AddDays(1);
                dtpTo.Value = DateTime.Parse(temp[3]).AddDays(-1);
            }
            else
            {
                MessageBox.Show("Deal not selected");
            }
        }

        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            if (lstVeDeals.SelectedItems.Count > 0)
            {
                formMain.MadeChanges = true;
                string[] temp = formControle.ListViewSelectedItemToString(lstVeDeals);
                int carId = int.Parse(formControle.ListViewSelectedItemToString(lstVeCar)[0]);
                Reservation res = new Reservation(int.Parse(temp[0]), carId, formMain.CustomerID, dtpFrom.Value,
                    dtpTo.Value, double.Parse(temp[4]));
                Deal deal = formControle.FindElementInListByProperty("DealID", DealList, temp[0]);
                string report = "";

                if (formControle.DateCheck1<Reservation>(res, ReservationList, dtpFrom.Value, dtpTo.Value, dateFrom,
                        dateTo) &&
                    formControle.CheckIfInBoundaries(dtpFrom.Value, dtpTo.Value, DealList, temp[0]))
                {
                    formMain.MadeChanges = true;
                    ReservationList.Add(res);
                }
            }
            else
            {
                MessageBox.Show("Deal not selected");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           Save();
        }

        public void Save()
        {
            formMain.MadeChanges = false;
            formControle.SaveToDatabaseReservation(ReservationList);
            formControle.SaveToDatabaseDeal(DealList);
            formControle.RefreshDatabase(GetData);
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (formMain.MadeChanges)
            {
                DialogResult = MessageBox.Show("All unsaved changes will be delete with this action", "Warning" + Environment.NewLine + "Do you want to continue?", MessageBoxButtons.YesNo);
                if (DialogResult == DialogResult.Yes)
                {
                    formMain.MadeChanges = false;
                    formControle.RefreshDatabase(GetData);
                }
            }
        }
    }
}