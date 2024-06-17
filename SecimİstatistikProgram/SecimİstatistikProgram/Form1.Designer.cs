namespace SecimİstatistikProgram
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
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_ilce = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Aparti = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Bparti = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Cparti = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Dparti = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_Eparti = new System.Windows.Forms.TextBox();
            this.Btn_oy = new System.Windows.Forms.Button();
            this.Btn_cikis = new System.Windows.Forms.Button();
            this.Btn_grafik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İLÇE AD:";
            // 
            // Txt_ilce
            // 
            this.Txt_ilce.Location = new System.Drawing.Point(85, 22);
            this.Txt_ilce.Name = "Txt_ilce";
            this.Txt_ilce.Size = new System.Drawing.Size(218, 20);
            this.Txt_ilce.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "A PARTİ:";
            // 
            // Txt_Aparti
            // 
            this.Txt_Aparti.Location = new System.Drawing.Point(85, 75);
            this.Txt_Aparti.Name = "Txt_Aparti";
            this.Txt_Aparti.Size = new System.Drawing.Size(218, 20);
            this.Txt_Aparti.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "B PARTİ:";
            // 
            // Txt_Bparti
            // 
            this.Txt_Bparti.Location = new System.Drawing.Point(85, 101);
            this.Txt_Bparti.Name = "Txt_Bparti";
            this.Txt_Bparti.Size = new System.Drawing.Size(218, 20);
            this.Txt_Bparti.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "C PARTİ:";
            // 
            // Txt_Cparti
            // 
            this.Txt_Cparti.Location = new System.Drawing.Point(85, 127);
            this.Txt_Cparti.Name = "Txt_Cparti";
            this.Txt_Cparti.Size = new System.Drawing.Size(218, 20);
            this.Txt_Cparti.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "D PARTİ:";
            // 
            // Txt_Dparti
            // 
            this.Txt_Dparti.Location = new System.Drawing.Point(85, 153);
            this.Txt_Dparti.Name = "Txt_Dparti";
            this.Txt_Dparti.Size = new System.Drawing.Size(218, 20);
            this.Txt_Dparti.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "E PARTİ:";
            // 
            // Txt_Eparti
            // 
            this.Txt_Eparti.Location = new System.Drawing.Point(85, 179);
            this.Txt_Eparti.Name = "Txt_Eparti";
            this.Txt_Eparti.Size = new System.Drawing.Size(218, 20);
            this.Txt_Eparti.TabIndex = 1;
            // 
            // Btn_oy
            // 
            this.Btn_oy.Location = new System.Drawing.Point(85, 206);
            this.Btn_oy.Name = "Btn_oy";
            this.Btn_oy.Size = new System.Drawing.Size(218, 23);
            this.Btn_oy.TabIndex = 2;
            this.Btn_oy.Text = "OY GİRİŞİ YAP";
            this.Btn_oy.UseVisualStyleBackColor = true;
            this.Btn_oy.Click += new System.EventHandler(this.Btn_oy_Click);
            // 
            // Btn_cikis
            // 
            this.Btn_cikis.Location = new System.Drawing.Point(197, 235);
            this.Btn_cikis.Name = "Btn_cikis";
            this.Btn_cikis.Size = new System.Drawing.Size(106, 23);
            this.Btn_cikis.TabIndex = 2;
            this.Btn_cikis.Text = "ÇIKIŞ YAP";
            this.Btn_cikis.UseVisualStyleBackColor = true;
            this.Btn_cikis.Click += new System.EventHandler(this.Btn_cikis_Click);
            // 
            // Btn_grafik
            // 
            this.Btn_grafik.Location = new System.Drawing.Point(85, 235);
            this.Btn_grafik.Name = "Btn_grafik";
            this.Btn_grafik.Size = new System.Drawing.Size(106, 23);
            this.Btn_grafik.TabIndex = 3;
            this.Btn_grafik.Text = "GRAFİKLER";
            this.Btn_grafik.UseVisualStyleBackColor = true;
            this.Btn_grafik.Click += new System.EventHandler(this.Btn_grafik_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 279);
            this.Controls.Add(this.Btn_grafik);
            this.Controls.Add(this.Btn_cikis);
            this.Controls.Add(this.Btn_oy);
            this.Controls.Add(this.Txt_Eparti);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txt_Dparti);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_Cparti);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_Bparti);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_Aparti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_ilce);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "VTGS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_ilce;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Aparti;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Bparti;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Cparti;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Dparti;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_Eparti;
        private System.Windows.Forms.Button Btn_oy;
        private System.Windows.Forms.Button Btn_cikis;
        private System.Windows.Forms.Button Btn_grafik;
    }
}

