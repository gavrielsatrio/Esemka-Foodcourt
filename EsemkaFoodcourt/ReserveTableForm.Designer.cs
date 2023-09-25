namespace EsemkaFoodcourt
{
    partial class ReserveTableForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboTable = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.groupCustomerInfo = new System.Windows.Forms.GroupBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkUseSameInformation = new System.Windows.Forms.CheckBox();
            this.txtNumOfPeople = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtQty = new System.Windows.Forms.NumericUpDown();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.comboMenu = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblReservationFee = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblMenuTotal = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.MenuID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Menu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupCustomerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumOfPeople)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reserve Table";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choose table:";
            // 
            // comboTable
            // 
            this.comboTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTable.FormattingEnabled = true;
            this.comboTable.Location = new System.Drawing.Point(114, 99);
            this.comboTable.Name = "comboTable";
            this.comboTable.Size = new System.Drawing.Size(225, 21);
            this.comboTable.TabIndex = 4;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.Location = new System.Drawing.Point(17, 409);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(150, 30);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.Location = new System.Drawing.Point(722, 409);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 30);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // groupCustomerInfo
            // 
            this.groupCustomerInfo.Controls.Add(this.txtLastname);
            this.groupCustomerInfo.Controls.Add(this.txtPhone);
            this.groupCustomerInfo.Controls.Add(this.txtEmail);
            this.groupCustomerInfo.Controls.Add(this.txtFirstname);
            this.groupCustomerInfo.Controls.Add(this.label4);
            this.groupCustomerInfo.Controls.Add(this.label6);
            this.groupCustomerInfo.Controls.Add(this.label5);
            this.groupCustomerInfo.Controls.Add(this.label3);
            this.groupCustomerInfo.Location = new System.Drawing.Point(17, 139);
            this.groupCustomerInfo.Name = "groupCustomerInfo";
            this.groupCustomerInfo.Size = new System.Drawing.Size(322, 176);
            this.groupCustomerInfo.TabIndex = 6;
            this.groupCustomerInfo.TabStop = false;
            this.groupCustomerInfo.Text = "Customer Information";
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(167, 40);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(140, 20);
            this.txtLastname.TabIndex = 1;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(15, 138);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(292, 20);
            this.txtPhone.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(15, 89);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(292, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(15, 40);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(140, 20);
            this.txtFirstname.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Phone Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "First Name";
            // 
            // checkUseSameInformation
            // 
            this.checkUseSameInformation.AutoSize = true;
            this.checkUseSameInformation.Location = new System.Drawing.Point(17, 321);
            this.checkUseSameInformation.Name = "checkUseSameInformation";
            this.checkUseSameInformation.Size = new System.Drawing.Size(247, 17);
            this.checkUseSameInformation.TabIndex = 7;
            this.checkUseSameInformation.Text = "Use the same information as logged in account";
            this.checkUseSameInformation.UseVisualStyleBackColor = true;
            this.checkUseSameInformation.CheckedChanged += new System.EventHandler(this.checkUseSameInformation_CheckedChanged);
            // 
            // txtNumOfPeople
            // 
            this.txtNumOfPeople.Location = new System.Drawing.Point(114, 73);
            this.txtNumOfPeople.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtNumOfPeople.Name = "txtNumOfPeople";
            this.txtNumOfPeople.Size = new System.Drawing.Size(225, 20);
            this.txtNumOfPeople.TabIndex = 8;
            this.txtNumOfPeople.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Number of people:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.txtQty);
            this.groupBox2.Controls.Add(this.dgvMenu);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.comboMenu);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(355, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(517, 269);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menu";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(315, 15);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(87, 44);
            this.txtQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(222, 20);
            this.txtQty.TabIndex = 8;
            this.txtQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dgvMenu
            // 
            this.dgvMenu.AllowUserToAddRows = false;
            this.dgvMenu.AllowUserToDeleteRows = false;
            this.dgvMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMenu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvMenu.BackgroundColor = System.Drawing.Color.White;
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MenuID,
            this.Menu,
            this.Qty,
            this.PriceValue,
            this.Price,
            this.Subtotal,
            this.Action});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMenu.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMenu.Location = new System.Drawing.Point(6, 70);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.ReadOnly = true;
            this.dgvMenu.RowHeadersVisible = false;
            this.dgvMenu.Size = new System.Drawing.Size(505, 193);
            this.dgvMenu.TabIndex = 0;
            this.dgvMenu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenu_CellClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Choose menu:";
            // 
            // comboMenu
            // 
            this.comboMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMenu.FormattingEnabled = true;
            this.comboMenu.Location = new System.Drawing.Point(87, 17);
            this.comboMenu.Name = "comboMenu";
            this.comboMenu.Size = new System.Drawing.Size(222, 21);
            this.comboMenu.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Qty:";
            // 
            // lblReservationFee
            // 
            this.lblReservationFee.Location = new System.Drawing.Point(722, 328);
            this.lblReservationFee.Name = "lblReservationFee";
            this.lblReservationFee.Size = new System.Drawing.Size(150, 16);
            this.lblReservationFee.TabIndex = 9;
            this.lblReservationFee.Text = "Rp100.000";
            this.lblReservationFee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(566, 328);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "Reservation Fee:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMenuTotal
            // 
            this.lblMenuTotal.Location = new System.Drawing.Point(722, 350);
            this.lblMenuTotal.Name = "lblMenuTotal";
            this.lblMenuTotal.Size = new System.Drawing.Size(150, 16);
            this.lblMenuTotal.TabIndex = 9;
            this.lblMenuTotal.Text = "Rp100.000";
            this.lblMenuTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(566, 350);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 16);
            this.label12.TabIndex = 10;
            this.label12.Text = "Menu Total:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Location = new System.Drawing.Point(722, 372);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(150, 16);
            this.lblTotalPrice.TabIndex = 9;
            this.lblTotalPrice.Text = "Rp100.000";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(566, 372);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(150, 16);
            this.label14.TabIndex = 10;
            this.label14.Text = "Total Price:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Date:";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(114, 47);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(225, 20);
            this.dtpDate.TabIndex = 11;
            // 
            // MenuID
            // 
            this.MenuID.HeaderText = "MenuID";
            this.MenuID.Name = "MenuID";
            this.MenuID.ReadOnly = true;
            this.MenuID.Visible = false;
            // 
            // Menu
            // 
            this.Menu.HeaderText = "Menu";
            this.Menu.Name = "Menu";
            this.Menu.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // PriceValue
            // 
            this.PriceValue.HeaderText = "PriceValue";
            this.PriceValue.Name = "PriceValue";
            this.PriceValue.ReadOnly = true;
            this.PriceValue.Visible = false;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.Text = "Remove";
            this.Action.UseColumnTextForButtonValue = true;
            // 
            // ReserveTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 451);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblMenuTotal);
            this.Controls.Add(this.lblReservationFee);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtNumOfPeople);
            this.Controls.Add(this.checkUseSameInformation);
            this.Controls.Add(this.groupCustomerInfo);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboTable);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReserveTableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Esemka Foodcourt";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReserveTableForm_FormClosed);
            this.Load += new System.EventHandler(this.ReserveTableForm_Load);
            this.groupCustomerInfo.ResumeLayout(false);
            this.groupCustomerInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumOfPeople)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboTable;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox groupCustomerInfo;
        private System.Windows.Forms.CheckBox checkUseSameInformation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown txtNumOfPeople;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboMenu;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown txtQty;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblReservationFee;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblMenuTotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Menu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewButtonColumn Action;
    }
}