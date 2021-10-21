
namespace Notebook
{
    partial class FindNote
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.returnaddscrnbtn = new System.Windows.Forms.Button();
            this.Findbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numpage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.titlebox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // returnaddscrnbtn
            // 
            this.returnaddscrnbtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnaddscrnbtn.Location = new System.Drawing.Point(12, 253);
            this.returnaddscrnbtn.Name = "returnaddscrnbtn";
            this.returnaddscrnbtn.Size = new System.Drawing.Size(188, 67);
            this.returnaddscrnbtn.TabIndex = 5;
            this.returnaddscrnbtn.Text = "Quay lại";
            this.returnaddscrnbtn.UseVisualStyleBackColor = true;
            this.returnaddscrnbtn.Click += new System.EventHandler(this.returnaddscrnbtn_Click);
            // 
            // Findbtn
            // 
            this.Findbtn.Enabled = false;
            this.Findbtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Findbtn.Location = new System.Drawing.Point(299, 253);
            this.Findbtn.Name = "Findbtn";
            this.Findbtn.Size = new System.Drawing.Size(194, 67);
            this.Findbtn.TabIndex = 6;
            this.Findbtn.Text = "Tìm";
            this.Findbtn.UseVisualStyleBackColor = true;
            this.Findbtn.Click += new System.EventHandler(this.Findbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Thời gian";
            // 
            // numpage
            // 
            this.numpage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numpage.Location = new System.Drawing.Point(116, 124);
            this.numpage.Name = "numpage";
            this.numpage.Size = new System.Drawing.Size(146, 34);
            this.numpage.TabIndex = 7;
            this.numpage.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Số Trang";
            // 
            // titlebox
            // 
            this.titlebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlebox.Location = new System.Drawing.Point(116, 194);
            this.titlebox.Name = "titlebox";
            this.titlebox.Size = new System.Drawing.Size(146, 34);
            this.titlebox.TabIndex = 7;
            this.titlebox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tiêu đề";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(116, 43);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(146, 30);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // FindNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 348);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.titlebox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numpage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Findbtn);
            this.Controls.Add(this.returnaddscrnbtn);
            this.Name = "FindNote";
            this.Text = "FindNote";
            this.Load += new System.EventHandler(this.ReadNote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnaddscrnbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button Findbtn;
        public System.Windows.Forms.TextBox numpage;
        public System.Windows.Forms.TextBox titlebox;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}