namespace MBP207VİZE
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.kAdiText = new System.Windows.Forms.TextBox();
            this.sifreText = new System.Windows.Forms.TextBox();
            this.epostaText = new System.Windows.Forms.TextBox();
            this.kadiLabel = new System.Windows.Forms.Label();
            this.sifreLabel = new System.Windows.Forms.Label();
            this.epostaLabel = new System.Windows.Forms.Label();
            this.isimLbl1 = new System.Windows.Forms.Label();
            this.hosgeldinizLbl = new System.Windows.Forms.Label();
            this.sifreDegistirBtn = new System.Windows.Forms.Button();
            this.epostaDegistir = new System.Windows.Forms.Button();
            this.yeniSif = new System.Windows.Forms.TextBox();
            this.yeniSif2 = new System.Windows.Forms.TextBox();
            this.onaylaBtn = new System.Windows.Forms.Button();
            this.yeniEposta = new System.Windows.Forms.TextBox();
            this.yeniEposta2 = new System.Windows.Forms.TextBox();
            this.onaylaBtn2 = new System.Windows.Forms.Button();
            this.yeniSiflbl1 = new System.Windows.Forms.Label();
            this.yeniSifLbl2 = new System.Windows.Forms.Label();
            this.yeniEpostaLbl = new System.Windows.Forms.Label();
            this.yeniEpostaLbl2 = new System.Windows.Forms.Label();
            this.geriDonBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kAdiText
            // 
            this.kAdiText.Location = new System.Drawing.Point(327, 84);
            this.kAdiText.Name = "kAdiText";
            this.kAdiText.Size = new System.Drawing.Size(174, 20);
            this.kAdiText.TabIndex = 0;
            // 
            // sifreText
            // 
            this.sifreText.Location = new System.Drawing.Point(327, 110);
            this.sifreText.Name = "sifreText";
            this.sifreText.Size = new System.Drawing.Size(174, 20);
            this.sifreText.TabIndex = 1;
            // 
            // epostaText
            // 
            this.epostaText.Location = new System.Drawing.Point(327, 136);
            this.epostaText.Name = "epostaText";
            this.epostaText.Size = new System.Drawing.Size(174, 20);
            this.epostaText.TabIndex = 2;
            // 
            // kadiLabel
            // 
            this.kadiLabel.AutoSize = true;
            this.kadiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kadiLabel.Location = new System.Drawing.Point(187, 84);
            this.kadiLabel.Name = "kadiLabel";
            this.kadiLabel.Size = new System.Drawing.Size(134, 20);
            this.kadiLabel.TabIndex = 3;
            this.kadiLabel.Text = "Kullanıcı Adınız:";
            this.kadiLabel.Click += new System.EventHandler(this.kadiLabel_Click);
            // 
            // sifreLabel
            // 
            this.sifreLabel.AutoSize = true;
            this.sifreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreLabel.Location = new System.Drawing.Point(246, 110);
            this.sifreLabel.Name = "sifreLabel";
            this.sifreLabel.Size = new System.Drawing.Size(75, 20);
            this.sifreLabel.TabIndex = 4;
            this.sifreLabel.Text = "Şifreniz:";
            // 
            // epostaLabel
            // 
            this.epostaLabel.AutoSize = true;
            this.epostaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.epostaLabel.Location = new System.Drawing.Point(227, 136);
            this.epostaLabel.Name = "epostaLabel";
            this.epostaLabel.Size = new System.Drawing.Size(94, 20);
            this.epostaLabel.TabIndex = 5;
            this.epostaLabel.Text = "Epostanız:";
            // 
            // isimLbl1
            // 
            this.isimLbl1.AutoSize = true;
            this.isimLbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.isimLbl1.ForeColor = System.Drawing.SystemColors.Control;
            this.isimLbl1.Location = new System.Drawing.Point(676, 9);
            this.isimLbl1.Name = "isimLbl1";
            this.isimLbl1.Size = new System.Drawing.Size(0, 20);
            this.isimLbl1.TabIndex = 6;
            // 
            // hosgeldinizLbl
            // 
            this.hosgeldinizLbl.AutoSize = true;
            this.hosgeldinizLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hosgeldinizLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.hosgeldinizLbl.Location = new System.Drawing.Point(574, 9);
            this.hosgeldinizLbl.Name = "hosgeldinizLbl";
            this.hosgeldinizLbl.Size = new System.Drawing.Size(102, 20);
            this.hosgeldinizLbl.TabIndex = 7;
            this.hosgeldinizLbl.Text = "Hoşgeldiniz";
            // 
            // sifreDegistirBtn
            // 
            this.sifreDegistirBtn.Location = new System.Drawing.Point(191, 162);
            this.sifreDegistirBtn.Name = "sifreDegistirBtn";
            this.sifreDegistirBtn.Size = new System.Drawing.Size(174, 44);
            this.sifreDegistirBtn.TabIndex = 8;
            this.sifreDegistirBtn.Text = "ŞİFRE DEĞİŞTİR";
            this.sifreDegistirBtn.UseVisualStyleBackColor = true;
            this.sifreDegistirBtn.Click += new System.EventHandler(this.sifreDegistirBtn_Click);
            // 
            // epostaDegistir
            // 
            this.epostaDegistir.Location = new System.Drawing.Point(388, 162);
            this.epostaDegistir.Name = "epostaDegistir";
            this.epostaDegistir.Size = new System.Drawing.Size(174, 44);
            this.epostaDegistir.TabIndex = 9;
            this.epostaDegistir.Text = "EPOSTA DEĞİŞTİR";
            this.epostaDegistir.UseVisualStyleBackColor = true;
            this.epostaDegistir.Click += new System.EventHandler(this.epostaDegistir_Click);
            // 
            // yeniSif
            // 
            this.yeniSif.Location = new System.Drawing.Point(191, 212);
            this.yeniSif.Name = "yeniSif";
            this.yeniSif.Size = new System.Drawing.Size(174, 20);
            this.yeniSif.TabIndex = 10;
            // 
            // yeniSif2
            // 
            this.yeniSif2.Location = new System.Drawing.Point(191, 238);
            this.yeniSif2.Name = "yeniSif2";
            this.yeniSif2.Size = new System.Drawing.Size(174, 20);
            this.yeniSif2.TabIndex = 11;
            // 
            // onaylaBtn
            // 
            this.onaylaBtn.Location = new System.Drawing.Point(191, 264);
            this.onaylaBtn.Name = "onaylaBtn";
            this.onaylaBtn.Size = new System.Drawing.Size(174, 26);
            this.onaylaBtn.TabIndex = 12;
            this.onaylaBtn.Text = "ONAYLA";
            this.onaylaBtn.UseVisualStyleBackColor = true;
            this.onaylaBtn.Click += new System.EventHandler(this.onaylaBtn_Click);
            // 
            // yeniEposta
            // 
            this.yeniEposta.Location = new System.Drawing.Point(388, 212);
            this.yeniEposta.Name = "yeniEposta";
            this.yeniEposta.Size = new System.Drawing.Size(174, 20);
            this.yeniEposta.TabIndex = 13;
            // 
            // yeniEposta2
            // 
            this.yeniEposta2.Location = new System.Drawing.Point(388, 238);
            this.yeniEposta2.Name = "yeniEposta2";
            this.yeniEposta2.Size = new System.Drawing.Size(174, 20);
            this.yeniEposta2.TabIndex = 14;
            // 
            // onaylaBtn2
            // 
            this.onaylaBtn2.Location = new System.Drawing.Point(388, 264);
            this.onaylaBtn2.Name = "onaylaBtn2";
            this.onaylaBtn2.Size = new System.Drawing.Size(174, 26);
            this.onaylaBtn2.TabIndex = 15;
            this.onaylaBtn2.Text = "ONAYLA";
            this.onaylaBtn2.UseVisualStyleBackColor = true;
            this.onaylaBtn2.Click += new System.EventHandler(this.onaylaBtn2_Click);
            // 
            // yeniSiflbl1
            // 
            this.yeniSiflbl1.AutoSize = true;
            this.yeniSiflbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yeniSiflbl1.Location = new System.Drawing.Point(9, 212);
            this.yeniSiflbl1.Name = "yeniSiflbl1";
            this.yeniSiflbl1.Size = new System.Drawing.Size(176, 20);
            this.yeniSiflbl1.TabIndex = 16;
            this.yeniSiflbl1.Text = "Yeni Şifrenizi Giriniz:";
            // 
            // yeniSifLbl2
            // 
            this.yeniSifLbl2.AutoSize = true;
            this.yeniSifLbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yeniSifLbl2.Location = new System.Drawing.Point(7, 238);
            this.yeniSifLbl2.Name = "yeniSifLbl2";
            this.yeniSifLbl2.Size = new System.Drawing.Size(178, 20);
            this.yeniSifLbl2.TabIndex = 17;
            this.yeniSifLbl2.Text = "Lütfen Tekrar Giriniz:";
            // 
            // yeniEpostaLbl
            // 
            this.yeniEpostaLbl.AutoSize = true;
            this.yeniEpostaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yeniEpostaLbl.Location = new System.Drawing.Point(568, 212);
            this.yeniEpostaLbl.Name = "yeniEpostaLbl";
            this.yeniEpostaLbl.Size = new System.Drawing.Size(163, 20);
            this.yeniEpostaLbl.TabIndex = 18;
            this.yeniEpostaLbl.Text = "Yeni Eposta Giriniz";
            // 
            // yeniEpostaLbl2
            // 
            this.yeniEpostaLbl2.AutoSize = true;
            this.yeniEpostaLbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yeniEpostaLbl2.Location = new System.Drawing.Point(568, 238);
            this.yeniEpostaLbl2.Name = "yeniEpostaLbl2";
            this.yeniEpostaLbl2.Size = new System.Drawing.Size(171, 20);
            this.yeniEpostaLbl2.TabIndex = 19;
            this.yeniEpostaLbl2.Text = "Lütfen Tekrar Ediniz";
            // 
            // geriDonBtn
            // 
            this.geriDonBtn.BackgroundImage = global::MBP207VİZE.Properties.Resources.arkaplan7;
            this.geriDonBtn.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geriDonBtn.Image = global::MBP207VİZE.Properties.Resources.Bellsprout_48px;
            this.geriDonBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.geriDonBtn.Location = new System.Drawing.Point(620, 382);
            this.geriDonBtn.Name = "geriDonBtn";
            this.geriDonBtn.Size = new System.Drawing.Size(168, 56);
            this.geriDonBtn.TabIndex = 20;
            this.geriDonBtn.Text = "GERİ DÖN";
            this.geriDonBtn.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.geriDonBtn.UseVisualStyleBackColor = true;
            this.geriDonBtn.Click += new System.EventHandler(this.geriDonBtn_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MBP207VİZE.Properties.Resources.resizedimage;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.geriDonBtn);
            this.Controls.Add(this.yeniEpostaLbl2);
            this.Controls.Add(this.yeniEpostaLbl);
            this.Controls.Add(this.yeniSifLbl2);
            this.Controls.Add(this.yeniSiflbl1);
            this.Controls.Add(this.onaylaBtn2);
            this.Controls.Add(this.yeniEposta2);
            this.Controls.Add(this.yeniEposta);
            this.Controls.Add(this.onaylaBtn);
            this.Controls.Add(this.yeniSif2);
            this.Controls.Add(this.yeniSif);
            this.Controls.Add(this.epostaDegistir);
            this.Controls.Add(this.sifreDegistirBtn);
            this.Controls.Add(this.hosgeldinizLbl);
            this.Controls.Add(this.isimLbl1);
            this.Controls.Add(this.epostaLabel);
            this.Controls.Add(this.sifreLabel);
            this.Controls.Add(this.kadiLabel);
            this.Controls.Add(this.epostaText);
            this.Controls.Add(this.sifreText);
            this.Controls.Add(this.kAdiText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form7";
            this.Text = "PROFİL GÜNCELLE";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kAdiText;
        private System.Windows.Forms.TextBox sifreText;
        private System.Windows.Forms.TextBox epostaText;
        private System.Windows.Forms.Label kadiLabel;
        private System.Windows.Forms.Label sifreLabel;
        private System.Windows.Forms.Label epostaLabel;
        private System.Windows.Forms.Label hosgeldinizLbl;
        public System.Windows.Forms.Label isimLbl1;
        private System.Windows.Forms.Button sifreDegistirBtn;
        private System.Windows.Forms.Button epostaDegistir;
        private System.Windows.Forms.TextBox yeniSif;
        private System.Windows.Forms.TextBox yeniSif2;
        private System.Windows.Forms.Button onaylaBtn;
        private System.Windows.Forms.TextBox yeniEposta;
        private System.Windows.Forms.TextBox yeniEposta2;
        private System.Windows.Forms.Button onaylaBtn2;
        private System.Windows.Forms.Label yeniSiflbl1;
        private System.Windows.Forms.Label yeniSifLbl2;
        private System.Windows.Forms.Label yeniEpostaLbl;
        private System.Windows.Forms.Label yeniEpostaLbl2;
        private System.Windows.Forms.Button geriDonBtn;
    }
}