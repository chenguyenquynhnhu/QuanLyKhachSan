namespace Quanlykhachsan
{
    partial class Form1
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mndangnhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnthaydoitt = new System.Windows.Forms.ToolStripMenuItem();
            this.dangxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnquanlykhachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.checkInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiémToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xoáKháchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkOutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnquanlydichvu = new System.Windows.Forms.ToolStripMenuItem();
            this.dịchVụĂnUốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dịchVụGiặtLàToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dịchVụGiảiTríToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnquanlynhanvien = new System.Windows.Forms.ToolStripMenuItem();
            this.capnhat = new System.Windows.Forms.ToolStripMenuItem();
            this.timkiem = new System.Windows.Forms.ToolStripMenuItem();
            this.themmoi = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.thốngKêToolStripMenuItem,
            this.aboutUsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(596, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mndangnhap,
            this.mnthaydoitt,
            this.dangxuat,
            this.thoátToolStripMenuItem});
            this.fileToolStripMenuItem.Image = global::Quanlykhachsan.Properties.Resources.untitled;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mndangnhap
            // 
            this.mndangnhap.Image = global::Quanlykhachsan.Properties.Resources.Options;
            this.mndangnhap.Name = "mndangnhap";
            this.mndangnhap.Size = new System.Drawing.Size(213, 22);
            this.mndangnhap.Text = "Đăng Nhập";
            this.mndangnhap.Click += new System.EventHandler(this.đăngNhậpToolStripMenuItem_Click);
            // 
            // mnthaydoitt
            // 
            this.mnthaydoitt.Enabled = false;
            this.mnthaydoitt.Image = global::Quanlykhachsan.Properties.Resources.Options;
            this.mnthaydoitt.Name = "mnthaydoitt";
            this.mnthaydoitt.Size = new System.Drawing.Size(213, 22);
            this.mnthaydoitt.Text = "Thay đổi thông tin cá nhân";
            this.mnthaydoitt.Click += new System.EventHandler(this.mnkhachhang_Click);
            // 
            // dangxuat
            // 
            this.dangxuat.Enabled = false;
            this.dangxuat.Image = global::Quanlykhachsan.Properties.Resources.Options;
            this.dangxuat.Name = "dangxuat";
            this.dangxuat.Size = new System.Drawing.Size(213, 22);
            this.dangxuat.Text = "Đăng Xuất";
            this.dangxuat.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Image = global::Quanlykhachsan.Properties.Resources.Options;
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnquanlykhachhang,
            this.mnquanlydichvu,
            this.mnquanlynhanvien});
            this.thốngKêToolStripMenuItem.Image = global::Quanlykhachsan.Properties.Resources.folder_yellow_2;
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.thốngKêToolStripMenuItem.Text = "Quản Lý";
            // 
            // mnquanlykhachhang
            // 
            this.mnquanlykhachhang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkInToolStripMenuItem,
            this.checkOutToolStripMenuItem,
            this.tìmKiémToolStripMenuItem,
            this.cậpNhậtToolStripMenuItem1,
            this.xoáKháchToolStripMenuItem,
            this.checkOutToolStripMenuItem1});
            this.mnquanlykhachhang.Enabled = false;
            this.mnquanlykhachhang.Image = global::Quanlykhachsan.Properties.Resources.Options;
            this.mnquanlykhachhang.Name = "mnquanlykhachhang";
            this.mnquanlykhachhang.Size = new System.Drawing.Size(184, 22);
            this.mnquanlykhachhang.Text = "Quản Lý Khách hàng";
            this.mnquanlykhachhang.Click += new System.EventHandler(this.mnquanlykhachhang_Click);
            // 
            // checkInToolStripMenuItem
            // 
            this.checkInToolStripMenuItem.Name = "checkInToolStripMenuItem";
            this.checkInToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.checkInToolStripMenuItem.Text = "Check in";
            this.checkInToolStripMenuItem.Click += new System.EventHandler(this.checkInToolStripMenuItem_Click);
            // 
            // checkOutToolStripMenuItem
            // 
            this.checkOutToolStripMenuItem.Name = "checkOutToolStripMenuItem";
            this.checkOutToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.checkOutToolStripMenuItem.Text = "Lưu trữ";
            this.checkOutToolStripMenuItem.Click += new System.EventHandler(this.checkOutToolStripMenuItem_Click);
            // 
            // tìmKiémToolStripMenuItem
            // 
            this.tìmKiémToolStripMenuItem.Name = "tìmKiémToolStripMenuItem";
            this.tìmKiémToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.tìmKiémToolStripMenuItem.Text = "Tìm Kiếm";
            this.tìmKiémToolStripMenuItem.Click += new System.EventHandler(this.tìmKiémToolStripMenuItem_Click);
            // 
            // cậpNhậtToolStripMenuItem1
            // 
            this.cậpNhậtToolStripMenuItem1.Name = "cậpNhậtToolStripMenuItem1";
            this.cậpNhậtToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.cậpNhậtToolStripMenuItem1.Text = "Cập Nhật";
            this.cậpNhậtToolStripMenuItem1.Click += new System.EventHandler(this.cậpNhậtToolStripMenuItem1_Click);
            // 
            // xoáKháchToolStripMenuItem
            // 
            this.xoáKháchToolStripMenuItem.Name = "xoáKháchToolStripMenuItem";
            this.xoáKháchToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.xoáKháchToolStripMenuItem.Text = "Xoá khách";
            this.xoáKháchToolStripMenuItem.Click += new System.EventHandler(this.xoáKháchToolStripMenuItem_Click);
            // 
            // checkOutToolStripMenuItem1
            // 
            this.checkOutToolStripMenuItem1.Name = "checkOutToolStripMenuItem1";
            this.checkOutToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.checkOutToolStripMenuItem1.Text = "Check out";
            this.checkOutToolStripMenuItem1.Click += new System.EventHandler(this.checkOutToolStripMenuItem1_Click);
            // 
            // mnquanlydichvu
            // 
            this.mnquanlydichvu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dịchVụĂnUốngToolStripMenuItem,
            this.dịchVụGiặtLàToolStripMenuItem,
            this.dịchVụGiảiTríToolStripMenuItem});
            this.mnquanlydichvu.Enabled = false;
            this.mnquanlydichvu.Image = global::Quanlykhachsan.Properties.Resources.Options;
            this.mnquanlydichvu.Name = "mnquanlydichvu";
            this.mnquanlydichvu.Size = new System.Drawing.Size(184, 22);
            this.mnquanlydichvu.Text = "Quản Lý Dịch Vụ";
            // 
            // dịchVụĂnUốngToolStripMenuItem
            // 
            this.dịchVụĂnUốngToolStripMenuItem.Name = "dịchVụĂnUốngToolStripMenuItem";
            this.dịchVụĂnUốngToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.dịchVụĂnUốngToolStripMenuItem.Text = "Dịch vụ ăn uống";
            this.dịchVụĂnUốngToolStripMenuItem.Click += new System.EventHandler(this.dịchVụĂnUốngToolStripMenuItem_Click);
            // 
            // dịchVụGiặtLàToolStripMenuItem
            // 
            this.dịchVụGiặtLàToolStripMenuItem.Name = "dịchVụGiặtLàToolStripMenuItem";
            this.dịchVụGiặtLàToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.dịchVụGiặtLàToolStripMenuItem.Text = "Dịch vụ giặt là";
            this.dịchVụGiặtLàToolStripMenuItem.Click += new System.EventHandler(this.dịchVụGiặtLàToolStripMenuItem_Click);
            // 
            // dịchVụGiảiTríToolStripMenuItem
            // 
            this.dịchVụGiảiTríToolStripMenuItem.Name = "dịchVụGiảiTríToolStripMenuItem";
            this.dịchVụGiảiTríToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.dịchVụGiảiTríToolStripMenuItem.Text = "Dịch vụ giải trí";
            this.dịchVụGiảiTríToolStripMenuItem.Click += new System.EventHandler(this.dịchVụGiảiTríToolStripMenuItem_Click);
            // 
            // mnquanlynhanvien
            // 
            this.mnquanlynhanvien.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.capnhat,
            this.timkiem,
            this.themmoi});
            this.mnquanlynhanvien.Enabled = false;
            this.mnquanlynhanvien.Image = global::Quanlykhachsan.Properties.Resources.Options;
            this.mnquanlynhanvien.Name = "mnquanlynhanvien";
            this.mnquanlynhanvien.Size = new System.Drawing.Size(184, 22);
            this.mnquanlynhanvien.Text = "Quản Lý Nhân Viên";
            // 
            // capnhat
            // 
            this.capnhat.Name = "capnhat";
            this.capnhat.Size = new System.Drawing.Size(170, 22);
            this.capnhat.Text = "Cập Nhật";
            this.capnhat.Click += new System.EventHandler(this.nângQuyềnToolStripMenuItem_Click);
            // 
            // timkiem
            // 
            this.timkiem.Name = "timkiem";
            this.timkiem.Size = new System.Drawing.Size(170, 22);
            this.timkiem.Text = "Tìm Kiếm";
            // 
            // themmoi
            // 
            this.themmoi.Enabled = false;
            this.themmoi.Name = "themmoi";
            this.themmoi.Size = new System.Drawing.Size(170, 22);
            this.themmoi.Text = "Thêm mới&&Xoá Bỏ";
            this.themmoi.Click += new System.EventHandler(this.thêmMớiToolStripMenuItem_Click);
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Image = global::Quanlykhachsan.Properties.Resources.folder_video_2;
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = global::Quanlykhachsan.Properties.Resources.hotel_view;
            this.ClientSize = new System.Drawing.Size(596, 448);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Quan Ly Khach San";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mndangnhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem mnthaydoitt;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnquanlykhachhang;
        private System.Windows.Forms.ToolStripMenuItem checkInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiémToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem xoáKháchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnquanlydichvu;
        private System.Windows.Forms.ToolStripMenuItem dịchVụĂnUốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dịchVụGiặtLàToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dịchVụGiảiTríToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnquanlynhanvien;
        private System.Windows.Forms.ToolStripMenuItem capnhat;
        private System.Windows.Forms.ToolStripMenuItem timkiem;
        private System.Windows.Forms.ToolStripMenuItem themmoi;
        private System.Windows.Forms.ToolStripMenuItem dangxuat;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkOutToolStripMenuItem1;
    }
}

