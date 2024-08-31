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
            Form1 form = new Form1();
            string sql = "SELECT * FROM pustakawan WHERE username = '"+ textBox1.Text +"' AND password = '"+textBox2.Text+"'";
            //if (md.getCount(sql) > 0)
            //{
            //    md.pesan("ada Data");
            //}
            //else
            //{
            //    md.pesan("Username atau Password Salah");
            //}
            this.Hide();
            form.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
