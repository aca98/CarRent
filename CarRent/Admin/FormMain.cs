using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRent
{
    
    public partial class formMain : Form
    {
        public static int CustomerID;
        public static bool MadeChanges;
        private FormManageCar frmManageCar;
        private FormDeals frmDeals;
        private FormReservations frmReservation;
        private FormCustomerProfile frmCustomerProfile;
        private FormCustomerReservation frmCustomerReservation;
        private Form currentForm;
        private delegate void Invoke();
        public formMain()
        {
            InitializeComponent();
            frmManageCar = new FormManageCar();
            frmManageCar.MdiParent = this;
            frmManageCar.Dock = DockStyle.Fill;
            frmDeals = new FormDeals();
            frmDeals.MdiParent = this;
            frmDeals.Dock = DockStyle.Fill;
            frmReservation = new FormReservations();
            frmReservation.MdiParent = this;
            frmReservation.Dock = DockStyle.Fill;
            frmCustomerProfile = new FormCustomerProfile();
            frmCustomerProfile.MdiParent = this;
            frmCustomerProfile.Dock = DockStyle.Fill;
            frmCustomerReservation = new FormCustomerReservation();
            frmCustomerReservation.MdiParent = this;
            frmCustomerReservation.Dock = DockStyle.Fill;

            
        }
        public int Max(FormManageCar frm)
        {
            int maxi = 0;
            foreach(Control c in frm.Controls)
            {
                if(maxi < c.Width)
                {
                    maxi = c.Width;
                }
            }
            return maxi;
        }

        private void btnManageCars_Click(object sender, EventArgs e)
        {
            //this.Width = frmManageCar.Width + 170;
            //this.Height = frmManageCar.Height;
//            this.Controls.Remove(frmManageCar);
//            frmManageCar = new FormManageCar();
//            frmManageCar.MdiParent = this;
//            frmManageCar.D    ock = DockStyle.Fill;
            if (currentForm != null)
            {
                ChangeCurrentForm();
            }

            currentForm = frmManageCar;

            
            this.Width = 679 + 200;
            this.Height = 485 + 50;
            frmManageCar.Show();
            frmManageCar.BringToFront();
        }

        public void ChangeCurrentForm()
        {
            if (MadeChanges)
            {
                DialogResult =
                    MessageBox.Show("You didn't save on you previous form" + Environment.NewLine + "Do you want save",
                        "Warning", MessageBoxButtons.YesNo);
                if (DialogResult == DialogResult.Yes)
                {
                    MethodInfo res = currentForm.GetType().GetMethod("Save");
                    res.Invoke(currentForm, new object[0]);
                }
            }
        }

        private void formMain_Load(object sender, EventArgs e)
        {

        }

        private void formMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MadeChanges)
            {
                DialogResult =
                    MessageBox.Show("You didn't save your changes" + Environment.NewLine +"Unsaved changes will be lost"+ Environment.NewLine +"Do you want save?",
                        "Warning", MessageBoxButtons.YesNo);
                if (DialogResult == DialogResult.Yes)
                {
                    MethodInfo res = currentForm.GetType().GetMethod("Save");
                    res.Invoke(currentForm, new object[0]);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Width = frmDeals.Width + 170;
            //this.Height = frmDeals.Height;
            //            this.Controls.Remove(frmDeals);
            //            frmDeals = new FormDeals();
            //            frmDeals.MdiParent = this;
            //            frmDeals.Dock = DockStyle.Fill;
            if (currentForm != null)
            {
                ChangeCurrentForm();
            }

            currentForm = frmDeals;

            
            this.Width = 664 + 204;
            this.Height = 493 + 50;
            frmDeals.Show();
            frmDeals.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //this.Width = frmReservation.Width + 170;
            //this.Height = frmReservation.Height;
            //            this.Controls.Remove(frmReservation);
            //            frmReservation = new FormReservations();
            //            frmReservation.MdiParent = this;
            //            frmReservation.Dock = DockStyle.Fill;
            if (currentForm != null)
            {
                ChangeCurrentForm();
            }

            currentForm = frmReservation;

            
            this.Width = 744 + 204;
            this.Height = 744 + 50;
            frmReservation.Show();
            frmReservation.BringToFront();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private bool selected = false;
        private int x;
        private int y;
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            selected = true;
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            selected = false;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (selected)
            {
                this.Left = MousePosition.X - x ;
                this.Top = MousePosition.Y - y ;

            }
        }

        public void DisableAdminPanel()
        {
            adminPanel.Enabled = false;
            adminPanel.Hide();
        }

        public void DisableCustomerPanel()
        {
            customerPanel.Enabled = false;
            customerPanel.Hide();
        }
        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            //            this.Controls.Remove(frmCustomerProfile);
            //            frmCustomerProfile = new FormCustomerProfile(); 
            //            frmCustomerProfile.MdiParent = this;
            //            frmCustomerProfile.Dock = DockStyle.Fill;
            if (currentForm != null)
            {
                ChangeCurrentForm();
            }

            currentForm = frmCustomerProfile;

           
            this.Height = 387 + 50;
            this.Width = 726 + 204;
            frmCustomerProfile.Show();
            frmCustomerProfile.BringToFront();

        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            //            this.Controls.Remove(frmCustomerReservation);
            //            frmCustomerReservation = new FormCustomerReservation();
            //            frmCustomerReservation.MdiParent = this;
            //            frmCustomerReservation.Dock = DockStyle.Fill;
            if (currentForm != null)
            {
                ChangeCurrentForm();
            }
            currentForm = frmCustomerReservation;
            
            this.Height = 577 + 50;
            this.Width = 659 + 204;
            frmCustomerReservation.Show();
            frmCustomerReservation.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
