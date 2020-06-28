using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CarRent
{
    public partial class FormReservations : Form
    {
        Database db;
        List<Vehicle> VehicleList;
        List<Deal> DealList;
        List<Customer> CustomerList;
        List<Reservation> ReservationList;
        private delegate void InvokeGetDataAs();
        FormControle formControle;
        bool MadeChanges = false;
        public FormReservations()
        {
            InitializeComponent();
            db = new Database();
            formControle = new FormControle(this);

            DealList = new List<Deal>();
            VehicleList = new List<Vehicle>();
            CustomerList = new List<Customer>();
            ReservationList = new List<Reservation>();
        }


        private void FormReservation_Load(object sender, EventArgs e)
        {
            formControle.RefreshDatabase(GetData);
        }

        public void GetData()
        {
            VehicleList = db.GetVehicles();
            DealList = db.GetDeals();
            CustomerList = db.GetCustomer();
            ReservationList = db.GetReservations();
            Reservation.IDincrement = ReservationList.Last().ReservationId;
            this.Invoke(new FormControle.InvokeFunction(FillListViews));
        }
        public void FillListViews()
        {
            lstVeDeals.Items.Clear();
            lstVeReservation.Items.Clear();
            formControle.AddDataToListBox<Deal>(DealList, lstVeDeals);
            formControle.AddDataToListBox<Customer>(CustomerList, LstVeCustomer);
        }

        private void LstVeCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            List<Reservation> temp = new List<Reservation>();
            if (LstVeCustomer.SelectedItems.Count > 0)
            {
                id = int.Parse(formControle.ListViewSelectedItemToString(LstVeCustomer)[0]);
                foreach (Reservation item in ReservationList)
                {
                    if (item.CustomerID == id)
                    {
                        temp.Add(item);
                    }
                }
            }
            formControle.AddDataToListBox<Reservation>(temp, lstVeReservation);
        }

        private void btnUpdateReser_Click(object sender, EventArgs e)
        {
            if (lstVeReservation.SelectedItems.Count > 0)
            {
                string[] res = formControle.ListViewSelectedItemToString(lstVeReservation);
                Reservation temp = new Reservation(int.Parse(res[0]), int.Parse(res[1]), int.Parse(res[2]),
                    int.Parse(res[3]), DateTime.Parse(res[4]), DateTime.Parse(res[5]), double.Parse(res[6]));
                if (formControle.DateCheck1(temp.ReservationId, temp, ReservationList, dtpFrom.Value, dtpTo.Value, lblFrom, lblTo) &&
                    formControle.CheckIfInBoundaries(dtpFrom.Value, dtpTo.Value, DealList, temp.DealID.ToString()))
                {
                    foreach (Reservation reservation in ReservationList)
                    {
                        if (reservation.ReservationId == temp.ReservationId)
                        {
                            formMain.MadeChanges = true;
                            reservation.DateFrom = dtpFrom.Value;
                            reservation.DateTo = dtpTo.Value;
                        }
                    }
                    Filter();
                }
            }
            else
            {
                MessageBox.Show("Reservation not selected");
            }
        }

        private void lstVeReservation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstVeReservation.SelectedItems.Count > 0)
            {
                dtpFrom.Value = DateTime.Parse(formControle.ListViewSelectedItemToString(lstVeReservation)[3]);
                dtpTo.Value = DateTime.Parse(formControle.ListViewSelectedItemToString(lstVeReservation)[4]);
                foreach (Vehicle vehicle in VehicleList)
                {
                    if (vehicle.CarID1 == int.Parse(formControle.ListViewSelectedItemToString(lstVeReservation)[1]))
                    {
                        formControle.Add1VehicleListBoxToForm(vehicle, lstVeCar);
                    }
                }
            }
            else
            {
                MessageBox.Show("Reservation not selected");
            }
        }

        private void btnDeleteReser_Click(object sender, EventArgs e)
        {
            if (lstVeReservation.SelectedItems.Count > 0)
            {
                int ReservationID = int.Parse(formControle.ListViewSelectedItemToString(lstVeReservation)[0]);
                for (int i = 0; i < ReservationList.Count; i++)
                {
                    if (ReservationList[i].ReservationId == ReservationID)
                    {
                        formMain.MadeChanges = true;
                        ReservationList.RemoveAt(i);
                        Filter();
                    }
                }
            }
            else
            {
                MessageBox.Show("Reservation not selected");
            }
        }

        public void Filter()
        {
            List<Reservation> rs = new List<Reservation>();

            if (lstVeReservation.SelectedItems.Count > 0)
            {
                foreach (Reservation reservation in ReservationList)
                {
                    if (reservation.CustomerID == int.Parse(formControle.ListViewSelectedItemToString(lstVeReservation)[3]))
                    {
                        rs.Add(reservation);
                    }
                }
            }
            formControle.AddDataToListBox<Reservation>(rs, lstVeReservation);
        }
        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            if (LstVeCustomer.SelectedItems.Count > 0)
            {
                if (lstVeDeals.SelectedItems.Count > 0)
                {
                    string[] d = formControle.ListViewSelectedItemToString(lstVeDeals);
                    string[] c = formControle.ListViewSelectedItemToString(LstVeCustomer);
                    Reservation res = new Reservation(int.Parse(d[0]), int.Parse(d[1]), int.Parse(c[0]),
                        dtpAddResFrom.Value, dtpAddResTo.Value, double.Parse(d[4]));
                    if (formControle.DateCheck1(res, ReservationList, dtpAddResFrom.Value, dtpAddResTo.Value, lblAResFrom, lblAResTo) &&
                        formControle.CheckIfInBoundaries(dtpAddResFrom.Value, dtpAddResTo.Value, DealList, d[0]))
                    {
                        formMain.MadeChanges = true;
                        ReservationList.Add(res);
                        FillListViews();
                    }
                }
                else
                {
                    MessageBox.Show("Deal not selected");
                }
            }
            else
            {
                MessageBox.Show("Customer not selected");
            }
        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstVeDeals_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] temp = formControle.ListViewSelectedItemToString(lstVeDeals);
            if (lstVeDeals.SelectedItems.Count > 0)
            {
                dtpAddResFrom.Value = DateTime.Parse(formControle.ListViewSelectedItemToString(lstVeDeals)[2]);
                dtpAddResTo.Value = DateTime.Parse(formControle.ListViewSelectedItemToString(lstVeDeals)[3]);
                foreach (Vehicle vehicle in VehicleList)
                {
                    if (vehicle.CarID1 == int.Parse(temp[1]))
                    {
                        formControle.Add1VehicleListBoxToForm(vehicle, lstVeCar);
                    }
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lbLstVeCustomer_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblFrom_Click(object sender, EventArgs e)
        {

        }

        private void lblTo_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dtpAddResTo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpAddResFrom_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           Save();
        }

        public void Save()
        {
            formMain.MadeChanges = false;
            formControle.SaveToDatabaseReservation(ReservationList);
            formControle.RefreshDatabase(GetData);
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lstVeReservation_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lstVeReservation.SelectedItems.Count > 0)
            {
                dtpFrom.Value = DateTime.Parse(formControle.ListViewSelectedItemToString(lstVeReservation)[4]);
                dtpTo.Value = DateTime.Parse(formControle.ListViewSelectedItemToString(lstVeReservation)[5]);
                foreach (Vehicle vehicle in VehicleList)
                {
                    if (vehicle.CarID1 == int.Parse(formControle.ListViewSelectedItemToString(lstVeReservation)[2]))
                    {
                        formControle.Add1VehicleListBoxToForm(vehicle, lstVeCar);
                    }
                }
            }
        }
    }
}
