using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perpustakaan
{
    public partial class Pengembalian : Form
    {
        public Pengembalian(Form1 fm1)
        {
            InitializeComponent();
        }

        Module md = new Module();
        string id = "0";

        public void awal()
        {
            string sql = "SELECT idpeminjaman, namapustakawan, namaanggota, judul, tanggalpeminjaman, status FROM vtransaksi WHERE namaanggota LIKE '%" + textBox1.Text + "%' and idstatus = 7";
            //md.pesan(sql);
            dataGridView1.DataSource = md.getData(sql);
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Pustakawan";
            dataGridView1.Columns[2].HeaderText = "Anggota";
            dataGridView1.Columns[3].HeaderText = "Judul";
            dataGridView1.Columns[4].HeaderText = "Tanggan Pijam";
            dataGridView1.Columns[5].HeaderText = "Status";
            comboBox1.SelectedIndex = 1;
            id = "0";
        }

        void getCombo()
        {
            comboBox1.DataSource = md.getData("SELECT * FROM status");
            comboBox1.DisplayMember = "status";
            comboBox1.ValueMember = "idstatus";
        }

        private void Pengembalian_Load(object sender, EventArgs e)
        {
            getCombo();
            awal();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            awal();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            awal();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

                id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (id == "0")
            {
                md.pesan("Pilih Data terlebih dahulu");
            }
            else
            {
                if (md.dialogForm("Apakah anda yakin data sudah benar?"))
                {
                    string sql = "UPDATE transaksi SET tanggalpengembalian = '" + dateTimePicker1.Value.ToString("yyyy/MM/dd") + "', idstatus = '" + comboBox1.SelectedValue + "' WHERE idpeminjaman = " + id;
                    //md.pesan(sql);
                    md.exc(sql);
                    md.clearForm(groupBox2);
                    awal();
                }
            }
        }
    }
}
