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

namespace CarRent
{
    public partial class FormLogIn : Form
    {
        Database db;
        private int CustomerID;
        private List<Customer> CustomerList;
        Thread thread;
        FormControle formControle;
        bool MadeChanges = false;
        public FormLogIn()
        {

            db = new Database();
            formControle = new FormControle(this);
            InitializeComponent();

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
            try
            {
            CustomerList = db.GetCustomer();
            CustomerID = CustomerList.Last().CustomerId;
            CustomerID++;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
           

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string temp = "";
            var linq = from s in CustomerList where s.Username.Equals(txtUsername.Text) && s.Password.Equals(txtPassword.Text) select s;

            if (linq.ToArray().Length == 1)
            {
                this.Hide();
                formMain.CustomerID = ((Customer)linq.ToArray()[0]).CustomerId;

                formMain frmMain = new formMain();
                frmMain.Closing += (s, args) => this.Close();

                if (!((Customer) linq.ToArray()[0]).Admin)
                {
                    frmMain.DisableAdminPanel();
                }
                else
                {
                    frmMain.DisableCustomerPanel();
                }
                frmMain.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or password");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private bool selected = false;
        private int x;
        private int y;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            selected = true;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            selected = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (selected)
            {
                this.Left = MousePosition.X - x;
                this.Top = MousePosition.Y - y;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormRegister frmRegister = new FormRegister();
            frmRegister.Closing += (s, args) => this.Close();
            
            frmRegister.ShowDialog();
        }

        private void FormLogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
