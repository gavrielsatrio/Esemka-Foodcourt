using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace EsemkaFoodcourt
{
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void AdminMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnViewReservations_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ViewReservationsForm().Show();
        }

        private void btnManageMembers_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ManageMemberForm().Show();
        }

        private void btnManageMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ManageMenuForm().Show();
        }

        private void btnManageMenuIngredients_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ManageMenuIngredientsForm().Show();
        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome, {GlobalData.User.FirstName} {GlobalData.User.LastName}";
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }
    }
}
