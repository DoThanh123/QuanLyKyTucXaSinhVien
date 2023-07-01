namespace QLKTXSV
{
    partial class Form_Hop_dong
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
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.cbb1 = new System.Windows.Forms.ComboBox();
            this.cbb2 = new System.Windows.Forms.ComboBox();
            this.dtP1 = new System.Windows.Forms.DateTimePicker();
            this.dtP2 = new System.Windows.Forms.DateTimePicker();
            this.dgv_DKP = new System.Windows.Forms.DataGridView();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DKP)).BeginInit();
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
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(819, 29);
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
            this.sinhViênToolStripMenuItem.Click += new System.EventHandler(this.sinhViênToolStripMenuItem_Click);
            // 
            // thuêToolStripMenuItem
            // 
            this.thuêToolStripMenuItem.Name = "thuêToolStripMenuItem";
            this.thuêToolStripMenuItem.Size = new System.Drawing.Size(128, 25);
            this.thuêToolStripMenuItem.Text = "Đăng Ký Phòng";
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
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Đăng Ký";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã Đăng Ký";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã Phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã Sinh Viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ngày Đăng Ký";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ngày Hết Hạn";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(128, 44);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(144, 20);
            this.txt1.TabIndex = 9;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(127, 103);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(142, 20);
            this.txt2.TabIndex = 10;
            // 
            // cbb1
            // 
            this.cbb1.FormattingEnabled = true;
            this.cbb1.Location = new System.Drawing.Point(127, 129);
            this.cbb1.Name = "cbb1";
            this.cbb1.Size = new System.Drawing.Size(141, 21);
            this.cbb1.TabIndex = 19;
            this.cbb1.SelectedIndexChanged += new System.EventHandler(this.cbb1_SelectedIndexChanged);
            this.cbb1.SelectedValueChanged += new System.EventHandler(this.cbb1_SelectedValueChanged);
            // 
            // cbb2
            // 
            this.cbb2.FormattingEnabled = true;
            this.cbb2.Location = new System.Drawing.Point(127, 159);
            this.cbb2.Name = "cbb2";
            this.cbb2.Size = new System.Drawing.Size(141, 21);
            this.cbb2.TabIndex = 20;
            this.cbb2.SelectedValueChanged += new System.EventHandler(this.cbb2_SelectedValueChanged);
            // 
            // dtP1
            // 
            this.dtP1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtP1.Location = new System.Drawing.Point(127, 189);
            this.dtP1.Name = "dtP1";
            this.dtP1.Size = new System.Drawing.Size(142, 20);
            this.dtP1.TabIndex = 21;
            this.dtP1.Value = new System.DateTime(2023, 6, 22, 0, 0, 0, 0);
            // 
            // dtP2
            // 
            this.dtP2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtP2.Location = new System.Drawing.Point(128, 215);
            this.dtP2.Name = "dtP2";
            this.dtP2.Size = new System.Drawing.Size(140, 20);
            this.dtP2.TabIndex = 22;
            this.dtP2.Value = new System.DateTime(2023, 6, 22, 0, 0, 0, 0);
            this.dtP2.ValueChanged += new System.EventHandler(this.dtP2_ValueChanged);
            // 
            // dgv_DKP
            // 
            this.dgv_DKP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DKP.Location = new System.Drawing.Point(296, 32);
            this.dgv_DKP.Name = "dgv_DKP";
            this.dgv_DKP.Size = new System.Drawing.Size(512, 314);
            this.dgv_DKP.TabIndex = 23;
            this.dgv_DKP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DKP_CellContentClick);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(199, 70);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(70, 27);
            this.btn_search.TabIndex = 24;
            this.btn_search.Text = "TÌm Kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(16, 312);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(70, 27);
            this.btn_add.TabIndex = 25;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(106, 312);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(70, 27);
            this.btn_update.TabIndex = 26;
            this.btn_update.Text = "Cập Nhật";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(198, 312);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(70, 27);
            this.btn_del.TabIndex = 27;
            this.btn_del.Text = "Xóa";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(16, 70);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(70, 27);
            this.btn_show.TabIndex = 28;
            this.btn_show.Text = "Hiển Thị";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // Form_Hop_dong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 351);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.dgv_DKP);
            this.Controls.Add(this.dtP2);
            this.Controls.Add(this.dtP1);
            this.Controls.Add(this.cbb2);
            this.Controls.Add(this.cbb1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form_Hop_dong";
            this.Text = "ĐĂNG KÝ PHÒNG";
            this.Load += new System.EventHandler(this.Form_Hop_dong_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DKP)).EndInit();
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
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.ComboBox cbb1;
        private System.Windows.Forms.ComboBox cbb2;
        private System.Windows.Forms.DateTimePicker dtP1;
        private System.Windows.Forms.DateTimePicker dtP2;
        private System.Windows.Forms.DataGridView dgv_DKP;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Button btn_show;
    }
}