using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
namespace CarRent
{
    class Database
    {
        private OleDbConnection conn;

        public Database()
        {
            conn = new OleDbConnection();
            string exec = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(exec));
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='CarRent.accdb'";
        }

        public void OpenConnection()
        {
         
                try
                {
                    conn.Open();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Database doesn't exist" + e.Message);
                }
            
        }
        public void CloseConnection()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }

        public OleDbConnection DbConnection
        {
            get { return conn; }
            set { conn = value; }
        }

        public void AddVehicle(Vehicle vehicle)
        {
            OpenConnection();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO Cars(Brand,Model,Engine,Body,ManuDate,Doors,Fuel,Drive,Gearbox)" +
                "VALUES(@Brand,@Model,@Engine,@Body,@ManuDate,@Doors,@Fuel,@Drive,@Gearbox)";
            cmd.Parameters.AddWithValue("Brand",vehicle.Brand1);
            cmd.Parameters.AddWithValue("Model",vehicle.Model1);
            cmd.Parameters.AddWithValue("Engine", vehicle.Engine1);
            cmd.Parameters.AddWithValue("Body", vehicle.Body1);
            cmd.Parameters.AddWithValue("ManuDate", vehicle.ManuDate1);
            cmd.Parameters.AddWithValue("Doors", vehicle.Doors1);
            cmd.Parameters.AddWithValue("Fuel", vehicle.Fuel1);
            cmd.Parameters.AddWithValue("Drive", vehicle.Drive1);
            cmd.Parameters.AddWithValue("Gearbox", vehicle.Gearbox1);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public void AddDeal(Deal deal)
        {
            OpenConnection();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO Deals(PricePerDay,CarID,DateFrom,DateTo)" +
                "VALUES(@PricePerDay,@CarID,@DateFrom,@DateTo)";
            cmd.Parameters.AddWithValue("PricePerDay", deal.PricePerDay.ToString());
            cmd.Parameters.AddWithValue("CarID", deal.CarID.ToString());
            cmd.Parameters.AddWithValue("DateFrom", deal.DateFrom.ToString());
            cmd.Parameters.AddWithValue("DateTo", deal.DateTo.ToString());
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public void AddCustomer(Customer customer)
        {
            OpenConnection();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO Customers(fullname,email,adress,phone,CustomerPassword,CustomerUsername,admin)" +
                              "VALUES(@fullname,@email,@adress,@phone,@CustomerPassword,@CustomerUsername,@admin)";
            cmd.Parameters.AddWithValue("fullname", customer.name.ToString());
            cmd.Parameters.AddWithValue("email", customer.email.ToString());
            cmd.Parameters.AddWithValue("adress", customer.adress.ToString());
            cmd.Parameters.AddWithValue("phone", customer.phone.ToString());
            cmd.Parameters.AddWithValue("CustomerPasssword", customer.Password.ToString());
            cmd.Parameters.AddWithValue("CustomerUsername", customer.Username.ToString());
            cmd.Parameters.AddWithValue("admin", customer.Admin);

            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public void AddReservation(Reservation reservation)
        {
            OpenConnection();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO Reservations(CarID,CustomerID,DealID,DateFrom,DateTo,Price)" +
                "VALUES(@CarID,@CustomerID,@DealID,@DateFrom,@DateTo,@Price)";
            cmd.Parameters.AddWithValue("CarID", reservation.CarID.ToString());
            cmd.Parameters.AddWithValue("CustomerID", reservation.CustomerID.ToString());
            cmd.Parameters.AddWithValue("DealID", reservation.DealID.ToString());
            cmd.Parameters.AddWithValue("DateFrom", reservation.DateFrom.ToString());
            cmd.Parameters.AddWithValue("DateTo", reservation.DateTo.ToString());
            cmd.Parameters.AddWithValue("Price", reservation.Price.ToString());
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public List<Vehicle> GetVehicles()
        {
            OpenConnection();
            List<Vehicle> lstV = new List<Vehicle>();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM Cars ORDER BY CarID";
            OleDbDataReader reader = cmd.ExecuteReader();
            try
            {
                while(reader.Read())
                {
                    Vehicle ve = new Vehicle();
                    ve.CarID1 = int.Parse(reader["CarID"].ToString());
                    ve.Body1 = reader["Body"].ToString();
                    ve.Brand1 = reader["Brand"].ToString();
                    ve.Doors1 = int.Parse(reader["Doors"].ToString());
                    ve.Drive1 = reader["Drive"].ToString();
                    ve.Engine1 = reader["Engine"].ToString();
                    ve.Fuel1 = reader["Fuel"].ToString();
                    ve.Gearbox1 = reader["Gearbox"].ToString();
                    ve.ManuDate1 = DateTime.Parse(reader["ManuDate"].ToString());
                    ve.Model1 = reader["Model"].ToString();
                    lstV.Add(ve);
                   
                } 
                reader.Close();
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            CloseConnection();
            return lstV;
        }

        public List<Deal> GetDeals()
        {
            OpenConnection();
            List<Deal> lstD = new List<Deal>();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM Deals ORDER BY DealID";
            OleDbDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    Deal de = new Deal();
                    de.DealID = int.Parse(reader["DealID"].ToString());
                    de.CarID = int.Parse(reader["CarID"].ToString());
                    de.DateFrom = DateTime.Parse(reader["DateFrom"].ToString());
                    de.DateTo = DateTime.Parse(reader["DateTo"].ToString());
                    de.PricePerDay = int.Parse(reader["PricePerDay"].ToString());
                    lstD.Add(de);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            CloseConnection();
            return lstD;
        }
        public List<Reservation> GetReservations()
        {
            OpenConnection();
            List<Reservation> lstR = new List<Reservation>();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM Reservations ORDER BY ReservationID";
            OleDbDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    Reservation re = new Reservation();
                    re.ReservationId = int.Parse(reader["ReservationID"].ToString());
                    re.CarID = int.Parse(reader["CarID"].ToString());
                    re.CustomerID = int.Parse(reader["CustomerID"].ToString());
                    re.DealID = int.Parse(reader["DealID"].ToString());
                    re.DateFrom = DateTime.Parse(reader["DateFrom"].ToString());
                    re.DateTo = DateTime.Parse(reader["DateTo"].ToString());
                    re.Price = double.Parse(reader["Price"].ToString());
                    lstR.Add(re);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            CloseConnection();
            return lstR;
        }
        public List<Customer> GetCustomer()
        {
            OpenConnection();
            List<Customer> lstC = new List<Customer>();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM Customers ORDER BY CustomerID";
            OleDbDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    Customer cus = new Customer();
                    cus.CustomerId = int.Parse(reader["CustomerID"].ToString());
                    cus.name = reader["fullname"].ToString();
                    cus.Username = reader["CustomerUsername"].ToString();
                    cus.Password = reader["CustomerPassword"].ToString();
                    cus.email = reader["email"].ToString();
                    cus.adress = reader["adress"].ToString();
                    cus.phone = reader["phone"].ToString();
                    cus.Admin = bool.Parse(reader["admin"].ToString());
                    lstC.Add(cus);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            CloseConnection();
            return lstC;
        }
        public void UpdateVehicle(Vehicle vehicle)
        {
            OpenConnection();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UPDATE Cars SET Brand = '" + vehicle.Brand1 + "', Model = '" + vehicle.Model1 + "', Engine = '" + vehicle.Engine1 + "', Body = '" + vehicle.Body1 + "', ManuDate = '" + vehicle.ManuDate1 + "', Doors = '" + vehicle.Doors1 + "', Fuel = '" + vehicle.Fuel1 + "', Drive = '" + vehicle.Drive1 + "', Gearbox = '" + vehicle.Gearbox1 + "'  WHERE CarID = " + vehicle.CarID1;
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public void UpdateCustomer(Customer customer)
        {
            OpenConnection();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UPDATE Customers SET CustomerUsername = '" + customer.Username + "', fullname = '" + customer.name + "', CustomerPassword = '" + customer.Password + "', Adress = '" + customer.adress + "', email = '" + customer.email + "', Phone = '" +customer.phone + "' , admin = '" + customer.Admin + "' WHERE CustomerID = " + customer.CustomerId;
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public void UpdateReservation(Reservation reservation)
        {
            OpenConnection();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UPDATE Reservations SET DateFrom = '" + reservation.DateFrom.ToShortDateString() + "', DateTo = '" + reservation.DateTo.ToShortDateString() + "'  WHERE ReservationID = " + reservation.ReservationId;
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public void UpdateDeal(Deal deal)
        {
            OpenConnection();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UPDATE Deals SET CarID = '" + deal.CarID + "', DateFrom = '" + deal.DateFrom.ToShortDateString() + "', DateTo = '" + deal.DateTo.ToShortDateString() + "', PricePerDay = '" + deal.PricePerDay + "' WHERE DealID = " + deal.DealID; 
            cmd.ExecuteNonQuery();
            CloseConnection();
        }

        public void DeleteVehicle(int CarID)
        {
            OpenConnection();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "DELETE * FROM Cars WHERE CarID = " + CarID;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Vehicle cannot be deleted because it has an active deal" + Environment.NewLine + "You need to go to Manage Deals and delete the deal there","Warning");

            }

            CloseConnection();
        }
        public void DeleteDeal(int DealID)
        {
            OpenConnection();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "DELETE * FROM Deals WHERE DealID = " + DealID;
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public void DeleteReservation(int ReservationID)
        {
            OpenConnection();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "DELETE * FROM Reservations WHERE ReservationID = " + ReservationID;
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
    }
}
