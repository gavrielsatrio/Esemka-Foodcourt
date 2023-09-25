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
    public partial class ManageMenuForm : Form
    {
        private ModelEntities db = new ModelEntities();
        private int selectedDataID = -1;

        public ManageMenuForm()
        {
            InitializeComponent();
        }

        private void ManageMenuForm_Load(object sender, EventArgs e)
        {
            EnableFieldAndButton(false);
            LoadData();
            LoadComboCategory();
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

            var query = db.Menus.ToList();

            if (txtSearch.Text != "")
            {
                query = query.Where(x => x.Name.ToLower().StartsWith(txtSearch.Text.ToLower()) || x.Category.Name.ToLower().StartsWith(txtSearch.Text.ToLower())).ToList();
            }

            dgvData.DataSource = query.Select(x => new
            {
                x.ID,
                Menu = x.Name,
                x.CategoryID,
                Category = x.Category.Name,
                x.Description,
                PriceValue = x.Price,
                Price = $"Rp{x.Price.ToString("N2")}"
            }).ToList();

            dgvData.Columns["ID"].Visible = false;
            dgvData.Columns["CategoryID"].Visible = false;
            dgvData.Columns["PriceValue"].Visible = false;
        }

        private void LoadComboCategory()
        {
            var query = db.Categories.ToList();
            comboCategory.ValueMember = "ID";
            comboCategory.DisplayMember = "Name";
            comboCategory.DataSource = query;
        }

        private void ManageMenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            new AdminMainForm().Show();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                selectedDataID = int.Parse(dgvData["ID", e.RowIndex].Value.ToString());

                txtName.Text = dgvData["Menu", e.RowIndex].Value.ToString();
                comboCategory.SelectedValue = int.Parse(dgvData["CategoryID", e.RowIndex].Value.ToString());
                txtDesc.Text = dgvData["Description", e.RowIndex].Value.ToString();
                txtPrice.Value = int.Parse(dgvData["PriceValue", e.RowIndex].Value.ToString());
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            EnableFieldAndButton(true);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedDataID == -1)
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
            if (dialog == DialogResult.Yes)
            {
                var queryDelete = db.Menus.Find(selectedDataID);
                db.Menus.Remove(queryDelete);
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
                        MessageBox.Show("Fill in menu information ...");
                        return;
                    }
                }
            }

            if (selectedDataID == -1)
            {
                db.Menus.Add(new Menu
                {
                    Name = txtName.Text,
                    CategoryID = int.Parse(comboCategory.SelectedValue.ToString()),
                    Description = txtDesc.Text,
                    Price = (int)txtPrice.Value
                });
                db.SaveChanges();
            }
            else
            {
                var query = db.Menus.Find(selectedDataID);
                query.Name = txtName.Text;
                query.CategoryID = int.Parse(comboCategory.SelectedValue.ToString());
                query.Description = txtDesc.Text;
                query.Price = (int)txtPrice.Value;

                db.SaveChanges();
            }

            EnableFieldAndButton(false);
            LoadData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            EnableFieldAndButton(false);
        }

        private void EnableFieldAndButton(bool enable)
        {
            EnableField(enable);
            EnableButton(enable);
        }

        private void EnableField(bool enable)
        {
            if (!enable)
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
            }

            txtName.Enabled = enable;
            comboCategory.Enabled = enable;
            txtDesc.Enabled = enable;
            txtPrice.Enabled = enable;
        }

        private void EnableButton(bool enable)
        {
            btnInsert.Enabled = !enable;
            btnUpdate.Enabled = !enable;
            btnDelete.Enabled = !enable;
            btnSave.Enabled = enable;
            btnCancel.Enabled = enable;
        }
    }
}
