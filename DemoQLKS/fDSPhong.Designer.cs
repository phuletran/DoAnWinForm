namespace DemoQLKS
{
    partial class fDSPhong
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
            this.gvP = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btCP = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvP)).BeginInit();
            this.SuspendLayout();
            // 
            // gvP
            // 
            this.gvP.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvP.Location = new System.Drawing.Point(-3, 76);
            this.gvP.Name = "gvP";
            this.gvP.Size = new System.Drawing.Size(491, 224);
            this.gvP.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH PHÒNG";
            // 
            // btCP
            // 
            this.btCP.Location = new System.Drawing.Point(184, 47);
            this.btCP.Name = "btCP";
            this.btCP.Size = new System.Drawing.Size(75, 23);
            this.btCP.TabIndex = 2;
            this.btCP.Text = "Cập Nhật";
            this.btCP.UseVisualStyleBackColor = true;
            this.btCP.Click += new System.EventHandler(this.btCP_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-3, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Đóng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fDSPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(485, 296);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btCP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvP);
            this.Name = "fDSPhong";
            this.Text = "fDSPhong";
            this.Load += new System.EventHandler(this.fDSPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCP;
        private System.Windows.Forms.Button button1;
    }
}