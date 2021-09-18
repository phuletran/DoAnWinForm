namespace DemoQLKS
{
    partial class fNhanVien
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
            this.gvNV = new System.Windows.Forms.DataGridView();
            this.btThemNV = new System.Windows.Forms.Button();
            this.btXoaNV = new System.Windows.Forms.Button();
            this.btSuaNV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_TenNv = new System.Windows.Forms.Label();
            this.tb_TenNv = new System.Windows.Forms.TextBox();
            this.lb_MaNv = new System.Windows.Forms.Label();
            this.tb_MaNv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_GioiTinhNV = new System.Windows.Forms.Label();
            this.lb_sdtnv = new System.Windows.Forms.Label();
            this.lb_ChucvuNv = new System.Windows.Forms.Label();
            this.tb_SdtNv = new System.Windows.Forms.TextBox();
            this.dt_NsNv = new System.Windows.Forms.DateTimePicker();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.cbGT = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gvNV)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvNV
            // 
            this.gvNV.AllowUserToAddRows = false;
            this.gvNV.AllowUserToDeleteRows = false;
            this.gvNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gvNV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvNV.Location = new System.Drawing.Point(92, 156);
            this.gvNV.Name = "gvNV";
            this.gvNV.ReadOnly = true;
            this.gvNV.Size = new System.Drawing.Size(505, 157);
            this.gvNV.TabIndex = 0;
            this.gvNV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvNV_CellContentClick);
            // 
            // btThemNV
            // 
            this.btThemNV.BackColor = System.Drawing.Color.Cyan;
            this.btThemNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemNV.ForeColor = System.Drawing.Color.Black;
            this.btThemNV.Location = new System.Drawing.Point(92, 324);
            this.btThemNV.Name = "btThemNV";
            this.btThemNV.Size = new System.Drawing.Size(126, 34);
            this.btThemNV.TabIndex = 1;
            this.btThemNV.Text = "Thêm Nhân Viên";
            this.btThemNV.UseVisualStyleBackColor = false;
            this.btThemNV.Click += new System.EventHandler(this.btThemNV_Click);
            // 
            // btXoaNV
            // 
            this.btXoaNV.BackColor = System.Drawing.Color.Red;
            this.btXoaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoaNV.Location = new System.Drawing.Point(283, 324);
            this.btXoaNV.Name = "btXoaNV";
            this.btXoaNV.Size = new System.Drawing.Size(121, 34);
            this.btXoaNV.TabIndex = 2;
            this.btXoaNV.Text = "Xóa Nhân Viên";
            this.btXoaNV.UseVisualStyleBackColor = false;
            this.btXoaNV.Click += new System.EventHandler(this.btXoaNV_Click);
            // 
            // btSuaNV
            // 
            this.btSuaNV.BackColor = System.Drawing.Color.Lime;
            this.btSuaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSuaNV.Location = new System.Drawing.Point(452, 324);
            this.btSuaNV.Name = "btSuaNV";
            this.btSuaNV.Size = new System.Drawing.Size(125, 31);
            this.btSuaNV.TabIndex = 3;
            this.btSuaNV.Text = "Sửa Nhân Viên";
            this.btSuaNV.UseVisualStyleBackColor = false;
            this.btSuaNV.Click += new System.EventHandler(this.btSuaNV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(81, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quản Lý Nhân Sự";
            // 
            // lb_TenNv
            // 
            this.lb_TenNv.AutoSize = true;
            this.lb_TenNv.Location = new System.Drawing.Point(90, 86);
            this.lb_TenNv.Name = "lb_TenNv";
            this.lb_TenNv.Size = new System.Drawing.Size(79, 13);
            this.lb_TenNv.TabIndex = 5;
            this.lb_TenNv.Text = "Tên Nhân Viên";
            // 
            // tb_TenNv
            // 
            this.tb_TenNv.Location = new System.Drawing.Point(171, 83);
            this.tb_TenNv.Name = "tb_TenNv";
            this.tb_TenNv.Size = new System.Drawing.Size(100, 20);
            this.tb_TenNv.TabIndex = 6;
            // 
            // lb_MaNv
            // 
            this.lb_MaNv.AutoSize = true;
            this.lb_MaNv.Location = new System.Drawing.Point(90, 45);
            this.lb_MaNv.Name = "lb_MaNv";
            this.lb_MaNv.Size = new System.Drawing.Size(75, 13);
            this.lb_MaNv.TabIndex = 5;
            this.lb_MaNv.Text = "Mã Nhân Viên";
            // 
            // tb_MaNv
            // 
            this.tb_MaNv.Location = new System.Drawing.Point(171, 38);
            this.tb_MaNv.Name = "tb_MaNv";
            this.tb_MaNv.Size = new System.Drawing.Size(100, 20);
            this.tb_MaNv.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ngày Sinh";
            // 
            // lb_GioiTinhNV
            // 
            this.lb_GioiTinhNV.AutoSize = true;
            this.lb_GioiTinhNV.Location = new System.Drawing.Point(434, 83);
            this.lb_GioiTinhNV.Name = "lb_GioiTinhNV";
            this.lb_GioiTinhNV.Size = new System.Drawing.Size(51, 13);
            this.lb_GioiTinhNV.TabIndex = 5;
            this.lb_GioiTinhNV.Text = "Giới Tính";
            // 
            // lb_sdtnv
            // 
            this.lb_sdtnv.AutoSize = true;
            this.lb_sdtnv.Location = new System.Drawing.Point(434, 45);
            this.lb_sdtnv.Name = "lb_sdtnv";
            this.lb_sdtnv.Size = new System.Drawing.Size(29, 13);
            this.lb_sdtnv.TabIndex = 5;
            this.lb_sdtnv.Text = "SĐT";
            // 
            // lb_ChucvuNv
            // 
            this.lb_ChucvuNv.AutoSize = true;
            this.lb_ChucvuNv.Location = new System.Drawing.Point(434, 116);
            this.lb_ChucvuNv.Name = "lb_ChucvuNv";
            this.lb_ChucvuNv.Size = new System.Drawing.Size(48, 13);
            this.lb_ChucvuNv.TabIndex = 5;
            this.lb_ChucvuNv.Text = "Chức Vụ";
            // 
            // tb_SdtNv
            // 
            this.tb_SdtNv.Location = new System.Drawing.Point(491, 42);
            this.tb_SdtNv.Name = "tb_SdtNv";
            this.tb_SdtNv.Size = new System.Drawing.Size(100, 20);
            this.tb_SdtNv.TabIndex = 6;
            // 
            // dt_NsNv
            // 
            this.dt_NsNv.Location = new System.Drawing.Point(171, 122);
            this.dt_NsNv.Name = "dt_NsNv";
            this.dt_NsNv.Size = new System.Drawing.Size(200, 20);
            this.dt_NsNv.TabIndex = 7;
            // 
            // cbRole
            // 
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Items.AddRange(new object[] {
            "Quản lý",
            "Lễ tân"});
            this.cbRole.Location = new System.Drawing.Point(491, 116);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(100, 21);
            this.cbRole.TabIndex = 9;
            // 
            // cbGT
            // 
            this.cbGT.FormattingEnabled = true;
            this.cbGT.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGT.Location = new System.Drawing.Point(491, 80);
            this.cbGT.Name = "cbGT";
            this.cbGT.Size = new System.Drawing.Size(100, 21);
            this.cbGT.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Quay lại";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.cbGT);
            this.panel1.Controls.Add(this.cbRole);
            this.panel1.Controls.Add(this.dt_NsNv);
            this.panel1.Controls.Add(this.tb_SdtNv);
            this.panel1.Controls.Add(this.tb_MaNv);
            this.panel1.Controls.Add(this.tb_TenNv);
            this.panel1.Controls.Add(this.lb_ChucvuNv);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lb_sdtnv);
            this.panel1.Controls.Add(this.lb_GioiTinhNV);
            this.panel1.Controls.Add(this.lb_MaNv);
            this.panel1.Controls.Add(this.lb_TenNv);
            this.panel1.Controls.Add(this.btSuaNV);
            this.panel1.Controls.Add(this.btXoaNV);
            this.panel1.Controls.Add(this.btThemNV);
            this.panel1.Controls.Add(this.gvNV);
            this.panel1.Location = new System.Drawing.Point(59, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 394);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(51, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(725, 457);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Location = new System.Drawing.Point(0, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(773, 23);
            this.panel3.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Location = new System.Drawing.Point(0, 60);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(53, 438);
            this.panel4.TabIndex = 14;
            // 
            // fNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(772, 494);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.fNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvNV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvNV;
        private System.Windows.Forms.Button btThemNV;
        private System.Windows.Forms.Button btXoaNV;
        private System.Windows.Forms.Button btSuaNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_TenNv;
        private System.Windows.Forms.TextBox tb_TenNv;
        private System.Windows.Forms.Label lb_MaNv;
        private System.Windows.Forms.TextBox tb_MaNv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_GioiTinhNV;
        private System.Windows.Forms.Label lb_sdtnv;
        private System.Windows.Forms.Label lb_ChucvuNv;
        private System.Windows.Forms.TextBox tb_SdtNv;
        private System.Windows.Forms.DateTimePicker dt_NsNv;
     
       
     
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.ComboBox cbGT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}