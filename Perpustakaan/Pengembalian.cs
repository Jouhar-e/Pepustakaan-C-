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
        public Pengembalian()
        {
            InitializeComponent();
        }

        Module md = new Module();

        public void awal()
        {
            dataGridView1.DataSource = md.getData("SELECT idpeminjaman, namapustakawan, namaanggota, judul, tanggalpeminjaman, status FROM vtransaksi WHERE namaanggota LIKE '%" + textBox1.Text + "%' and idstatus = "+comboBox2.SelectedValue);
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Pustakawan";
            dataGridView1.Columns[2].HeaderText = "Anggota";
            dataGridView1.Columns[3].HeaderText = "Judul";
            dataGridView1.Columns[4].HeaderText = "Tanggan Pijam";
            dataGridView1.Columns[5].HeaderText = "Status";
        }

        void getCombo()
        {
            comboBox1.DataSource = md.getData("SELECT * FROM status");
            comboBox1.DisplayMember = "status";
            comboBox1.ValueMember = "idstatus";
        }

        void getCombo1()
        {
            comboBox2.DataSource = md.getData("SELECT * FROM status");
            comboBox2.DisplayMember = "status";
            comboBox2.ValueMember = "idstatus";
        }

        private void Pengembalian_Load(object sender, EventArgs e)
        {
            getCombo1();
            awal();
            getCombo();
            comboBox1.SelectedIndex = 1;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            awal();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            awal();
        }
    }
}
