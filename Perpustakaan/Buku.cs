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
    public partial class Buku : Form
    {
        public Buku()
        {
            InitializeComponent();
        }

        Module md = new Module();
        string id, sql;
        bool aksi = true;

        public void awal()
        {
            dataGridView1.DataSource = md.getData("SELECT * FROM buku WHERE judul LIKE '%" + textBox1.Text + "%'");
            md.clearForm(groupBox2);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Judul";
            dataGridView1.Columns[2].HeaderText = "Penerbit";
            groupBox1.Enabled = true;
            groupBox2.Enabled = false;
            groupBox3.Enabled = true;
            id = "0";
            aksi = true;
        }

        void buka()
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = true;
            groupBox3.Enabled = false;
        }

        private void Buku_Load(object sender, EventArgs e)
        {
            awal();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buka();
            md.clearForm(groupBox2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            awal();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (id == "0")
            {
                MessageBox.Show("Pilih Data Terlebih Dahulu");
            }
            else
            {
                aksi = false;
                buka();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (id == "0")
            {
                MessageBox.Show("Pilih Data Terlebih Dahulu");
            }
            else
            {
                if (md.dialogForm("Apakah Anda ingin menghapus data " + textBox2.Text))
                {
                    sql = "DELETE FROM buku WHERE idbuku = " + id;
                    //md.pesan(sql);
                    md.exc(sql);
                    md.pesan("Berhasil Dihapus");
                    awal();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (aksi)
            {
                sql = "INSERT INTO buku VALUES ('" + textBox2.Text + "','" + textBox3.Text + "')";
                //md.pesan(sql);
                md.exc(sql);
                md.pesan("Berhasil Ditambahkan");
                awal();
            }
            else
            {
                sql = "UPDATE buku SET judul = '" + textBox2.Text + "',penerbit = '" + textBox3.Text + "' WHERE idbuku = " + id;
                //md.pesan(sql);
                md.exc(sql);
                md.pesan("Berhasil Diubah");
                awal();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            awal();
        }
    }

}

