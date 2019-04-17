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
    public partial class New_Expense : Form
    {
        //create object of Entity to allow communiction with database 
        //declare receipt class 
        Expens model = new Expens();

        public New_Expense()
        {
            InitializeComponent();
        }

        private void New_Expense_Load(object sender, EventArgs e)
        {
            Clear();
        }

        //declare clear function to reset all fields
        void Clear()
        {
            try { 
            //clear all text fields
            txtDescription.Text = txtVoucherNum.Text = txtReference.Text = txtAmount.Text = "";
            //show the currently active customers 
            model.ExpenseID = 0;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search"); //excep.GetType().ToString() 
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        // save new expense 
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                model.Date = dtDate.Value.Date;

                //model.Date = Convert.ToDateTime(dtDate.Text.Trim());
                model.Description = txtDescription.Text.Trim();
                model.VoucherNumber = txtVoucherNum.Text.Trim();
                model.Reference = txtReference.Text.Trim();
                model.Amount = Convert.ToDecimal(txtAmount.Text.Trim());

                using (CashbookEntities db = new CashbookEntities())
                {
                    //add new expense record
                    db.Expenses.Add(model);
                    db.SaveChanges();
                }
                Clear();
                MessageBox.Show("New Cash Expense Saved Successfully");

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search"); //excep.GetType().ToString() 
            }
        }
    }
}
