
namespace Notebook
{
    partial class AddNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNote));
            this.returnaddscrnbtn = new System.Windows.Forms.Button();
            this.Addnotebtn = new System.Windows.Forms.Button();
            this.descripbox = new System.Windows.Forms.RichTextBox();
            this.titlebox = new System.Windows.Forms.TextBox();
            this.datebox = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.boldtoolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BoldtoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.InclinetoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.UnderlinetoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.colorbtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.Fontbox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.Fontsizebox = new System.Windows.Forms.ToolStripComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.boldtoolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // returnaddscrnbtn
            // 
            this.returnaddscrnbtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnaddscrnbtn.Location = new System.Drawing.Point(12, 606);
            this.returnaddscrnbtn.Name = "returnaddscrnbtn";
            this.returnaddscrnbtn.Size = new System.Drawing.Size(148, 46);
            this.returnaddscrnbtn.TabIndex = 4;
            this.returnaddscrnbtn.Text = "Quay lại";
            this.returnaddscrnbtn.UseVisualStyleBackColor = true;
            this.returnaddscrnbtn.Click += new System.EventHandler(this.returnaddscrnbtn_Click);
            // 
            // Addnotebtn
            // 
            this.Addnotebtn.Enabled = false;
            this.Addnotebtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addnotebtn.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Addnotebtn.Location = new System.Drawing.Point(881, 606);
            this.Addnotebtn.Name = "Addnotebtn";
            this.Addnotebtn.Size = new System.Drawing.Size(140, 46);
            this.Addnotebtn.TabIndex = 10;
            this.Addnotebtn.Text = "Thêm";
            this.Addnotebtn.UseVisualStyleBackColor = true;
            this.Addnotebtn.Click += new System.EventHandler(this.Addnotebtn_Click);
            // 
            // descripbox
            // 
            this.descripbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripbox.Location = new System.Drawing.Point(22, 192);
            this.descripbox.Name = "descripbox";
            this.descripbox.Size = new System.Drawing.Size(1009, 391);
            this.descripbox.TabIndex = 11;
            this.descripbox.Text = "";
            this.descripbox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // titlebox
            // 
            this.titlebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlebox.Location = new System.Drawing.Point(12, 126);
            this.titlebox.Name = "titlebox";
            this.titlebox.Size = new System.Drawing.Size(941, 38);
            this.titlebox.TabIndex = 12;
            this.titlebox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // datebox
            // 
            this.datebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datebox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datebox.Location = new System.Drawing.Point(675, 70);
            this.datebox.Name = "datebox";
            this.datebox.Size = new System.Drawing.Size(130, 30);
            this.datebox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tiêu đề:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(499, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ngày và tháng:";
            // 
            // boldtoolStrip1
            // 
            this.boldtoolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.boldtoolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BoldtoolStripButton,
            this.toolStripSeparator2,
            this.InclinetoolStripButton,
            this.toolStripSeparator3,
            this.UnderlinetoolStripButton,
            this.toolStripSeparator1,
            this.colorbtn,
            this.toolStripSeparator5,
            this.Fontbox,
            this.toolStripSeparator4,
            this.Fontsizebox});
            this.boldtoolStrip1.Location = new System.Drawing.Point(0, 0);
            this.boldtoolStrip1.Name = "boldtoolStrip1";
            this.boldtoolStrip1.Size = new System.Drawing.Size(1043, 37);
            this.boldtoolStrip1.TabIndex = 15;
            this.boldtoolStrip1.Text = "In đậm chữ";
            this.boldtoolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.boldtoolStrip1_ItemClicked);
            // 
            // BoldtoolStripButton
            // 
            this.BoldtoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BoldtoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("BoldtoolStripButton.Image")));
            this.BoldtoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BoldtoolStripButton.Name = "BoldtoolStripButton";
            this.BoldtoolStripButton.Size = new System.Drawing.Size(34, 34);
            this.BoldtoolStripButton.ToolTipText = "In đậm chữ";
            this.BoldtoolStripButton.Click += new System.EventHandler(this.BoldtoolStripButton_Click);
            this.BoldtoolStripButton.DoubleClick += new System.EventHandler(this.BoldtoolStripButton_DoubleClick);
            this.BoldtoolStripButton.MouseEnter += new System.EventHandler(this.BoldtoolStripButton_MouseEnter);
            this.BoldtoolStripButton.MouseLeave += new System.EventHandler(this.BoldtoolStripButton_MouseLeave);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 37);
            // 
            // InclinetoolStripButton
            // 
            this.InclinetoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.InclinetoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("InclinetoolStripButton.Image")));
            this.InclinetoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.InclinetoolStripButton.Name = "InclinetoolStripButton";
            this.InclinetoolStripButton.Size = new System.Drawing.Size(34, 34);
            this.InclinetoolStripButton.Text = "In nghiêng chữ";
            this.InclinetoolStripButton.Click += new System.EventHandler(this.InclinetoolStripButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 37);
            // 
            // UnderlinetoolStripButton
            // 
            this.UnderlinetoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UnderlinetoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("UnderlinetoolStripButton.Image")));
            this.UnderlinetoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UnderlinetoolStripButton.Name = "UnderlinetoolStripButton";
            this.UnderlinetoolStripButton.Size = new System.Drawing.Size(34, 34);
            this.UnderlinetoolStripButton.Text = "Gạch chân dưới chữ";
            this.UnderlinetoolStripButton.Click += new System.EventHandler(this.UnderlinetoolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // colorbtn
            // 
            this.colorbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.colorbtn.Image = ((System.Drawing.Image)(resources.GetObject("colorbtn.Image")));
            this.colorbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.colorbtn.Name = "colorbtn";
            this.colorbtn.Size = new System.Drawing.Size(34, 34);
            this.colorbtn.ToolTipText = "Đổi màu chữ";
            this.colorbtn.Click += new System.EventHandler(this.colorbtn_Click);
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
            this.Fontbox.SelectedIndexChanged += new System.EventHandler(this.Fontbox_SelectedIndexChanged);
            this.Fontbox.Click += new System.EventHandler(this.Fontbox_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 37);
            // 
            // Fontsizebox
            // 
            this.Fontsizebox.Items.AddRange(new object[] {
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
            this.Fontsizebox.Name = "Fontsizebox";
            this.Fontsizebox.Size = new System.Drawing.Size(121, 37);
            this.Fontsizebox.ToolTipText = "Thay đổi kích cỡ của chữ";
            this.Fontsizebox.SelectedIndexChanged += new System.EventHandler(this.Fontsizebox_SelectedIndexChanged);
            this.Fontsizebox.Click += new System.EventHandler(this.Fontsizebox_Click);
            // 
            // AddNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 678);
            this.Controls.Add(this.boldtoolStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datebox);
            this.Controls.Add(this.titlebox);
            this.Controls.Add(this.descripbox);
            this.Controls.Add(this.Addnotebtn);
            this.Controls.Add(this.returnaddscrnbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AddNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNote";
            this.Load += new System.EventHandler(this.AddNote_Load);
            this.boldtoolStrip1.ResumeLayout(false);
            this.boldtoolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnaddscrnbtn;
        private System.Windows.Forms.Button Addnotebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip boldtoolStrip1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripButton BoldtoolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton InclinetoolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton UnderlinetoolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        public System.Windows.Forms.RichTextBox descripbox;
        public System.Windows.Forms.TextBox titlebox;
        public System.Windows.Forms.DateTimePicker datebox;
        public System.Windows.Forms.ToolStripComboBox Fontbox;
        public System.Windows.Forms.ToolStripComboBox Fontsizebox;
        public System.Windows.Forms.ToolStripButton colorbtn;
        public System.Windows.Forms.ColorDialog colorDialog;
    }
}