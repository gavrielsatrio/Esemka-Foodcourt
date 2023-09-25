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
    public partial class ViewReservationsForm : Form
    {
        private ModelEntities db = new ModelEntities();
        private List<PictureBox> tableList = new List<PictureBox>();
        public ViewReservationsForm()
        {
            InitializeComponent();
        }

        private void ViewReservationsForm_Load(object sender, EventArgs e)
        {
            tableList = new List<PictureBox>()
            {
                new PictureBox(),
                picBoxTable1,
                picBoxTable2,
                picBoxTable3,
                picBoxTable4,
                picBoxTable5,
                picBoxTable6,
                picBoxTable7,
                picBoxTable8,
                picBoxTable9,
                picBoxTable10,
                picBoxTable11,
                picBoxTable12
            };

            LoadTableStatus();
        }

        private void LoadTableStatus()
        {
            dgvMenu.Columns.Clear();
            txtFirstname.Text = "";
            txtLastname.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";

            var allTables = db.Tables.ToList();
            foreach (var table in allTables)
            {
                var reservationOnThatTable = db.Reservations.ToList().Where(x => x.TableID == table.ID && x.ReservationDate.Date == dtpDate.Value.Date).ToList().FirstOrDefault();

                if (reservationOnThatTable != null)
                {
                    // Ada reservasi di table tersebut
                    tableList[table.ID].ImageLocation = Application.StartupPath + "/table_reserved.png";
                }
                else
                {
                    tableList[table.ID].ImageLocation = Application.StartupPath + "/table_free.png";
                }
            }
        }

        private void ViewReservationsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            new AdminMainForm().Show();
        }

        private void picBoxTable_Click(object sender, EventArgs e)
        {
            var picBoxTable = (PictureBox)sender;
            var tableID = int.Parse(picBoxTable.Name.Replace("picBoxTable", ""));

            var queryReservation = db.Reservations.ToList().Where(x => x.TableID == tableID && x.ReservationDate.Date == dtpDate.Value.Date).FirstOrDefault();
            if(queryReservation == null)
            {
                dgvMenu.Columns.Clear();
                txtFirstname.Text = "";
                txtLastname.Text = "";
                txtEmail.Text = "";
                txtPhone.Text = "";

                return;
            }

            txtFirstname.Text = queryReservation.CustomerFirstName;
            txtLastname.Text = queryReservation.CustomerLastName;
            txtEmail.Text = queryReservation.CustomerEmail;
            txtPhone.Text = queryReservation.CustomerPhoneNumber;

            dgvMenu.Columns.Clear();

            dgvMenu.DataSource = queryReservation.ReservationDetails.Select(x => new
            {
                Menu = x.Menu.Name,
                x.Qty,
                Price = $"Rp{x.Menu.Price.ToString("N2")}",
                Subtotal = $"Rp{(x.Menu.Price * x.Qty).ToString("N2")}"
            }).ToList();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            LoadTableStatus();
        }
    }
}
