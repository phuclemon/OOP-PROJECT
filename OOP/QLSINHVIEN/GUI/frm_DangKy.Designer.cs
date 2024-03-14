
namespace QLSINHVIEN.GUI
{
    partial class frm_DangKy
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dk_Email = new System.Windows.Forms.TextBox();
            this.dk_XacNhanMK = new System.Windows.Forms.TextBox();
            this.dk_TK = new System.Windows.Forms.TextBox();
            this.dk_MK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Thoat = new System.Windows.Forms.Button();
            this.bt_DangKy = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dk_Email);
            this.groupBox1.Controls.Add(this.dk_XacNhanMK);
            this.groupBox1.Controls.Add(this.dk_TK);
            this.groupBox1.Controls.Add(this.dk_MK);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(8, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 288);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(9, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(9, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Xác Nhận lại Mật Khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(9, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mật Khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(9, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên Tài Khoản";
            // 
            // dk_Email
            // 
            this.dk_Email.Location = new System.Drawing.Point(270, 221);
            this.dk_Email.Name = "dk_Email";
            this.dk_Email.Size = new System.Drawing.Size(256, 31);
            this.dk_Email.TabIndex = 9;
            // 
            // dk_XacNhanMK
            // 
            this.dk_XacNhanMK.Location = new System.Drawing.Point(270, 162);
            this.dk_XacNhanMK.Name = "dk_XacNhanMK";
            this.dk_XacNhanMK.PasswordChar = '*';
            this.dk_XacNhanMK.Size = new System.Drawing.Size(256, 31);
            this.dk_XacNhanMK.TabIndex = 8;
            // 
            // dk_TK
            // 
            this.dk_TK.Location = new System.Drawing.Point(270, 39);
            this.dk_TK.Name = "dk_TK";
            this.dk_TK.Size = new System.Drawing.Size(256, 31);
            this.dk_TK.TabIndex = 5;
            // 
            // dk_MK
            // 
            this.dk_MK.Location = new System.Drawing.Point(270, 106);
            this.dk_MK.Name = "dk_MK";
            this.dk_MK.PasswordChar = '*';
            this.dk_MK.Size = new System.Drawing.Size(256, 31);
            this.dk_MK.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(167, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "Đăng Ký Tài Khoản";
            // 
            // bt_Thoat
            // 
            this.bt_Thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Thoat.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_Thoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Thoat.Location = new System.Drawing.Point(396, 376);
            this.bt_Thoat.Name = "bt_Thoat";
            this.bt_Thoat.Size = new System.Drawing.Size(123, 45);
            this.bt_Thoat.TabIndex = 10;
            this.bt_Thoat.Text = "Thoát";
            this.bt_Thoat.UseVisualStyleBackColor = false;
            this.bt_Thoat.Click += new System.EventHandler(this.bt_Thoat_Click);
            // 
            // bt_DangKy
            // 
            this.bt_DangKy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_DangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_DangKy.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_DangKy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_DangKy.Location = new System.Drawing.Point(109, 376);
            this.bt_DangKy.Name = "bt_DangKy";
            this.bt_DangKy.Size = new System.Drawing.Size(123, 45);
            this.bt_DangKy.TabIndex = 9;
            this.bt_DangKy.Text = "Đăng Ký";
            this.bt_DangKy.UseVisualStyleBackColor = false;
            this.bt_DangKy.Click += new System.EventHandler(this.bt_DangKy_Click);
            // 
            // frm_DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(635, 444);
            this.ControlBox = false;
            this.Controls.Add(this.bt_Thoat);
            this.Controls.Add(this.bt_DangKy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_DangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_DangKy_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox dk_Email;
        public System.Windows.Forms.TextBox dk_XacNhanMK;
        public System.Windows.Forms.TextBox dk_TK;
        public System.Windows.Forms.TextBox dk_MK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Thoat;
        private System.Windows.Forms.Button bt_DangKy;
    }
}