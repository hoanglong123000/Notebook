
namespace Notebook
{
    partial class UpNote
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpNote));
            this.returnaddscrnbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Updatebox = new System.Windows.Forms.DateTimePicker();
            this.Uptitlebox = new System.Windows.Forms.TextBox();
            this.Updescripbox = new System.Windows.Forms.RichTextBox();
            this.Upnotebtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BoldUpbtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ItalicUpbtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.underUpbtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Colorbtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.Fontbox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.Sizebox = new System.Windows.Forms.ToolStripComboBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // returnaddscrnbtn
            // 
            this.returnaddscrnbtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnaddscrnbtn.Location = new System.Drawing.Point(12, 565);
            this.returnaddscrnbtn.Name = "returnaddscrnbtn";
            this.returnaddscrnbtn.Size = new System.Drawing.Size(155, 45);
            this.returnaddscrnbtn.TabIndex = 5;
            this.returnaddscrnbtn.Text = "Quay lại";
            this.returnaddscrnbtn.UseVisualStyleBackColor = true;
            this.returnaddscrnbtn.Click += new System.EventHandler(this.returnaddscrnbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(761, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 29);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ngày và tháng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tiêu đề:";
            // 
            // Updatebox
            // 
            this.Updatebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Updatebox.Location = new System.Drawing.Point(949, 74);
            this.Updatebox.Name = "Updatebox";
            this.Updatebox.Size = new System.Drawing.Size(155, 30);
            this.Updatebox.TabIndex = 18;
            // 
            // Uptitlebox
            // 
            this.Uptitlebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Uptitlebox.Location = new System.Drawing.Point(12, 117);
            this.Uptitlebox.Name = "Uptitlebox";
            this.Uptitlebox.Size = new System.Drawing.Size(941, 38);
            this.Uptitlebox.TabIndex = 17;
            this.Uptitlebox.TextChanged += new System.EventHandler(this.Uptitlebox_TextChanged);
            // 
            // Updescripbox
            // 
            this.Updescripbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updescripbox.Location = new System.Drawing.Point(21, 172);
            this.Updescripbox.Name = "Updescripbox";
            this.Updescripbox.Size = new System.Drawing.Size(1072, 359);
            this.Updescripbox.TabIndex = 16;
            this.Updescripbox.Text = "";
            this.Updescripbox.TextChanged += new System.EventHandler(this.Updescripbox_TextChanged);
            // 
            // Upnotebtn
            // 
            this.Upnotebtn.Enabled = false;
            this.Upnotebtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Upnotebtn.Location = new System.Drawing.Point(983, 564);
            this.Upnotebtn.Name = "Upnotebtn";
            this.Upnotebtn.Size = new System.Drawing.Size(140, 46);
            this.Upnotebtn.TabIndex = 21;
            this.Upnotebtn.Text = "Sửa";
            this.Upnotebtn.UseVisualStyleBackColor = true;
            this.Upnotebtn.Click += new System.EventHandler(this.Upnotebtn_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BoldUpbtn,
            this.toolStripSeparator2,
            this.ItalicUpbtn,
            this.toolStripSeparator3,
            this.underUpbtn,
            this.toolStripSeparator1,
            this.Colorbtn,
            this.toolStripSeparator5,
            this.Fontbox,
            this.toolStripSeparator4,
            this.Sizebox});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1135, 37);
            this.toolStrip1.TabIndex = 22;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BoldUpbtn
            // 
            this.BoldUpbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BoldUpbtn.Image = ((System.Drawing.Image)(resources.GetObject("BoldUpbtn.Image")));
            this.BoldUpbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BoldUpbtn.Name = "BoldUpbtn";
            this.BoldUpbtn.Size = new System.Drawing.Size(34, 34);
            this.BoldUpbtn.Text = "toolStripButton1";
            this.BoldUpbtn.ToolTipText = "In đậm chữ";
            this.BoldUpbtn.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 37);
            // 
            // ItalicUpbtn
            // 
            this.ItalicUpbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ItalicUpbtn.Image = ((System.Drawing.Image)(resources.GetObject("ItalicUpbtn.Image")));
            this.ItalicUpbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ItalicUpbtn.Name = "ItalicUpbtn";
            this.ItalicUpbtn.Size = new System.Drawing.Size(34, 34);
            this.ItalicUpbtn.Text = "toolStripButton2";
            this.ItalicUpbtn.ToolTipText = "In nghiêng chữ";
            this.ItalicUpbtn.Click += new System.EventHandler(this.ItalicUpbtn_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 37);
            // 
            // underUpbtn
            // 
            this.underUpbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.underUpbtn.Image = ((System.Drawing.Image)(resources.GetObject("underUpbtn.Image")));
            this.underUpbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.underUpbtn.Name = "underUpbtn";
            this.underUpbtn.Size = new System.Drawing.Size(34, 34);
            this.underUpbtn.Text = "toolStripButton3";
            this.underUpbtn.ToolTipText = "Gạch chân dưới chữ";
            this.underUpbtn.Click += new System.EventHandler(this.underUpbtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // Colorbtn
            // 
            this.Colorbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Colorbtn.Image = ((System.Drawing.Image)(resources.GetObject("Colorbtn.Image")));
            this.Colorbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Colorbtn.Name = "Colorbtn";
            this.Colorbtn.Size = new System.Drawing.Size(34, 34);
            this.Colorbtn.Text = "toolStripButton4";
            this.Colorbtn.ToolTipText = "Thay đổi màu của chữ";
            this.Colorbtn.Click += new System.EventHandler(this.Colorbtn_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 37);
            // 
            // Fontbox
            // 
            this.Fontbox.Name = "Fontbox";
            this.Fontbox.Size = new System.Drawing.Size(121, 37);
            this.Fontbox.ToolTipText = "Thay đổi Font chữ";
            this.Fontbox.Click += new System.EventHandler(this.Fontbox_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 37);
            // 
            // Sizebox
            // 
            this.Sizebox.Items.AddRange(new object[] {
            "8",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "28",
            "32",
            "36",
            "48",
            "56",
            "72"});
            this.Sizebox.Name = "Sizebox";
            this.Sizebox.Size = new System.Drawing.Size(121, 37);
            this.Sizebox.ToolTipText = "Thay đổi kích cỡ chữ";
            this.Sizebox.Click += new System.EventHandler(this.Sizebox_Click);
            // 
            // UpNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 622);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Upnotebtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Updatebox);
            this.Controls.Add(this.Uptitlebox);
            this.Controls.Add(this.Updescripbox);
            this.Controls.Add(this.returnaddscrnbtn);
            this.Name = "UpNote";
            this.Text = "UpNote";
            this.Load += new System.EventHandler(this.UpNote_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnaddscrnbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Updatebox;
        private System.Windows.Forms.Button Upnotebtn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BoldUpbtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton ItalicUpbtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton underUpbtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton Colorbtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripComboBox Fontbox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripComboBox Sizebox;
        public System.Windows.Forms.TextBox Uptitlebox;
        public System.Windows.Forms.RichTextBox Updescripbox;
        public System.Windows.Forms.ColorDialog colorDialog;
    }
}