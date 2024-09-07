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
    public partial class CariBuku : Form
    {

        Form1 f1;
        public CariBuku(Form1 fm1)
        {
            InitializeComponent();
            this.f1 = fm1;
        }

        Module md = new Module();

        private void CariBuku_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = md.getData("SELECT * FROM buku");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) {
                f1.textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                f1.idbuku = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                //md.pesan(data);
                this.Close();
            }
        }
    }
}
