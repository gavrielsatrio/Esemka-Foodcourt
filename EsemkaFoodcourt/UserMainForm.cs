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
    public partial class UserMainForm : Form
    {
        private ModelEntities db = new ModelEntities();
        private List<PictureBox> tableList = new List<PictureBox>();

        public UserMainForm()
        {
            InitializeComponent();
        }

        private void UserMainForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome, {GlobalData.User.FirstName} {GlobalData.User.LastName}";

            lblCurrTime.Text = $"Current Time: {DateTime.Now.ToString("HH:mm:ss")}";
            timerTime.Start();

            LoadTodayTable();
        }

        private void LoadTodayTable()
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

            var allTables = db.Tables.ToList();
            foreach (var table in allTables)
            {
                var reservationOnThatTable = db.Reservations.ToList().Where(x => x.TableID == table.ID && x.ReservationDate.Date == DateTime.Now.Date).ToList();

                if(reservationOnThatTable.Count > 0)
                {
                    tableList[table.ID].ImageLocation = Application.StartupPath + "/table_reserved.png";
                }
                else
                {
                    tableList[table.ID].ImageLocation = Application.StartupPath + "/table_free.png";
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void UserMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            lblCurrTime.Text = $"Current Time: {DateTime.Now.ToString("HH:mm:ss")}";
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ReserveTableForm().Show();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ViewReservationHistoryForm().Show();
        }
    }
}
