
namespace vtuygulama
{
    partial class Kullaniciislemform
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
            this.btnyenik = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btntemizle = new System.Windows.Forms.Button();
            this.btnksil = new System.Windows.Forms.Button();
            this.btnsdegistir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbkturu = new System.Windows.Forms.ComboBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.txtkadi = new System.Windows.Forms.TextBox();
            this.txtkkod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblkadi = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblkturu = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(429, 412);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btnyenik
            // 
            this.btnyenik.Location = new System.Drawing.Point(6, 44);
            this.btnyenik.Name = "btnyenik";
            this.btnyenik.Size = new System.Drawing.Size(132, 48);
            this.btnyenik.TabIndex = 1;
            this.btnyenik.Text = "Yeni kullanıcı ";
            this.btnyenik.UseVisualStyleBackColor = true;
            this.btnyenik.Click += new System.EventHandler(this.btnyenik_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btntemizle);
            this.groupBox1.Controls.Add(this.btnksil);
            this.groupBox1.Controls.Add(this.btnsdegistir);
            this.groupBox1.Controls.Add(this.btnyenik);
            this.groupBox1.Location = new System.Drawing.Point(453, 264);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 160);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "işlemler";
            // 
            // btntemizle
            // 
            this.btntemizle.Location = new System.Drawing.Point(161, 98);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(135, 48);
            this.btntemizle.TabIndex = 1;
            this.btntemizle.Text = "Temizle";
            this.btntemizle.UseVisualStyleBackColor = true;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // btnksil
            // 
            this.btnksil.Location = new System.Drawing.Point(161, 44);
            this.btnksil.Name = "btnksil";
            this.btnksil.Size = new System.Drawing.Size(135, 48);
            this.btnksil.TabIndex = 1;
            this.btnksil.Text = "Kullanıcı sil";
            this.btnksil.UseVisualStyleBackColor = true;
            this.btnksil.Click += new System.EventHandler(this.btnksil_Click);
            // 
            // btnsdegistir
            // 
            this.btnsdegistir.Location = new System.Drawing.Point(6, 98);
            this.btnsdegistir.Name = "btnsdegistir";
            this.btnsdegistir.Size = new System.Drawing.Size(132, 48);
            this.btnsdegistir.TabIndex = 1;
            this.btnsdegistir.Text = "Şifre değiştir";
            this.btnsdegistir.UseVisualStyleBackColor = true;
            this.btnsdegistir.Click += new System.EventHandler(this.btnsdegistir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.cmbkturu);
            this.groupBox2.Controls.Add(this.txtsifre);
            this.groupBox2.Controls.Add(this.txtkadi);
            this.groupBox2.Controls.Add(this.txtkkod);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(453, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 246);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kullanici Bilgileri";
            // 
            // cmbkturu
            // 
            this.cmbkturu.FormattingEnabled = true;
            this.cmbkturu.Items.AddRange(new object[] {
            "Yönetici",
            "Kullanıcı"});
            this.cmbkturu.Location = new System.Drawing.Point(161, 196);
            this.cmbkturu.Name = "cmbkturu";
            this.cmbkturu.Size = new System.Drawing.Size(142, 24);
            this.cmbkturu.TabIndex = 4;
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(167, 141);
            this.txtsifre.Multiline = true;
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(129, 34);
            this.txtsifre.TabIndex = 3;
            // 
            // txtkadi
            // 
            this.txtkadi.Location = new System.Drawing.Point(167, 93);
            this.txtkadi.Multiline = true;
            this.txtkadi.Name = "txtkadi";
            this.txtkadi.Size = new System.Drawing.Size(129, 34);
            this.txtkadi.TabIndex = 2;
            // 
            // txtkkod
            // 
            this.txtkkod.Location = new System.Drawing.Point(167, 32);
            this.txtkkod.Multiline = true;
            this.txtkkod.Name = "txtkkod";
            this.txtkkod.Size = new System.Drawing.Size(129, 34);
            this.txtkkod.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(25, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kullanıcı Türü";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(25, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Şifre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(25, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "K.Kodu";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblkadi,
            this.toolStripStatusLabel4,
            this.lblkturu});
            this.statusStrip1.Location = new System.Drawing.Point(0, 451);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(809, 26);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(93, 20);
            this.toolStripStatusLabel1.Text = "Kullanıcı adı:";
            // 
            // lblkadi
            // 
            this.lblkadi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblkadi.Name = "lblkadi";
            this.lblkadi.Size = new System.Drawing.Size(55, 20);
            this.lblkadi.Text = "lblkadi";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(101, 20);
            this.toolStripStatusLabel4.Text = "Kullanıcı Türü:";
            // 
            // lblkturu
            // 
            this.lblkturu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblkturu.Name = "lblkturu";
            this.lblkturu.Size = new System.Drawing.Size(64, 20);
            this.lblkturu.Text = "lblkturu";
            // 
            // Kullaniciislemform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 477);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Kullaniciislemform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kullaniciislemform";
            this.Load += new System.EventHandler(this.Kullaniciislemform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnyenik;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btntemizle;
        private System.Windows.Forms.Button btnksil;
        private System.Windows.Forms.Button btnsdegistir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtkkod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.TextBox txtkadi;
        private System.Windows.Forms.ComboBox cmbkturu;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblkadi;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel lblkturu;
    }
}