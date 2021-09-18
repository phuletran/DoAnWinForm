namespace DemoQLKS
{
    partial class fGiaodienChinh
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
            this.lbID = new System.Windows.Forms.Label();
            this.btn_dong = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýThuêPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phòngĐangThuêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tấtCảCácPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lịchSửĐăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1122, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Xin chào nhân viên có ID là";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(1267, 5);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(0, 13);
            this.lbID.TabIndex = 2;
            // 
            // btn_dong
            // 
            this.btn_dong.Location = new System.Drawing.Point(1289, 1);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(75, 23);
            this.btn_dong.TabIndex = 4;
            this.btn_dong.Text = "Đăng xuất";
            this.btn_dong.UseVisualStyleBackColor = true;
            this.btn_dong.Click += new System.EventHandler(this.button3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýNhânViênToolStripMenuItem,
            this.quảnLýThuêPhòngToolStripMenuItem,
            this.lịchSửĐăngNhậpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.quảnLýNhânViênToolStripMenuItem.Text = "Quản lý nhân viên";
            this.quảnLýNhânViênToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNhânViênToolStripMenuItem_Click);
            // 
            // quảnLýThuêPhòngToolStripMenuItem
            // 
            this.quảnLýThuêPhòngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phòngToolStripMenuItem,
            this.hóaĐơnToolStripMenuItem,
            this.kháchHàngToolStripMenuItem});
            this.quảnLýThuêPhòngToolStripMenuItem.Name = "quảnLýThuêPhòngToolStripMenuItem";
            this.quảnLýThuêPhòngToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.quảnLýThuêPhòngToolStripMenuItem.Text = "Quản lý thuê phòng";
            this.quảnLýThuêPhòngToolStripMenuItem.Click += new System.EventHandler(this.quảnLýThuêPhòngToolStripMenuItem_Click);
            // 
            // phòngToolStripMenuItem
            // 
            this.phòngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phòngĐangThuêToolStripMenuItem,
            this.tấtCảCácPhòngToolStripMenuItem});
            this.phòngToolStripMenuItem.Name = "phòngToolStripMenuItem";
            this.phòngToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.phòngToolStripMenuItem.Text = "Phòng";
            // 
            // phòngĐangThuêToolStripMenuItem
            // 
            this.phòngĐangThuêToolStripMenuItem.Name = "phòngĐangThuêToolStripMenuItem";
            this.phòngĐangThuêToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.phòngĐangThuêToolStripMenuItem.Text = "Phòng đang thuê";
            this.phòngĐangThuêToolStripMenuItem.Click += new System.EventHandler(this.phòngĐangThuêToolStripMenuItem_Click);
            // 
            // tấtCảCácPhòngToolStripMenuItem
            // 
            this.tấtCảCácPhòngToolStripMenuItem.Name = "tấtCảCácPhòngToolStripMenuItem";
            this.tấtCảCácPhòngToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.tấtCảCácPhòngToolStripMenuItem.Text = "Tất cả các phòng";
            this.tấtCảCácPhòngToolStripMenuItem.Click += new System.EventHandler(this.tấtCảCácPhòngToolStripMenuItem_Click);
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hóaĐơnToolStripMenuItem.Text = "Hóa đơn";
            this.hóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.hóaĐơnToolStripMenuItem_Click);
            // 
            // lịchSửĐăngNhậpToolStripMenuItem
            // 
            this.lịchSửĐăngNhậpToolStripMenuItem.Name = "lịchSửĐăngNhậpToolStripMenuItem";
            this.lịchSửĐăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.lịchSửĐăngNhậpToolStripMenuItem.Text = "Lịch sử đăng nhập";
            this.lịchSửĐăngNhậpToolStripMenuItem.Click += new System.EventHandler(this.lịchSửĐăngNhậpToolStripMenuItem_Click);
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kháchHàngToolStripMenuItem.Text = "Khách hàng";
            this.kháchHàngToolStripMenuItem.Click += new System.EventHandler(this.kháchHàngToolStripMenuItem_Click);
            // 
            // fGiaodienChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DemoQLKS.Properties.Resources.hotelMain;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 361);
            this.Controls.Add(this.btn_dong);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fGiaodienChinh";
            this.Text = "Quản lý khách sạn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GiaodienChinh_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Button btn_dong;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýThuêPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lịchSửĐăngNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phòngĐangThuêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tấtCảCácPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;

    }
}