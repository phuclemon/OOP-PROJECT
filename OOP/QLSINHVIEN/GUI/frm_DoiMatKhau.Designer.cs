
namespace QLSINHVIEN.GUI
{
    partial class frm_DoiMatKhau
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.New_MK = new System.Windows.Forms.TextBox();
            this.XacNhanMK = new System.Windows.Forms.TextBox();
            this.MatKhau = new System.Windows.Forms.TextBox();
            this.bt_Thoat = new System.Windows.Forms.Button();
            this.bt_DoiMK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(192, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "Đổi Mật Khẩu";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.New_MK);
            this.groupBox1.Controls.Add(this.XacNhanMK);
            this.groupBox1.Controls.Add(this.MatKhau);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(4, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 268);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(9, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Mật Khẩu Mới";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(9, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Xác Nhận lại Mật Khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(9, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mật Khẩu";
            // 
            // New_MK
            // 
            this.New_MK.Location = new System.Drawing.Point(270, 174);
            this.New_MK.Name = "New_MK";
            this.New_MK.Size = new System.Drawing.Size(256, 31);
            this.New_MK.TabIndex = 9;
            // 
            // XacNhanMK
            // 
            this.XacNhanMK.Location = new System.Drawing.Point(270, 116);
            this.XacNhanMK.Name = "XacNhanMK";
            this.XacNhanMK.PasswordChar = '*';
            this.XacNhanMK.Size = new System.Drawing.Size(256, 31);
            this.XacNhanMK.TabIndex = 8;
            // 
            // MatKhau
            // 
            this.MatKhau.Location = new System.Drawing.Point(270, 64);
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.PasswordChar = '*';
            this.MatKhau.Size = new System.Drawing.Size(256, 31);
            this.MatKhau.TabIndex = 7;
            // 
            // bt_Thoat
            // 
            this.bt_Thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Thoat.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_Thoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Thoat.Location = new System.Drawing.Point(373, 331);
            this.bt_Thoat.Name = "bt_Thoat";
            this.bt_Thoat.Size = new System.Drawing.Size(123, 45);
            this.bt_Thoat.TabIndex = 15;
            this.bt_Thoat.Text = "Thoát";
            this.bt_Thoat.UseVisualStyleBackColor = false;
            // 
            // bt_DoiMK
            // 
            this.bt_DoiMK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_DoiMK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_DoiMK.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_DoiMK.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_DoiMK.Location = new System.Drawing.Point(86, 331);
            this.bt_DoiMK.Name = "bt_DoiMK";
            this.bt_DoiMK.Size = new System.Drawing.Size(138, 45);
            this.bt_DoiMK.TabIndex = 14;
            this.bt_DoiMK.Text = "Đổi Mật Khẩu";
            this.bt_DoiMK.UseVisualStyleBackColor = false;
            this.bt_DoiMK.Click += new System.EventHandler(this.bt_DoiMK_Click);
            // 
            // frm_DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(623, 403);
            this.ControlBox = false;
            this.Controls.Add(this.bt_Thoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_DoiMK);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_DoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox New_MK;
        public System.Windows.Forms.TextBox XacNhanMK;
        public System.Windows.Forms.TextBox MatKhau;
        private System.Windows.Forms.Button bt_Thoat;
        private System.Windows.Forms.Button bt_DoiMK;
    }
}