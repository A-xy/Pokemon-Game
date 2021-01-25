namespace MBP207VİZE
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.mevcutPoke = new System.Windows.Forms.Label();
            this.hosgeldinizLbl = new System.Windows.Forms.Label();
            this.isimLbl = new System.Windows.Forms.Label();
            this.pokeTurTxt = new System.Windows.Forms.TextBox();
            this.degisLbl = new System.Windows.Forms.Label();
            this.pokeTurDgsLbl = new System.Windows.Forms.Label();
            this.pokeCanDgsLbl = new System.Windows.Forms.Label();
            this.pokeCanDgs = new System.Windows.Forms.TextBox();
            this.pokeGucDgs = new System.Windows.Forms.TextBox();
            this.pokeAcikDgs = new System.Windows.Forms.TextBox();
            this.pokeGucDgsLbl = new System.Windows.Forms.Label();
            this.pokemonAcikDgsLbl = new System.Windows.Forms.Label();
            this.pokeAdiTxt = new System.Windows.Forms.TextBox();
            this.pokeAdiLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.geriDonBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(40, 119);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(208, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // mevcutPoke
            // 
            this.mevcutPoke.AutoSize = true;
            this.mevcutPoke.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mevcutPoke.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mevcutPoke.Location = new System.Drawing.Point(12, 76);
            this.mevcutPoke.Name = "mevcutPoke";
            this.mevcutPoke.Size = new System.Drawing.Size(275, 40);
            this.mevcutPoke.TabIndex = 1;
            this.mevcutPoke.Text = "Mevcut Pokemonlar Arasından\r\nDüzenlenecek Pokemonu Seçiniz\r\n";
            // 
            // hosgeldinizLbl
            // 
            this.hosgeldinizLbl.AutoSize = true;
            this.hosgeldinizLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hosgeldinizLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.hosgeldinizLbl.Location = new System.Drawing.Point(574, 9);
            this.hosgeldinizLbl.Name = "hosgeldinizLbl";
            this.hosgeldinizLbl.Size = new System.Drawing.Size(102, 20);
            this.hosgeldinizLbl.TabIndex = 2;
            this.hosgeldinizLbl.Text = "Hoşgeldiniz";
            this.hosgeldinizLbl.Click += new System.EventHandler(this.hosgeldinizLbl_Click);
            // 
            // isimLbl
            // 
            this.isimLbl.AutoSize = true;
            this.isimLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.isimLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.isimLbl.Location = new System.Drawing.Point(676, 9);
            this.isimLbl.Name = "isimLbl";
            this.isimLbl.Size = new System.Drawing.Size(0, 20);
            this.isimLbl.TabIndex = 3;
            // 
            // pokeTurTxt
            // 
            this.pokeTurTxt.Location = new System.Drawing.Point(551, 119);
            this.pokeTurTxt.Name = "pokeTurTxt";
            this.pokeTurTxt.Size = new System.Drawing.Size(146, 20);
            this.pokeTurTxt.TabIndex = 4;
            // 
            // degisLbl
            // 
            this.degisLbl.AutoSize = true;
            this.degisLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.degisLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.degisLbl.Location = new System.Drawing.Point(443, 44);
            this.degisLbl.Name = "degisLbl";
            this.degisLbl.Size = new System.Drawing.Size(254, 40);
            this.degisLbl.TabIndex = 5;
            this.degisLbl.Text = "Değiştirmek İstediğiniz Bilgileri\r\nAşağıda Doldurunuz\r\n";
            // 
            // pokeTurDgsLbl
            // 
            this.pokeTurDgsLbl.AutoSize = true;
            this.pokeTurDgsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pokeTurDgsLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pokeTurDgsLbl.Location = new System.Drawing.Point(407, 119);
            this.pokeTurDgsLbl.Name = "pokeTurDgsLbl";
            this.pokeTurDgsLbl.Size = new System.Drawing.Size(129, 20);
            this.pokeTurDgsLbl.TabIndex = 6;
            this.pokeTurDgsLbl.Text = "Pokemon Türü:";
            // 
            // pokeCanDgsLbl
            // 
            this.pokeCanDgsLbl.AutoSize = true;
            this.pokeCanDgsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pokeCanDgsLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pokeCanDgsLbl.Location = new System.Drawing.Point(407, 145);
            this.pokeCanDgsLbl.Name = "pokeCanDgsLbl";
            this.pokeCanDgsLbl.Size = new System.Drawing.Size(129, 20);
            this.pokeCanDgsLbl.TabIndex = 7;
            this.pokeCanDgsLbl.Text = "Pokemon Canı:";
            // 
            // pokeCanDgs
            // 
            this.pokeCanDgs.Location = new System.Drawing.Point(551, 145);
            this.pokeCanDgs.Name = "pokeCanDgs";
            this.pokeCanDgs.Size = new System.Drawing.Size(146, 20);
            this.pokeCanDgs.TabIndex = 8;
            // 
            // pokeGucDgs
            // 
            this.pokeGucDgs.Location = new System.Drawing.Point(551, 171);
            this.pokeGucDgs.Name = "pokeGucDgs";
            this.pokeGucDgs.Size = new System.Drawing.Size(146, 20);
            this.pokeGucDgs.TabIndex = 9;
            // 
            // pokeAcikDgs
            // 
            this.pokeAcikDgs.Location = new System.Drawing.Point(551, 197);
            this.pokeAcikDgs.Multiline = true;
            this.pokeAcikDgs.Name = "pokeAcikDgs";
            this.pokeAcikDgs.Size = new System.Drawing.Size(146, 80);
            this.pokeAcikDgs.TabIndex = 10;
            // 
            // pokeGucDgsLbl
            // 
            this.pokeGucDgsLbl.AutoSize = true;
            this.pokeGucDgsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pokeGucDgsLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pokeGucDgsLbl.Location = new System.Drawing.Point(400, 171);
            this.pokeGucDgsLbl.Name = "pokeGucDgsLbl";
            this.pokeGucDgsLbl.Size = new System.Drawing.Size(136, 20);
            this.pokeGucDgsLbl.TabIndex = 11;
            this.pokeGucDgsLbl.Text = "Pokemon Gücü:";
            // 
            // pokemonAcikDgsLbl
            // 
            this.pokemonAcikDgsLbl.AutoSize = true;
            this.pokemonAcikDgsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pokemonAcikDgsLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pokemonAcikDgsLbl.Location = new System.Drawing.Point(358, 197);
            this.pokemonAcikDgsLbl.Name = "pokemonAcikDgsLbl";
            this.pokemonAcikDgsLbl.Size = new System.Drawing.Size(178, 20);
            this.pokemonAcikDgsLbl.TabIndex = 12;
            this.pokemonAcikDgsLbl.Text = "Pokemon Açıklaması:";
            // 
            // pokeAdiTxt
            // 
            this.pokeAdiTxt.Location = new System.Drawing.Point(551, 93);
            this.pokeAdiTxt.Name = "pokeAdiTxt";
            this.pokeAdiTxt.Size = new System.Drawing.Size(146, 20);
            this.pokeAdiTxt.TabIndex = 13;
            // 
            // pokeAdiLbl
            // 
            this.pokeAdiLbl.AutoSize = true;
            this.pokeAdiLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pokeAdiLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pokeAdiLbl.Location = new System.Drawing.Point(397, 93);
            this.pokeAdiLbl.Name = "pokeAdiLbl";
            this.pokeAdiLbl.Size = new System.Drawing.Size(139, 20);
            this.pokeAdiLbl.TabIndex = 14;
            this.pokeAdiLbl.Text = "Pokemonun Adı:";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::MBP207VİZE.Properties.Resources.arkaplan7;
            this.button1.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(551, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 49);
            this.button1.TabIndex = 15;
            this.button1.Text = "BİLGİLERİ GÜNCELLE";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // geriDonBtn
            // 
            this.geriDonBtn.Location = new System.Drawing.Point(643, 389);
            this.geriDonBtn.Name = "geriDonBtn";
            this.geriDonBtn.Size = new System.Drawing.Size(145, 49);
            this.geriDonBtn.TabIndex = 16;
            this.geriDonBtn.Text = "GERİ DÖN";
            this.geriDonBtn.UseVisualStyleBackColor = true;
            this.geriDonBtn.Click += new System.EventHandler(this.geriDonBtn_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MBP207VİZE.Properties.Resources.resizedimage;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.geriDonBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pokeAdiLbl);
            this.Controls.Add(this.pokeAdiTxt);
            this.Controls.Add(this.pokemonAcikDgsLbl);
            this.Controls.Add(this.pokeGucDgsLbl);
            this.Controls.Add(this.pokeAcikDgs);
            this.Controls.Add(this.pokeGucDgs);
            this.Controls.Add(this.pokeCanDgs);
            this.Controls.Add(this.pokeCanDgsLbl);
            this.Controls.Add(this.pokeTurDgsLbl);
            this.Controls.Add(this.degisLbl);
            this.Controls.Add(this.pokeTurTxt);
            this.Controls.Add(this.isimLbl);
            this.Controls.Add(this.hosgeldinizLbl);
            this.Controls.Add(this.mevcutPoke);
            this.Controls.Add(this.comboBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form9";
            this.Text = "POKEMON DÜZENLE";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label mevcutPoke;
        private System.Windows.Forms.Label hosgeldinizLbl;
        public System.Windows.Forms.Label isimLbl;
        private System.Windows.Forms.TextBox pokeTurTxt;
        private System.Windows.Forms.Label degisLbl;
        private System.Windows.Forms.Label pokeTurDgsLbl;
        private System.Windows.Forms.Label pokeCanDgsLbl;
        private System.Windows.Forms.TextBox pokeCanDgs;
        private System.Windows.Forms.TextBox pokeGucDgs;
        private System.Windows.Forms.TextBox pokeAcikDgs;
        private System.Windows.Forms.Label pokeGucDgsLbl;
        private System.Windows.Forms.Label pokemonAcikDgsLbl;
        private System.Windows.Forms.TextBox pokeAdiTxt;
        private System.Windows.Forms.Label pokeAdiLbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button geriDonBtn;
    }
}