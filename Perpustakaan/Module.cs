using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perpustakaan
{
    internal class Module
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

        //menampilakan data tabel
        public DataTable getData(string sql)
        {
            koneksi();
            try
            {
                cmd = new SqlCommand(sql, conn);
                da = new SqlDataAdapter();
                dt = new DataTable();
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                closeKoneksi();
            }
        }

        //digunakan untuk menampillkan jumlah data
        public int getCount(string sql)
        {
            koneksi();
            try
            {
                cmd = new SqlCommand(sql, conn);
                da = new SqlDataAdapter();
                dt = new DataTable();
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
            finally
            {
                closeKoneksi();
            }
        }

        public object getValue(string sql, string col)
        {
            koneksi();
            object value = null;
            try
            {
                cmd = new SqlCommand(sql, conn);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    if (dr.IsDBNull(dr.GetOrdinal(col)))
                    {
                        return "";
                    }
                    else
                    {
                        value = dr[col];
                        return value;
                    }
                }
                else
                {
                    return "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }
            finally
            {
                closeKoneksi();
            }
        }

        //untuk mengeksekusi code
        public bool exc(string sql)
        {
            koneksi();
            try
            {
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                closeKoneksi();
            }
        }

        //untuk mengecek apakah properti yang ada didalam groupbox apakah masih kosong
        public bool adaKosong(GroupBox gb)
        {
            foreach (Control ct in gb.Controls)
            {
                if (ct is TextBox textBox && textBox.Text.Trim() == string.Empty)
                {
                    return true;
                }else if(ct is PictureBox pc && pc.ImageLocation.Trim() == string.Empty)
                {
                    return true;
                }
            }
            return false;
        }

        //untuk menghapus data properti yang ada didalam groupbox
        public void clearForm(GroupBox gb)
        {
            foreach (Control ct in gb.Controls)
            {
                if (ct is TextBox tx)
                {
                    tx.Text = "";
                }
                else if (ct is NumericUpDown np)
                {
                    np.Value = 0;
                }
                else if (ct is ComboBox cb)
                {
                    cb.SelectedIndex = 0;
                }
            }
        }

        //agar textbox tertentu hanya bisa diisi dengan angka
        public void onlyNumber(KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back)
            {
                if (e.KeyChar < '0' || e.KeyChar > '9')
                {
                    e.Handled = true;
                }
            }
        }

        //untuk menampikan pesan eksekusi
        public bool dialogForm(string s)
        {
            DialogResult a = MessageBox.Show(s, "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }

        //pengganti untuk messagebox
        public void pesan(string s)
        {
            MessageBox.Show(s);
        }

    }
}
