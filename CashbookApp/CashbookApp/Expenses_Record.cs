using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;


namespace CashbookApp
{
    public partial class Expenses_Record : Form
    {
        //create object of Entity to allow communiction with database 
        //declare receipt class 
        Expens model = new Expens();

        public Expenses_Record()
        {
            InitializeComponent();
        }

        private void Expenses_Record_Load(object sender, EventArgs e)
        {
            PopulateData();
        }

        //bind datagridview to database content 
        void PopulateData()
        {
            try
            {

                //dgvReceipts.AutoGenerateColumns = false; //prevent auto-generated columns in datagridview 
                using (CashbookEntities db = new CashbookEntities())
                {
                    dgvExpenses.DataSource = db.Expenses.ToList<Expens>();
                    dgvExpenses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search"); //excep.GetType().ToString() 
            }
        }

        // display expenses record when selected gridview row is double-clicked 
        private void dgvExpenses_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                if (dgvExpenses.CurrentRow.Index != -1)
                {
                    model.ExpenseID = Convert.ToInt32(dgvExpenses.CurrentRow.Cells["ExpenseID"].Value);

                    //select receipt record from receipt table
                    using (CashbookEntities db = new CashbookEntities())
                    {
                        model = db.Expenses.Where(x => x.ExpenseID == model.ExpenseID).FirstOrDefault();
                        txtDescription.Text = model.Description;
                        txtVoucherNum.Text = model.VoucherNumber;
                        txtReference.Text = model.Reference;
                        txtAmount.Text = model.Amount.ToString();
                    }
                    panel1.Visible = true;
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search"); //excep.GetType().ToString() 
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        // search Receipts record using data in search box
        void Search()
        {
            try
            {
                int num = Convert.ToInt32(txtSearch.Text);
                CashbookEntities dc = new CashbookEntities();
                var exp = from expense in dc.Expenses                                                    
                          where expense.ExpenseID == num
                          select expense;
                dgvExpenses.DataSource = exp.ToList();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search"); //excep.GetType().ToString() 
            }
        }

        // reset all fields in the expenses module 
        void Clear()
        {
            try
            {

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
            panel1.Visible = false;
        }

        // update cash expenses record
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                model.Description = txtDescription.Text.Trim();
                model.VoucherNumber = txtVoucherNum.Text.Trim();
                model.Reference = txtReference.Text.Trim();
                model.Amount = Convert.ToDecimal(txtAmount.Text.Trim());

                using (CashbookEntities db = new CashbookEntities())
                {
                    //update selected/existing customer record 
                    db.Entry(model).State = EntityState.Modified;
                    db.SaveChanges();
                }
                Clear();
                PopulateData();
                MessageBox.Show("Record Updated Successfully");
                panel1.Visible = false;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search"); //excep.GetType().ToString() 
            }

        }
    }
}
