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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Module md = new Module();
        public string idbuku, nbuku;

        public void setTextbox(string buku)
        {
            textBox3.Text = buku;
            nbuku = buku;
        }

        public void getAnggota()
        {
            dataGridView1.DataSource = md.getData("SELECT * FROM anggota WHERE namaanggota LIKE '%" + textBox1.Text + "%'");
        }

        private void pustakawanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pustakawan pustakawan = new Pustakawan();
            pustakawan.ShowDialog();
        }

        private void anggotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Anggota anggota = new Anggota();    
            anggota.ShowDialog();
        }

        private void bukuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Buku buku = new Buku();
            buku.ShowDialog();
        }

        private void pengembalianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pengembalian p = new Pengembalian();
            p.ShowDialog();
        }

        private void laporanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Laporan laporan = new Laporan();
            laporan.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }

        void getCombo()
        {
            comboBox1.DataSource = md.getData("SELECT * FROM status");
            comboBox1.DisplayMember = "status";
            comboBox1.ValueMember = "idstatus";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getCombo();
            getAnggota();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            md.clearForm(groupBox2);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CariBuku cr = new CariBuku(this);
            cr.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            md.pesan(idbuku);
        }
    }
}
