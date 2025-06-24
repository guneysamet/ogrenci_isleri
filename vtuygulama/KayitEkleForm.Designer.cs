
namespace vtuygulama
{
    partial class KayitEkleForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtTcno = new System.Windows.Forms.MaskedTextBox();
            this.radErkek = new System.Windows.Forms.RadioButton();
            this.radKadin = new System.Windows.Forms.RadioButton();
            this.cmbBirim = new System.Windows.Forms.ComboBox();
            this.dtTar = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblYidiz2 = new System.Windows.Forms.Label();
            this.lblYildiz = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "TCno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cinsiyet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Bölüm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "Doğum Tarihi";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(256, 11);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(149, 34);
            this.txtAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(256, 67);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(149, 34);
            this.txtSoyad.TabIndex = 2;
            // 
            // txtTcno
            // 
            this.txtTcno.BeepOnError = true;
            this.txtTcno.Location = new System.Drawing.Point(256, 119);
            this.txtTcno.Mask = "00000000000";
            this.txtTcno.Name = "txtTcno";
            this.txtTcno.Size = new System.Drawing.Size(149, 34);
            this.txtTcno.TabIndex = 3;
            this.txtTcno.ValidatingType = typeof(int);
            // 
            // radErkek
            // 
            this.radErkek.AutoSize = true;
            this.radErkek.Location = new System.Drawing.Point(256, 174);
            this.radErkek.Name = "radErkek";
            this.radErkek.Size = new System.Drawing.Size(96, 33);
            this.radErkek.TabIndex = 4;
            this.radErkek.TabStop = true;
            this.radErkek.Text = "Erkek";
            this.radErkek.UseVisualStyleBackColor = true;
            this.radErkek.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radKadin
            // 
            this.radKadin.AutoSize = true;
            this.radKadin.Location = new System.Drawing.Point(364, 174);
            this.radKadin.Name = "radKadin";
            this.radKadin.Size = new System.Drawing.Size(96, 33);
            this.radKadin.TabIndex = 5;
            this.radKadin.TabStop = true;
            this.radKadin.Text = "Kadın";
            this.radKadin.UseVisualStyleBackColor = true;
            this.radKadin.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // cmbBirim
            // 
            this.cmbBirim.FormattingEnabled = true;
            this.cmbBirim.Location = new System.Drawing.Point(256, 224);
            this.cmbBirim.Name = "cmbBirim";
            this.cmbBirim.Size = new System.Drawing.Size(183, 37);
            this.cmbBirim.TabIndex = 6;
            this.cmbBirim.Text = "Bölüm Seçiniz";
            // 
            // dtTar
            // 
            this.dtTar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTar.Location = new System.Drawing.Point(256, 281);
            this.dtTar.Name = "dtTar";
            this.dtTar.Size = new System.Drawing.Size(204, 34);
            this.dtTar.TabIndex = 8;
            this.dtTar.Value = new System.DateTime(2025, 5, 14, 0, 0, 0, 0);
            this.dtTar.ValueChanged += new System.EventHandler(this.dtTar_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 341);
            this.panel1.TabIndex = 0;
            // 
            // lblYidiz2
            // 
            this.lblYidiz2.AutoSize = true;
            this.lblYidiz2.ForeColor = System.Drawing.Color.Red;
            this.lblYidiz2.Location = new System.Drawing.Point(466, 281);
            this.lblYidiz2.Name = "lblYidiz2";
            this.lblYidiz2.Size = new System.Drawing.Size(23, 29);
            this.lblYidiz2.TabIndex = 11;
            this.lblYidiz2.Text = "*";
            this.lblYidiz2.Visible = false;
            // 
            // lblYildiz
            // 
            this.lblYildiz.AutoSize = true;
            this.lblYildiz.ForeColor = System.Drawing.Color.Red;
            this.lblYildiz.Location = new System.Drawing.Point(466, 178);
            this.lblYildiz.Name = "lblYildiz";
            this.lblYildiz.Size = new System.Drawing.Size(23, 29);
            this.lblYildiz.TabIndex = 10;
            this.lblYildiz.Text = "*";
            this.lblYildiz.Visible = false;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEkle.Location = new System.Drawing.Point(12, 359);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(513, 63);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Kayıt Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // KayitEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 427);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "KayitEkleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KayitEkleForm";
            this.Load += new System.EventHandler(this.KayitEkleForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.MaskedTextBox txtTcno;
        private System.Windows.Forms.RadioButton radErkek;
        private System.Windows.Forms.RadioButton radKadin;
        private System.Windows.Forms.DateTimePicker dtTar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblYildiz;
        private System.Windows.Forms.Label lblYidiz2;
        public System.Windows.Forms.ComboBox cmbBirim;
    }
}