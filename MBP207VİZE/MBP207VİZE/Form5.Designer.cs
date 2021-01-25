namespace MBP207VİZE
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.resKAdi = new System.Windows.Forms.TextBox();
            this.resEposta = new System.Windows.Forms.TextBox();
            this.resLbl1 = new System.Windows.Forms.Label();
            this.resLbl2 = new System.Windows.Forms.Label();
            this.resBtn = new System.Windows.Forms.Button();
            this.gelenKod = new System.Windows.Forms.TextBox();
            this.resLbl3 = new System.Windows.Forms.Label();
            this.dogrulaBtn = new System.Windows.Forms.Button();
            this.geriDonBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resKAdi
            // 
            this.resKAdi.Location = new System.Drawing.Point(299, 206);
            this.resKAdi.Name = "resKAdi";
            this.resKAdi.Size = new System.Drawing.Size(196, 20);
            this.resKAdi.TabIndex = 0;
            // 
            // resEposta
            // 
            this.resEposta.Location = new System.Drawing.Point(299, 232);
            this.resEposta.Name = "resEposta";
            this.resEposta.Size = new System.Drawing.Size(196, 20);
            this.resEposta.TabIndex = 1;
            // 
            // resLbl1
            // 
            this.resLbl1.AutoSize = true;
            this.resLbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.resLbl1.Location = new System.Drawing.Point(182, 206);
            this.resLbl1.Name = "resLbl1";
            this.resLbl1.Size = new System.Drawing.Size(111, 20);
            this.resLbl1.TabIndex = 2;
            this.resLbl1.Text = "Kullanıcı Adı:";
            // 
            // resLbl2
            // 
            this.resLbl2.AutoSize = true;
            this.resLbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.resLbl2.Location = new System.Drawing.Point(199, 232);
            this.resLbl2.Name = "resLbl2";
            this.resLbl2.Size = new System.Drawing.Size(94, 20);
            this.resLbl2.TabIndex = 3;
            this.resLbl2.Text = "Epostanız:";
            // 
            // resBtn
            // 
            this.resBtn.Location = new System.Drawing.Point(299, 258);
            this.resBtn.Name = "resBtn";
            this.resBtn.Size = new System.Drawing.Size(196, 44);
            this.resBtn.TabIndex = 4;
            this.resBtn.Text = "KODU GÖNDER";
            this.resBtn.UseVisualStyleBackColor = true;
            this.resBtn.Click += new System.EventHandler(this.resBtn_Click);
            // 
            // gelenKod
            // 
            this.gelenKod.Location = new System.Drawing.Point(299, 308);
            this.gelenKod.Name = "gelenKod";
            this.gelenKod.Size = new System.Drawing.Size(196, 20);
            this.gelenKod.TabIndex = 5;
            // 
            // resLbl3
            // 
            this.resLbl3.AutoSize = true;
            this.resLbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.resLbl3.Location = new System.Drawing.Point(129, 308);
            this.resLbl3.Name = "resLbl3";
            this.resLbl3.Size = new System.Drawing.Size(164, 20);
            this.resLbl3.TabIndex = 6;
            this.resLbl3.Text = "Gelen Kodu Giriniz:";
            // 
            // dogrulaBtn
            // 
            this.dogrulaBtn.Location = new System.Drawing.Point(299, 334);
            this.dogrulaBtn.Name = "dogrulaBtn";
            this.dogrulaBtn.Size = new System.Drawing.Size(196, 44);
            this.dogrulaBtn.TabIndex = 7;
            this.dogrulaBtn.Text = "DOĞRULA";
            this.dogrulaBtn.UseVisualStyleBackColor = true;
            this.dogrulaBtn.Click += new System.EventHandler(this.dogrulaBtn_Click);
            // 
            // geriDonBtn
            // 
            this.geriDonBtn.Location = new System.Drawing.Point(634, 397);
            this.geriDonBtn.Name = "geriDonBtn";
            this.geriDonBtn.Size = new System.Drawing.Size(154, 41);
            this.geriDonBtn.TabIndex = 8;
            this.geriDonBtn.Text = "GERİ DÖN";
            this.geriDonBtn.UseVisualStyleBackColor = true;
            this.geriDonBtn.Click += new System.EventHandler(this.geriDonBtn_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MBP207VİZE.Properties.Resources.resizedimage;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.geriDonBtn);
            this.Controls.Add(this.dogrulaBtn);
            this.Controls.Add(this.resLbl3);
            this.Controls.Add(this.gelenKod);
            this.Controls.Add(this.resBtn);
            this.Controls.Add(this.resLbl2);
            this.Controls.Add(this.resLbl1);
            this.Controls.Add(this.resEposta);
            this.Controls.Add(this.resKAdi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.Text = "ŞİFREMİ UNUTTUM";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resKAdi;
        private System.Windows.Forms.TextBox resEposta;
        private System.Windows.Forms.Label resLbl1;
        private System.Windows.Forms.Label resLbl2;
        private System.Windows.Forms.Button resBtn;
        private System.Windows.Forms.TextBox gelenKod;
        private System.Windows.Forms.Label resLbl3;
        private System.Windows.Forms.Button dogrulaBtn;
        private System.Windows.Forms.Button geriDonBtn;
    }
}