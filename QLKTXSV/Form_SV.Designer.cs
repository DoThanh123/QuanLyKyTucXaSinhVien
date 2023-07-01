namespace QLKTXSV
{
    partial class Form_SV
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.phòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thuêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.điệnNướcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.txt7 = new System.Windows.Forms.TextBox();
            this.txt8 = new System.Windows.Forms.TextBox();
            this.cbb = new System.Windows.Forms.ComboBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.dgv_SV = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtP = new System.Windows.Forms.DateTimePicker();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.btn_show = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SV)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phòngToolStripMenuItem,
            this.sinhViênToolStripMenuItem,
            this.thuêToolStripMenuItem,
            this.điệnNướcToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(908, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // phòngToolStripMenuItem
            // 
            this.phòngToolStripMenuItem.Name = "phòngToolStripMenuItem";
            this.phòngToolStripMenuItem.Size = new System.Drawing.Size(128, 25);
            this.phòngToolStripMenuItem.Text = "Quản Lý Phòng";
            this.phòngToolStripMenuItem.Click += new System.EventHandler(this.phòngToolStripMenuItem_Click);
            // 
            // sinhViênToolStripMenuItem
            // 
            this.sinhViênToolStripMenuItem.Name = "sinhViênToolStripMenuItem";
            this.sinhViênToolStripMenuItem.Size = new System.Drawing.Size(149, 25);
            this.sinhViênToolStripMenuItem.Text = "Quản Lý Sinh Viên";
            // 
            // thuêToolStripMenuItem
            // 
            this.thuêToolStripMenuItem.Name = "thuêToolStripMenuItem";
            this.thuêToolStripMenuItem.Size = new System.Drawing.Size(128, 25);
            this.thuêToolStripMenuItem.Text = "Đăng Ký Phòng";
            this.thuêToolStripMenuItem.Click += new System.EventHandler(this.thuêToolStripMenuItem_Click);
            // 
            // điệnNướcToolStripMenuItem
            // 
            this.điệnNướcToolStripMenuItem.Name = "điệnNướcToolStripMenuItem";
            this.điệnNướcToolStripMenuItem.Size = new System.Drawing.Size(179, 25);
            this.điệnNướcToolStripMenuItem.Text = "Thanh Toán Điện Nước";
            this.điệnNướcToolStripMenuItem.Click += new System.EventHandler(this.điệnNướcToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(61, 25);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Sinh Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã Sinh Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên Sinh Viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã Phòng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Lớp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Khoa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Địa Chỉ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 369);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Số Điện Thoại";
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(135, 98);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(157, 20);
            this.txt2.TabIndex = 12;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(136, 128);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(157, 20);
            this.txt3.TabIndex = 13;
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(134, 243);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(157, 20);
            this.txt4.TabIndex = 14;
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(134, 275);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(157, 20);
            this.txt5.TabIndex = 15;
            // 
            // txt6
            // 
            this.txt6.Location = new System.Drawing.Point(134, 308);
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(157, 20);
            this.txt6.TabIndex = 16;
            // 
            // txt7
            // 
            this.txt7.Location = new System.Drawing.Point(135, 339);
            this.txt7.Name = "txt7";
            this.txt7.Size = new System.Drawing.Size(157, 20);
            this.txt7.TabIndex = 17;
            // 
            // txt8
            // 
            this.txt8.Location = new System.Drawing.Point(134, 369);
            this.txt8.Name = "txt8";
            this.txt8.Size = new System.Drawing.Size(157, 20);
            this.txt8.TabIndex = 18;
            // 
            // cbb
            // 
            this.cbb.FormattingEnabled = true;
            this.cbb.Location = new System.Drawing.Point(136, 159);
            this.cbb.Name = "cbb";
            this.cbb.Size = new System.Drawing.Size(157, 21);
            this.cbb.TabIndex = 19;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(227, 60);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(66, 23);
            this.btn_search.TabIndex = 20;
            this.btn_search.Text = "Tìm Kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(12, 413);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(66, 23);
            this.btn_add.TabIndex = 21;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(122, 413);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(66, 23);
            this.btn_update.TabIndex = 22;
            this.btn_update.Text = "Cập Nhật";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(226, 413);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(66, 23);
            this.btn_del.TabIndex = 23;
            this.btn_del.Text = "Xóa";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // dgv_SV
            // 
            this.dgv_SV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SV.Location = new System.Drawing.Point(316, 32);
            this.dgv_SV.Name = "dgv_SV";
            this.dgv_SV.Size = new System.Drawing.Size(580, 404);
            this.dgv_SV.TabIndex = 24;
            this.dgv_SV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SV_CellContentClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Giới Tính";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(136, 214);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 17);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "Nam";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(254, 214);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(38, 17);
            this.checkBox2.TabIndex = 27;
            this.checkBox2.Text = "nữ";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 186);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 20);
            this.label11.TabIndex = 30;
            this.label11.Text = "Ngày sinh";
            // 
            // dtP
            // 
            this.dtP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtP.Location = new System.Drawing.Point(136, 186);
            this.dtP.Name = "dtP";
            this.dtP.Size = new System.Drawing.Size(156, 20);
            this.dtP.TabIndex = 31;
            this.dtP.Value = new System.DateTime(2023, 6, 22, 0, 0, 0, 0);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(136, 34);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(157, 20);
            this.txt1.TabIndex = 11;
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(18, 60);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(66, 23);
            this.btn_show.TabIndex = 32;
            this.btn_show.Text = "Hiển Thị";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // Form_SV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 447);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.dtP);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgv_SV);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.cbb);
            this.Controls.Add(this.txt8);
            this.Controls.Add(this.txt7);
            this.Controls.Add(this.txt6);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form_SV";
            this.Text = "QUẢN LÝ SINH VIÊN";
            this.Load += new System.EventHandler(this.Form_SV_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem phòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thuêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem điệnNướcToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.TextBox txt6;
        private System.Windows.Forms.TextBox txt7;
        private System.Windows.Forms.TextBox txt8;
        private System.Windows.Forms.ComboBox cbb;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.DataGridView dgv_SV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtP;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button btn_show;
    }
}