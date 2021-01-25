namespace MBP207VİZE
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.kAdiTxtB = new System.Windows.Forms.TextBox();
            this.sifreKayitTxt = new System.Windows.Forms.TextBox();
            this.epostaKytTxt = new System.Windows.Forms.TextBox();
            this.kayitOlBtn = new System.Windows.Forms.Button();
            this.kAdiKayit = new System.Windows.Forms.Label();
            this.sifreKayit = new System.Windows.Forms.Label();
            this.epostaKayit = new System.Windows.Forms.Label();
            this.geriDonBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kAdiTxtB
            // 
            this.kAdiTxtB.Location = new System.Drawing.Point(320, 193);
            this.kAdiTxtB.Name = "kAdiTxtB";
            this.kAdiTxtB.Size = new System.Drawing.Size(162, 20);
            this.kAdiTxtB.TabIndex = 0;
            this.kAdiTxtB.TextChanged += new System.EventHandler(this.kAdiTxtB_TextChanged);
            // 
            // sifreKayitTxt
            // 
            this.sifreKayitTxt.Location = new System.Drawing.Point(320, 219);
            this.sifreKayitTxt.Name = "sifreKayitTxt";
            this.sifreKayitTxt.Size = new System.Drawing.Size(162, 20);
            this.sifreKayitTxt.TabIndex = 1;
            // 
            // epostaKytTxt
            // 
            this.epostaKytTxt.Location = new System.Drawing.Point(320, 245);
            this.epostaKytTxt.Name = "epostaKytTxt";
            this.epostaKytTxt.Size = new System.Drawing.Size(162, 20);
            this.epostaKytTxt.TabIndex = 2;
            // 
            // kayitOlBtn
            // 
            this.kayitOlBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayitOlBtn.Image = global::MBP207VİZE.Properties.Resources.Pokeball_30px;
            this.kayitOlBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kayitOlBtn.Location = new System.Drawing.Point(320, 271);
            this.kayitOlBtn.Name = "kayitOlBtn";
            this.kayitOlBtn.Size = new System.Drawing.Size(162, 45);
            this.kayitOlBtn.TabIndex = 3;
            this.kayitOlBtn.Text = "KAYIT OL";
            this.kayitOlBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.kayitOlBtn.UseVisualStyleBackColor = true;
            this.kayitOlBtn.Click += new System.EventHandler(this.kayitOlBtn_Click);
            // 
            // kAdiKayit
            // 
            this.kAdiKayit.AutoSize = true;
            this.kAdiKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kAdiKayit.Location = new System.Drawing.Point(203, 193);
            this.kAdiKayit.Name = "kAdiKayit";
            this.kAdiKayit.Size = new System.Drawing.Size(111, 20);
            this.kAdiKayit.TabIndex = 4;
            this.kAdiKayit.Text = "Kullanıcı Adı:";
            // 
            // sifreKayit
            // 
            this.sifreKayit.AutoSize = true;
            this.sifreKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreKayit.Location = new System.Drawing.Point(262, 219);
            this.sifreKayit.Name = "sifreKayit";
            this.sifreKayit.Size = new System.Drawing.Size(52, 20);
            this.sifreKayit.TabIndex = 5;
            this.sifreKayit.Text = "Şifre:";
            // 
            // epostaKayit
            // 
            this.epostaKayit.AutoSize = true;
            this.epostaKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.epostaKayit.Location = new System.Drawing.Point(243, 245);
            this.epostaKayit.Name = "epostaKayit";
            this.epostaKayit.Size = new System.Drawing.Size(71, 20);
            this.epostaKayit.TabIndex = 6;
            this.epostaKayit.Text = "Eposta:";
            // 
            // geriDonBtn
            // 
            this.geriDonBtn.Location = new System.Drawing.Point(629, 398);
            this.geriDonBtn.Name = "geriDonBtn";
            this.geriDonBtn.Size = new System.Drawing.Size(159, 40);
            this.geriDonBtn.TabIndex = 7;
            this.geriDonBtn.Text = "GERİ DÖN";
            this.geriDonBtn.UseVisualStyleBackColor = true;
            this.geriDonBtn.Click += new System.EventHandler(this.geriDonBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MBP207VİZE.Properties.Resources.resizedimage;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.geriDonBtn);
            this.Controls.Add(this.epostaKayit);
            this.Controls.Add(this.sifreKayit);
            this.Controls.Add(this.kAdiKayit);
            this.Controls.Add(this.kayitOlBtn);
            this.Controls.Add(this.epostaKytTxt);
            this.Controls.Add(this.sifreKayitTxt);
            this.Controls.Add(this.kAdiTxtB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "CANBO POKEMON";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox sifreKayitTxt;
        private System.Windows.Forms.TextBox epostaKytTxt;
        private System.Windows.Forms.Button kayitOlBtn;
        private System.Windows.Forms.Label kAdiKayit;
        private System.Windows.Forms.Label sifreKayit;
        private System.Windows.Forms.Label epostaKayit;
        private System.Windows.Forms.TextBox kAdiTxtB;
        private System.Windows.Forms.Button geriDonBtn;
    }
}