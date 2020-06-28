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
    public partial class FormDeals : Form
    {
        Database db;
        List<Vehicle> VehicleList;
        List<Deal> DealList;
        private delegate void InvokeGetData();
        Thread thread;
        int DealId;
        FormControle formControle;
        bool MadeChanges = false;

        public FormDeals()
        {
            InitializeComponent();
            db = new Database();

            formControle = new FormControle(this);
           
        }
        public void GetData()
        {
            VehicleList = db.GetVehicles();
            DealList = db.GetDeals();
            Deal.IDincrement = DealList.Last().DealID;
            this.Invoke(new InvokeGetData(FillListView));

        }
        public void FillListView()
        {
            formControle.AddDataToListBox(VehicleList, lstVeCar);
            formControle.AddDataToListBox(DealList, lstVeDeals);
        }


        private void FormDeals_Load(object sender, EventArgs e)
        {
            formControle.RefreshDatabase(GetData);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lstVeCar.SelectedItems.Count > 0)
            {
                if (formControle.CheckTextBox() && formControle.CheckIFBeforeAndSameDate(dtpFrom.Value, dtpTo.Value))
                {
                    string[] s = formControle.ListViewSelectedItemToString(lstVeCar);
                        Deal de = new Deal(int.Parse(s[0]), dtpFrom.Value, dtpTo.Value,
                            double.Parse(txtPricePerDay.Text));
                    if (formControle.DateCheck1(de, DealList, dtpFrom.Value, dtpTo.Value,lblFrom, lblTo))
                    {
                        DealList.Add(de);
                        formControle.AddDataToListBox(DealList,lstVeDeals);
                        formMain.MadeChanges = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Vehicle not selected");
            }
        }

        private void lstVeCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstVeDeals.Items.Clear();
            List<Deal> temp = new List<Deal>();
            if (formControle.ListViewSelectedItemToString(lstVeCar).Length > 1)
            {
                foreach (Deal item in DealList)
                {
                    if (item.CarID == int.Parse(formControle.ListViewSelectedItemToString(lstVeCar)[0]))
                    {
                        temp.Add(item);
                    }
                }
                formControle.AddDealListBoxToForm(temp, lstVeDeals);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstVeDeals.SelectedItems.Count > 0)
            {
                string[] temp = formControle.ListViewSelectedItemToString(lstVeDeals);
                if (formControle.CheckTextBox() && formControle.CheckIFBeforeAndSameDate(dtpFrom.Value, dtpTo.Value))
                {
                    Deal de = new Deal(int.Parse(temp[0]), int.Parse(temp[1]), DateTime.Parse(temp[2]), DateTime.Parse(temp[3]), double.Parse(temp[4]));
                    if (formControle.DateCheck1(de.DealID,de, DealList, dtpFrom.Value, dtpTo.Value, lblFrom, lblTo))
                    {
                        foreach (Deal item in DealList)
                        {
                            if (item.DealID == de.DealID)
                            {
                                item.DateFrom = dtpFrom.Value;
                                item.DateTo = dtpTo.Value;
                                item.PricePerDay = int.Parse(txtPricePerDay.Text);
                                formMain.MadeChanges = true;
                            }
                           
                        }
                        formControle.AddDataToListBox(DealList,lstVeDeals);
                    }
                }
            }
            else
            {
                MessageBox.Show("Car not selected");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstVeDeals.SelectedItems.Count > 0)
            {
                DialogResult = MessageBox.Show("Are u sure u want to remove this Deal?", "Warning", MessageBoxButtons.YesNo);
                if (DialogResult == DialogResult.Yes)
                {
                    string[] temp = formControle.ListViewSelectedItemToString(lstVeDeals);
                    for (int i = 0; i < DealList.Count; i++)
                    {
                        if (DealList[i].DealID == int.Parse(temp[0]))
                        {
                            DealList.RemoveAt(i);
                            formMain.MadeChanges = true;
                        }
                    }
                    formControle.AddDataToListBox(DealList, lstVeDeals);
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
            formControle.SaveToDatabaseDeal(DealList);
            formMain.MadeChanges = false;
            formControle.RefreshDatabase(GetData);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("All unsaved changes on this form will be deleted with this action",
                "Warning" + Environment.NewLine + "Do you want to continue?", MessageBoxButtons.YesNo);
            if (DialogResult == DialogResult.Yes)
            {
                formMain.MadeChanges = false;
                formControle.RefreshDatabase(GetData);
            }
        }

        private void lstVeDeals_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] temp = formControle.ListViewSelectedItemToString(lstVeDeals);
            if (temp.Length > 1)
            {
                dtpFrom.Value = DateTime.Parse(temp[2]);
                dtpTo.Value = DateTime.Parse(temp[3]);
                txtPricePerDay.Text = temp[4];
            }
        }

        private void FormDeals_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (formMain.MadeChanges)
            {
                DialogResult = MessageBox.Show("Unsaved changed will be lost" + Environment.NewLine + "Do you want save? ", "Warning", MessageBoxButtons.YesNoCancel);
                if (DialogResult == DialogResult.Yes)
                {
                    formControle.SaveToDatabaseDeal(DealList);
                    formMain.MadeChanges = false;
                }
                if(DialogResult == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (lstVeCar.SelectedItems.Count > 1)
            {
                MessageBox.Show("Test");
            }
            MessageBox.Show(lstVeCar.SelectedItems.Count.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formControle.AddDealListBoxToForm(DealList, lstVeDeals);

        }
    }
}
