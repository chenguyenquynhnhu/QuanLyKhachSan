namespace Quanlykhachsan
{
    partial class Phanquyen
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("NHANVIEN", 2);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("QUANLY", 2);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("ADMIN", 2);
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.txttendangnhap = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtmanhanvien = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.ItemHeight = 20;
            this.treeView1.Location = new System.Drawing.Point(-2, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(166, 414);
            this.treeView1.TabIndex = 5;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(-100, -40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 30);
            this.button1.TabIndex = 9;
            this.button1.Text = "Phân quyền";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.listView1.GridLines = true;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            listViewItem3.StateImageIndex = 0;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.listView1.Location = new System.Drawing.Point(264, 279);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(155, 94);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Quyền hạn";
            this.columnHeader1.Width = 146;
            // 
            // txttendangnhap
            // 
            this.txttendangnhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttendangnhap.Location = new System.Drawing.Point(264, 170);
            this.txttendangnhap.Name = "txttendangnhap";
            this.txttendangnhap.Size = new System.Drawing.Size(155, 20);
            this.txttendangnhap.TabIndex = 15;
            // 
            // txthoten
            // 
            this.txthoten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txthoten.Location = new System.Drawing.Point(264, 119);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(155, 20);
            this.txthoten.TabIndex = 14;
            // 
            // txtmanhanvien
            // 
            this.txtmanhanvien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmanhanvien.Location = new System.Drawing.Point(264, 70);
            this.txtmanhanvien.Name = "txtmanhanvien";
            this.txtmanhanvien.Size = new System.Drawing.Size(83, 20);
            this.txtmanhanvien.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Silver;
            this.button3.Location = new System.Drawing.Point(327, 396);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 30);
            this.button3.TabIndex = 18;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Silver;
            this.button4.Location = new System.Drawing.Point(204, 396);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(79, 30);
            this.button4.TabIndex = 17;
            this.button4.Text = "Cập Nhật";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Quyền hạn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tên đăng nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Mã nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Họ tên";
            // 
            // txtdiachi
            // 
            this.txtdiachi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdiachi.Location = new System.Drawing.Point(264, 218);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(155, 20);
            this.txtdiachi.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Địa chỉ:";
            // 
            // Phanquyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(488, 438);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txttendangnhap);
            this.Controls.Add(this.txthoten);
            this.Controls.Add(this.txtmanhanvien);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Name = "Phanquyen";
            this.Text = "Phanquyen";
            this.Load += new System.EventHandler(this.Phanquyen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TextBox txttendangnhap;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtmanhanvien;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label label5;
    }
}