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
    public partial class FormRegister : Form
    {
        Database db;
        private int CustomerID;
        private List<Customer> CustomerList;
        Thread thread;
        FormControle formControle;
        bool MadeChanges = false;
        public FormRegister()
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
            CustomerList = db.GetCustomer();
            CustomerID = CustomerList.Last().CustomerId;
            CustomerID++;

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (formControle.CheckTextBox() &&
                formControle.checkRegisterData(txtPhone.Text, txtUsername.Text, txtEmail.Text, CustomerList))
            {
                Customer customer = new Customer(CustomerID, txtUsername.Text, txtPassword.Text,
                    txtFirstname.Text + " " + txtLastname.Text, txtEmail.Text, txtPhone.Text, txtAdress.Text);
                db.AddCustomer(customer);
                this.Hide();
                FormLogIn frmLogIn = new FormLogIn();
                frmLogIn.Closing += (s, args) => this.Close();
                frmLogIn.ShowDialog();
                
               
            }
        }
    

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

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

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
