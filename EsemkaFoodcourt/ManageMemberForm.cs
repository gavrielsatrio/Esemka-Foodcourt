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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace EsemkaFoodcourt
{
    public partial class ManageMemberForm : Form
    {
        private ModelEntities db = new ModelEntities();
        private int selectedDataID = -1;

        public ManageMemberForm()
        {
            InitializeComponent();
        }

        private void ManageMemberForm_Load(object sender, EventArgs e)
        {
            EnableFieldAndButton(false);
            LoadData();
        }

        private void LoadData()
        {
            selectedDataID = -1;
            foreach (var control in Controls)
            {
                if (control is TextBox txt)
                {
                    if (txt.Name != "txtSearch")
                    {
                        txt.Text = "";
                    }
                }
            }

            dgvData.Columns.Clear();

            var query = db.Users.Where(x => x.RoleID == 2).ToList();

            if(txtSearch.Text != "")
            {
                query = query.Where(x => x.FirstName.ToLower().StartsWith(txtSearch.Text.ToLower()) || x.LastName.ToLower().StartsWith(txtSearch.Text.ToLower()) || x.Email.ToLower().StartsWith(txtSearch.Text.ToLower())).ToList();
            }

            dgvData.DataSource = query.Select(x => new
            {
                x.ID,
                x.FirstName,
                x.LastName,
                x.Email,
                x.Password,
                x.PhoneNumber,
                MemberSince = $"{x.DateJoined.ToString("dd/MM/yyyy")} ({Math.Floor((DateTime.Now.Date - x.DateJoined.Date).TotalDays / 365)} year(s))"
            }).ToList();

            // Math.Round()
            // 4,3 = 4
            // 4,9 = 5

            // Math.Floor()
            // 4,3 = 4
            // 4,9 = 4

            // Math.Ceiling()
            // 4,00001 = 5
            // 4,9 = 5

            dgvData.Columns["ID"].Visible = false;
            dgvData.Columns["Password"].Visible = false;
        }

        private void ManageMemberForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            new AdminMainForm().Show();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                selectedDataID = int.Parse(dgvData["ID", e.RowIndex].Value.ToString());

                txtFirstName.Text = dgvData["FirstName", e.RowIndex].Value.ToString();
                txtLastName.Text = dgvData["LastName", e.RowIndex].Value.ToString();
                txtEmail.Text = dgvData["Email", e.RowIndex].Value.ToString();
                txtPass.Text = dgvData["Password", e.RowIndex].Value.ToString();
                txtPhone.Text = dgvData["PhoneNumber", e.RowIndex].Value.ToString();
            }
        }

        private void EnableFieldAndButton(bool enable)
        {
            EnableField(enable);
            EnableButton(enable);
        }

        private void EnableField(bool enable)
        {
            if(!enable)
            {
                selectedDataID = -1;

                foreach (var control in Controls)
                {
                    if(control is TextBox txt)
                    {
                        if(txt.Name != "txtSearch")
                        {
                            txt.Text = "";
                        }
                    }
                }
            }

            txtFirstName.Enabled = enable;
            txtLastName.Enabled = enable;
            txtEmail.Enabled = enable;
            txtPass.Enabled = enable;
            txtPhone.Enabled = enable;
        }

        private void EnableButton(bool enable)
        {
            btnInsert.Enabled = !enable;
            btnUpdate.Enabled = !enable;
            btnDelete.Enabled = !enable;
            btnSave.Enabled = enable;
            btnCancel.Enabled = enable;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            EnableFieldAndButton(true);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(selectedDataID == -1)
            {
                MessageBox.Show("Select a data first ...");
                return;
            }

            EnableFieldAndButton(true);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedDataID == -1)
            {
                MessageBox.Show("Select a data first ...");
                return;
            }

            var dialog = MessageBox.Show("Are you sure want to delete?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dialog == DialogResult.Yes)
            {
                var queryDelete = db.Users.Find(selectedDataID);
                db.Users.Remove(queryDelete);
                db.SaveChanges();
            }

            EnableFieldAndButton(false);
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (var control in Controls)
            {
                if (control is TextBox txt)
                {
                    if (txt.Text == "" && txt.Name != "txtSearch")
                    {
                        MessageBox.Show("Fill in member information ...");
                        return;
                    }
                }
            }

            if (!new EmailAddressAttribute().IsValid(txtEmail.Text))
            {
                MessageBox.Show("Email is not valid ...");
                return;
            }

            if (!new PhoneAttribute().IsValid(txtPhone.Text))
            {
                MessageBox.Show("Phone number is not valid ...");
                return;
            }

            if (txtPass.Text.Length < 8)
            {
                MessageBox.Show("Password length must be at least 8 characters ...");
                return;
            }

            if (selectedDataID == -1)
            {
                db.Users.Add(new User
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    RoleID = 2,
                    Email = txtEmail.Text,
                    Password = txtPass.Text,
                    DateJoined = DateTime.Now,
                    PhoneNumber = txtPhone.Text
                });
                db.SaveChanges();
            }
            else
            {
                var query = db.Users.Find(selectedDataID);

                if(query.Email != txtEmail.Text)
                {
                    var checkEmail = db.Users.Where(x => x.Email == txtEmail.Text).ToList();
                    if(checkEmail.Count > 0)
                    {
                        MessageBox.Show("Email already used ...");
                        return;
                    }
                }

                query.FirstName = txtFirstName.Text;
                query.LastName = txtLastName.Text;
                query.Email = txtEmail.Text;
                query.Password = txtPass.Text;
                query.DateJoined = DateTime.Now;
                query.PhoneNumber = txtPhone.Text;
                
                db.SaveChanges();
            }

            EnableFieldAndButton(false);
            LoadData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            EnableFieldAndButton(false);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
