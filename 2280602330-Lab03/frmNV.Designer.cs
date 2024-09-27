namespace _2280602330_Lab03
{
    partial class frmNV
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
            this.txtmsnv = new System.Windows.Forms.Label();
            this.txttennhanvien = new System.Windows.Forms.Label();
            this.txtluongcanban = new System.Windows.Forms.Label();
            this.btndongy = new System.Windows.Forms.Button();
            this.btnboqua = new System.Windows.Forms.Button();
            this.txbmsnv = new System.Windows.Forms.TextBox();
            this.txbtennhanvien = new System.Windows.Forms.TextBox();
            this.txbluong = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtmsnv
            // 
            this.txtmsnv.AutoSize = true;
            this.txtmsnv.Location = new System.Drawing.Point(63, 68);
            this.txtmsnv.Name = "txtmsnv";
            this.txtmsnv.Size = new System.Drawing.Size(59, 20);
            this.txtmsnv.TabIndex = 0;
            this.txtmsnv.Text = "MSNV:";
            // 
            // txttennhanvien
            // 
            this.txttennhanvien.AutoSize = true;
            this.txttennhanvien.Location = new System.Drawing.Point(63, 145);
            this.txttennhanvien.Name = "txttennhanvien";
            this.txttennhanvien.Size = new System.Drawing.Size(112, 20);
            this.txttennhanvien.TabIndex = 1;
            this.txttennhanvien.Text = "Tên nhân viên:";
            // 
            // txtluongcanban
            // 
            this.txtluongcanban.AutoSize = true;
            this.txtluongcanban.Location = new System.Drawing.Point(63, 225);
            this.txtluongcanban.Name = "txtluongcanban";
            this.txtluongcanban.Size = new System.Drawing.Size(119, 20);
            this.txtluongcanban.TabIndex = 2;
            this.txtluongcanban.Text = "Lương căn bản:";
            // 
            // btndongy
            // 
            this.btndongy.Location = new System.Drawing.Point(148, 337);
            this.btndongy.Name = "btndongy";
            this.btndongy.Size = new System.Drawing.Size(139, 38);
            this.btndongy.TabIndex = 3;
            this.btndongy.Text = "Đồng ý";
            this.btndongy.UseVisualStyleBackColor = true;
            this.btndongy.Click += new System.EventHandler(this.btndongy_Click);
            // 
            // btnboqua
            // 
            this.btnboqua.Location = new System.Drawing.Point(388, 337);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(137, 38);
            this.btnboqua.TabIndex = 4;
            this.btnboqua.Text = "Bỏ qua";
            this.btnboqua.UseVisualStyleBackColor = true;
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // txbmsnv
            // 
            this.txbmsnv.Location = new System.Drawing.Point(185, 62);
            this.txbmsnv.Name = "txbmsnv";
            this.txbmsnv.Size = new System.Drawing.Size(209, 26);
            this.txbmsnv.TabIndex = 5;
            this.txbmsnv.TextChanged += new System.EventHandler(this.txbmsnv_TextChanged);
            // 
            // txbtennhanvien
            // 
            this.txbtennhanvien.Location = new System.Drawing.Point(185, 139);
            this.txbtennhanvien.Name = "txbtennhanvien";
            this.txbtennhanvien.Size = new System.Drawing.Size(361, 26);
            this.txbtennhanvien.TabIndex = 6;
            this.txbtennhanvien.TextChanged += new System.EventHandler(this.txbtennhanvien_TextChanged);
            // 
            // txbluong
            // 
            this.txbluong.Location = new System.Drawing.Point(191, 219);
            this.txbluong.Name = "txbluong";
            this.txbluong.Size = new System.Drawing.Size(203, 26);
            this.txbluong.TabIndex = 7;
            // 
            // frmNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbluong);
            this.Controls.Add(this.txbtennhanvien);
            this.Controls.Add(this.txbmsnv);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.btndongy);
            this.Controls.Add(this.txtluongcanban);
            this.Controls.Add(this.txttennhanvien);
            this.Controls.Add(this.txtmsnv);
            this.Name = "frmNV";
            this.Text = "frmNV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtmsnv;
        private System.Windows.Forms.Label txttennhanvien;
        private System.Windows.Forms.Label txtluongcanban;
        private System.Windows.Forms.Button btndongy;
        private System.Windows.Forms.Button btnboqua;
        private System.Windows.Forms.TextBox txbmsnv;
        private System.Windows.Forms.TextBox txbtennhanvien;
        private System.Windows.Forms.TextBox txbluong;
    }
}

