namespace CashbookApp
{
    partial class New_Receipt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtVoucherNum = new System.Windows.Forms.TextBox();
            this.txtReference = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.receiptsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newReceiptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewReceiptsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newExpenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewExpensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cashbookViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtDate
            // 
            this.dtDate.CustomFormat = "yyyy-mm-dd";
            this.dtDate.Location = new System.Drawing.Point(139, 40);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(307, 20);
            this.dtDate.TabIndex = 0;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(139, 77);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(307, 103);
            this.txtDescription.TabIndex = 1;
            // 
            // txtVoucherNum
            // 
            this.txtVoucherNum.Location = new System.Drawing.Point(139, 186);
            this.txtVoucherNum.Name = "txtVoucherNum";
            this.txtVoucherNum.Size = new System.Drawing.Size(307, 20);
            this.txtVoucherNum.TabIndex = 2;
            // 
            // txtReference
            // 
            this.txtReference.Location = new System.Drawing.Point(139, 221);
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(307, 20);
            this.txtReference.TabIndex = 3;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(139, 256);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(307, 20);
            this.txtAmount.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Voucher Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Reference";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Amount";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(470, 89);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 31);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(470, 140);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(135, 31);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.receiptsToolStripMenuItem,
            this.expensesToolStripMenuItem,
            this.cashbookViewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(637, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // receiptsToolStripMenuItem
            // 
            this.receiptsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newReceiptToolStripMenuItem,
            this.viewReceiptsToolStripMenuItem});
            this.receiptsToolStripMenuItem.Name = "receiptsToolStripMenuItem";
            this.receiptsToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.receiptsToolStripMenuItem.Text = "Receipts";
            // 
            // newReceiptToolStripMenuItem
            // 
            this.newReceiptToolStripMenuItem.Name = "newReceiptToolStripMenuItem";
            this.newReceiptToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newReceiptToolStripMenuItem.Text = "New Receipt";
            // 
            // viewReceiptsToolStripMenuItem
            // 
            this.viewReceiptsToolStripMenuItem.Name = "viewReceiptsToolStripMenuItem";
            this.viewReceiptsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.viewReceiptsToolStripMenuItem.Text = "View Receipts";
            this.viewReceiptsToolStripMenuItem.Click += new System.EventHandler(this.viewReceiptsToolStripMenuItem_Click);
            // 
            // expensesToolStripMenuItem
            // 
            this.expensesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newExpenseToolStripMenuItem,
            this.viewExpensesToolStripMenuItem});
            this.expensesToolStripMenuItem.Name = "expensesToolStripMenuItem";
            this.expensesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.expensesToolStripMenuItem.Text = "Expenses";
            // 
            // newExpenseToolStripMenuItem
            // 
            this.newExpenseToolStripMenuItem.Name = "newExpenseToolStripMenuItem";
            this.newExpenseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newExpenseToolStripMenuItem.Text = "New Expense";
            this.newExpenseToolStripMenuItem.Click += new System.EventHandler(this.newExpenseToolStripMenuItem_Click);
            // 
            // viewExpensesToolStripMenuItem
            // 
            this.viewExpensesToolStripMenuItem.Name = "viewExpensesToolStripMenuItem";
            this.viewExpensesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.viewExpensesToolStripMenuItem.Text = "View Expenses";
            this.viewExpensesToolStripMenuItem.Click += new System.EventHandler(this.viewExpensesToolStripMenuItem_Click);
            // 
            // cashbookViewToolStripMenuItem
            // 
            this.cashbookViewToolStripMenuItem.Name = "cashbookViewToolStripMenuItem";
            this.cashbookViewToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.cashbookViewToolStripMenuItem.Text = "Cashbook View";
            // 
            // New_Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(637, 323);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtReference);
            this.Controls.Add(this.txtVoucherNum);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "New_Receipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Cash Receipt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtVoucherNum;
        private System.Windows.Forms.TextBox txtReference;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem receiptsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newReceiptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewReceiptsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newExpenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewExpensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cashbookViewToolStripMenuItem;
    }
}

