using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms.VisualStyles;

namespace EsemkaFoodcourt
{
    public partial class ReserveTableForm : Form
    {
        private ModelEntities db = new ModelEntities();

        public ReserveTableForm()
        {
            InitializeComponent();
        }

        private void ReserveTableForm_Load(object sender, EventArgs e)
        {
            LoadComboTable();
            LoadComboMenu();
            LoadTotal();
        }

        private void LoadComboTable()
        {
            var query = db.Tables.ToList();
            var reservedTableID = db.Reservations.ToList().Where(x => x.ReservationDate.Date == dtpDate.Value.Date).Select(x => x.TableID).ToList();

            query = query.Where(x => !reservedTableID.Contains(x.ID)).ToList();

            comboTable.ValueMember = "ID";
            comboTable.DisplayMember = "Name";
            comboTable.DataSource = query;
        }

        private void LoadComboMenu()
        {
            var query = db.Menus.ToList();

            comboMenu.ValueMember = "ID";
            comboMenu.DisplayMember = "Name";
            comboMenu.DataSource = query;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UserMainForm().Show();
        }

        private void ReserveTableForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            new UserMainForm().Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(comboTable.SelectedValue == null)
            {
                MessageBox.Show("Select a table first ...");
                return;
            }

            if(dgvMenu.RowCount == 0)
            {
                MessageBox.Show("You have to add menu first ...");
                return;
            }

            foreach (var control in groupCustomerInfo.Controls)
            {
                if(control is TextBox txt)
                {
                    if(txt.Text == "")
                    {
                        MessageBox.Show("Fill in customer information ...");
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

            db.Reservations.Add(new Reservation
            {
                UserID = GlobalData.User.ID,
                CustomerFirstName = txtFirstname.Text,
                CustomerLastName = txtLastname.Text,
                CustomerEmail = txtEmail.Text,
                CustomerPhoneNumber = txtPhone.Text,
                NumberOfPeople = (int)txtNumOfPeople.Value,
                TableID = int.Parse(comboTable.SelectedValue.ToString()),
                ReservationDate = DateTime.Now.Date
            });
            db.SaveChanges();

            var reservationID = db.Reservations.ToList().LastOrDefault().ID;
            for (int i = 0; i < dgvMenu.RowCount; i++)
            {
                db.ReservationDetails.Add(new ReservationDetail
                {
                    ReservationID = reservationID,
                    MenuID = int.Parse(dgvMenu["MenuID", i].Value.ToString()),
                    Qty = int.Parse(dgvMenu["Qty", i].Value.ToString())
                });
                db.SaveChanges();
            }

            MessageBox.Show("Success reserved a table ...");

            this.Hide();
            new UserMainForm().Show();
        }

        private void checkUseSameInformation_CheckedChanged(object sender, EventArgs e)
        {
            if(checkUseSameInformation.Checked)
            {
                groupCustomerInfo.Enabled = false;

                txtFirstname.Text = GlobalData.User.FirstName;
                txtLastname.Text = GlobalData.User.LastName;
                txtEmail.Text = GlobalData.User.Email;
                txtPhone.Text = GlobalData.User.PhoneNumber;
            }
            else
            {
                groupCustomerInfo.Enabled = true;

                txtFirstname.Text = "";
                txtLastname.Text = "";
                txtEmail.Text = "";
                txtPhone.Text = "";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var menuIndex = -1;
            for (int i = 0; i < dgvMenu.Rows.Count; i++)
            {
                if (dgvMenu["MenuID", i].Value.ToString() == comboMenu.SelectedValue.ToString())
                {
                    menuIndex = i;
                    break;
                }
            }

            if(menuIndex == -1)
            {
                dgvMenu.Rows.Add();

                var menuID = int.Parse(comboMenu.SelectedValue.ToString());
                var queryMenu = db.Menus.ToList().FirstOrDefault(x => x.ID == menuID);

                dgvMenu["MenuID", dgvMenu.RowCount - 1].Value = menuID;
                dgvMenu["Menu", dgvMenu.RowCount - 1].Value = queryMenu.Name;
                dgvMenu["Qty", dgvMenu.RowCount - 1].Value = txtQty.Value.ToString();
                dgvMenu["PriceValue", dgvMenu.RowCount - 1].Value = queryMenu.Price;
                dgvMenu["Price", dgvMenu.RowCount - 1].Value = $"Rp{queryMenu.Price.ToString("N2")}";
                dgvMenu["Subtotal", dgvMenu.RowCount - 1].Value = $"Rp{(queryMenu.Price * (double)txtQty.Value).ToString("N2")}";
            }
            else
            {
                var newQty = double.Parse(dgvMenu["Qty", menuIndex].Value.ToString()) + (double)txtQty.Value;
                var newSubtotal = newQty * double.Parse(dgvMenu["PriceValue", menuIndex].Value.ToString());

                dgvMenu["Qty", menuIndex].Value = newQty.ToString();
                dgvMenu["Subtotal", menuIndex].Value = $"Rp{newSubtotal.ToString("N2")}";
            }

            LoadTotal();
        }

        private void LoadTotal()
        {
            lblReservationFee.Text = $"Rp{GlobalData.ReservationFee.ToString("N2")}";

            double totalMenu = 0;
            for (int i = 0; i < dgvMenu.Rows.Count; i++)
            {
                totalMenu += double.Parse(dgvMenu["PriceValue", i].Value.ToString()) * double.Parse(dgvMenu["Qty", i].Value.ToString());
            }

            lblMenuTotal.Text = $"Rp{totalMenu.ToString("N2")}";
            lblTotalPrice.Text = $"Rp{(GlobalData.ReservationFee + totalMenu).ToString("N2")}";
        }

        private void dgvMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex == dgvMenu.Columns["Action"].Index)
            {
                dgvMenu.Rows.RemoveAt(e.RowIndex);
                LoadTotal();
            }
        }
    }
}
