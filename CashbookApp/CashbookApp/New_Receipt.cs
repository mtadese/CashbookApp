using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashbookApp
{
    public partial class New_Receipt : Form
    {
        //create object of Entity to allow communiction with database 
        //declare receipt class 
        Receipt model = new Receipt();

        public New_Receipt()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Clear();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        //declare clear function
        void Clear()
        {
            try { 

            //clear all text fields
            txtDescription.Text = txtVoucherNum.Text = txtReference.Text = txtAmount.Text = "";            
            //show the currently active customers 
            model.ReceiptID = 0;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search"); //excep.GetType().ToString() 
            }
        }

        //save new cash receipt details
        private void btnSave_Click(object sender, EventArgs e)
        {
            try { 

            model.Date = dtDate.Value.Date;

            //model.Date = Convert.ToDateTime(dtDate.Text.Trim());
            model.Description = txtDescription.Text.Trim();
            model.VoucherNumber = txtVoucherNum.Text.Trim();
            model.Reference = txtReference.Text.Trim();
            model.Amount = Convert.ToDecimal(txtAmount.Text.Trim());

            using (CashbookEntities db = new CashbookEntities())
            {
                //add new receipt record
                db.Receipts.Add(model);                
                db.SaveChanges();
            }
            Clear();            
            MessageBox.Show("New Cash Receipt Saved Successfully");

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search"); //excep.GetType().ToString() 
            }
        }

        
        //menu item to open receipt-records sheet
        private void viewReceiptsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { 
            Receipts_Record dashpage = new Receipts_Record();
            dashpage.Show();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search"); //excep.GetType().ToString() 
            }
        }

        //menu item to open New Expense Module
        private void newExpenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                New_Expense dashpage = new New_Expense();
                dashpage.Show();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search"); //excep.GetType().ToString() 
            }
        }

        //menu item to open Expenses sheet
        private void viewExpensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Expenses_Record dashpage = new Expenses_Record();
                dashpage.Show();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search"); //excep.GetType().ToString() 
            }
        }
    }
}
