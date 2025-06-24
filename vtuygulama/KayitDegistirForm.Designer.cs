
namespace vtuygulama
{
    partial class KayitDegistirForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtKayitno = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblYidiz2 = new System.Windows.Forms.Label();
            this.lblYildiz = new System.Windows.Forms.Label();
            this.dtTar = new System.Windows.Forms.DateTimePicker();
            this.cmbBirim = new System.Windows.Forms.ComboBox();
            this.radKadin = new System.Windows.Forms.RadioButton();
            this.radErkek = new System.Windows.Forms.RadioButton();
            this.txtTcno = new System.Windows.Forms.MaskedTextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtKayitno);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lblYidiz2);
            this.panel1.Controls.Add(this.lblYildiz);
            this.panel1.Controls.Add(this.dtTar);
            this.panel1.Controls.Add(this.cmbBirim);
            this.panel1.Controls.Add(this.radKadin);
            this.panel1.Controls.Add(this.radErkek);
            this.panel1.Controls.Add(this.txtTcno);
            this.panel1.Controls.Add(this.txtSoyad);
            this.panel1.Controls.Add(this.txtAd);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 394);
            this.panel1.TabIndex = 1;
            // 
            // txtKayitno
            // 
            this.txtKayitno.Location = new System.Drawing.Point(261, 17);
            this.txtKayitno.Name = "txtKayitno";
            this.txtKayitno.Size = new System.Drawing.Size(149, 30);
            this.txtKayitno.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 25);
            this.label9.TabIndex = 12;
            this.label9.Text = "Kayıt No";
            // 
            // lblYidiz2
            // 
            this.lblYidiz2.AutoSize = true;
            this.lblYidiz2.ForeColor = System.Drawing.Color.Red;
            this.lblYidiz2.Location = new System.Drawing.Point(471, 332);
            this.lblYidiz2.Name = "lblYidiz2";
            this.lblYidiz2.Size = new System.Drawing.Size(20, 25);
            this.lblYidiz2.TabIndex = 11;
            this.lblYidiz2.Text = "*";
            this.lblYidiz2.Visible = false;
            // 
            // lblYildiz
            // 
            this.lblYildiz.AutoSize = true;
            this.lblYildiz.ForeColor = System.Drawing.Color.Red;
            this.lblYildiz.Location = new System.Drawing.Point(471, 226);
            this.lblYildiz.Name = "lblYildiz";
            this.lblYildiz.Size = new System.Drawing.Size(20, 25);
            this.lblYildiz.TabIndex = 10;
            this.lblYildiz.Text = "*";
            this.lblYildiz.Visible = false;
            // 
            // dtTar
            // 
            this.dtTar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTar.Location = new System.Drawing.Point(261, 327);
            this.dtTar.Name = "dtTar";
            this.dtTar.Size = new System.Drawing.Size(204, 30);
            this.dtTar.TabIndex = 8;
            this.dtTar.Value = new System.DateTime(2025, 4, 16, 0, 0, 0, 0);
            // 
            // cmbBirim
            // 
            this.cmbBirim.FormattingEnabled = true;
            this.cmbBirim.Location = new System.Drawing.Point(261, 272);
            this.cmbBirim.Name = "cmbBirim";
            this.cmbBirim.Size = new System.Drawing.Size(183, 33);
            this.cmbBirim.TabIndex = 6;
            this.cmbBirim.Text = "Bölüm Seçiniz";
            // 
            // radKadin
            // 
            this.radKadin.AutoSize = true;
            this.radKadin.Location = new System.Drawing.Point(369, 222);
            this.radKadin.Name = "radKadin";
            this.radKadin.Size = new System.Drawing.Size(84, 29);
            this.radKadin.TabIndex = 5;
            this.radKadin.TabStop = true;
            this.radKadin.Text = "Kadın";
            this.radKadin.UseVisualStyleBackColor = true;
            // 
            // radErkek
            // 
            this.radErkek.AutoSize = true;
            this.radErkek.Location = new System.Drawing.Point(261, 222);
            this.radErkek.Name = "radErkek";
            this.radErkek.Size = new System.Drawing.Size(83, 29);
            this.radErkek.TabIndex = 4;
            this.radErkek.TabStop = true;
            this.radErkek.Text = "Erkek";
            this.radErkek.UseVisualStyleBackColor = true;
            // 
            // txtTcno
            // 
            this.txtTcno.BeepOnError = true;
            this.txtTcno.Location = new System.Drawing.Point(261, 167);
            this.txtTcno.Mask = "00000000000";
            this.txtTcno.Name = "txtTcno";
            this.txtTcno.Size = new System.Drawing.Size(149, 30);
            this.txtTcno.TabIndex = 3;
            this.txtTcno.ValidatingType = typeof(int);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(261, 115);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(149, 30);
            this.txtSoyad.TabIndex = 2;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(261, 59);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(149, 30);
            this.txtAd.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Doğum Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Bölüm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cinsiyet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "TCno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // btnDegistir
            // 
            this.btnDegistir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDegistir.Location = new System.Drawing.Point(12, 426);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(502, 57);
            this.btnDegistir.TabIndex = 2;
            this.btnDegistir.Text = "Kayıt Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = false;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click_1);
            // 
            // KayitDegistirForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 499);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "KayitDegistirForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KayitDegistirForm";
            this.Load += new System.EventHandler(this.KayitDegistirForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblYidiz2;
        private System.Windows.Forms.Label lblYildiz;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDegistir;
        public System.Windows.Forms.TextBox txtSoyad;
        public System.Windows.Forms.TextBox txtAd;
        public System.Windows.Forms.TextBox txtKayitno;
        public System.Windows.Forms.DateTimePicker dtTar;
        public System.Windows.Forms.ComboBox cmbBirim;
        public System.Windows.Forms.RadioButton radKadin;
        public System.Windows.Forms.RadioButton radErkek;
        public System.Windows.Forms.MaskedTextBox txtTcno;
    }
}