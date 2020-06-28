using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRent
{
    public struct FormControle
    {
        Form form;
        Database db;
        List<Vehicle> VehicleList;
        Thread thread;

        public delegate void InvokeFunction();

        public List<Vehicle> vehicleList
        {
            get => VehicleList;
            set => VehicleList = value;
        }

        public FormControle(Form frm)
        {
            form = frm;
            db = new Database();
            VehicleList = db.GetVehicles();
            thread = null;
        }

        public void RefreshDatabase(InvokeFunction f)
        {
            thread = new Thread(() => f());
            thread.IsBackground = true;
            thread.Start();
        }

        public void DatabaseConnecting()
        {
            VehicleList = db.GetVehicles();
        }

        public bool CheckTextBox()
        {
            bool flag = true;
            int result;
            foreach (var control in form.Controls)
            {
                if (control is TextBox)
                {
                    if (((TextBox) control).Text == "")
                    {
                        flag = false;
                        ((TextBox) control).BackColor = Color.Red;
                    }
                    else
                    {
                        ((TextBox) control).BackColor = Color.White;
                        if (((TextBox) control).Name == "txtDoors")
                        {
                            if (!int.TryParse(((TextBox) control).Text, out result))
                            {
                                MessageBox.Show("Amount of doors must be a number ");
                                flag = false;
                            }
                        }

                        if (((TextBox) control).Name == "txtPricePerDay")
                        {
                            if (!int.TryParse(((TextBox) control).Text, out result))
                            {
                                MessageBox.Show("Field 'Price per day' must be a number  ");
                                flag = false;
                            }
                        }
                        if (((TextBox)control).Name == "txtPhone")
                        {
                            if (((TextBox)control).Text.Any(char.IsLetter))
                            {
                                MessageBox.Show("Field 'Phone' mustn't contain a letter  ");
                                flag = false;
                            }
                        }
                    }
                }
            }

            return flag;
        }

        public void WhiteTextBoxes()
        {
            foreach (var control in form.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox) control).BackColor = Color.White;
                }
            }
        }

        public void Add1VehicleListBoxToForm<T>(T Vehicle, ListView listView)
        {
            listView.Items.Clear();
            List<ListViewItem> items = new List<ListViewItem>();
            string[] temp;
            string[] ar;

            temp = Vehicle.ToString().Trim().Split(',');
            ListViewItem item = new ListViewItem(temp[0]);
            ar = new string[temp.Length];
            for (int j = 1; j < ar.Length; j++)
            {
                ar[j] = temp[j];
            }

            item.SubItems.AddRange(ar);
            items.Add(item);

            listView.Items.AddRange(items.ToArray());
        }

        public void Add1VehicleListBoxToForm2<T>(T Vehicle, ListView listView)
        {
            List<ListViewItem> items = new List<ListViewItem>();
            string[] temp;
            string[] ar;

            temp = Vehicle.ToString().Trim().Split(',');
            ListViewItem item = new ListViewItem(temp[0]);
            ar = new string[temp.Length];
            for (int j = 1; j < ar.Length; j++)
            {
                ar[j] = temp[j];
            }

            item.SubItems.AddRange(ar);
            items.Add(item);

            listView.Items.AddRange(items.ToArray());
        }

        public void AddVehicleListBoxToForm(List<Vehicle> VehicleList, ListView listView)
        {
            listView.Items.Clear();
            List<ListViewItem> items = new List<ListViewItem>();
            string[][] ar = new string[VehicleList.Count()][];
            string[] temp;
            for (int i = 0; i < VehicleList.Count; i++)
            {
                ar[i] = VehicleList[i].ToString().Trim().Split(',');
                ListViewItem item = new ListViewItem(ar[i][0]);
                temp = new string[ar[i].Length - 1];
                for (int j = 1; j < ar[i].Length; j++)
                {
                    temp[j - 1] = ar[i][j];
                }

                item.SubItems.AddRange(temp);
                items.Add(item);
            }

            listView.Items.AddRange(items.ToArray());
        }

        public string[] ListViewSelectedItemToString(ListView listView)
        {
            string s = "";
            if (listView.SelectedItems.Count > 0)
            {
                for (int i = 0; i < listView.SelectedItems[0].SubItems.Count; i++)
                {
                    if (listView.SelectedItems[0].SubItems[i].Text != " " &&
                        listView.SelectedItems[0].SubItems[i].Text != "")
                    {
                        s += listView.SelectedItems[0].SubItems[i].Text + ',';
                    }
                }
            }

            return s.Split(',');
        }

        //FormCustomerReservation
        public void Filter()
        {
        }


        public void AddDealListBoxToForm(List<Deal> DealList, ListView listView)
        {
            listView.Items.Clear();
            List<ListViewItem> items = new List<ListViewItem>();
            string[][] ar = new string[DealList.Count()][];
            string[] temp;
            for (int i = 0; i < DealList.Count; i++)
            {
                ar[i] = DealList[i].ToString().Trim().Split(',');
                ListViewItem item = new ListViewItem(ar[i][0]);
                temp = new string[ar[i].Length - 1];
                for (int j = 1; j < ar[i].Length; j++)
                {
                    temp[j - 1] = ar[i][j];
                }

                item.SubItems.AddRange(temp);
                items.Add(item);
            }

            listView.Items.AddRange(items.ToArray());
        }

        public void AddDataToListBox<T>(List<T> DealList, ListView listView)
        {
            listView.Items.Clear();
            List<ListViewItem> items = new List<ListViewItem>();
            string[][] ar = new string[DealList.Count()][];
            string[] temp;
            for (int i = 0; i < DealList.Count; i++)
            {
                ar[i] = DealList[i].ToString().Trim().Split(',');
                ListViewItem item = new ListViewItem(ar[i][0]);
                temp = new string[ar[i].Length - 1];
                for (int j = 1; j < ar[i].Length; j++)
                {
                    temp[j - 1] = ar[i][j];
                }

                item.SubItems.AddRange(temp);
                items.Add(item);
            }

            listView.Items.AddRange(items.ToArray());
        }

        public bool CheckIFBeforeAndSameDate(DateTime dateTime1, DateTime dateTime2)
        {
            if (dateTime1.CompareTo(DateTime.Now.Date) == -1 || dateTime2.CompareTo(DateTime.Now.Date) == -1)
            {
                MessageBox.Show("You can't schedule a date yesterday");
                return false;
            }

            if (dateTime1.CompareTo(dateTime2.Date) == 0)
            {
                MessageBox.Show("Date From and Date To are the same");
                return false;
            }

            if ((dateTime2.CompareTo(dateTime1.Date)) == -1)
            {
                MessageBox.Show("Date From, needs to go Before Date to, not after");
                return false;
            }

            return true;
        }


        public void CompareVehicleListVehicle(List<Vehicle> currentList, List<Vehicle> secondList, bool dbBigger)
        {
            bool flagFound = false;
            foreach (Vehicle v in currentList)
            {
                foreach (Vehicle ve in secondList)
                {
                    if (v.CarID1 == ve.CarID1)
                    {
                        flagFound = true;
                        if (!v.ToString().Equals(ve.ToString()) && !dbBigger)
                        {
                            db.UpdateVehicle(v);
                            MessageBox.Show("Update: " + v.ToString());
                        }
                    }
                }

                if (!flagFound)
                {
                    if (dbBigger)
                    {
                        db.DeleteVehicle(v.CarID1);
                        MessageBox.Show("Delete: " + v.ToString());
                    }
                    else
                    {
                        db.AddVehicle(v);
                        MessageBox.Show("Add: " + v.ToString());
                    }
                }

                flagFound = false;
            }
        }

        public void CompareVehicleListDeal(List<Deal> currentList, List<Deal> secondList, bool dbBigger)
        {
            bool flagFound = false;
            foreach (Deal v in currentList)
            {
                foreach (Deal ve in secondList)
                {
                    if (v.DealID == ve.DealID)
                    {
                        flagFound = true;
                        if (!v.ToString().Equals(ve.ToString()) && !dbBigger)
                        {
                            db.UpdateDeal(v);
                            MessageBox.Show("Update: " + v.ToString());
                        }
                    }
                }

                if (!flagFound)
                {
                    if (dbBigger)
                    {
                        db.DeleteDeal(v.DealID);
                        MessageBox.Show("Delete: " + v.ToString());
                    }
                    else
                    {
                        db.AddDeal(v);
                        MessageBox.Show("Add: " + v.ToString());
                    }
                }

                flagFound = false;
            }
        }

        public bool checkRegisterData(string phone,string username,string email,List<Customer> list)
        {
            var linq = from s in list where s.Username.Equals(username) || s.email.Equals(email) || s.phone.Equals(phone) select s;

            if (linq.ToArray().Length > 0)
            {
                MessageBox.Show("Username, phone or email already exist");
                return false;
            }
            else
            {
                return true;
            }
        }


        public void CompareVehicleListReservation(List<Reservation> currentList, List<Reservation> secondList,
            bool dbBigger)
        {
            bool flagFound = false;
            foreach (Reservation v in currentList)
            {
                foreach (Reservation ve in secondList)
                {
                    if (v.ReservationId == ve.ReservationId)
                    {
                        flagFound = true;
                        if (!v.ToString().Equals(ve.ToString()) && !dbBigger)
                        {
                            MessageBox.Show("Current list: " + v.ToString() + "newList: " + ve.ToString());
                            db.UpdateReservation(v);
                            MessageBox.Show("Update: " + v.ToString());
                        }
                    }
                }

                if (!flagFound)
                {
                    if (dbBigger)
                    {
                        db.DeleteReservation(v.ReservationId);
                        MessageBox.Show("Delete: " + v.ToString());
                    }
                    else
                    {
                        db.AddReservation(v);
                        MessageBox.Show("Add: " + v.ToString());
                    }
                }

                flagFound = false;
            }
        }

        public void SaveToDatabaseVehicle(List<Vehicle> VehicleList)
        {
            List<Vehicle> newList = db.GetVehicles();
            if (newList.Count < VehicleList.Count)
            {
                CompareVehicleListVehicle(VehicleList, newList, false);
            }
            else if (newList.Count == VehicleList.Count)
            {
                CompareVehicleListVehicle(VehicleList, newList, false);
                CompareVehicleListVehicle(newList, VehicleList, true);
            }
            else
            {
                CompareVehicleListVehicle(newList, VehicleList, true);
            }
        }

        public void SaveToDatabaseReservation(List<Reservation> ReservatonList)
        {
            List<Reservation> newList = db.GetReservations();
            if (newList.Count < ReservatonList.Count)
            {
                CompareVehicleListReservation(ReservatonList, newList, false);
            }
            else if (newList.Count == ReservatonList.Count)
            {
                CompareVehicleListReservation(ReservatonList, newList, false);
                CompareVehicleListReservation(newList, ReservatonList, true);
            }
            else
            {
                CompareVehicleListReservation(newList, ReservatonList, true);
            }
        }

        public void SaveToDatabaseDeal(List<Deal> DealList)
        {
            List<Deal> newList = db.GetDeals();
            if (newList.Count < DealList.Count)
            {
                CompareVehicleListDeal(DealList, newList, false);
            }
            else if (newList.Count == DealList.Count)
            {
                CompareVehicleListDeal(DealList, newList, false);
                CompareVehicleListDeal(newList, DealList, true);
            }
            else
            {
                CompareVehicleListDeal(newList, DealList, true);
            }
        }

        ///<summary>
        ///Item to search for the item, List its searching in, DateFrom ,Date To, LabelFrom, LabelTO
        ///</summary>
        public bool DateCheck1<T>(T item, List<T> list, DateTime Datefrom, DateTime Dateto, Label lblFrom, Label lblTo)
        {
            bool pass = true;
            if (CheckIfDateNotBeforeORAfterOtherDate(Datefrom, Dateto) && dateIsSame(Datefrom, Dateto, item, list) && CheckIFBeforeAndSameDate(Datefrom, Dateto))
            {
                if (dateIsInside<T>(Datefrom, item, list))
                {
                    lblFrom.ForeColor = Color.Green;
                    if (dateIsInside<T>(Dateto, item, list))
                    {
                        lblTo.ForeColor = Color.Green;

                        if (dateIsOverlapping<T>(Datefrom, Dateto, item, list))
                        {
                            lblFrom.ForeColor = Color.Green;
                            lblTo.ForeColor = Color.Green;
                        }
                        else
                        {
                            lblFrom.ForeColor = Color.Red;
                            lblTo.ForeColor = Color.Red;
                            pass = false;
                        }
                    }
                    else
                    {
                        lblTo.ForeColor = Color.Red;
                        pass = false;
                    }
                }
                else
                {
                    lblFrom.ForeColor = Color.Red;
                    pass = false;
                }
            }
            else
            {
                lblFrom.ForeColor = Color.Red;
                lblTo.ForeColor = Color.Red;
                pass = false;
            }

            if (pass)
            {
                lblFrom.ForeColor = Color.Green;
                lblTo.ForeColor = Color.Green;
            }

            return pass;
        }
        public bool DateCheck1<T>(int ignoreID,T item, List<T> list, DateTime Datefrom, DateTime Dateto, Label lblFrom, Label lblTo)
        {
            bool pass = true;
            string report = "";
            if (CheckIfDateNotBeforeORAfterOtherDate(Datefrom, Dateto) && dateIsSame(ignoreID,Datefrom,Dateto,item,list) && CheckIFBeforeAndSameDate(Datefrom,Dateto))
            {
                if (dateIsInside<T>(Datefrom, item, list, ignoreID))
                {
                    lblFrom.ForeColor = Color.Green;
                    if (dateIsInside<T>(Dateto, item, list, ignoreID))
                    {
                        lblTo.ForeColor = Color.Green;

                        if (dateIsOverlapping<T>(Datefrom, Dateto, item, list))
                        {
                            lblFrom.ForeColor = Color.Green;
                            lblTo.ForeColor = Color.Green;
                        }
                        else
                        {
                            lblFrom.ForeColor = Color.Red;
                            lblTo.ForeColor = Color.Red;
                            pass = false;
                        }
                    }
                    else
                    {
                        lblTo.ForeColor = Color.Red;
                        pass = false;
                    }
                }
                else
                {
                    lblFrom.ForeColor = Color.Red;
                    pass = false;
                }
            }
            else
            {
                lblFrom.ForeColor = Color.Red;
                lblTo.ForeColor = Color.Red;
                pass = false;
            }

            if (pass)
            {
                lblFrom.ForeColor = Color.Green;
                lblTo.ForeColor = Color.Green;
            }
            else
            {
                MessageBox.Show(report);
            }

            return pass;
        }
        public bool dateIsInside<T>(DateTime date, T item, List<T> list, int ignoreID)
        {
            bool pass = true;
            string report = Environment.NewLine + "Date '" + date.ToShortDateString() + "' is inside of dates:" + Environment.NewLine;
            foreach (T temp in list)
            {
                if (CompareItemsIDs<T>(temp, item, ignoreID))
                {
                    DateTime from = DateTime.Parse(temp.GetType().GetProperty("DateFrom").GetValue(temp).ToString());
                    DateTime to = DateTime.Parse(temp.GetType().GetProperty("DateTo").GetValue(temp).ToString());

                    if (CheckForInside(from, to, date))
                    {
                        report += temp.ToString() + Environment.NewLine;
                        pass = false;
                        MessageBox.Show(report);
                        break;
                    }
                }
            }
            return pass;
        }
        public bool dateIsInside<T>(DateTime date, T item, List<T> list)
        {
            bool pass = true;
            string report = Environment.NewLine + "Date '" + date.ToShortDateString() + "' is inside of dates:" + Environment.NewLine;
            foreach (T temp in list)
            {
                if (CompareItemsIDs<T>(temp, item))
                {
                    DateTime from = DateTime.Parse(temp.GetType().GetProperty("DateFrom").GetValue(temp).ToString());
                    DateTime to = DateTime.Parse(temp.GetType().GetProperty("DateTo").GetValue(temp).ToString());

                    if (CheckForInside(from,to, date))
                    {
                        report += temp.ToString() + Environment.NewLine;
                        pass = false;
                        MessageBox.Show(report);
                        break;
                    }
                }
            }
            return pass;
        }
        public bool dateIsSame<T>(DateTime dateFrom, DateTime dateTo, T item, List<T> list)
        {
            bool pass = true;
            string report = Environment.NewLine + "Dates '" + dateFrom.ToShortDateString() + "' or '"+ dateTo.ToShortDateString() +"' are the same with:" + Environment.NewLine;
            foreach (T temp in list)
            {
                if (CompareItemsIDs<T>(temp, item))
                {
                    DateTime from = DateTime.Parse(temp.GetType().GetProperty("DateFrom").GetValue(temp).ToString());
                    DateTime to = DateTime.Parse(temp.GetType().GetProperty("DateTo").GetValue(temp).ToString());

                    if (CheckForSameDay(from, dateFrom) || CheckForSameDay(to, dateTo))
                    {
                        report += temp.ToString() + Environment.NewLine;
                        pass = false;
                        MessageBox.Show(report);
                        break;
                    }
                }
            }

            return pass;
        }
        public bool dateIsSame<T>(int ignoreID,DateTime dateFrom, DateTime dateTo, T item, List<T> list)
        {
            bool pass = true;
            string report = Environment.NewLine + "Dates '" + dateFrom.ToShortDateString() + "' or '" + dateTo.ToShortDateString() + "' are the same with:" + Environment.NewLine;
            foreach (T temp in list)
            {
                if (CompareItemsIDs<T>(temp, item,ignoreID))
                {
                    DateTime from = DateTime.Parse(temp.GetType().GetProperty("DateFrom").GetValue(temp).ToString());
                    DateTime to = DateTime.Parse(temp.GetType().GetProperty("DateTo").GetValue(temp).ToString());

                    if (CheckForSameDay(from, dateFrom) || CheckForSameDay(to, dateTo))
                    {
                        report += temp.ToString() + Environment.NewLine;
                        pass = false;
                        MessageBox.Show(report);
                        break;
                    }
                }
            }

            return pass;
        }
        /// <summary>
        /// Returns false if from is after to, or if to is before from
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public bool CheckIfDateNotBeforeORAfterOtherDate(DateTime from, DateTime to)
        {
            if (from.CompareTo(to.Date) == 1 || to.CompareTo(from.Date) == -1)
            {
                MessageBox.Show("Date From is after Date to");
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool CheckForInside(DateTime from , DateTime to, DateTime date)
        {
            
            if ((date.CompareTo(from.Date) == 1 && date.CompareTo(to.Date) == -1) /*|| CheckForSameDay(item, date)*/)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckForSameDay(DateTime date1, DateTime date2)
        {
            if (date1.CompareTo(date2.Date) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Only works for the types Deal and Reservation, checks if ID from item1 and ID from item2 are the same
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public bool CompareItemsIDs<T>(T item1, T item2)
        {
            if (typeof(T).IsAssignableFrom(typeof(Deal)))
            {
                if (item1.GetType().GetProperty("CarID").GetValue(item1).ToString()
                    .Equals(item2.GetType().GetProperty("CarID").GetValue(item2).ToString()))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (typeof(T).IsAssignableFrom(typeof(Reservation)))
            {
                if (item1.GetType().GetProperty("CarID").GetValue(item1).ToString()
                    .Equals(item2.GetType().GetProperty("CarID").GetValue(item2).ToString()))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                throw new Exception("Wrong type");
            }
        }
        public bool CompareItemsIDs<T>(T item1, T item2, int ignoreID)
        {
            if (typeof(T).IsAssignableFrom(typeof(Deal)))
            {
                if (item1.GetType().GetProperty("DealID").GetValue(item1).ToString().Equals(ignoreID.ToString()))
                {

                    return false;
                }

                if (item1.GetType().GetProperty("CarID").GetValue(item1).ToString()
                    .Equals(item2.GetType().GetProperty("CarID").GetValue(item2).ToString()))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (typeof(T).IsAssignableFrom(typeof(Reservation)))
            {
                if (item1.GetType().GetProperty("ReservationId").GetValue(item1).ToString().Equals(ignoreID.ToString()))
                {
                    return false;
                }

                if (item1.GetType().GetProperty("CarID").GetValue(item1).ToString()
                    .Equals(item2.GetType().GetProperty("CarID").GetValue(item2).ToString()))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                throw new Exception("Wrong type");
            }
        }
        public bool dateIsOverlapping<T>(DateTime dateFrom, DateTime dateTo, T item, List<T> list)
        {
            bool pass = true;
            string report = Environment.NewLine + "Dates '" + dateFrom.ToShortDateString() + "' and '" + dateTo.ToShortDateString() + "' is inside of dates:" + Environment.NewLine;
            foreach (T temp in list)
            {
                if (CompareItemsIDs<T>(temp, item))
                {
                    DateTime from =
                            DateTime.Parse(temp.GetType().GetProperty("DateFrom").GetValue(temp).ToString());
                        DateTime to = DateTime.Parse(temp.GetType().GetProperty("DateTo").GetValue(temp).ToString());
                        if (CheckForInside(dateFrom, dateTo, from) && CheckForInside(dateFrom, dateTo, to))
                        {
                            report += temp.ToString() + Environment.NewLine;
                            MessageBox.Show(report);
                            pass = false;
                            break;
                        }
//                    }
                }
            }
            return pass;
        }
        public T FindElementInListByProperty<T>(string prop, List<T> list, string value)
        {
            T temp = default;
            foreach (T item in list)
            {
                if (item.GetType().GetProperty(prop).GetValue(item).ToString().Equals(value))
                {
                    temp = item;
                    return item;
                }
            }
            return temp;
        }
        public bool CheckIfInBoundaries<T>(DateTime Datefrom, DateTime Dateto, List<T> DealList, string id)
        {
            string report = "";
            foreach (T temp in DealList)
            {
                if (temp.GetType().GetProperty("DealID").GetValue(temp).ToString() == id)
                {
                    DateTime from = DateTime.Parse(temp.GetType().GetProperty("DateFrom").GetValue(temp).ToString());
                    DateTime to = DateTime.Parse(temp.GetType().GetProperty("DateTo").GetValue(temp).ToString());

                    if ((CheckForInside(from,to, Datefrom) || CheckForSameDay(Datefrom,from)) && (CheckForInside(from, to, Dateto) || CheckForSameDay(Dateto, to)))
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Selected dates are going out side of the deal");
                        return false;
                    }
                }
            }
            return false;
        }
        public string Get<T>(string prop,T item)
        {
            return item.GetType().GetProperty(prop).GetValue(item).ToString();
        }
    }
}