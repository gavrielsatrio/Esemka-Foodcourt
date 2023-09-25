using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsemkaFoodcourt
{
    public partial class ManageMenuIngredientsForm : Form
    {
        private ModelEntities db = new ModelEntities();
        private int selectedDataID = -1;
        private int selected = -1;

        public ManageMenuIngredientsForm()
        {
            InitializeComponent();
        }

        private void ManageMenuIngredientsForm_Load(object sender, EventArgs e)
        {
            //groupBox1.Enabled = false;

            //LoadDataMenu();
            //LoadComboIngredient();
            //LoadComboUnit();
















            LoadDataMenu();

            // Bikin groupbox di kanan tidak bisa diedit

            groupBox1.Enabled = false;

            // Load ComboBox Choose Ingredients
            LoadComboIngredient();

            // Load ComboBox Unit
            LoadComboUnit();
        }

        private void LoadDataMenu()
        {
            //groupBox1.Enabled = false;
            //dgvIngredients.Rows.Clear();

            //dgvData.Columns.Clear();

            //var query = db.Menus.ToList();

            //if(txtSearch.Text != "")
            //{
            //    query = query.Where(x => x.Name.ToLower().StartsWith(txtSearch.Text.ToLower())).ToList();
            //}

            //dgvData.DataSource = query.Select(x => new
            //{
            //    x.ID,
            //    Menu = x.Name
            //}).ToList();

            //dgvData.Columns["ID"].Visible = false;

            //dgvData.Columns.Add(new DataGridViewLinkColumn()
            //{
            //    Name = "Action",
            //    HeaderText = "Action",
            //    Text = "Edit Ingredients",
            //    UseColumnTextForLinkValue = true
            //});












            // Hapus semua column-column
            // Sebelum load datanya

            dgvData.Columns.Clear();



            // Load data menu (tabel/dgv yang di kiri)
            // Ambil dari database
            // Tampilkan nama menu saja

            var query = db.Menus.ToList();
            dgvData.DataSource = query.Select(x => new
            {
                x.ID,
                Menu = x.Name
            }).ToList();

            dgvData.Columns["ID"].Visible = false;


            // Tambahkan column "Actions"
            // Dengan tipe LinkColumn

            // Clue :
            // Columns.Add();
            // DataGridViewLinkColumn();

            DataGridViewLinkColumn actionColumn = new DataGridViewLinkColumn();
            // Set nama columnnya
            // Clue :
            // namaVariable.Name = .......
            actionColumn.Name = "Action";

            // Set headerText columnya
            // Clue :
            // namaVariable.HeaderText = .......
            actionColumn.HeaderText = "Action";

            // Set tulisan di link labelnya
            // Clue :
            // namaVariable.Text = .......
            actionColumn.Text = "Edit Ingredients";
            actionColumn.UseColumnTextForLinkValue = true;


            dgvData.Columns.Add(actionColumn);







        }

        private void LoadComboIngredient()
        {
            //var query = db.Ingredients.ToList();
            //comboIngredient.ValueMember = "ID";
            //comboIngredient.DisplayMember = "Name";
            //comboIngredient.DataSource = query;












            // Load Combobox ingredients
            // Load dari database

            var query = db.Ingredients.ToList();
            comboIngredient.ValueMember = "ID";
            comboIngredient.DisplayMember = "Name";
            comboIngredient.DataSource = query;







        }

        private void LoadComboUnit()
        {
            //var query = db.Units.ToList();
            //comboUnit.ValueMember = "ID";
            //comboUnit.DisplayMember = "Name";
            //comboUnit.DataSource = query;













            // Load Combobox unit
            // Load dari database
            var query = db.Units.ToList();
            comboUnit.ValueMember = "ID";
            comboUnit.DisplayMember = "Name";
            comboUnit.DataSource = query;










        }

        private void ManageMenuIngredientsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            new AdminMainForm().Show();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if(e.RowIndex >= 0)
            //{
            //    selectedDataID = int.Parse(dgvData["ID", e.RowIndex].Value.ToString());

            //    dgvIngredients.Rows.Clear();

            //    var queryIngredients = db.MenuIngredients.ToList().Where(x => x.MenuID == selectedDataID).ToList();
            //    foreach (var item in queryIngredients)
            //    {
            //        dgvIngredients.Rows.Add(item.IngredientID, item.Ingredient.Name, item.Qty, item.UnitID, item.Unit.Name, "Remove");
            //    }

            //    groupBox1.Enabled = e.ColumnIndex == dgvData.Columns["Action"].Index;
            //}








            // Select data dari table kiri
            selected = e.RowIndex;

            if(selected != -1)
            {
                // Dapatkan ID dari menu yang kita select
                // di table sebelah kiri itu

                // Simpan ke variabel saja untuk
                // ID yang sudah di dapat

                // Kondisi sekarang:
                // Kita sudah tahu index row yang kita pilih

                var menuIDYangKitaSelect = int.Parse(dgvData.Rows[selected].Cells["ID"].Value.ToString());

                // Sekarang kita sudah dapatkan menuIDnya
                // Lalu,

                // Cari di table MenuIngredients
                // yang di mana
                // MenuID nya adalah menuID yang kita select tadi
                // Dengan kondisi kita sudah tahu menuID yang kita select

                // Clue :
                // Pakai database
                // Where

                var dataIngredientsYangAdaDiTableKanan = db.MenuIngredients.Where(x => x.MenuID == menuIDYangKitaSelect).ToList();

                // Ngeload datanya kali ini tidak pakai DataSource
                // Clue :
                // Looping
                // Rows.Add();

                dgvIngredients.Rows.Clear();
                foreach (var item in dataIngredientsYangAdaDiTableKanan)
                {
                    dgvIngredients.Rows.Add(item.IngredientID, item.Ingredient.Name, item.Qty, item.UnitID, item.Unit.Name, "Remove");
                }



                // Cek apakah column yang kita klik ini
                // adalah column "Action"

                // Clue :
                // Pakai index column yang kita select


                // Index column yang kita select adalah = e.ColumnIndex
                // Index column action = dgvData.Columns["Action"].Index
                if (e.ColumnIndex == dgvData.Columns["Action"].Index)
                {
                    // Enable semua field yang ada di groupbox
                    groupBox1.Enabled = true;
                }
                else
                {
                    // Disable semua field yang ada di groupbox
                    groupBox1.Enabled = false;
                }
            }













        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //if(dgvIngredients.RowCount == 0)
            //{
            //    MessageBox.Show("Menu must have at least one ingredient ...");
            //    return;
            //}

            //var queryDelete = db.MenuIngredients.Where(x => x.MenuID == selectedDataID).ToList();
            //db.MenuIngredients.RemoveRange(queryDelete);
            //db.SaveChanges();

            //for (int i = 0; i < dgvIngredients.RowCount; i++)
            //{
            //    db.MenuIngredients.Add(new MenuIngredient
            //    {
            //        MenuID = selectedDataID,
            //        Qty = int.Parse(dgvIngredients["Qty", i].Value.ToString()),
            //        UnitID = int.Parse(dgvIngredients["UnitID", i].Value.ToString()),
            //        IngredientID = int.Parse(dgvIngredients["IngredientID", i].Value.ToString())
            //    });
            //    db.SaveChanges();
            //}

            //btnCancel.PerformClick();


























            // Save ke database
            // Clue :
            // Looping


            // Hapus ingredients untuk menu yang kita pilih
            // dari database

            // Clue :
            // Pakai database
            // Where

            var menuIDYangDiSelectDiTableKiri = int.Parse(dgvData["ID", selected].Value.ToString());

            var ingredientsSebelumnya = db.MenuIngredients
                .Where(x => x.MenuID == menuIDYangDiSelectDiTableKiri)
                .ToList();

            db.MenuIngredients.RemoveRange(ingredientsSebelumnya);
            db.SaveChanges();


            var semuaRowIngredients = dgvIngredients.Rows;
            foreach (DataGridViewRow row in semuaRowIngredients)
            {
                // Save ke table MenuIngredients
                // Clue :
                // Pakai database

                MenuIngredient menuIngredient = new MenuIngredient();
                menuIngredient.MenuID = menuIDYangDiSelectDiTableKiri;
                menuIngredient.IngredientID = int.Parse(row.Cells["IngredientID"].Value.ToString());
                menuIngredient.Qty = int.Parse(row.Cells["Qty"].Value.ToString());
                menuIngredient.UnitID = int.Parse(row.Cells["UnitID"].Value.ToString());

                db.MenuIngredients.Add(menuIngredient);
                db.SaveChanges();
            }

            btnCancel.PerformClick();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //groupBox1.Enabled = false;
            //selectedDataID = -1;

            //dgvIngredients.Rows.Clear();
















            // 1. Clear semua row table kanan
            // 2. Disable semua field di groupbox

            dgvIngredients.Rows.Clear();
            groupBox1.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //var ingredientIndex = -1;
            //for (int i = 0; i < dgvIngredients.RowCount; i++)
            //{
            //    if (dgvIngredients["IngredientID", i].Value.ToString() == comboIngredient.SelectedValue.ToString())
            //    {
            //        ingredientIndex = i;
            //        break;
            //    }
            //}

            //if(ingredientIndex != -1)
            //{
            //    MessageBox.Show("You already added this ingredient ...");
            //    return;
            //}

            //dgvIngredients.Rows.Add();
            //dgvIngredients["IngredientID", dgvIngredients.RowCount - 1].Value = comboIngredient.SelectedValue.ToString();
            //dgvIngredients["IngredientName", dgvIngredients.RowCount - 1].Value = comboIngredient.Text;
            //dgvIngredients["Qty", dgvIngredients.RowCount - 1].Value = txtQty.Value.ToString();
            //dgvIngredients["UnitID", dgvIngredients.RowCount - 1].Value = comboUnit.SelectedValue.ToString();
            //dgvIngredients["Unit", dgvIngredients.RowCount - 1].Value = comboUnit.Text;


























            // Masukkan ingredients yang di select
            // ke dalam table atau dgv di bawahnya

            // Yang perlu kita masukkan:
            // ID dari ingredient yang kita pilih
            // Nama ingredient yang kita pilih
            // Qty dari ingredient itu
            // ID dari unit yang kita pilih
            // Nama unit yang kita pilih

            // Clue :
            // Rows.Add();

            // Tantangan:
            // - Bagaimana cara dapetin ID dari ingredient di 
            //   comboBox?
            // namaComboBox.SelectedValue
            // - Bagaimana cara dapetin ID dari unit di 
            //   comboBox?

            // Cara Rows.Add() nya sama dengan
            // yang di dgvKiri_CellClick


            // Sebelum kita add ke bawah,
            // Kita cek, apakah ingredient yang kita select
            // Udah pernah masuk ke table?

            // Clue 
            // Looping di setiap row datagridview nya
            // (foreach)
            // Tidak pakai database

            // 1. Dapetin semua row di datagridview
            var semuaRow = dgvIngredients.Rows;

            // 2. Looping (foreach)
            //    foreach(row in semuaRow)

            foreach (DataGridViewRow row in semuaRow)
            {
                // 3. Cek apakah row ini merupakan
                //    ingredient yang kita pilih

                // Kondisi sekarang :
                // Kita tahu ingredient yang kita select
                // itu namanya apa (misalnya Telur)

                // Tinggal kita cek, dengan nama ingredient
                // yang ada di row tersebut

                var ingredientDiRowIni = row.Cells["IngredientName"].Value.ToString();
                var ingredientYangKitaPilih = comboIngredient.Text;

                // CEK!!
                // Apakah ingredient di row ini = ingredient yang kita pilih
                if(ingredientDiRowIni == ingredientYangKitaPilih)
                {
                    MessageBox.Show("You can't add the same ingredients ...");
                    return;
                }
            }


            dgvIngredients.Rows
                .Add(
                    // IngredientID, diambil dari combo box ingredient
                    comboIngredient.SelectedValue,
                    // IngredientName, diambil dari combo box ingredient
                    comboIngredient.Text,
                    // Qty, diambil dari numeric up down
                    txtQty.Value,
                    // UnitID, diambil dari combo box unit
                    comboUnit.SelectedValue,
                    // UnitName, diambil dari combo box unit
                    comboUnit.Text,
                    // Action,
                    "Remove"
                );
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //LoadDataMenu();
        }

        private void dgvIngredients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvIngredients.Columns["IngredientAction"].Index)
            {
                dgvIngredients.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}
