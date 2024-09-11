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
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        Module md = new Module();

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            string sql = "SELECT * FROM pustakawan WHERE username = '" + textBox1.Text + "' AND password = '" + textBox2.Text + "'";
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                md.pesan("Username atau password kosong");
            }
            else
            {
                if (md.getCount(sql) > 0)
                {
                    md.pesan("Login Berhasil");
                    f1.lPustakawan.Text = md.getValue(sql, "namapustakawan");
                    f1.idpustakawan = md.getValue(sql, "idpustakawan");
                    this.Hide();
                    f1.Show();
                }
                else
                {
                    md.pesan("Username atau Password Salah");
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Close();
            //this.Close();
        }
    }
}
