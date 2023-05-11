
namespace LTDT_Project_NhomAnhSang
{
    partial class FormPrim
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
            this.btn_Them = new System.Windows.Forms.Button();
            this.tBox_TrongSo = new System.Windows.Forms.TextBox();
            this.tBox_DenDinh = new System.Windows.Forms.TextBox();
            this.tBox_TuDinh = new System.Windows.Forms.TextBox();
            this.lb_TrongSo = new System.Windows.Forms.Label();
            this.lb_DenDinh = new System.Windows.Forms.Label();
            this.lb_TuDinh = new System.Windows.Forms.Label();
            this.groupBox_DauVao = new System.Windows.Forms.GroupBox();
            this.btnXoaCanh = new System.Windows.Forms.Button();
            this.btnXoaDinh = new System.Windows.Forms.Button();
            this.listBoxCanh = new System.Windows.Forms.ListBox();
            this.listBoxDinh = new System.Windows.Forms.ListBox();
            this.labelCanh = new System.Windows.Forms.Label();
            this.labelDinh = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_KetQua = new System.Windows.Forms.Button();
            this.tBox_TongGiaTri = new System.Windows.Forms.TextBox();
            this.tBox_KetQuaPrim = new System.Windows.Forms.TextBox();
            this.tBox_MaTranKe = new System.Windows.Forms.TextBox();
            this.lb_TongGiaTri = new System.Windows.Forms.Label();
            this.lb_KetQuaPrim = new System.Windows.Forms.Label();
            this.lb_MaTranKe = new System.Windows.Forms.Label();
            this.groupBox_DoThi = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox_DauVao.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox_DoThi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Them.Font = new System.Drawing.Font("UTM Aptima", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Them.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_Them.Location = new System.Drawing.Point(27, 206);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(196, 39);
            this.btn_Them.TabIndex = 4;
            this.btn_Them.Text = "NHẬP TRỌNG SỐ";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // tBox_TrongSo
            // 
            this.tBox_TrongSo.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBox_TrongSo.Location = new System.Drawing.Point(121, 156);
            this.tBox_TrongSo.Name = "tBox_TrongSo";
            this.tBox_TrongSo.Size = new System.Drawing.Size(102, 26);
            this.tBox_TrongSo.TabIndex = 3;
            // 
            // tBox_DenDinh
            // 
            this.tBox_DenDinh.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBox_DenDinh.Location = new System.Drawing.Point(121, 111);
            this.tBox_DenDinh.Name = "tBox_DenDinh";
            this.tBox_DenDinh.Size = new System.Drawing.Size(102, 26);
            this.tBox_DenDinh.TabIndex = 2;
            // 
            // tBox_TuDinh
            // 
            this.tBox_TuDinh.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBox_TuDinh.Location = new System.Drawing.Point(121, 66);
            this.tBox_TuDinh.Name = "tBox_TuDinh";
            this.tBox_TuDinh.Size = new System.Drawing.Size(102, 26);
            this.tBox_TuDinh.TabIndex = 1;
            // 
            // lb_TrongSo
            // 
            this.lb_TrongSo.AutoSize = true;
            this.lb_TrongSo.Font = new System.Drawing.Font("UTM Times", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_TrongSo.Location = new System.Drawing.Point(29, 157);
            this.lb_TrongSo.Name = "lb_TrongSo";
            this.lb_TrongSo.Size = new System.Drawing.Size(86, 25);
            this.lb_TrongSo.TabIndex = 2;
            this.lb_TrongSo.Text = "Trọng số";
            // 
            // lb_DenDinh
            // 
            this.lb_DenDinh.AutoSize = true;
            this.lb_DenDinh.Font = new System.Drawing.Font("UTM Times", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_DenDinh.Location = new System.Drawing.Point(27, 112);
            this.lb_DenDinh.Name = "lb_DenDinh";
            this.lb_DenDinh.Size = new System.Drawing.Size(88, 25);
            this.lb_DenDinh.TabIndex = 2;
            this.lb_DenDinh.Text = "Đến đỉnh";
            // 
            // lb_TuDinh
            // 
            this.lb_TuDinh.AutoSize = true;
            this.lb_TuDinh.Font = new System.Drawing.Font("UTM Times", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_TuDinh.Location = new System.Drawing.Point(29, 67);
            this.lb_TuDinh.Name = "lb_TuDinh";
            this.lb_TuDinh.Size = new System.Drawing.Size(79, 25);
            this.lb_TuDinh.TabIndex = 1;
            this.lb_TuDinh.Text = "Từ đỉnh";
            // 
            // groupBox_DauVao
            // 
            this.groupBox_DauVao.Controls.Add(this.btnXoaCanh);
            this.groupBox_DauVao.Controls.Add(this.btnXoaDinh);
            this.groupBox_DauVao.Controls.Add(this.listBoxCanh);
            this.groupBox_DauVao.Controls.Add(this.listBoxDinh);
            this.groupBox_DauVao.Controls.Add(this.btn_Them);
            this.groupBox_DauVao.Controls.Add(this.tBox_TrongSo);
            this.groupBox_DauVao.Controls.Add(this.labelCanh);
            this.groupBox_DauVao.Controls.Add(this.labelDinh);
            this.groupBox_DauVao.Controls.Add(this.lb_TuDinh);
            this.groupBox_DauVao.Controls.Add(this.tBox_DenDinh);
            this.groupBox_DauVao.Controls.Add(this.lb_DenDinh);
            this.groupBox_DauVao.Controls.Add(this.tBox_TuDinh);
            this.groupBox_DauVao.Controls.Add(this.lb_TrongSo);
            this.groupBox_DauVao.Font = new System.Drawing.Font("UTM Guanine", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox_DauVao.ForeColor = System.Drawing.Color.DarkCyan;
            this.groupBox_DauVao.Location = new System.Drawing.Point(21, 33);
            this.groupBox_DauVao.Name = "groupBox_DauVao";
            this.groupBox_DauVao.Size = new System.Drawing.Size(592, 273);
            this.groupBox_DauVao.TabIndex = 5;
            this.groupBox_DauVao.TabStop = false;
            this.groupBox_DauVao.Text = "THÔNG TIN ĐẦU VÀO";
            // 
            // btnXoaCanh
            // 
            this.btnXoaCanh.BackColor = System.Drawing.Color.DarkCyan;
            this.btnXoaCanh.Font = new System.Drawing.Font("UTM Aptima", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoaCanh.ForeColor = System.Drawing.SystemColors.Info;
            this.btnXoaCanh.Location = new System.Drawing.Point(406, 204);
            this.btnXoaCanh.Name = "btnXoaCanh";
            this.btnXoaCanh.Size = new System.Drawing.Size(140, 41);
            this.btnXoaCanh.TabIndex = 8;
            this.btnXoaCanh.Text = "XOÁ CẠNH";
            this.btnXoaCanh.UseVisualStyleBackColor = false;
            this.btnXoaCanh.Click += new System.EventHandler(this.btnXoaCanh_Click);
            // 
            // btnXoaDinh
            // 
            this.btnXoaDinh.BackColor = System.Drawing.Color.DarkCyan;
            this.btnXoaDinh.Font = new System.Drawing.Font("UTM Aptima", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoaDinh.ForeColor = System.Drawing.SystemColors.Info;
            this.btnXoaDinh.Location = new System.Drawing.Point(245, 205);
            this.btnXoaDinh.Name = "btnXoaDinh";
            this.btnXoaDinh.Size = new System.Drawing.Size(140, 40);
            this.btnXoaDinh.TabIndex = 7;
            this.btnXoaDinh.Text = "XOÁ ĐỈNH";
            this.btnXoaDinh.UseVisualStyleBackColor = false;
            this.btnXoaDinh.Click += new System.EventHandler(this.btnXoaDinh_Click);
            // 
            // listBoxCanh
            // 
            this.listBoxCanh.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxCanh.FormattingEnabled = true;
            this.listBoxCanh.ItemHeight = 18;
            this.listBoxCanh.Location = new System.Drawing.Point(411, 80);
            this.listBoxCanh.Name = "listBoxCanh";
            this.listBoxCanh.Size = new System.Drawing.Size(144, 112);
            this.listBoxCanh.TabIndex = 7;
            // 
            // listBoxDinh
            // 
            this.listBoxDinh.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxDinh.FormattingEnabled = true;
            this.listBoxDinh.ItemHeight = 18;
            this.listBoxDinh.Location = new System.Drawing.Point(249, 82);
            this.listBoxDinh.Name = "listBoxDinh";
            this.listBoxDinh.Size = new System.Drawing.Size(142, 112);
            this.listBoxDinh.TabIndex = 6;
            // 
            // labelCanh
            // 
            this.labelCanh.AutoSize = true;
            this.labelCanh.Font = new System.Drawing.Font("UTM Times", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCanh.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelCanh.Location = new System.Drawing.Point(406, 48);
            this.labelCanh.Name = "labelCanh";
            this.labelCanh.Size = new System.Drawing.Size(144, 25);
            this.labelCanh.TabIndex = 1;
            this.labelCanh.Text = "Danh sách cạnh";
            this.labelCanh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDinh
            // 
            this.labelDinh.AutoSize = true;
            this.labelDinh.Font = new System.Drawing.Font("UTM Times", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDinh.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelDinh.Location = new System.Drawing.Point(250, 49);
            this.labelDinh.Name = "labelDinh";
            this.labelDinh.Size = new System.Drawing.Size(142, 25);
            this.labelDinh.TabIndex = 1;
            this.labelDinh.Text = "Danh sách đỉnh";
            this.labelDinh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_KetQua);
            this.groupBox1.Controls.Add(this.tBox_TongGiaTri);
            this.groupBox1.Controls.Add(this.tBox_KetQuaPrim);
            this.groupBox1.Controls.Add(this.tBox_MaTranKe);
            this.groupBox1.Controls.Add(this.lb_TongGiaTri);
            this.groupBox1.Controls.Add(this.lb_KetQuaPrim);
            this.groupBox1.Controls.Add(this.lb_MaTranKe);
            this.groupBox1.Font = new System.Drawing.Font("UTM Guanine", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox1.Location = new System.Drawing.Point(21, 339);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 361);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN ĐẦU RA";
            // 
            // btn_KetQua
            // 
            this.btn_KetQua.BackColor = System.Drawing.Color.Crimson;
            this.btn_KetQua.Font = new System.Drawing.Font("UTM Aptima", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_KetQua.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_KetQua.Location = new System.Drawing.Point(32, 297);
            this.btn_KetQua.Name = "btn_KetQua";
            this.btn_KetQua.Size = new System.Drawing.Size(533, 39);
            this.btn_KetQua.TabIndex = 5;
            this.btn_KetQua.Text = "CHẠY THUẬT TOÁN";
            this.btn_KetQua.UseVisualStyleBackColor = false;
            this.btn_KetQua.Click += new System.EventHandler(this.btn_KetQua_Click);
            // 
            // tBox_TongGiaTri
            // 
            this.tBox_TongGiaTri.Font = new System.Drawing.Font("Century", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBox_TongGiaTri.Location = new System.Drawing.Point(434, 89);
            this.tBox_TongGiaTri.Multiline = true;
            this.tBox_TongGiaTri.Name = "tBox_TongGiaTri";
            this.tBox_TongGiaTri.ReadOnly = true;
            this.tBox_TongGiaTri.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tBox_TongGiaTri.Size = new System.Drawing.Size(131, 189);
            this.tBox_TongGiaTri.TabIndex = 1;
            // 
            // tBox_KetQuaPrim
            // 
            this.tBox_KetQuaPrim.Font = new System.Drawing.Font("Century", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBox_KetQuaPrim.Location = new System.Drawing.Point(276, 89);
            this.tBox_KetQuaPrim.Multiline = true;
            this.tBox_KetQuaPrim.Name = "tBox_KetQuaPrim";
            this.tBox_KetQuaPrim.ReadOnly = true;
            this.tBox_KetQuaPrim.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tBox_KetQuaPrim.Size = new System.Drawing.Size(142, 189);
            this.tBox_KetQuaPrim.TabIndex = 1;
            // 
            // tBox_MaTranKe
            // 
            this.tBox_MaTranKe.Font = new System.Drawing.Font("Century", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBox_MaTranKe.Location = new System.Drawing.Point(32, 89);
            this.tBox_MaTranKe.Multiline = true;
            this.tBox_MaTranKe.Name = "tBox_MaTranKe";
            this.tBox_MaTranKe.ReadOnly = true;
            this.tBox_MaTranKe.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tBox_MaTranKe.Size = new System.Drawing.Size(229, 189);
            this.tBox_MaTranKe.TabIndex = 1;
            this.tBox_MaTranKe.Text = "0";
            // 
            // lb_TongGiaTri
            // 
            this.lb_TongGiaTri.AutoSize = true;
            this.lb_TongGiaTri.Font = new System.Drawing.Font("UTM Times", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_TongGiaTri.ForeColor = System.Drawing.Color.Black;
            this.lb_TongGiaTri.Location = new System.Drawing.Point(434, 53);
            this.lb_TongGiaTri.Name = "lb_TongGiaTri";
            this.lb_TongGiaTri.Size = new System.Drawing.Size(110, 25);
            this.lb_TongGiaTri.TabIndex = 1;
            this.lb_TongGiaTri.Text = "Tổng giá trị";
            // 
            // lb_KetQuaPrim
            // 
            this.lb_KetQuaPrim.AutoSize = true;
            this.lb_KetQuaPrim.Font = new System.Drawing.Font("UTM Times", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_KetQuaPrim.ForeColor = System.Drawing.Color.Black;
            this.lb_KetQuaPrim.Location = new System.Drawing.Point(298, 53);
            this.lb_KetQuaPrim.Name = "lb_KetQuaPrim";
            this.lb_KetQuaPrim.Size = new System.Drawing.Size(78, 25);
            this.lb_KetQuaPrim.TabIndex = 1;
            this.lb_KetQuaPrim.Text = "Kết quả";
            // 
            // lb_MaTranKe
            // 
            this.lb_MaTranKe.AutoSize = true;
            this.lb_MaTranKe.Font = new System.Drawing.Font("UTM Times", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_MaTranKe.ForeColor = System.Drawing.Color.Black;
            this.lb_MaTranKe.Location = new System.Drawing.Point(89, 53);
            this.lb_MaTranKe.Name = "lb_MaTranKe";
            this.lb_MaTranKe.Size = new System.Drawing.Size(104, 25);
            this.lb_MaTranKe.TabIndex = 1;
            this.lb_MaTranKe.Text = "Ma trận kề";
            // 
            // groupBox_DoThi
            // 
            this.groupBox_DoThi.Controls.Add(this.label2);
            this.groupBox_DoThi.Controls.Add(this.label1);
            this.groupBox_DoThi.Controls.Add(this.pictureBox2);
            this.groupBox_DoThi.Controls.Add(this.pictureBox1);
            this.groupBox_DoThi.Font = new System.Drawing.Font("UTM Guanine", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox_DoThi.ForeColor = System.Drawing.Color.DarkCyan;
            this.groupBox_DoThi.Location = new System.Drawing.Point(637, 33);
            this.groupBox_DoThi.Name = "groupBox_DoThi";
            this.groupBox_DoThi.Size = new System.Drawing.Size(761, 667);
            this.groupBox_DoThi.TabIndex = 10;
            this.groupBox_DoThi.TabStop = false;
            this.groupBox_DoThi.Text = "CHẠY THUẬT TOÁN PRIM";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("UTM Aptima", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(31, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 50);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kết quả";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("UTM Aptima", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(31, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Đề bài";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.LightSalmon;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(31, 346);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(710, 297);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox2_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(31, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(710, 297);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // FormPrim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1419, 712);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_DauVao);
            this.Controls.Add(this.groupBox_DoThi);
            this.Name = "FormPrim";
            this.Text = "FromPrim";
            this.Load += new System.EventHandler(this.FormPrim_Load);
            this.groupBox_DauVao.ResumeLayout(false);
            this.groupBox_DauVao.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_DoThi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox tBox_TrongSo;
        private System.Windows.Forms.TextBox tBox_DenDinh;
        private System.Windows.Forms.TextBox tBox_TuDinh;
        private System.Windows.Forms.Label lb_TrongSo;
        private System.Windows.Forms.Label lb_DenDinh;
        private System.Windows.Forms.Label lb_TuDinh;
        private System.Windows.Forms.GroupBox groupBox_DauVao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox_DoThi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_MaTranKe;
        private System.Windows.Forms.Button btnXoaCanh;
        private System.Windows.Forms.Button btnXoaDinh;
        private System.Windows.Forms.ListBox listBoxCanh;
        private System.Windows.Forms.ListBox listBoxDinh;
        private System.Windows.Forms.Label labelCanh;
        private System.Windows.Forms.Label labelDinh;
        private System.Windows.Forms.TextBox tBox_KetQuaPrim;
        private System.Windows.Forms.Label lb_KetQuaPrim;
        private System.Windows.Forms.Button btn_KetQua;
        private System.Windows.Forms.TextBox tBox_TongGiaTri;
        private System.Windows.Forms.Label lb_TongGiaTri;
        public System.Windows.Forms.TextBox tBox_MaTranKe;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}