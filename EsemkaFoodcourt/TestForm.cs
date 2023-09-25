using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsemkaFoodcourt
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            Mobil mobil = new Mobil();
            mobil.Nama = "Avanza";
            mobil.Harga = 150000;
            mobil.JumlahPintu = 4;

            List<Mobil> listMobil = new List<Mobil>();

            Mobil mobil1 = new Mobil();
            mobil1.Nama = "Avanza";
            mobil1.Harga = 150000;
            mobil1.JumlahPintu = 4;

            Mobil mobil2 = new Mobil();
            mobil2.Nama = "Kijang";
            mobil2.Harga = 300000;
            mobil2.JumlahPintu = 2;

            Mobil mobil3 = new Mobil();
            mobil3.Nama = "Innova";
            mobil3.Harga = 450000;
            mobil3.JumlahPintu = 5;

            listMobil.Add(mobil1);
            listMobil.Add(mobil2);
            listMobil.Add(mobil3);


            var mobilInnova = listMobil.Where(x => x.Nama == "Innova").FirstOrDefault();
            mobilInnova.Harga = 560000;
            mobilInnova.JumlahPintu = 3;

            var mobilKijang = listMobil.Where(x => x.Nama == "Kijang").FirstOrDefault();
            listMobil.Remove(mobilKijang);

            var coba = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal total = 0;

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                var subtotal = item.Cells["SubtotalHidden"].Value.ToString();

                // Cara 1
                total += Convert.ToDecimal(subtotal);

                // Cara 2
                // total = total + int.Parse(subtotal);
            }

            lblTotal.Text = total.ToString();
        }
    }

    internal class Mobil
    {
        public string Nama { get; set; }
        public int Harga { get; set; }
        public int JumlahPintu { get; set; }
    }
}
