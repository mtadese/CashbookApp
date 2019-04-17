using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.Entity;

using System.Data.SqlClient;

namespace CashbookApp
{
    public partial class Receipts_Record : Form
    {
        //create object of Entity to allow communiction with database
        //declare receipt class 
        Receipt model = new Receipt();

      
        public Receipts_Record()
        {
            InitializeComponent();
        }

        private void Receipts_Record_Load(object sender, EventArgs e)
        {
            PopulateData();
        }

        //bind datagridview to database content 
        void PopulateData()
        {
            try { 
    
            //dgvReceipts.AutoGenerateColumns = false; //prevent auto-generated columns in datagridview 
            using (CashbookEntities db = new CashbookEntities())
            {
                dgvReceipts.DataSource = db.Receipts.ToList<Receipt>();
                dgvReceipts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search"); //excep.GetType().ToString() 
            }

        }

        // display receipt record when selected gridview row is double-clicked 
        private void dgvReceipts_DoubleClick(object sender, EventArgs e)
        {
            try { 

            if (dgvReceipts.CurrentRow.Index != -1)
            {
                model.ReceiptID = Convert.ToInt32(dgvReceipts.CurrentRow.Cells["ReceiptID"].Value);

                //select receipt record from receipt table
                using (CashbookEntities db = new CashbookEntities())
                {
                    model = db.Receipts.Where(x => x.ReceiptID == model.ReceiptID).FirstOrDefault();
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

       // update cash receipts record
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try { 

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

        // reset all fields in the receipts module 
        void Clear()
        {
            try { 

            txtDescription.Text = txtVoucherNum.Text = txtReference.Text = txtAmount.Text = "";
            //show the currently active customers 
            model.ReceiptID = 0;

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

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            Search();
        }

        // search Receipts record using data in search box
        void Search()
        {
            try { 

            int num = Convert.ToInt32(txtSearch.Text);
            CashbookEntities dc = new CashbookEntities();
            var rec = from receipt in dc.Receipts
                          //where receipt.ReceiptID == 2                     
                      where receipt.ReceiptID == num
                      select receipt;
            dgvReceipts.DataSource = rec.ToList();

            }

             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message, "Search"); //excep.GetType().ToString() 
             }
        }

       
    }
}
