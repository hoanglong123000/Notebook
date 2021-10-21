
namespace Notebook
{
    partial class Signup
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
            this.SignUpPasstxt = new System.Windows.Forms.TextBox();
            this.SignUpUsertxt = new System.Windows.Forms.TextBox();
            this.SignUpPassbox = new System.Windows.Forms.Label();
            this.SignUpUserbox = new System.Windows.Forms.Label();
            this.complSignUpbtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.returnbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SignUpPasstxt
            // 
            this.SignUpPasstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpPasstxt.Location = new System.Drawing.Point(293, 182);
            this.SignUpPasstxt.Name = "SignUpPasstxt";
            this.SignUpPasstxt.PasswordChar = '*';
            this.SignUpPasstxt.Size = new System.Drawing.Size(390, 38);
            this.SignUpPasstxt.TabIndex = 6;
            // 
            // SignUpUsertxt
            // 
            this.SignUpUsertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpUsertxt.Location = new System.Drawing.Point(293, 110);
            this.SignUpUsertxt.Name = "SignUpUsertxt";
            this.SignUpUsertxt.Size = new System.Drawing.Size(390, 38);
            this.SignUpUsertxt.TabIndex = 7;
            // 
            // SignUpPassbox
            // 
            this.SignUpPassbox.AutoSize = true;
            this.SignUpPassbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpPassbox.Location = new System.Drawing.Point(73, 185);
            this.SignUpPassbox.Name = "SignUpPassbox";
            this.SignUpPassbox.Size = new System.Drawing.Size(136, 32);
            this.SignUpPassbox.TabIndex = 4;
            this.SignUpPassbox.Text = "Mật Khẩu";
            // 
            // SignUpUserbox
            // 
            this.SignUpUserbox.AutoSize = true;
            this.SignUpUserbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpUserbox.Location = new System.Drawing.Point(73, 110);
            this.SignUpUserbox.Name = "SignUpUserbox";
            this.SignUpUserbox.Size = new System.Drawing.Size(214, 32);
            this.SignUpUserbox.TabIndex = 5;
            this.SignUpUserbox.Text = "Tên Đăng Nhập";
            // 
            // complSignUpbtn
            // 
            this.complSignUpbtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complSignUpbtn.Location = new System.Drawing.Point(117, 303);
            this.complSignUpbtn.Name = "complSignUpbtn";
            this.complSignUpbtn.Size = new System.Drawing.Size(188, 67);
            this.complSignUpbtn.TabIndex = 3;
            this.complSignUpbtn.Text = "OK";
            this.complSignUpbtn.UseVisualStyleBackColor = true;
            this.complSignUpbtn.Click += new System.EventHandler(this.complSignUpbtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(578, 303);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(188, 67);
            this.ExitBtn.TabIndex = 8;
            this.ExitBtn.Text = "Thoát";
            this.ExitBtn.UseVisualStyleBackColor = true;
            // 
            // returnbtn
            // 
            this.returnbtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnbtn.Location = new System.Drawing.Point(348, 303);
            this.returnbtn.Name = "returnbtn";
            this.returnbtn.Size = new System.Drawing.Size(188, 67);
            this.returnbtn.TabIndex = 3;
            this.returnbtn.Text = "Quay lại";
            this.returnbtn.UseVisualStyleBackColor = true;
            this.returnbtn.Click += new System.EventHandler(this.returnbtn_Click);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.SignUpPasstxt);
            this.Controls.Add(this.SignUpUsertxt);
            this.Controls.Add(this.SignUpPassbox);
            this.Controls.Add(this.SignUpUserbox);
            this.Controls.Add(this.returnbtn);
            this.Controls.Add(this.complSignUpbtn);
            this.Name = "Signup";
            this.Text = "Signup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SignUpPasstxt;
        private System.Windows.Forms.TextBox SignUpUsertxt;
        private System.Windows.Forms.Label SignUpPassbox;
        private System.Windows.Forms.Label SignUpUserbox;
        private System.Windows.Forms.Button complSignUpbtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button returnbtn;
    }
}