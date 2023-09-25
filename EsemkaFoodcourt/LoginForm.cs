using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsemkaFoodcourt
{
    public partial class LoginForm : Form
    {
        private ModelEntities db = new ModelEntities();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //var dateJoined = new DateTime(2020, 08, 25);
            //var totalDaysJoined = (DateTime.Now.Date - dateJoined).TotalDays;
            //var yearsJoined = Math.Floor(totalDaysJoined / 365);

            //MessageBox.Show(yearsJoined.ToString());

            //return;

            if(txtEmail.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Fill in login information ...");
                return;
            }

            var checkUser = db.Users.ToList().FirstOrDefault(x => x.Email == txtEmail.Text && x.Password == txtPassword.Text);
            if(checkUser == null)
            {
                MessageBox.Show("User not found ...");
                return;
            }

            GlobalData.User = checkUser;

            if(checkUser.RoleID == 1)
            {
                this.Hide();
                new AdminMainForm().Show();
            }
            else
            {
                this.Hide();
                new UserMainForm().Show();
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void linkJoin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new MemberRegistrationForm().Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // User
            txtEmail.Text = "lschwant0@europa.eu";
            txtPassword.Text = "uM1%g)Aq0";

            // Admin
            //txtEmail.Text = "dgannyt@squidoo.com";
            //txtPassword.Text = "dN1|qg!,xuZ";
        }
    }
}
