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
            Pengembalian pengembalian = new Pengembalian();
            pengembalian.ShowDialog();
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
    }
}
