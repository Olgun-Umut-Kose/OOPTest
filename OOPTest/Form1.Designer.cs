
namespace OOPTest
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbTasit = new System.Windows.Forms.CheckBox();
            this.cbKonut = new System.Windows.Forms.CheckBox();
            this.cbIhtiyac = new System.Windows.Forms.CheckBox();
            this.rbTasit = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbIhtiyac = new System.Windows.Forms.RadioButton();
            this.rbKonut = new System.Windows.Forms.RadioButton();
            this.btnKredi = new System.Windows.Forms.Button();
            this.btnOnBilgi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbTasit
            // 
            this.cbTasit.AutoSize = true;
            this.cbTasit.Location = new System.Drawing.Point(6, 19);
            this.cbTasit.Name = "cbTasit";
            this.cbTasit.Size = new System.Drawing.Size(83, 17);
            this.cbTasit.TabIndex = 0;
            this.cbTasit.Text = "Taşıt Kredisi";
            this.cbTasit.UseVisualStyleBackColor = true;
            this.cbTasit.CheckedChanged += new System.EventHandler(this.cbTasit_CheckedChanged);
            // 
            // cbKonut
            // 
            this.cbKonut.AutoSize = true;
            this.cbKonut.Location = new System.Drawing.Point(6, 42);
            this.cbKonut.Name = "cbKonut";
            this.cbKonut.Size = new System.Drawing.Size(88, 17);
            this.cbKonut.TabIndex = 1;
            this.cbKonut.Text = "Konut Kredisi";
            this.cbKonut.UseVisualStyleBackColor = true;
            this.cbKonut.CheckedChanged += new System.EventHandler(this.cbKonut_CheckedChanged);
            // 
            // cbIhtiyac
            // 
            this.cbIhtiyac.AutoSize = true;
            this.cbIhtiyac.Location = new System.Drawing.Point(6, 65);
            this.cbIhtiyac.Name = "cbIhtiyac";
            this.cbIhtiyac.Size = new System.Drawing.Size(91, 17);
            this.cbIhtiyac.TabIndex = 2;
            this.cbIhtiyac.Text = "İhtiyaç Kredisi";
            this.cbIhtiyac.UseVisualStyleBackColor = true;
            this.cbIhtiyac.CheckedChanged += new System.EventHandler(this.cbIhtiyac_CheckedChanged);
            // 
            // rbTasit
            // 
            this.rbTasit.AutoSize = true;
            this.rbTasit.Location = new System.Drawing.Point(6, 19);
            this.rbTasit.Name = "rbTasit";
            this.rbTasit.Size = new System.Drawing.Size(82, 17);
            this.rbTasit.TabIndex = 3;
            this.rbTasit.TabStop = true;
            this.rbTasit.Text = "Taşıt Kredisi";
            this.rbTasit.UseVisualStyleBackColor = true;
            this.rbTasit.CheckedChanged += new System.EventHandler(this.rbTasit_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbTasit);
            this.groupBox1.Controls.Add(this.cbKonut);
            this.groupBox1.Controls.Add(this.cbIhtiyac);
            this.groupBox1.Location = new System.Drawing.Point(535, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 315);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ÖnBilgilendirilecek Kredileri Seçiniz ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbIhtiyac);
            this.groupBox2.Controls.Add(this.rbKonut);
            this.groupBox2.Controls.Add(this.rbTasit);
            this.groupBox2.Location = new System.Drawing.Point(2, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 320);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kredi Seçiniz";
            // 
            // rbIhtiyac
            // 
            this.rbIhtiyac.AutoSize = true;
            this.rbIhtiyac.Location = new System.Drawing.Point(6, 64);
            this.rbIhtiyac.Name = "rbIhtiyac";
            this.rbIhtiyac.Size = new System.Drawing.Size(90, 17);
            this.rbIhtiyac.TabIndex = 5;
            this.rbIhtiyac.TabStop = true;
            this.rbIhtiyac.Text = "İhtiyaç Kredisi";
            this.rbIhtiyac.UseVisualStyleBackColor = true;
            this.rbIhtiyac.CheckedChanged += new System.EventHandler(this.rbIhtiyac_CheckedChanged);
            // 
            // rbKonut
            // 
            this.rbKonut.AutoSize = true;
            this.rbKonut.Location = new System.Drawing.Point(6, 41);
            this.rbKonut.Name = "rbKonut";
            this.rbKonut.Size = new System.Drawing.Size(87, 17);
            this.rbKonut.TabIndex = 4;
            this.rbKonut.TabStop = true;
            this.rbKonut.Text = "Konut Kredisi";
            this.rbKonut.UseVisualStyleBackColor = true;
            this.rbKonut.CheckedChanged += new System.EventHandler(this.rbKonut_CheckedChanged);
            // 
            // btnKredi
            // 
            this.btnKredi.Location = new System.Drawing.Point(2, 338);
            this.btnKredi.Name = "btnKredi";
            this.btnKredi.Size = new System.Drawing.Size(229, 34);
            this.btnKredi.TabIndex = 5;
            this.btnKredi.Text = "Kredi Hesapla";
            this.btnKredi.UseVisualStyleBackColor = true;
            this.btnKredi.Click += new System.EventHandler(this.btnKredi_Click);
            // 
            // btnOnBilgi
            // 
            this.btnOnBilgi.Location = new System.Drawing.Point(535, 333);
            this.btnOnBilgi.Name = "btnOnBilgi";
            this.btnOnBilgi.Size = new System.Drawing.Size(262, 34);
            this.btnOnBilgi.TabIndex = 6;
            this.btnOnBilgi.Text = "Ön Bilgilendir";
            this.btnOnBilgi.UseVisualStyleBackColor = true;
            this.btnOnBilgi.Click += new System.EventHandler(this.btnOnBilgi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOnBilgi);
            this.Controls.Add(this.btnKredi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cbTasit;
        private System.Windows.Forms.CheckBox cbKonut;
        private System.Windows.Forms.CheckBox cbIhtiyac;
        private System.Windows.Forms.RadioButton rbTasit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbIhtiyac;
        private System.Windows.Forms.RadioButton rbKonut;
        private System.Windows.Forms.Button btnKredi;
        private System.Windows.Forms.Button btnOnBilgi;
    }
}

