namespace Quanlykhachsan
{
    partial class thaydoimk
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
            this.txtnhaplai = new System.Windows.Forms.TextBox();
            this.txtmatkhaumoi = new System.Windows.Forms.TextBox();
            this.txtmatkhaucu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btthaydoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mật khẩu cũ";
            // 
            // txtnhaplai
            // 
            this.txtnhaplai.Location = new System.Drawing.Point(153, 119);
            this.txtnhaplai.Name = "txtnhaplai";
            this.txtnhaplai.PasswordChar = '*';
            this.txtnhaplai.Size = new System.Drawing.Size(157, 20);
            this.txtnhaplai.TabIndex = 8;
            this.txtnhaplai.Tag = "3";
            // 
            // txtmatkhaumoi
            // 
            this.txtmatkhaumoi.Location = new System.Drawing.Point(153, 90);
            this.txtmatkhaumoi.Name = "txtmatkhaumoi";
            this.txtmatkhaumoi.PasswordChar = '*';
            this.txtmatkhaumoi.Size = new System.Drawing.Size(157, 20);
            this.txtmatkhaumoi.TabIndex = 7;
            this.txtmatkhaumoi.Tag = "2";
            // 
            // txtmatkhaucu
            // 
            this.txtmatkhaucu.Location = new System.Drawing.Point(153, 56);
            this.txtmatkhaucu.Name = "txtmatkhaucu";
            this.txtmatkhaucu.PasswordChar = '*';
            this.txtmatkhaucu.Size = new System.Drawing.Size(157, 20);
            this.txtmatkhaucu.TabIndex = 3;
            this.txtmatkhaucu.Tag = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhập lại mật khẩu mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật khẩu mới";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.ForeColor = System.Drawing.Color.Cyan;
            this.button1.Location = new System.Drawing.Point(225, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Tag = "5";
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btthaydoi
            // 
            this.btthaydoi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btthaydoi.ForeColor = System.Drawing.Color.Cyan;
            this.btthaydoi.Location = new System.Drawing.Point(89, 182);
            this.btthaydoi.Name = "btthaydoi";
            this.btthaydoi.Size = new System.Drawing.Size(75, 23);
            this.btthaydoi.TabIndex = 9;
            this.btthaydoi.Tag = "4";
            this.btthaydoi.Text = "Thực hiện";
            this.btthaydoi.UseVisualStyleBackColor = false;
            this.btthaydoi.Click += new System.EventHandler(this.btthaydoi_Click);
            // 
            // thaydoimk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(402, 237);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btthaydoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnhaplai);
            this.Controls.Add(this.txtmatkhaumoi);
            this.Controls.Add(this.txtmatkhaucu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "thaydoimk";
            this.Text = "Thay đổi mật khẩu";
            this.Load += new System.EventHandler(this.thaydoimk_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnhaplai;
        private System.Windows.Forms.TextBox txtmatkhaumoi;
        private System.Windows.Forms.TextBox txtmatkhaucu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btthaydoi;
    }
}