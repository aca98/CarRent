using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRent
{
    public partial class FormCustomerProfile : Form
    {
        public int CustomerID = -1;
        Database db;
        List<Vehicle> VehicleList;
        private List<Reservation> ReservationList;
        private List<Reservation> TempReservationList;

        private delegate void InvokeGetData();
        Thread thread;
        int DealId;
        FormControle formControle;
        bool MadeChanges = false;
        public FormCustomerProfile()
        {
            InitializeComponent();
            CustomerID = formMain.CustomerID;
            db = new Database();
            VehicleList = new List<Vehicle>();
            ReservationList = new List<Reservation>();
            TempReservationList = new List<Reservation>();
            formControle = new FormControle(this);
            RefreshDatabase();
        }
        public void RefreshDatabase()
        {
            thread = new Thread(GetData);
            thread.IsBackground = true;
            thread.Start();
        }
        public void GetData()
        {
            VehicleList = db.GetVehicles();
            ReservationList = db.GetReservations();
            this.Invoke(new FormControle.InvokeFunction(FillListView));

        }
        public void FillListView()
        {
            TempReservationList.Clear();
            foreach (Reservation reservation in ReservationList)
            {
                if(reservation.CustomerID == CustomerID)
                {
                    TempReservationList.Add(reservation);
                }
            }

            formControle.AddDataToListBox(TempReservationList, lstVeReservation);
        }

       
        private void FormCustomerProfile_Load(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstVeReservation.SelectedItems.Count > 0)
            {
                for (int i = 0; i < ReservationList.Count; i++)
                {
                    if (ReservationList[i].ReservationId ==
                        int.Parse(formControle.ListViewSelectedItemToString(lstVeReservation)[0]))
                    {
                        formMain.MadeChanges = true;
                        ReservationList.RemoveAt(i);
                    }
                }
                FillListView();
            }
        }

        private void lstVeReservation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstVeReservation.SelectedItems.Count > 0)
            {
                string[] temp = formControle.ListViewSelectedItemToString(lstVeReservation);
                List<Vehicle> vehicles = new List<Vehicle>();
                foreach (Vehicle vehicle in VehicleList)
                {
                    if (vehicle.CarID1 == int.Parse(temp[2]))
                    {
                        vehicles.Add(vehicle);
                    }
                }
                formControle.AddDataToListBox(vehicles, lstVeCar);
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
            formControle.RefreshDatabase(GetData);
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDatabase();
        }
    }
}
