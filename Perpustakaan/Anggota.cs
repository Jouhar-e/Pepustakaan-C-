using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Perpustakaan
{

    public partial class Anggota : Form
    {

        public SqlConnection conn;
        public SqlDataAdapter da;
        public SqlDataReader dr;
        public DataTable dt;

        public readonly string namaServer = "Data Source=DESKTOP-5UJ2CS8\\SQLEXPRESS;Initial Catalog=perpustakaan;Integrated Security=True";

        public SqlCommand cmd;

        public void koneksi()
        {
            conn = new SqlConnection(namaServer);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void closeKoneksi()
        {
            conn.Close();
            cmd.Dispose();
        }

        public Anggota()
        {
            InitializeComponent();
        }

        Module md = new Module();
        string id, sql;
        bool aksi = true;

        public void awal()
        {
            koneksi();
            try
            {
                cmd = new SqlCommand("SELECT * FROM anggota WHERE namaanggota LIKE '%" + textBox1.Text + "%'", conn);
                da = new SqlDataAdapter();
                dt = new DataTable();
                da.SelectCommand = cmd;
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeKoneksi();
            }
            //dataGridView1.DataSource = md.getData("SELECT * FROM anggota WHERE namaanggota LIKE '%" + textBox1.Text + "%'");
            md.clearForm(groupBox2);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Anggota";
            dataGridView1.Columns[2].HeaderText = "Alamat";
            groupBox1.Enabled = true;
            groupBox2.Enabled = false;
            groupBox3.Enabled = true;
            id = "0";
            aksi = true;
        }

        private void Anggota_Load(object sender, EventArgs e)
        {
            awal();
        }

        void buka()
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = true;
            groupBox3.Enabled = false;
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
                    sql = "DELETE FROM anggota WHERE idanggota = " + id;
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
                sql = "INSERT INTO anggota VALUES ('" + textBox2.Text + "','" + textBox3.Text + "')";
                //md.pesan(sql);
                md.exc(sql);
                md.pesan("Berhasil Ditambahkan");
                awal();
            }
            else
            {
                sql = "UPDATE anggota SET namaanggota = '" + textBox2.Text + "',alamat = '" + textBox3.Text + "' WHERE idanggota = " + id;
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
