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
    public partial class UpNote : Form
    {
        Noteb noteDB = new Noteb();
        public UpNote()
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

        private void Updescripbox_TextChanged(object sender, EventArgs e)
        {
            if (this.Updescripbox.Text.ToString() != "")
            {
                this.Upnotebtn.Enabled = true;
            }

            
        }

        private void Boldswitch(bool swit)
        {
            if (true)
            {
                this.Updescripbox.Font = new Font(this.Updescripbox.Font.FontFamily, this.Updescripbox.Font.Size, FontStyle.Bold);
                this.Uptitlebox.Font = new Font(this.Uptitlebox.Font.FontFamily, this.Uptitlebox.Font.Size, FontStyle.Bold);
            }
            else if (false)
            {
                this.Updescripbox.Font = new Font(this.Updescripbox.Font.FontFamily, this.Updescripbox.Font.Size, FontStyle.Regular);
                this.Uptitlebox.Font = new Font(this.Uptitlebox.Font.FontFamily, this.Uptitlebox.Font.Size, FontStyle.Regular);
            }
        }

        private void ItalicSwitch(bool i)
        {
            if (true)
            {
                this.Updescripbox.Font = new Font(this.Updescripbox.Font.FontFamily, this.Updescripbox.Font.Size, FontStyle.Italic);
                this.Uptitlebox.Font = new Font(this.Uptitlebox.Font.FontFamily, this.Uptitlebox.Font.Size, FontStyle.Italic);
            }
            else if (false)
            {
                this.Updescripbox.Font = new Font(this.Updescripbox.Font.FontFamily, this.Updescripbox.Font.Size, FontStyle.Regular);
                this.Uptitlebox.Font = new Font(this.Uptitlebox.Font.FontFamily, this.Uptitlebox.Font.Size, FontStyle.Regular);
            }
        }



        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Updescripbox.Font = new Font(this.Updescripbox.Font.FontFamily, this.Updescripbox.Font.Size, FontStyle.Italic);
            this.Uptitlebox.Font = new Font(this.Uptitlebox.Font.FontFamily, this.Uptitlebox.Font.Size, FontStyle.Italic);
        }



        private void Uptitlebox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Upnotebtn_Click(object sender, EventArgs e)
        {
            NoteDB note = noteDB.NoteDBs.FirstOrDefault(p => p.Title == this.Uptitlebox.Text);
            note.Desciption = this.Updescripbox.Text.ToString();
            note.Date = this.Updatebox.Value;
            
            noteDB.SaveChanges();
            this.Hide();
            Main main = new Main();
            main.Refresh();
            main.Show();

        }

        private void Fontbox_Click(object sender, EventArgs e)
        {
            this.Updescripbox.Font = new Font(this.Fontbox.Text, this.Updescripbox.Font.Size);
            this.Uptitlebox.Font = new Font(this.Fontbox.Text, this.Uptitlebox.Font.Size);
        }

        private void Sizebox_Click(object sender, EventArgs e)
        {
            this.Updescripbox.Font = new Font(this.Fontbox.Text, this.Updescripbox.Font.Size);
            this.Uptitlebox.Font = new Font(this.Fontbox.Text, this.Uptitlebox.Font.Size);
        }

        private void ItalicUpbtn_Click(object sender, EventArgs e)
        {
            this.Updescripbox.Font = new Font(this.Updescripbox.Font.FontFamily, this.Updescripbox.Font.Size, FontStyle.Italic);
            this.Uptitlebox.Font = new Font(this.Uptitlebox.Font.FontFamily, this.Uptitlebox.Font.Size, FontStyle.Italic);
        }

        private void underUpbtn_Click(object sender, EventArgs e)
        {
            this.Updescripbox.Font = new Font(this.Updescripbox.Font.FontFamily, this.Updescripbox.Font.Size, FontStyle.Underline);
            this.Uptitlebox.Font = new Font(this.Uptitlebox.Font.FontFamily, this.Uptitlebox.Font.Size, FontStyle.Underline);
        }

        private void Colorbtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = this.colorDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                this.Updescripbox.ForeColor = this.colorDialog.Color;
                this.Uptitlebox.ForeColor = this.colorDialog.Color;
            }
        }

        private void UpNote_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in FontFamily.Families)
            {
                this.Fontbox.Items.Add(font.Name.ToString());
            }
        }
    }
}
