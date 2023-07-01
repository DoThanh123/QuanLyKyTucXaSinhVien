namespace QLKTXSV
{
    partial class Form2
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
            this.label6 = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.TextBox();
            this.cbb_RoomID2 = new System.Windows.Forms.ComboBox();
            this.dgv_room = new System.Windows.Forms.DataGridView();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.cbb_seat = new System.Windows.Forms.ComboBox();
            this.cbb_RoomID1 = new System.Windows.Forms.ComboBox();
            this.txt_RoomName = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_room)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(771, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // phòngToolStripMenuItem
            // 
            this.phòngToolStripMenuItem.Name = "phòngToolStripMenuItem";
            this.phòngToolStripMenuItem.Size = new System.Drawing.Size(128, 25);
            this.phòngToolStripMenuItem.Text = "Quản Lý Phòng";
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
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số Chỗ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Thiết Bị";
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(126, 225);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(140, 20);
            this.txt.TabIndex = 11;
            // 
            // cbb_RoomID2
            // 
            this.cbb_RoomID2.FormattingEnabled = true;
            this.cbb_RoomID2.Location = new System.Drawing.Point(126, 119);
            this.cbb_RoomID2.Name = "cbb_RoomID2";
            this.cbb_RoomID2.Size = new System.Drawing.Size(139, 21);
            this.cbb_RoomID2.TabIndex = 12;
            // 
            // dgv_room
            // 
            this.dgv_room.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_room.Location = new System.Drawing.Point(305, 32);
            this.dgv_room.Name = "dgv_room";
            this.dgv_room.Size = new System.Drawing.Size(454, 321);
            this.dgv_room.TabIndex = 13;
            this.dgv_room.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_room_CellContentClick);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(201, 78);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(64, 28);
            this.btn_search.TabIndex = 14;
            this.btn_search.Text = "Tìm Kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(49, 325);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(64, 28);
            this.btn_load.TabIndex = 15;
            this.btn_load.Text = "Hiển Thị";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(165, 325);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(64, 28);
            this.btn_update.TabIndex = 16;
            this.btn_update.Text = "Cập Nhật";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // cbb_seat
            // 
            this.cbb_seat.FormattingEnabled = true;
            this.cbb_seat.Items.AddRange(new object[] {
            "0/4",
            "1/4",
            "2/4",
            "3/4",
            "4/4"});
            this.cbb_seat.Location = new System.Drawing.Point(126, 190);
            this.cbb_seat.Name = "cbb_seat";
            this.cbb_seat.Size = new System.Drawing.Size(139, 21);
            this.cbb_seat.TabIndex = 18;
            // 
            // cbb_RoomID1
            // 
            this.cbb_RoomID1.FormattingEnabled = true;
            this.cbb_RoomID1.Location = new System.Drawing.Point(126, 43);
            this.cbb_RoomID1.Name = "cbb_RoomID1";
            this.cbb_RoomID1.Size = new System.Drawing.Size(139, 21);
            this.cbb_RoomID1.TabIndex = 19;
            // 
            // txt_RoomName
            // 
            this.txt_RoomName.Location = new System.Drawing.Point(125, 152);
            this.txt_RoomName.Name = "txt_RoomName";
            this.txt_RoomName.Size = new System.Drawing.Size(140, 20);
            this.txt_RoomName.TabIndex = 20;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 365);
            this.Controls.Add(this.txt_RoomName);
            this.Controls.Add(this.cbb_RoomID1);
            this.Controls.Add(this.cbb_seat);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.dgv_room);
            this.Controls.Add(this.cbb_RoomID2);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "QUẢN LÝ PHÒNG";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_room)).EndInit();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.ComboBox cbb_RoomID2;
        private System.Windows.Forms.DataGridView dgv_room;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.ComboBox cbb_seat;
        private System.Windows.Forms.ComboBox cbb_RoomID1;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_RoomName;
    }
}