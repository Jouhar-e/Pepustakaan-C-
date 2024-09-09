using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Perpustakaan
{
    public partial class Laporan : Form
    {
        public Laporan()
        {
            InitializeComponent();
        }

        Module md = new Module();

        public void awal()
        {
            string sql = "SELECT idpeminjaman, namapustakawan, namaanggota, alamatanggota judul, penerbit, tanggalpeminjaman, tanggalpengembalian, status FROM vtransaksi WHERE namaanggota LIKE '%" + textBox1.Text + "%' ORDER BY tanggalpeminjaman ASC";
            //md.pesan(sql);
            dataGridView1.DataSource = md.getData(sql);
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Pustakawan";
            dataGridView1.Columns[2].HeaderText = "Anggota";
            dataGridView1.Columns[3].HeaderText = "Alamat Anggota";
            dataGridView1.Columns[4].HeaderText = "Judul";
            dataGridView1.Columns[5].HeaderText = "Tanggan Pijam";
            dataGridView1.Columns[6].HeaderText = "Tanggan Kembali";
            dataGridView1.Columns[7].HeaderText = "Status";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            awal();
        }

        private void Laporan_Load(object sender, EventArgs e)
        {
            awal();
        }
    }
}
