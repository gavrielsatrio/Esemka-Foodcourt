using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsemkaFoodcourt
{
    public partial class MemberRegistrationForm : Form
    {
        private ModelEntities db = new ModelEntities();

        public MemberRegistrationForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            foreach (var control in groupBox1.Controls)
            {
                if(control is TextBox txt)
                {
                    if(txt.Text == "")
                    {
                        MessageBox.Show("Fill in registration information ...");
                        return;
                    }
                }
            }

            if (!new EmailAddressAttribute().IsValid(txtEmail.Text))
            {
                MessageBox.Show("Email is not valid ...");
                return;
            }

            if (!new PhoneAttribute().IsValid(txtPhoneNumber.Text))
            {
                MessageBox.Show("Phone number is not valid ...");
                return;
            }

            if(txtPhoneNumber.Text.Length < 10 || txtPhoneNumber.Text.Length > 15)
            {
                MessageBox.Show("Phone number must be between 10 - 15 digits");
                return;
            }

            if (txtPass.Text.Length < 8)
            {
                MessageBox.Show("Password length must be at least 8 characters ...");
                return;
            }

            if (txtConfPass.Text != txtPass.Text)
            {
                MessageBox.Show("Confirmation password doesn't match ...");
                return;
            }

            var checkEmail = db.Users.ToList().FirstOrDefault(x => x.Email == txtEmail.Text);
            if(checkEmail != null)
            {
                MessageBox.Show("Email already registered ...");
                return;
            }

            db.Users.Add(new User
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                RoleID = 2,
                Email = txtEmail.Text,
                Password = txtPass.Text,
                DateJoined = DateTime.Now,
                PhoneNumber = txtPhoneNumber.Text
            });
            db.SaveChanges();

            GlobalData.User = db.Users.ToList().LastOrDefault();

            this.Hide();
            new UserMainForm().Show();
        }

        private void MemberRegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void MemberRegistrationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }
    }
}
