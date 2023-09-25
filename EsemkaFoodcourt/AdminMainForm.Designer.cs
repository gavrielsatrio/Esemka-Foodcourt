namespace EsemkaFoodcourt
{
    partial class AdminMainForm
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnManageMenuIngredients = new System.Windows.Forms.Button();
            this.btnManageMembers = new System.Windows.Forms.Button();
            this.btnManageMenu = new System.Windows.Forms.Button();
            this.btnViewReservations = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(12, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(254, 25);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Welcome, Hady Wijaya";
            // 
            // btnManageMenuIngredients
            // 
            this.btnManageMenuIngredients.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnManageMenuIngredients.Location = new System.Drawing.Point(119, 133);
            this.btnManageMenuIngredients.Name = "btnManageMenuIngredients";
            this.btnManageMenuIngredients.Size = new System.Drawing.Size(150, 30);
            this.btnManageMenuIngredients.TabIndex = 6;
            this.btnManageMenuIngredients.Text = "Manage Menu Ingredients";
            this.btnManageMenuIngredients.UseVisualStyleBackColor = true;
            this.btnManageMenuIngredients.Click += new System.EventHandler(this.btnManageMenuIngredients_Click);
            // 
            // btnManageMembers
            // 
            this.btnManageMembers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnManageMembers.Location = new System.Drawing.Point(119, 61);
            this.btnManageMembers.Name = "btnManageMembers";
            this.btnManageMembers.Size = new System.Drawing.Size(150, 30);
            this.btnManageMembers.TabIndex = 7;
            this.btnManageMembers.Text = "Manage Members";
            this.btnManageMembers.UseVisualStyleBackColor = true;
            this.btnManageMembers.Click += new System.EventHandler(this.btnManageMembers_Click);
            // 
            // btnManageMenu
            // 
            this.btnManageMenu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnManageMenu.Location = new System.Drawing.Point(119, 97);
            this.btnManageMenu.Name = "btnManageMenu";
            this.btnManageMenu.Size = new System.Drawing.Size(150, 30);
            this.btnManageMenu.TabIndex = 8;
            this.btnManageMenu.Text = "Manage Menu";
            this.btnManageMenu.UseVisualStyleBackColor = true;
            this.btnManageMenu.Click += new System.EventHandler(this.btnManageMenu_Click);
            // 
            // btnViewReservations
            // 
            this.btnViewReservations.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnViewReservations.Location = new System.Drawing.Point(119, 169);
            this.btnViewReservations.Name = "btnViewReservations";
            this.btnViewReservations.Size = new System.Drawing.Size(150, 30);
            this.btnViewReservations.TabIndex = 9;
            this.btnViewReservations.Text = "View Reservations";
            this.btnViewReservations.UseVisualStyleBackColor = true;
            this.btnViewReservations.Click += new System.EventHandler(this.btnViewReservations_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLogout.Location = new System.Drawing.Point(119, 247);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(150, 30);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 289);
            this.Controls.Add(this.btnManageMenuIngredients);
            this.Controls.Add(this.btnManageMembers);
            this.Controls.Add(this.btnManageMenu);
            this.Controls.Add(this.btnViewReservations);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblWelcome);
            this.Name = "AdminMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Esemka Foodcourt";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminMainForm_FormClosed);
            this.Load += new System.EventHandler(this.AdminMainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnManageMenuIngredients;
        private System.Windows.Forms.Button btnManageMembers;
        private System.Windows.Forms.Button btnManageMenu;
        private System.Windows.Forms.Button btnViewReservations;
        private System.Windows.Forms.Button btnLogout;
    }
}