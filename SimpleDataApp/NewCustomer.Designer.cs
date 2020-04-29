using System;

namespace SimpleDataApp
{
    partial class NewCustomer
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
            this.gridCstmrLbl = new System.Windows.Forms.Label();
            this.gridOrderLbl = new System.Windows.Forms.Label();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnAddFinish = new System.Windows.Forms.Button();
            this.btnAddAnotherAccount = new System.Windows.Forms.Button();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.lblCustName = new System.Windows.Forms.Label();
            this.lblCustId = new System.Windows.Forms.Label();
            this.lblOrderAmnt = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.numOrderAmount = new System.Windows.Forms.NumericUpDown();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.numOrderAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCstmrLbl
            // 
            this.gridCstmrLbl.AccessibleName = "gridCstmrLbl";
            this.gridCstmrLbl.AutoSize = true;
            this.gridCstmrLbl.Location = new System.Drawing.Point(77, 28);
            this.gridCstmrLbl.Name = "gridCstmrLbl";
            this.gridCstmrLbl.Size = new System.Drawing.Size(69, 13);
            this.gridCstmrLbl.TabIndex = 0;
            this.gridCstmrLbl.Text = "Add Account";
            // 
            // gridOrderLbl
            // 
            this.gridOrderLbl.AccessibleName = "gridOrderLbl";
            this.gridOrderLbl.AutoSize = true;
            this.gridOrderLbl.Location = new System.Drawing.Point(77, 167);
            this.gridOrderLbl.Name = "gridOrderLbl";
            this.gridOrderLbl.Size = new System.Drawing.Size(67, 13);
            this.gridOrderLbl.TabIndex = 1;
            this.gridOrderLbl.Text = "Create Order";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.AccessibleName = "btnCreateAccount";
            this.btnCreateAccount.Location = new System.Drawing.Point(382, 58);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(92, 23);
            this.btnCreateAccount.TabIndex = 2;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.AccessibleName = "btnPlaceOrder";
            this.btnPlaceOrder.Location = new System.Drawing.Point(399, 234);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(75, 23);
            this.btnPlaceOrder.TabIndex = 3;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAddFinish
            // 
            this.btnAddFinish.AccessibleName = "btnAddFinish";
            this.btnAddFinish.Location = new System.Drawing.Point(80, 295);
            this.btnAddFinish.Name = "btnAddFinish";
            this.btnAddFinish.Size = new System.Drawing.Size(75, 23);
            this.btnAddFinish.TabIndex = 4;
            this.btnAddFinish.Text = "Finish";
            this.btnAddFinish.UseVisualStyleBackColor = true;
            // 
            // btnAddAnotherAccount
            // 
            this.btnAddAnotherAccount.AccessibleName = "btnAddAnotherAccount";
            this.btnAddAnotherAccount.Location = new System.Drawing.Point(344, 295);
            this.btnAddAnotherAccount.Name = "btnAddAnotherAccount";
            this.btnAddAnotherAccount.Size = new System.Drawing.Size(130, 24);
            this.btnAddAnotherAccount.TabIndex = 5;
            this.btnAddAnotherAccount.Text = "Add Another Account";
            this.btnAddAnotherAccount.UseVisualStyleBackColor = true;
            this.btnAddAnotherAccount.Click += new System.EventHandler(this.btnAddAnotherAccount_Click_1);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.AccessibleName = "txtCustomerName";
            this.txtCustomerName.Location = new System.Drawing.Point(147, 58);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerName.TabIndex = 6;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.AccessibleName = "txtCustomerID";
            this.txtCustomerID.Location = new System.Drawing.Point(147, 93);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerID.TabIndex = 7;
            this.txtCustomerID.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblCustName
            // 
            this.lblCustName.AccessibleName = "lblCustName";
            this.lblCustName.AutoSize = true;
            this.lblCustName.Location = new System.Drawing.Point(56, 61);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(85, 13);
            this.lblCustName.TabIndex = 8;
            this.lblCustName.Text = "Customer Name:";
            // 
            // lblCustId
            // 
            this.lblCustId.AccessibleName = "lblCustId";
            this.lblCustId.AutoSize = true;
            this.lblCustId.Location = new System.Drawing.Point(56, 93);
            this.lblCustId.Name = "lblCustId";
            this.lblCustId.Size = new System.Drawing.Size(68, 13);
            this.lblCustId.TabIndex = 9;
            this.lblCustId.Text = "Customer ID:";
            // 
            // lblOrderAmnt
            // 
            this.lblOrderAmnt.AccessibleName = "lblOrderAmnt";
            this.lblOrderAmnt.AutoSize = true;
            this.lblOrderAmnt.Location = new System.Drawing.Point(66, 212);
            this.lblOrderAmnt.Name = "lblOrderAmnt";
            this.lblOrderAmnt.Size = new System.Drawing.Size(75, 13);
            this.lblOrderAmnt.TabIndex = 10;
            this.lblOrderAmnt.Text = "Order Amount:";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AccessibleName = "lblOrderDate";
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(66, 244);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(62, 13);
            this.lblOrderDate.TabIndex = 11;
            this.lblOrderDate.Text = "Order Date:";
            // 
            // numOrderAmount
            // 
            this.numOrderAmount.AccessibleName = "numOrderAmount";
            this.numOrderAmount.Location = new System.Drawing.Point(147, 210);
            this.numOrderAmount.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numOrderAmount.Name = "numOrderAmount";
            this.numOrderAmount.Size = new System.Drawing.Size(120, 20);
            this.numOrderAmount.TabIndex = 12;
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.AccessibleName = "dtpOrderDate";
            this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderDate.Location = new System.Drawing.Point(147, 244);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(120, 20);
            this.dtpOrderDate.TabIndex = 13;
            // 
            // NewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 386);
            this.Controls.Add(this.dtpOrderDate);
            this.Controls.Add(this.numOrderAmount);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.lblOrderAmnt);
            this.Controls.Add(this.lblCustId);
            this.Controls.Add(this.lblCustName);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.btnAddAnotherAccount);
            this.Controls.Add(this.btnAddFinish);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.gridOrderLbl);
            this.Controls.Add(this.gridCstmrLbl);
            this.Name = "NewCustomer";
            this.Text = "NewCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.numOrderAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label gridCstmrLbl;
        private System.Windows.Forms.Label gridOrderLbl;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnAddFinish;
        private System.Windows.Forms.Button btnAddAnotherAccount;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Label lblCustId;
        private System.Windows.Forms.Label lblOrderAmnt;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.NumericUpDown numOrderAmount;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
    }
}