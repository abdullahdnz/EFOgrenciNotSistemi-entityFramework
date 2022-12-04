
namespace EFOgrenci
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
            this.btnOgrList = new System.Windows.Forms.Button();
            this.btnOgrEkle = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDersList = new System.Windows.Forms.Button();
            this.btnNotList = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFoto = new System.Windows.Forms.TextBox();
            this.txtOgrSoyad = new System.Windows.Forms.TextBox();
            this.txtOgrAdi = new System.Windows.Forms.TextBox();
            this.txtOgrID = new System.Windows.Forms.TextBox();
            this.lblFoto = new System.Windows.Forms.Label();
            this.lblOgrSoyad = new System.Windows.Forms.Label();
            this.lblOgrAdi = new System.Windows.Forms.Label();
            this.lblOgrID = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDersAdi = new System.Windows.Forms.TextBox();
            this.lblDersID = new System.Windows.Forms.Label();
            this.txtDersID = new System.Windows.Forms.TextBox();
            this.lblDersAdi = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnNotEkle = new System.Windows.Forms.Button();
            this.txtDurum = new System.Windows.Forms.TextBox();
            this.lblDurum = new System.Windows.Forms.Label();
            this.txtOrtalama = new System.Windows.Forms.TextBox();
            this.txtSinav3 = new System.Windows.Forms.TextBox();
            this.txtSinav2 = new System.Windows.Forms.TextBox();
            this.txtSinav1 = new System.Windows.Forms.TextBox();
            this.lblOrtalama = new System.Windows.Forms.Label();
            this.lblSinav3 = new System.Windows.Forms.Label();
            this.lblSinav2 = new System.Windows.Forms.Label();
            this.lblSinav1 = new System.Windows.Forms.Label();
            this.btnDersEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 178);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnOgrList
            // 
            this.btnOgrList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOgrList.Location = new System.Drawing.Point(-3, 197);
            this.btnOgrList.Name = "btnOgrList";
            this.btnOgrList.Size = new System.Drawing.Size(119, 30);
            this.btnOgrList.TabIndex = 1;
            this.btnOgrList.Text = "Öğrenci Listele";
            this.btnOgrList.UseVisualStyleBackColor = true;
            this.btnOgrList.Click += new System.EventHandler(this.btnOgrList_Click);
            // 
            // btnOgrEkle
            // 
            this.btnOgrEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOgrEkle.Location = new System.Drawing.Point(-3, 226);
            this.btnOgrEkle.Name = "btnOgrEkle";
            this.btnOgrEkle.Size = new System.Drawing.Size(119, 30);
            this.btnOgrEkle.TabIndex = 2;
            this.btnOgrEkle.Text = "Öğrenci Ekle";
            this.btnOgrEkle.UseVisualStyleBackColor = true;
            this.btnOgrEkle.Click += new System.EventHandler(this.btnOgrEkle_Click);
            // 
            // btnAra
            // 
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAra.Location = new System.Drawing.Point(-3, 255);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(119, 30);
            this.btnAra.TabIndex = 3;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle.Location = new System.Drawing.Point(-3, 284);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(119, 30);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.Location = new System.Drawing.Point(-3, 313);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(119, 30);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDersList
            // 
            this.btnDersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDersList.Location = new System.Drawing.Point(-3, 342);
            this.btnDersList.Name = "btnDersList";
            this.btnDersList.Size = new System.Drawing.Size(119, 30);
            this.btnDersList.TabIndex = 6;
            this.btnDersList.Text = "Ders Listele";
            this.btnDersList.UseVisualStyleBackColor = true;
            this.btnDersList.Click += new System.EventHandler(this.btnDersList_Click);
            // 
            // btnNotList
            // 
            this.btnNotList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotList.Location = new System.Drawing.Point(-3, 371);
            this.btnNotList.Name = "btnNotList";
            this.btnNotList.Size = new System.Drawing.Size(119, 30);
            this.btnNotList.TabIndex = 7;
            this.btnNotList.Text = "Not Listele";
            this.btnNotList.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFoto);
            this.groupBox1.Controls.Add(this.txtOgrSoyad);
            this.groupBox1.Controls.Add(this.txtOgrAdi);
            this.groupBox1.Controls.Add(this.txtOgrID);
            this.groupBox1.Controls.Add(this.lblFoto);
            this.groupBox1.Controls.Add(this.lblOgrSoyad);
            this.groupBox1.Controls.Add(this.lblOgrAdi);
            this.groupBox1.Controls.Add(this.lblOgrID);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(182, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 175);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci";
            // 
            // txtFoto
            // 
            this.txtFoto.Location = new System.Drawing.Point(79, 115);
            this.txtFoto.Name = "txtFoto";
            this.txtFoto.Size = new System.Drawing.Size(100, 22);
            this.txtFoto.TabIndex = 7;
            // 
            // txtOgrSoyad
            // 
            this.txtOgrSoyad.Location = new System.Drawing.Point(79, 87);
            this.txtOgrSoyad.Name = "txtOgrSoyad";
            this.txtOgrSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtOgrSoyad.TabIndex = 6;
            // 
            // txtOgrAdi
            // 
            this.txtOgrAdi.Location = new System.Drawing.Point(79, 58);
            this.txtOgrAdi.Name = "txtOgrAdi";
            this.txtOgrAdi.Size = new System.Drawing.Size(100, 22);
            this.txtOgrAdi.TabIndex = 5;
            // 
            // txtOgrID
            // 
            this.txtOgrID.Location = new System.Drawing.Point(79, 29);
            this.txtOgrID.Name = "txtOgrID";
            this.txtOgrID.Size = new System.Drawing.Size(100, 22);
            this.txtOgrID.TabIndex = 4;
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoto.Location = new System.Drawing.Point(42, 118);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(39, 15);
            this.lblFoto.TabIndex = 3;
            this.lblFoto.Text = "Foto:";
            // 
            // lblOgrSoyad
            // 
            this.lblOgrSoyad.AutoSize = true;
            this.lblOgrSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOgrSoyad.Location = new System.Drawing.Point(29, 90);
            this.lblOgrSoyad.Name = "lblOgrSoyad";
            this.lblOgrSoyad.Size = new System.Drawing.Size(50, 15);
            this.lblOgrSoyad.TabIndex = 2;
            this.lblOgrSoyad.Text = "Soyad:";
            // 
            // lblOgrAdi
            // 
            this.lblOgrAdi.AutoSize = true;
            this.lblOgrAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOgrAdi.Location = new System.Drawing.Point(52, 61);
            this.lblOgrAdi.Name = "lblOgrAdi";
            this.lblOgrAdi.Size = new System.Drawing.Size(27, 15);
            this.lblOgrAdi.TabIndex = 1;
            this.lblOgrAdi.Text = "Ad:";
            // 
            // lblOgrID
            // 
            this.lblOgrID.AutoSize = true;
            this.lblOgrID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOgrID.Location = new System.Drawing.Point(56, 32);
            this.lblOgrID.Name = "lblOgrID";
            this.lblOgrID.Size = new System.Drawing.Size(25, 15);
            this.lblOgrID.TabIndex = 0;
            this.lblOgrID.Text = "ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDersAdi);
            this.groupBox2.Controls.Add(this.lblDersID);
            this.groupBox2.Controls.Add(this.txtDersID);
            this.groupBox2.Controls.Add(this.lblDersAdi);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(182, 398);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dersler";
            // 
            // txtDersAdi
            // 
            this.txtDersAdi.Location = new System.Drawing.Point(75, 55);
            this.txtDersAdi.Name = "txtDersAdi";
            this.txtDersAdi.Size = new System.Drawing.Size(100, 22);
            this.txtDersAdi.TabIndex = 11;
            // 
            // lblDersID
            // 
            this.lblDersID.AutoSize = true;
            this.lblDersID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDersID.Location = new System.Drawing.Point(15, 29);
            this.lblDersID.Name = "lblDersID";
            this.lblDersID.Size = new System.Drawing.Size(59, 15);
            this.lblDersID.TabIndex = 8;
            this.lblDersID.Text = "Ders ID:";
            // 
            // txtDersID
            // 
            this.txtDersID.Location = new System.Drawing.Point(75, 26);
            this.txtDersID.Name = "txtDersID";
            this.txtDersID.Size = new System.Drawing.Size(100, 22);
            this.txtDersID.TabIndex = 10;
            // 
            // lblDersAdi
            // 
            this.lblDersAdi.AutoSize = true;
            this.lblDersAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDersAdi.Location = new System.Drawing.Point(9, 58);
            this.lblDersAdi.Name = "lblDersAdi";
            this.lblDersAdi.Size = new System.Drawing.Size(65, 15);
            this.lblDersAdi.TabIndex = 9;
            this.lblDersAdi.Text = "Ders Adı:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnNotEkle);
            this.groupBox3.Controls.Add(this.txtDurum);
            this.groupBox3.Controls.Add(this.lblDurum);
            this.groupBox3.Controls.Add(this.txtOrtalama);
            this.groupBox3.Controls.Add(this.txtSinav3);
            this.groupBox3.Controls.Add(this.txtSinav2);
            this.groupBox3.Controls.Add(this.txtSinav1);
            this.groupBox3.Controls.Add(this.lblOrtalama);
            this.groupBox3.Controls.Add(this.lblSinav3);
            this.groupBox3.Controls.Add(this.lblSinav2);
            this.groupBox3.Controls.Add(this.lblSinav1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(437, 197);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 245);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Notlar";
            // 
            // btnNotEkle
            // 
            this.btnNotEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotEkle.Location = new System.Drawing.Point(39, 189);
            this.btnNotEkle.Name = "btnNotEkle";
            this.btnNotEkle.Size = new System.Drawing.Size(119, 30);
            this.btnNotEkle.TabIndex = 11;
            this.btnNotEkle.Text = "Not Ekle";
            this.btnNotEkle.UseVisualStyleBackColor = true;
            this.btnNotEkle.Click += new System.EventHandler(this.btnNotEkle_Click);
            // 
            // txtDurum
            // 
            this.txtDurum.Location = new System.Drawing.Point(75, 146);
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Size = new System.Drawing.Size(100, 22);
            this.txtDurum.TabIndex = 17;
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDurum.Location = new System.Drawing.Point(21, 149);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(54, 15);
            this.lblDurum.TabIndex = 16;
            this.lblDurum.Text = "Durum:";
            // 
            // txtOrtalama
            // 
            this.txtOrtalama.Location = new System.Drawing.Point(75, 118);
            this.txtOrtalama.Name = "txtOrtalama";
            this.txtOrtalama.Size = new System.Drawing.Size(100, 22);
            this.txtOrtalama.TabIndex = 15;
            // 
            // txtSinav3
            // 
            this.txtSinav3.Location = new System.Drawing.Point(75, 90);
            this.txtSinav3.Name = "txtSinav3";
            this.txtSinav3.Size = new System.Drawing.Size(100, 22);
            this.txtSinav3.TabIndex = 14;
            // 
            // txtSinav2
            // 
            this.txtSinav2.Location = new System.Drawing.Point(75, 61);
            this.txtSinav2.Name = "txtSinav2";
            this.txtSinav2.Size = new System.Drawing.Size(100, 22);
            this.txtSinav2.TabIndex = 13;
            // 
            // txtSinav1
            // 
            this.txtSinav1.Location = new System.Drawing.Point(75, 32);
            this.txtSinav1.Name = "txtSinav1";
            this.txtSinav1.Size = new System.Drawing.Size(100, 22);
            this.txtSinav1.TabIndex = 12;
            // 
            // lblOrtalama
            // 
            this.lblOrtalama.AutoSize = true;
            this.lblOrtalama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrtalama.Location = new System.Drawing.Point(5, 121);
            this.lblOrtalama.Name = "lblOrtalama";
            this.lblOrtalama.Size = new System.Drawing.Size(70, 15);
            this.lblOrtalama.TabIndex = 11;
            this.lblOrtalama.Text = "Ortalama:";
            // 
            // lblSinav3
            // 
            this.lblSinav3.AutoSize = true;
            this.lblSinav3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinav3.Location = new System.Drawing.Point(21, 93);
            this.lblSinav3.Name = "lblSinav3";
            this.lblSinav3.Size = new System.Drawing.Size(54, 15);
            this.lblSinav3.TabIndex = 10;
            this.lblSinav3.Text = "Sınav3:";
            // 
            // lblSinav2
            // 
            this.lblSinav2.AutoSize = true;
            this.lblSinav2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinav2.Location = new System.Drawing.Point(21, 64);
            this.lblSinav2.Name = "lblSinav2";
            this.lblSinav2.Size = new System.Drawing.Size(54, 15);
            this.lblSinav2.TabIndex = 9;
            this.lblSinav2.Text = "Sınav2:";
            // 
            // lblSinav1
            // 
            this.lblSinav1.AutoSize = true;
            this.lblSinav1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinav1.Location = new System.Drawing.Point(21, 35);
            this.lblSinav1.Name = "lblSinav1";
            this.lblSinav1.Size = new System.Drawing.Size(54, 15);
            this.lblSinav1.TabIndex = 8;
            this.lblSinav1.Text = "Sınav1:";
            // 
            // btnDersEkle
            // 
            this.btnDersEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDersEkle.Location = new System.Drawing.Point(-3, 398);
            this.btnDersEkle.Name = "btnDersEkle";
            this.btnDersEkle.Size = new System.Drawing.Size(119, 30);
            this.btnDersEkle.TabIndex = 10;
            this.btnDersEkle.Text = "Ders Ekle";
            this.btnDersEkle.UseVisualStyleBackColor = true;
            this.btnDersEkle.Click += new System.EventHandler(this.btnDersEkle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.btnDersEkle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNotList);
            this.Controls.Add(this.btnDersList);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.btnOgrEkle);
            this.Controls.Add(this.btnOgrList);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnOgrList;
        private System.Windows.Forms.Button btnOgrEkle;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDersList;
        private System.Windows.Forms.Button btnNotList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtFoto;
        private System.Windows.Forms.TextBox txtOgrSoyad;
        private System.Windows.Forms.TextBox txtOgrAdi;
        private System.Windows.Forms.TextBox txtOgrID;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.Label lblOgrSoyad;
        private System.Windows.Forms.Label lblOgrAdi;
        private System.Windows.Forms.Label lblOgrID;
        private System.Windows.Forms.TextBox txtDersAdi;
        private System.Windows.Forms.Label lblDersID;
        private System.Windows.Forms.TextBox txtDersID;
        private System.Windows.Forms.Label lblDersAdi;
        private System.Windows.Forms.TextBox txtDurum;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.TextBox txtOrtalama;
        private System.Windows.Forms.TextBox txtSinav3;
        private System.Windows.Forms.TextBox txtSinav2;
        private System.Windows.Forms.TextBox txtSinav1;
        private System.Windows.Forms.Label lblOrtalama;
        private System.Windows.Forms.Label lblSinav3;
        private System.Windows.Forms.Label lblSinav2;
        private System.Windows.Forms.Label lblSinav1;
        private System.Windows.Forms.Button btnNotEkle;
        private System.Windows.Forms.Button btnDersEkle;
    }
}

