namespace DatabaseProject
{
    partial class frmPersonel
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
            this.f_name = new System.Windows.Forms.TextBox();
            this.l_name = new System.Windows.Forms.TextBox();
            this.salary = new System.Windows.Forms.TextBox();
            this.gorev = new System.Windows.Forms.TextBox();
            this.Bilgiler = new System.Windows.Forms.ListView();
            this.isim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.soyisim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.maas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.empId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grvId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblGorev = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblMaas = new System.Windows.Forms.Label();
            this.Gorevler = new System.Windows.Forms.ListView();
            this.gorevNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gorevAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grvEkle = new System.Windows.Forms.Button();
            this.grvSil = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.grvName = new System.Windows.Forms.TextBox();
            this.grvNO = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // f_name
            // 
            this.f_name.Location = new System.Drawing.Point(110, 123);
            this.f_name.Name = "f_name";
            this.f_name.Size = new System.Drawing.Size(156, 50);
            this.f_name.TabIndex = 3;
            // 
            // l_name
            // 
            this.l_name.Location = new System.Drawing.Point(110, 179);
            this.l_name.Name = "l_name";
            this.l_name.Size = new System.Drawing.Size(156, 50);
            this.l_name.TabIndex = 3;
            // 
            // salary
            // 
            this.salary.Location = new System.Drawing.Point(110, 235);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(156, 50);
            this.salary.TabIndex = 3;
            // 
            // gorev
            // 
            this.gorev.Location = new System.Drawing.Point(110, 67);
            this.gorev.Name = "gorev";
            this.gorev.Size = new System.Drawing.Size(156, 50);
            this.gorev.TabIndex = 3;
            // 
            // Bilgiler
            // 
            this.Bilgiler.BackColor = System.Drawing.Color.White;
            this.Bilgiler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.isim,
            this.soyisim,
            this.maas,
            this.empId,
            this.grvId});
            this.Bilgiler.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Bilgiler.FullRowSelect = true;
            this.Bilgiler.GridLines = true;
            this.Bilgiler.HideSelection = false;
            this.Bilgiler.Location = new System.Drawing.Point(6, 67);
            this.Bilgiler.Name = "Bilgiler";
            this.Bilgiler.Size = new System.Drawing.Size(658, 576);
            this.Bilgiler.TabIndex = 4;
            this.Bilgiler.UseCompatibleStateImageBehavior = false;
            this.Bilgiler.View = System.Windows.Forms.View.Details;
            // 
            // isim
            // 
            this.isim.Text = "İD";
            this.isim.Width = 0;
            // 
            // soyisim
            // 
            this.soyisim.Text = "GÖREV İD";
            this.soyisim.Width = 186;
            // 
            // maas
            // 
            this.maas.Text = "İSİM";
            this.maas.Width = 158;
            // 
            // empId
            // 
            this.empId.Text = "SOYİSİM";
            this.empId.Width = 181;
            // 
            // grvId
            // 
            this.grvId.Text = "MAAŞ";
            this.grvId.Width = 126;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.IndianRed;
            this.groupBox2.Controls.Add(this.btnSil);
            this.groupBox2.Controls.Add(this.btnGuncelle);
            this.groupBox2.Controls.Add(this.Bilgiler);
            this.groupBox2.Controls.Add(this.btnEkle);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(12, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(675, 656);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personel Bilgileri";
            // 
            // btnSil
            // 
            this.btnSil.BackgroundImage = global::DatabaseProject.Properties.Resources.sil;
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSil.Location = new System.Drawing.Point(523, 0);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(61, 66);
            this.btnSil.TabIndex = 0;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click_1);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackgroundImage = global::DatabaseProject.Properties.Resources.iiii;
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnGuncelle.Location = new System.Drawing.Point(590, 0);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(74, 66);
            this.btnGuncelle.TabIndex = 0;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click_1);
            // 
            // btnEkle
            // 
            this.btnEkle.BackgroundImage = global::DatabaseProject.Properties.Resources.indir;
            this.btnEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEkle.Location = new System.Drawing.Point(456, 0);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(61, 66);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblGorev
            // 
            this.lblGorev.AutoSize = true;
            this.lblGorev.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGorev.Location = new System.Drawing.Point(13, 77);
            this.lblGorev.Name = "lblGorev";
            this.lblGorev.Size = new System.Drawing.Size(91, 32);
            this.lblGorev.TabIndex = 6;
            this.lblGorev.Text = "Görevi:";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAd.Location = new System.Drawing.Point(13, 134);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(71, 32);
            this.lblAd.TabIndex = 6;
            this.lblAd.Text = "İsim: ";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.Location = new System.Drawing.Point(13, 188);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(109, 32);
            this.lblSoyad.TabIndex = 6;
            this.lblSoyad.Text = "Soyisim: ";
            // 
            // lblMaas
            // 
            this.lblMaas.AutoSize = true;
            this.lblMaas.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMaas.Location = new System.Drawing.Point(13, 244);
            this.lblMaas.Name = "lblMaas";
            this.lblMaas.Size = new System.Drawing.Size(85, 32);
            this.lblMaas.TabIndex = 6;
            this.lblMaas.Text = "Maaş: ";
            // 
            // Gorevler
            // 
            this.Gorevler.BackColor = System.Drawing.Color.White;
            this.Gorevler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.gorevNo,
            this.gorevAd});
            this.Gorevler.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Gorevler.FullRowSelect = true;
            this.Gorevler.GridLines = true;
            this.Gorevler.HideSelection = false;
            this.Gorevler.Location = new System.Drawing.Point(6, 77);
            this.Gorevler.Name = "Gorevler";
            this.Gorevler.Size = new System.Drawing.Size(509, 566);
            this.Gorevler.TabIndex = 7;
            this.Gorevler.UseCompatibleStateImageBehavior = false;
            this.Gorevler.View = System.Windows.Forms.View.Details;
            // 
            // gorevNo
            // 
            this.gorevNo.Text = "GÖREV NO";
            this.gorevNo.Width = 185;
            // 
            // gorevAd
            // 
            this.gorevAd.Text = "GÖREV ADI";
            this.gorevAd.Width = 237;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.IndianRed;
            this.groupBox3.Controls.Add(this.Gorevler);
            this.groupBox3.Controls.Add(this.grvEkle);
            this.groupBox3.Controls.Add(this.grvSil);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox3.Location = new System.Drawing.Point(1009, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(529, 656);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Görev Bilgileri";
            // 
            // grvEkle
            // 
            this.grvEkle.BackColor = System.Drawing.Color.White;
            this.grvEkle.BackgroundImage = global::DatabaseProject.Properties.Resources.indir;
            this.grvEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grvEkle.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grvEkle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grvEkle.Location = new System.Drawing.Point(375, 8);
            this.grvEkle.Name = "grvEkle";
            this.grvEkle.Size = new System.Drawing.Size(67, 64);
            this.grvEkle.TabIndex = 11;
            this.grvEkle.UseVisualStyleBackColor = false;
            this.grvEkle.Click += new System.EventHandler(this.grvEkle_Click);
            // 
            // grvSil
            // 
            this.grvSil.BackColor = System.Drawing.Color.White;
            this.grvSil.BackgroundImage = global::DatabaseProject.Properties.Resources.sil;
            this.grvSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grvSil.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grvSil.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grvSil.Location = new System.Drawing.Point(448, 8);
            this.grvSil.Name = "grvSil";
            this.grvSil.Size = new System.Drawing.Size(65, 63);
            this.grvSil.TabIndex = 11;
            this.grvSil.UseVisualStyleBackColor = false;
            this.grvSil.Click += new System.EventHandler(this.grvSil_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.IndianRed;
            this.groupBox4.Controls.Add(this.f_name);
            this.groupBox4.Controls.Add(this.gorev);
            this.groupBox4.Controls.Add(this.l_name);
            this.groupBox4.Controls.Add(this.lblMaas);
            this.groupBox4.Controls.Add(this.salary);
            this.groupBox4.Controls.Add(this.lblSoyad);
            this.groupBox4.Controls.Add(this.lblGorev);
            this.groupBox4.Controls.Add(this.lblAd);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox4.Location = new System.Drawing.Point(18, 719);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(454, 312);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Yeni personel bilgileri";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.IndianRed;
            this.groupBox5.Controls.Add(this.grvName);
            this.groupBox5.Controls.Add(this.grvNO);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox5.Location = new System.Drawing.Point(1009, 719);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(337, 200);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Yeni görev bilgileri";
            // 
            // grvName
            // 
            this.grvName.Location = new System.Drawing.Point(141, 123);
            this.grvName.Name = "grvName";
            this.grvName.Size = new System.Drawing.Size(156, 50);
            this.grvName.TabIndex = 3;
            // 
            // grvNO
            // 
            this.grvNO.Location = new System.Drawing.Point(141, 62);
            this.grvNO.Name = "grvNO";
            this.grvNO.Size = new System.Drawing.Size(156, 50);
            this.grvNO.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Görev No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Görev Adı:";
            // 
            // frmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1653, 1068);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPersonel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Siparis";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPersonel_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox f_name;
        private System.Windows.Forms.TextBox l_name;
        private System.Windows.Forms.TextBox salary;
        private System.Windows.Forms.TextBox gorev;
        private System.Windows.Forms.ListView Bilgiler;
        private System.Windows.Forms.ColumnHeader isim;
        private System.Windows.Forms.ColumnHeader soyisim;
        private System.Windows.Forms.ColumnHeader maas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblGorev;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblMaas;
        private System.Windows.Forms.ListView Gorevler;
        private System.Windows.Forms.ColumnHeader gorevNo;
        private System.Windows.Forms.ColumnHeader gorevAd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button grvEkle;
        private System.Windows.Forms.Button grvSil;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox grvName;
        private System.Windows.Forms.TextBox grvNO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader empId;
        private System.Windows.Forms.ColumnHeader grvId;
    }
}

