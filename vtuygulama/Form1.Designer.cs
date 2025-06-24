
namespace vtuygulama
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbBirim = new System.Windows.Forms.ComboBox();
            this.chkbirim = new System.Windows.Forms.CheckBox();
            this.btnara = new System.Windows.Forms.Button();
            this.chksoyad = new System.Windows.Forms.CheckBox();
            this.chkad = new System.Windows.Forms.CheckBox();
            this.txtsoyadara = new System.Windows.Forms.TextBox();
            this.txtadara = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblarananalan = new System.Windows.Forms.Label();
            this.txthizliara = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radsoyad = new System.Windows.Forms.RadioButton();
            this.radad = new System.Windows.Forms.RadioButton();
            this.radbirim = new System.Windows.Forms.RadioButton();
            this.radtcno = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbaramaturu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.btnEkle = new System.Windows.Forms.ToolStripButton();
            this.btnSil = new System.Windows.Forms.ToolStripButton();
            this.btnDegistir = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 67);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(861, 524);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEkle,
            this.toolStripSeparator2,
            this.btnSil,
            this.toolStripSeparator1,
            this.btnDegistir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 620);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1329, 55);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 55);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 55);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.cmbBirim);
            this.groupBox1.Controls.Add(this.chkbirim);
            this.groupBox1.Controls.Add(this.btnara);
            this.groupBox1.Controls.Add(this.chksoyad);
            this.groupBox1.Controls.Add(this.chkad);
            this.groupBox1.Controls.Add(this.txtsoyadara);
            this.groupBox1.Controls.Add(this.txtadara);
            this.groupBox1.Location = new System.Drawing.Point(899, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 224);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Birebir Kayıt Arama";
            // 
            // cmbBirim
            // 
            this.cmbBirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBirim.FormattingEnabled = true;
            this.cmbBirim.Location = new System.Drawing.Point(129, 118);
            this.cmbBirim.Name = "cmbBirim";
            this.cmbBirim.Size = new System.Drawing.Size(230, 37);
            this.cmbBirim.TabIndex = 8;
            this.cmbBirim.Text = "Bölüm Seçiniz";
            // 
            // chkbirim
            // 
            this.chkbirim.AutoSize = true;
            this.chkbirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkbirim.Location = new System.Drawing.Point(17, 118);
            this.chkbirim.Name = "chkbirim";
            this.chkbirim.Size = new System.Drawing.Size(89, 29);
            this.chkbirim.TabIndex = 5;
            this.chkbirim.Text = "Bölüm";
            this.chkbirim.UseVisualStyleBackColor = true;
            this.chkbirim.CheckedChanged += new System.EventHandler(this.chkbirim_CheckedChanged);
            // 
            // btnara
            // 
            this.btnara.Location = new System.Drawing.Point(129, 171);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(120, 42);
            this.btnara.TabIndex = 2;
            this.btnara.Text = "Ara";
            this.btnara.UseVisualStyleBackColor = true;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // chksoyad
            // 
            this.chksoyad.AutoSize = true;
            this.chksoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chksoyad.Location = new System.Drawing.Point(17, 77);
            this.chksoyad.Name = "chksoyad";
            this.chksoyad.Size = new System.Drawing.Size(91, 29);
            this.chksoyad.TabIndex = 3;
            this.chksoyad.Text = "Soyad";
            this.chksoyad.UseVisualStyleBackColor = true;
            this.chksoyad.CheckedChanged += new System.EventHandler(this.chksoyad_CheckedChanged);
            // 
            // chkad
            // 
            this.chkad.AutoSize = true;
            this.chkad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkad.Location = new System.Drawing.Point(17, 34);
            this.chkad.Name = "chkad";
            this.chkad.Size = new System.Drawing.Size(59, 29);
            this.chkad.TabIndex = 1;
            this.chkad.Text = "Ad";
            this.chkad.UseVisualStyleBackColor = true;
            this.chkad.CheckedChanged += new System.EventHandler(this.chkad_CheckedChanged);
            // 
            // txtsoyadara
            // 
            this.txtsoyadara.Enabled = false;
            this.txtsoyadara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsoyadara.Location = new System.Drawing.Point(129, 73);
            this.txtsoyadara.Multiline = true;
            this.txtsoyadara.Name = "txtsoyadara";
            this.txtsoyadara.Size = new System.Drawing.Size(230, 37);
            this.txtsoyadara.TabIndex = 4;
            // 
            // txtadara
            // 
            this.txtadara.Enabled = false;
            this.txtadara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtadara.Location = new System.Drawing.Point(129, 26);
            this.txtadara.Multiline = true;
            this.txtadara.Name = "txtadara";
            this.txtadara.Size = new System.Drawing.Size(230, 37);
            this.txtadara.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.lblarananalan);
            this.groupBox2.Controls.Add(this.txthizliara);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbaramaturu);
            this.groupBox2.Location = new System.Drawing.Point(899, 306);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 285);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hızlı Arama";
            // 
            // lblarananalan
            // 
            this.lblarananalan.AutoSize = true;
            this.lblarananalan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblarananalan.Location = new System.Drawing.Point(12, 244);
            this.lblarananalan.Name = "lblarananalan";
            this.lblarananalan.Size = new System.Drawing.Size(70, 25);
            this.lblarananalan.TabIndex = 4;
            this.lblarananalan.Text = "TC No";
            // 
            // txthizliara
            // 
            this.txthizliara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txthizliara.Location = new System.Drawing.Point(153, 239);
            this.txthizliara.Name = "txthizliara";
            this.txthizliara.Size = new System.Drawing.Size(183, 30);
            this.txthizliara.TabIndex = 3;
            this.txthizliara.TextChanged += new System.EventHandler(this.txthizliara_TextChanged_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.radsoyad);
            this.panel1.Controls.Add(this.radad);
            this.panel1.Controls.Add(this.radbirim);
            this.panel1.Controls.Add(this.radtcno);
            this.panel1.Location = new System.Drawing.Point(11, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 159);
            this.panel1.TabIndex = 2;
            // 
            // radsoyad
            // 
            this.radsoyad.AutoSize = true;
            this.radsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radsoyad.Location = new System.Drawing.Point(157, 70);
            this.radsoyad.Name = "radsoyad";
            this.radsoyad.Size = new System.Drawing.Size(90, 29);
            this.radsoyad.TabIndex = 2;
            this.radsoyad.TabStop = true;
            this.radsoyad.Text = "Soyad";
            this.radsoyad.UseVisualStyleBackColor = true;
            this.radsoyad.CheckedChanged += new System.EventHandler(this.radsoyad_CheckedChanged);
            // 
            // radad
            // 
            this.radad.AutoSize = true;
            this.radad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radad.Location = new System.Drawing.Point(7, 70);
            this.radad.Name = "radad";
            this.radad.Size = new System.Drawing.Size(58, 29);
            this.radad.TabIndex = 2;
            this.radad.TabStop = true;
            this.radad.Text = "Ad";
            this.radad.UseVisualStyleBackColor = true;
            this.radad.CheckedChanged += new System.EventHandler(this.radad_CheckedChanged);
            // 
            // radbirim
            // 
            this.radbirim.AutoSize = true;
            this.radbirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radbirim.Location = new System.Drawing.Point(157, 18);
            this.radbirim.Name = "radbirim";
            this.radbirim.Size = new System.Drawing.Size(88, 29);
            this.radbirim.TabIndex = 1;
            this.radbirim.TabStop = true;
            this.radbirim.Text = "Bölüm";
            this.radbirim.UseVisualStyleBackColor = true;
            this.radbirim.CheckedChanged += new System.EventHandler(this.radbirim_CheckedChanged);
            // 
            // radtcno
            // 
            this.radtcno.AutoSize = true;
            this.radtcno.Checked = true;
            this.radtcno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radtcno.Location = new System.Drawing.Point(6, 18);
            this.radtcno.Name = "radtcno";
            this.radtcno.Size = new System.Drawing.Size(91, 29);
            this.radtcno.TabIndex = 0;
            this.radtcno.TabStop = true;
            this.radtcno.Text = "TC No";
            this.radtcno.UseVisualStyleBackColor = true;
            this.radtcno.CheckedChanged += new System.EventHandler(this.radtcno_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Arama Türü";
            // 
            // cmbaramaturu
            // 
            this.cmbaramaturu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbaramaturu.FormattingEnabled = true;
            this.cmbaramaturu.Items.AddRange(new object[] {
            "İle Başlayan",
            "İle Biten",
            "İçeren"});
            this.cmbaramaturu.Location = new System.Drawing.Point(143, 35);
            this.cmbaramaturu.Name = "cmbaramaturu";
            this.cmbaramaturu.Size = new System.Drawing.Size(193, 33);
            this.cmbaramaturu.TabIndex = 0;
            this.cmbaramaturu.Text = "Seçiniz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kullanıcı ve Birim İşlemleri";
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator3,
            this.toolStripButton2,
            this.toolStripSeparator4});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1329, 55);
            this.toolStrip2.TabIndex = 6;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 55);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 55);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripButton1.Image = global::vtuygulama.Properties.Resources.pngegg;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(94, 52);
            this.toolStripButton1.Text = "Bölümler";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripButton2.Image = global::vtuygulama.Properties.Resources.pngwing_com;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(111, 52);
            this.toolStripButton2.Text = "Kullanıcılar";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Image = global::vtuygulama.Properties.Resources.pngwing_com__3_;
            this.btnEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 52);
            this.btnEkle.Text = "Kayıt Ekle";
            this.btnEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Image = global::vtuygulama.Properties.Resources.pngwing_com__2_;
            this.btnSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(86, 52);
            this.btnSil.Text = "Kayıt Sil";
            this.btnSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDegistir
            // 
            this.btnDegistir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDegistir.Image = global::vtuygulama.Properties.Resources.pngwing_com__1_;
            this.btnDegistir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(133, 52);
            this.btnDegistir.Text = "Kayit Değiştir";
            this.btnDegistir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 675);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VT Uygulama";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnEkle;
        private System.Windows.Forms.ToolStripButton btnSil;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnDegistir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.CheckBox chksoyad;
        private System.Windows.Forms.CheckBox chkad;
        private System.Windows.Forms.TextBox txtsoyadara;
        private System.Windows.Forms.TextBox txtadara;
        private System.Windows.Forms.CheckBox chkbirim;
        public System.Windows.Forms.ComboBox cmbBirim;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblarananalan;
        private System.Windows.Forms.TextBox txthizliara;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radtcno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbaramaturu;
        private System.Windows.Forms.RadioButton radbirim;
        private System.Windows.Forms.RadioButton radsoyad;
        private System.Windows.Forms.RadioButton radad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}

