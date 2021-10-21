using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Notebook.Database;

namespace Notebook
{
    public partial class Signup : Form
    {
        //    string connectionstring = @"Data Source=LAPTOP-5C698NK2\SQLEXPRESS;Initial Catalog=notebook;Integrated Security=True";
        private Noteb noteb = new Noteb();
        public Signup()
        {
            InitializeComponent();
        }

       

        private void complSignUpbtn_Click(object sender, EventArgs e)
        {
            //using (SqlConnection sqlcon = new SqlConnection(this.connectionstring))
            //{
            //    sqlcon.Open();
            //    SqlCommand sqlcom = new SqlCommand("Reg", sqlcon);
            //    sqlcom.CommandType = CommandType.StoredProcedure;
            //    sqlcom.Parameters.AddWithValue("@Username", this.SignUpUsertxt.Text.Trim());
            //    sqlcom.Parameters.AddWithValue("@Password", this.SignUpPasstxt.Text.Trim());
            //    sqlcom.ExecuteNonQuery();
            //    MessageBox.Show("Đăng ký thành công mời quay lại");
            //}

            LoginDB loginDB = new LoginDB()
            {
                Username = this.SignUpUsertxt.Text,
                Password = this.SignUpPasstxt.Text,
            };
            this.noteb.LoginDBs.Add(loginDB);
            this.noteb.SaveChanges();
            MessageBox.Show("Đăng ký thành công mời quay lại");

        }

        private void returnbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SigninFrm transscrn = new SigninFrm();
            transscrn.ShowDialog();
        }
    }
}
