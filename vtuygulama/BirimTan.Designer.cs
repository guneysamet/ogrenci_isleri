
namespace vtuygulama
{
    partial class BirimTanimlama
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
            this.txtbirimadi = new System.Windows.Forms.TextBox();
            this.txtbirimkodu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btndegistir = new System.Windows.Forms.Button();
            this.btntemizle = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.txtbirimadi);
            this.panel1.Controls.Add(this.txtbirimkodu);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(45, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 183);
            this.panel1.TabIndex = 0;
            // 
            // txtbirimadi
            // 
            this.txtbirimadi.Location = new System.Drawing.Point(173, 99);
            this.txtbirimadi.Multiline = true;
            this.txtbirimadi.Name = "txtbirimadi";
            this.txtbirimadi.Size = new System.Drawing.Size(184, 39);
            this.txtbirimadi.TabIndex = 1;
            // 
            // txtbirimkodu
            // 
            this.txtbirimkodu.Location = new System.Drawing.Point(173, 49);
            this.txtbirimkodu.Multiline = true;
            this.txtbirimkodu.Name = "txtbirimkodu";
            this.txtbirimkodu.Size = new System.Drawing.Size(184, 39);
            this.txtbirimkodu.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(44, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Birim Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(44, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Birim Kodu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(443, 197);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(70, 31);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(132, 50);
            this.btnekle.TabIndex = 3;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(70, 122);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(132, 50);
            this.btnsil.TabIndex = 3;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btndegistir
            // 
            this.btndegistir.Location = new System.Drawing.Point(70, 215);
            this.btndegistir.Name = "btndegistir";
            this.btndegistir.Size = new System.Drawing.Size(132, 50);
            this.btndegistir.TabIndex = 3;
            this.btndegistir.Text = "Değiştir";
            this.btndegistir.UseVisualStyleBackColor = true;
            this.btndegistir.Click += new System.EventHandler(this.btndegistir_Click);
            // 
            // btntemizle
            // 
            this.btntemizle.Location = new System.Drawing.Point(70, 304);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(132, 50);
            this.btntemizle.TabIndex = 3;
            this.btntemizle.Text = "Temizle";
            this.btntemizle.UseVisualStyleBackColor = true;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btnsil);
            this.panel2.Controls.Add(this.btntemizle);
            this.panel2.Controls.Add(this.btndegistir);
            this.panel2.Controls.Add(this.btnekle);
            this.panel2.Location = new System.Drawing.Point(494, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(262, 386);
            this.panel2.TabIndex = 4;
            // 
            // BirimTanimlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "BirimTanimlama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BirimTan";
            this.Load += new System.EventHandler(this.BirimTanimlama_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtbirimadi;
        private System.Windows.Forms.TextBox txtbirimkodu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btndegistir;
        private System.Windows.Forms.Button btntemizle;
        private System.Windows.Forms.Panel panel2;
    }
}