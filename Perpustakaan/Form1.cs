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
        public string idbuku, nbuku, idanggonta, idpustakawan;

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
            Pengembalian p = new Pengembalian(this);
            p.ShowDialog();
        }

        private void laporanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Laporan laporan = new Laporan();
            laporan.ShowDialog();
        }

        Login login = new Login();
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            login.Show();
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
                idanggonta = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CariBuku cr = new CariBuku(this);
            cr.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            getAnggota();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            md.clearForm(groupBox2);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            login.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (idbuku == "0" || idanggonta == "0")
            {
                md.pesan("Data tidak boleh kosong");
            }
            else
            {
                if (md.dialogForm("Apakah anda yakin ingin menyimpan data ini?"))
                {
                    string sql = "INSERT INTO transaksi VALUES ('" + idpustakawan + "','" + idanggonta + "','" + idbuku + "','" + comboBox1.SelectedValue + "','" + dateTimePicker1.Value.ToString("yyyy/MM/dd") + "',NULL)";
                    //md.pesan(sql);
                    md.exc(sql);
                    md.pesan("Peminjaman berhasil");
                    md.clearForm(groupBox2);
                    groupBox2.Enabled = false;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            md.pesan(idbuku);
        }
    }
}
