
namespace QLSINHVIEN.GUI
{
    partial class frm_SinhVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_ChiTiet = new System.Windows.Forms.Button();
            this.bt_Hủy = new System.Windows.Forms.Button();
            this.bt_Reset = new System.Windows.Forms.Button();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.cb_Lop = new System.Windows.Forms.ComboBox();
            this.NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txt_TenSV = new System.Windows.Forms.TextBox();
            this.txt_MaSV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_Xoa = new System.Windows.Forms.Button();
            this.bt_Sua = new System.Windows.Forms.Button();
            this.bt_Luu = new System.Windows.Forms.Button();
            this.bt_Them = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.bt_Tim = new System.Windows.Forms.Button();
            this.bt_LoadLai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 45;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(99, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Azure;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1023, 518);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.bt_ChiTiet);
            this.panel1.Controls.Add(this.bt_Hủy);
            this.panel1.Controls.Add(this.bt_Reset);
            this.panel1.Controls.Add(this.txt_SDT);
            this.panel1.Controls.Add(this.cb_Lop);
            this.panel1.Controls.Add(this.NgaySinh);
            this.panel1.Controls.Add(this.txt_TenSV);
            this.panel1.Controls.Add(this.txt_MaSV);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1187, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 518);
            this.panel1.TabIndex = 1;
            // 
            // bt_ChiTiet
            // 
            this.bt_ChiTiet.BackColor = System.Drawing.Color.LightCoral;
            this.bt_ChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_ChiTiet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_ChiTiet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_ChiTiet.Location = new System.Drawing.Point(187, 457);
            this.bt_ChiTiet.Name = "bt_ChiTiet";
            this.bt_ChiTiet.Size = new System.Drawing.Size(115, 46);
            this.bt_ChiTiet.TabIndex = 13;
            this.bt_ChiTiet.Text = "Chi Tiết";
            this.bt_ChiTiet.UseVisualStyleBackColor = false;
            this.bt_ChiTiet.Click += new System.EventHandler(this.bt_ChiTiet_Click);
            // 
            // bt_Hủy
            // 
            this.bt_Hủy.BackColor = System.Drawing.Color.LightCoral;
            this.bt_Hủy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_Hủy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_Hủy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Hủy.Location = new System.Drawing.Point(187, 391);
            this.bt_Hủy.Name = "bt_Hủy";
            this.bt_Hủy.Size = new System.Drawing.Size(115, 46);
            this.bt_Hủy.TabIndex = 12;
            this.bt_Hủy.Text = "Hủy";
            this.bt_Hủy.UseVisualStyleBackColor = false;
            this.bt_Hủy.Visible = false;
            this.bt_Hủy.Click += new System.EventHandler(this.bt_Hủy_Click);
            // 
            // bt_Reset
            // 
            this.bt_Reset.BackColor = System.Drawing.Color.LightCoral;
            this.bt_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_Reset.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_Reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Reset.Location = new System.Drawing.Point(20, 391);
            this.bt_Reset.Name = "bt_Reset";
            this.bt_Reset.Size = new System.Drawing.Size(115, 46);
            this.bt_Reset.TabIndex = 11;
            this.bt_Reset.Text = "Reset";
            this.bt_Reset.UseVisualStyleBackColor = false;
            this.bt_Reset.Visible = false;
            this.bt_Reset.Click += new System.EventHandler(this.bt_Reset_Click);
            // 
            // txt_SDT
            // 
            this.txt_SDT.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_SDT.Enabled = false;
            this.txt_SDT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_SDT.Location = new System.Drawing.Point(20, 254);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(282, 34);
            this.txt_SDT.TabIndex = 10;
            // 
            // cb_Lop
            // 
            this.cb_Lop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cb_Lop.Enabled = false;
            this.cb_Lop.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_Lop.FormattingEnabled = true;
            this.cb_Lop.Location = new System.Drawing.Point(20, 330);
            this.cb_Lop.Name = "cb_Lop";
            this.cb_Lop.Size = new System.Drawing.Size(282, 34);
            this.cb_Lop.TabIndex = 9;
            this.cb_Lop.SelectedIndexChanged += new System.EventHandler(this.cb_Lop_SelectedIndexChanged);
            // 
            // NgaySinh
            // 
            this.NgaySinh.CalendarFont = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NgaySinh.CustomFormat = "MM/dd/yyyy";
            this.NgaySinh.Enabled = false;
            this.NgaySinh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NgaySinh.Location = new System.Drawing.Point(18, 188);
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Size = new System.Drawing.Size(284, 34);
            this.NgaySinh.TabIndex = 7;
            this.NgaySinh.Value = new System.DateTime(2022, 10, 11, 0, 0, 0, 0);
            // 
            // txt_TenSV
            // 
            this.txt_TenSV.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_TenSV.Enabled = false;
            this.txt_TenSV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_TenSV.Location = new System.Drawing.Point(20, 116);
            this.txt_TenSV.Name = "txt_TenSV";
            this.txt_TenSV.Size = new System.Drawing.Size(282, 34);
            this.txt_TenSV.TabIndex = 6;
            // 
            // txt_MaSV
            // 
            this.txt_MaSV.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_MaSV.Enabled = false;
            this.txt_MaSV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_MaSV.Location = new System.Drawing.Point(18, 38);
            this.txt_MaSV.Name = "txt_MaSV";
            this.txt_MaSV.Size = new System.Drawing.Size(284, 34);
            this.txt_MaSV.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(20, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lớp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(18, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số Điện Thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(18, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Sinh Viên";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label.Location = new System.Drawing.Point(18, 166);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(91, 22);
            this.label.TabIndex = 1;
            this.label.Text = "Ngày Sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sinh Viên";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Controls.Add(this.bt_Xoa);
            this.panel2.Controls.Add(this.bt_Sua);
            this.panel2.Controls.Add(this.bt_Luu);
            this.panel2.Controls.Add(this.bt_Them);
            this.panel2.Location = new System.Drawing.Point(99, 650);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1434, 106);
            this.panel2.TabIndex = 2;
            // 
            // bt_Xoa
            // 
            this.bt_Xoa.BackColor = System.Drawing.Color.SkyBlue;
            this.bt_Xoa.Dock = System.Windows.Forms.DockStyle.Right;
            this.bt_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Xoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_Xoa.Image = global::QLSINHVIEN.Properties.Resources.icons8_delete_100;
            this.bt_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Xoa.Location = new System.Drawing.Point(1054, 0);
            this.bt_Xoa.Name = "bt_Xoa";
            this.bt_Xoa.Size = new System.Drawing.Size(380, 106);
            this.bt_Xoa.TabIndex = 3;
            this.bt_Xoa.Text = "Xóa";
            this.bt_Xoa.UseVisualStyleBackColor = false;
            this.bt_Xoa.Click += new System.EventHandler(this.bt_Xoa_Click);
            // 
            // bt_Sua
            // 
            this.bt_Sua.BackColor = System.Drawing.Color.SkyBlue;
            this.bt_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Sua.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_Sua.Image = global::QLSINHVIEN.Properties.Resources.icons8_pencil_drawing_96;
            this.bt_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Sua.Location = new System.Drawing.Point(768, 0);
            this.bt_Sua.Name = "bt_Sua";
            this.bt_Sua.Size = new System.Drawing.Size(390, 106);
            this.bt_Sua.TabIndex = 2;
            this.bt_Sua.Text = "Sửa";
            this.bt_Sua.UseVisualStyleBackColor = false;
            this.bt_Sua.Click += new System.EventHandler(this.bt_Sua_Click);
            // 
            // bt_Luu
            // 
            this.bt_Luu.BackColor = System.Drawing.Color.SkyBlue;
            this.bt_Luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Luu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_Luu.Image = global::QLSINHVIEN.Properties.Resources.icons8_save_96;
            this.bt_Luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Luu.Location = new System.Drawing.Point(389, 0);
            this.bt_Luu.Name = "bt_Luu";
            this.bt_Luu.Size = new System.Drawing.Size(380, 106);
            this.bt_Luu.TabIndex = 1;
            this.bt_Luu.Text = "Lưu";
            this.bt_Luu.UseVisualStyleBackColor = false;
            this.bt_Luu.Click += new System.EventHandler(this.bt_Luu_Click);
            // 
            // bt_Them
            // 
            this.bt_Them.BackColor = System.Drawing.Color.SkyBlue;
            this.bt_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Them.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_Them.Image = global::QLSINHVIEN.Properties.Resources.icons8_add_80;
            this.bt_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Them.Location = new System.Drawing.Point(0, 0);
            this.bt_Them.Name = "bt_Them";
            this.bt_Them.Size = new System.Drawing.Size(390, 106);
            this.bt_Them.TabIndex = 0;
            this.bt_Them.Text = "Thêm";
            this.bt_Them.UseVisualStyleBackColor = false;
            this.bt_Them.Click += new System.EventHandler(this.bt_Them_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.pictureBox1.Image = global::QLSINHVIEN.Properties.Resources.icons8_search_96;
            this.pictureBox1.Location = new System.Drawing.Point(99, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.BackColor = System.Drawing.Color.SkyBlue;
            this.txt_TimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TimKiem.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_TimKiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_TimKiem.Location = new System.Drawing.Point(157, 56);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(251, 39);
            this.txt_TimKiem.TabIndex = 4;
            this.txt_TimKiem.Tag = "";
            this.txt_TimKiem.WordWrap = false;
            this.txt_TimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tim_KD);
            // 
            // bt_Tim
            // 
            this.bt_Tim.BackColor = System.Drawing.Color.LightCoral;
            this.bt_Tim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_Tim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_Tim.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Tim.Location = new System.Drawing.Point(414, 56);
            this.bt_Tim.Name = "bt_Tim";
            this.bt_Tim.Size = new System.Drawing.Size(115, 39);
            this.bt_Tim.TabIndex = 13;
            this.bt_Tim.Text = "Tìm";
            this.bt_Tim.UseVisualStyleBackColor = false;
            this.bt_Tim.Click += new System.EventHandler(this.bt_Tim_Click);
            // 
            // bt_LoadLai
            // 
            this.bt_LoadLai.BackColor = System.Drawing.Color.LightCoral;
            this.bt_LoadLai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_LoadLai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_LoadLai.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_LoadLai.Location = new System.Drawing.Point(986, 55);
            this.bt_LoadLai.Name = "bt_LoadLai";
            this.bt_LoadLai.Size = new System.Drawing.Size(136, 39);
            this.bt_LoadLai.TabIndex = 14;
            this.bt_LoadLai.Text = "Load Lại";
            this.bt_LoadLai.UseVisualStyleBackColor = false;
            this.bt_LoadLai.Click += new System.EventHandler(this.bt_LoadLai_Click);
            // 
            // frm_SinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1571, 782);
            this.Controls.Add(this.bt_LoadLai);
            this.Controls.Add(this.bt_Tim);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frm_SinhVien";
            this.Text = "frm_SinhVien";
            this.Load += new System.EventHandler(this.frm_SinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ComboBox cb_Lop;
        public System.Windows.Forms.DateTimePicker NgaySinh;
        public System.Windows.Forms.TextBox txt_TenSV;
        public System.Windows.Forms.TextBox txt_MaSV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_Them;
        private System.Windows.Forms.Button bt_Luu;
        private System.Windows.Forms.Button bt_Sua;
        private System.Windows.Forms.Button bt_Xoa;
        private System.Windows.Forms.Button bt_Hủy;
        private System.Windows.Forms.Button bt_Reset;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Button bt_Tim;
        private System.Windows.Forms.Button bt_LoadLai;
        private System.Windows.Forms.Button bt_ChiTiet;
    }
}