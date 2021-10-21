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
    public partial class AddNote : Form
    {
       // private string connectionstring = @"Data Source=LAPTOP-5C698NK2\SQLEXPRESS;Initial Catalog=notebook;Integrated Security=True";
      //  private SqlCommand sqlcom = new SqlCommand();
      //  private SqlDataReader sqlreader;
       Noteb noteb = new Noteb();
   
        public AddNote()
        {
            InitializeComponent();
        }


        private void returnaddscrnbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Refresh();
            main.Show();
        }

        private void Addnotebtn_Click(object sender, EventArgs e)
        {
            //using (SqlConnection sqlcon = new SqlConnection(this.connectionstring))
            //{
            //    sqlcon.Open();
            //    this.sqlcom = new SqlCommand("Insert into NoteDB(Title, Date, Desciption) Values (@Title, @Date, @Desciption)", sqlcon);
            //    this.sqlcom.Parameters.Add("@Title", this.titlebox.Text.ToString());
            //    this.sqlcom.Parameters.Add("@Date", this.datebox.Value.ToString());
            //    this.sqlcom.Parameters.Add("@Desciption", this.descripbox.Text.ToString());
            //    this.sqlcom.ExecuteNonQuery();


            //    sqlcon.Close();
            //    this.Close();
            //    Main main = new Main();
            //    main.Refresh();
            //    main.Show();

            // }

            NoteDB noteDB = new NoteDB()
            {
                Title = this.titlebox.Text.ToString(),
                Date = this.datebox.Value,
                Desciption = this.descripbox.Text
            };

            
            if (noteDB != null)
            {
                noteb.NoteDBs.Add(noteDB);
                noteb.SaveChanges();
                this.Refresh();
                this.Hide();
                Main main = new Main();
                main.Refresh();
                main.Show();
                
            
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.descripbox.Text.ToString() != "")
            {
                this.Addnotebtn.Enabled = true;
            }
            else
            {
                this.Addnotebtn.Enabled = false;
            }    
        }

        private void AddNote_Load(object sender, EventArgs e)
        {
            foreach(FontFamily font in FontFamily.Families)
            {
                this.Fontbox.Items.Add(font.Name.ToString());
            }
        }

        private void Boldswitch(bool swit)
        {
            if (true)
            {
                this.descripbox.Font = new Font(this.descripbox.Font.FontFamily, this.descripbox.Font.Size, FontStyle.Bold);
                this.titlebox.Font = new Font(this.titlebox.Font.FontFamily, this.titlebox.Font.Size, FontStyle.Bold);
            }
            else if (false)
            {
                this.descripbox.Font = new Font(this.descripbox.Font.FontFamily, this.descripbox.Font.Size, FontStyle.Regular);
                this.titlebox.Font = new Font(this.titlebox.Font.FontFamily, this.titlebox.Font.Size, FontStyle.Regular);
            }
        }

        private void ItalicSwitch(bool i)
        {
            if (true)
            {
                this.descripbox.Font = new Font(this.descripbox.Font.FontFamily, this.descripbox.Font.Size, FontStyle.Italic);
                this.titlebox.Font = new Font(this.titlebox.Font.FontFamily, this.titlebox.Font.Size, FontStyle.Italic);
            }
            else if (false)
            {
                this.descripbox.Font = new Font(this.descripbox.Font.FontFamily, this.descripbox.Font.Size, FontStyle.Regular);
                this.titlebox.Font = new Font(this.titlebox.Font.FontFamily, this.titlebox.Font.Size, FontStyle.Regular);
            }
        }

        private void BoldtoolStripButton_Click(object sender, EventArgs e)
        {
            this.Boldswitch(true);
        }

        private void InclinetoolStripButton_Click(object sender, EventArgs e)
        {
            this.ItalicSwitch(true);
        }

        private void UnderlinetoolStripButton_Click(object sender, EventArgs e)
        {
            this.descripbox.Font = new Font(this.descripbox.Font.FontFamily, this.descripbox.Font.Size, FontStyle.Underline);
            this.titlebox.Font = new Font(this.titlebox.Font.FontFamily, this.titlebox.Font.Size, FontStyle.Underline);
        }

        private void BoldtoolStripButton_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void BoldtoolStripButton_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void BoldtoolStripButton_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void colorbtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = this.colorDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                this.descripbox.ForeColor = this.colorDialog.Color;
                this.titlebox.ForeColor = this.colorDialog.Color;
            }    
        }

        private void Fontbox_Click(object sender, EventArgs e)
        {

        }

        private void boldtoolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Fontbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.descripbox.Font = new Font(this.Fontbox.Text, this.descripbox.Font.Size);
            this.titlebox.Font = new Font(this.Fontbox.Text, this.titlebox.Font.Size);
        }

        private void Fontsizebox_Click(object sender, EventArgs e)
        {

        }

        private void Fontsizebox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.descripbox.Font = new Font(this.descripbox.Font.FontFamily, int.Parse(this.Fontsizebox.Text.ToString()));
            this.titlebox.Font = new Font(this.descripbox.Font.FontFamily, int.Parse(this.Fontsizebox.Text.ToString()));
        }
    }
}
