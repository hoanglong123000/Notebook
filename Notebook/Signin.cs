using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Notebook.Database;

namespace Notebook
{
    public partial class SigninFrm : Form
    {
        //  private string connectionstring = @"data source=LAPTOP-5C698NK2\SQLEXPRESS;initial catalog=notebook;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
        //  private SqlCommand sqlcom = new SqlCommand();
        // private SqlDataReader sqlreader;
        private Noteb noteb = new Noteb();
        

        public SigninFrm()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SigninFrm_Load(object sender, EventArgs e)
        {
           
        }

        private void Signuplbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup transscrn = new Signup();
            transscrn.ShowDialog();
        }

        private void Signinbtn_Click(object sender, EventArgs e)
        {
            //using(SqlConnection sqlcon = new SqlConnection(this.connectionstring))
            //{
            //    sqlcon.Open();
            //    string logintbl = "Select * from LoginDB where Username ='" + this.usertxt.Text.Trim() +"' and Password ='"+ this.passtxt.Text.Trim() + "'";
            //    SqlDataAdapter sda = new SqlDataAdapter(logintbl, sqlcon);
            //    DataTable dataTable = new DataTable();
            //    sda.Fill(dataTable);
            //    if(dataTable.Rows.Count == 1)
            //    {
            //        this.Hide();
            //        Main transscrn = new Main();
            //        transscrn.ShowDialog();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Kiểm tra lại mật khẩu và tài khoản");
            //    }    
            //}
            List<LoginDB> loginDB = noteb.LoginDBs.ToList();
            var verify = (from i in loginDB where i.Username == this.usertxt.Text && i.Password == this.passtxt.Text select i).Count();
            if (verify == 1)
            {
                this.Hide();
                Main mainscrn = new Main();
                
                mainscrn.ShowDialog();
                
               
   
                
            }
            else
            {
                MessageBox.Show("Kiểm tra lại mật khẩu và tài khoản");
            }
            

        }

        private void usertxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
