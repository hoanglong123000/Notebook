
namespace Notebook
{
    partial class SigninFrm
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
            this.Signinbtn = new System.Windows.Forms.Button();
            this.userbox = new System.Windows.Forms.Label();
            this.passbox = new System.Windows.Forms.Label();
            this.usertxt = new System.Windows.Forms.TextBox();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.Signuplbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Signinbtn
            // 
            this.Signinbtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signinbtn.Location = new System.Drawing.Point(74, 307);
            this.Signinbtn.Name = "Signinbtn";
            this.Signinbtn.Size = new System.Drawing.Size(188, 67);
            this.Signinbtn.TabIndex = 0;
            this.Signinbtn.Text = "Đăng Nhập";
            this.Signinbtn.UseVisualStyleBackColor = true;
            this.Signinbtn.Click += new System.EventHandler(this.Signinbtn_Click);
            // 
            // userbox
            // 
            this.userbox.AutoSize = true;
            this.userbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userbox.Location = new System.Drawing.Point(12, 114);
            this.userbox.Name = "userbox";
            this.userbox.Size = new System.Drawing.Size(214, 32);
            this.userbox.TabIndex = 1;
            this.userbox.Text = "Tên Đăng Nhập";
            // 
            // passbox
            // 
            this.passbox.AutoSize = true;
            this.passbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passbox.Location = new System.Drawing.Point(12, 189);
            this.passbox.Name = "passbox";
            this.passbox.Size = new System.Drawing.Size(136, 32);
            this.passbox.TabIndex = 1;
            this.passbox.Text = "Mật Khẩu";
            // 
            // usertxt
            // 
            this.usertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertxt.Location = new System.Drawing.Point(232, 114);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(390, 38);
            this.usertxt.TabIndex = 2;
            this.usertxt.TextChanged += new System.EventHandler(this.usertxt_TextChanged);
            // 
            // passtxt
            // 
            this.passtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passtxt.Location = new System.Drawing.Point(232, 186);
            this.passtxt.Name = "passtxt";
            this.passtxt.PasswordChar = '*';
            this.passtxt.Size = new System.Drawing.Size(390, 38);
            this.passtxt.TabIndex = 2;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(557, 307);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(188, 67);
            this.ExitBtn.TabIndex = 0;
            this.ExitBtn.Text = "Thoát";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // Signuplbl
            // 
            this.Signuplbl.AutoSize = true;
            this.Signuplbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Signuplbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signuplbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Signuplbl.Location = new System.Drawing.Point(318, 243);
            this.Signuplbl.Name = "Signuplbl";
            this.Signuplbl.Size = new System.Drawing.Size(304, 24);
            this.Signuplbl.TabIndex = 1;
            this.Signuplbl.Text = "Chưa có tài khoản thì nhấn vào đây";
            this.Signuplbl.Click += new System.EventHandler(this.Signuplbl_Click);
            // 
            // SigninFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.usertxt);
            this.Controls.Add(this.Signuplbl);
            this.Controls.Add(this.passbox);
            this.Controls.Add(this.userbox);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.Signinbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SigninFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.SigninFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Signinbtn;
        private System.Windows.Forms.Label userbox;
        private System.Windows.Forms.Label passbox;
        private System.Windows.Forms.TextBox usertxt;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label Signuplbl;
    }
}

