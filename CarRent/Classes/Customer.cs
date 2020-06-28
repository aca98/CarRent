using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRent
{
    public class Customer
    {
        private int CustomerID;
        private string username;
        private string password;
        private string Name;
        private string Email;
        private string Phone;
        private string Adress;
        private bool admin;


        public Customer(int customerId, string username,string password, string name, string email, string phone, string adress)
        {
            CustomerID = customerId;
            this.username = username;
            this.password = password;
            Name = name;
            Email = email;
            Phone = phone;
            Adress = adress;
            admin = false;
        }

        public Customer(int customerID, string name, string email, string phone, string adress)
        {
            CustomerID = customerID;
            Name = name;
            Email = email;
            Phone = phone;
            Adress = adress;
            admin = false;

        }

        public Customer(string name, string email, string phone, string adress)
        {
            CustomerID = -1;
            Name = name;
            Email = email;
            Phone = phone;
            Adress = adress;
            admin = false;

        }
        public Customer()
        {
            CustomerID = -1;
            Name = "";
            Email = "";
            Phone = "";
            Adress = "";
            admin = false;

        }
        public int CustomerId 
        { 
            get => CustomerID; 
            set => CustomerID = value; 
        }
        public string name 
        { 
            get => Name; 
            set => Name = value;
        }
        public string email 
        {
            get => Email; 
            set => Email = value; 
        }
        public string phone 
        {
            get => Phone; 
            set => Phone = value; 
        }
        public string adress 
        {
            get => Adress; 
            set => Adress = value;
        }

        public string Username
        {
            get => username;
            set => username = value;
        }

        public string Password
        {
            get => password;
            set => password = value;
        }

        public bool Admin
        {
            get => admin;
            set => admin = value;
        }

        public override string ToString()
        {
            return $"{CustomerId}, {name}, {username}, {email}, {phone}, {adress}";
        }
    }
}
