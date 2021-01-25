namespace MBP207VİZE
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.otoText = new System.Windows.Forms.TextBox();
            this.yeniSif1 = new System.Windows.Forms.TextBox();
            this.yeniSif2 = new System.Windows.Forms.TextBox();
            this.sifYenileBtn = new System.Windows.Forms.Button();
            this.epostaLBL = new System.Windows.Forms.Label();
            this.yeniSifLBL = new System.Windows.Forms.Label();
            this.yeniSif2LBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // otoText
            // 
            this.otoText.Location = new System.Drawing.Point(134, 14);
            this.otoText.Name = "otoText";
            this.otoText.Size = new System.Drawing.Size(172, 20);
            this.otoText.TabIndex = 0;
            // 
            // yeniSif1
            // 
            this.yeniSif1.Location = new System.Drawing.Point(134, 38);
            this.yeniSif1.Name = "yeniSif1";
            this.yeniSif1.Size = new System.Drawing.Size(172, 20);
            this.yeniSif1.TabIndex = 1;
            // 
            // yeniSif2
            // 
            this.yeniSif2.Location = new System.Drawing.Point(134, 64);
            this.yeniSif2.Name = "yeniSif2";
            this.yeniSif2.Size = new System.Drawing.Size(172, 20);
            this.yeniSif2.TabIndex = 2;
            // 
            // sifYenileBtn
            // 
            this.sifYenileBtn.Location = new System.Drawing.Point(134, 90);
            this.sifYenileBtn.Name = "sifYenileBtn";
            this.sifYenileBtn.Size = new System.Drawing.Size(172, 44);
            this.sifYenileBtn.TabIndex = 3;
            this.sifYenileBtn.Text = "ŞİFREMİ YENİLE";
            this.sifYenileBtn.UseVisualStyleBackColor = true;
            this.sifYenileBtn.Click += new System.EventHandler(this.sifYenileBtn_Click);
            // 
            // epostaLBL
            // 
            this.epostaLBL.AutoSize = true;
            this.epostaLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.epostaLBL.Location = new System.Drawing.Point(29, 12);
            this.epostaLBL.Name = "epostaLBL";
            this.epostaLBL.Size = new System.Drawing.Size(94, 20);
            this.epostaLBL.TabIndex = 4;
            this.epostaLBL.Text = "Epostanız:";
            // 
            // yeniSifLBL
            // 
            this.yeniSifLBL.AutoSize = true;
            this.yeniSifLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yeniSifLBL.Location = new System.Drawing.Point(7, 38);
            this.yeniSifLBL.Name = "yeniSifLBL";
            this.yeniSifLBL.Size = new System.Drawing.Size(116, 20);
            this.yeniSifLBL.TabIndex = 5;
            this.yeniSifLBL.Text = "Yeni Şifreniz:";
            // 
            // yeniSif2LBL
            // 
            this.yeniSif2LBL.AutoSize = true;
            this.yeniSif2LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yeniSif2LBL.Location = new System.Drawing.Point(2, 64);
            this.yeniSif2LBL.Name = "yeniSif2LBL";
            this.yeniSif2LBL.Size = new System.Drawing.Size(121, 20);
            this.yeniSif2LBL.TabIndex = 6;
            this.yeniSif2LBL.Text = "Tekrar Giriniz:";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MBP207VİZE.Properties.Resources.sifrearkaplan1;
            this.ClientSize = new System.Drawing.Size(318, 469);
            this.Controls.Add(this.yeniSif2LBL);
            this.Controls.Add(this.yeniSifLBL);
            this.Controls.Add(this.epostaLBL);
            this.Controls.Add(this.sifYenileBtn);
            this.Controls.Add(this.yeniSif2);
            this.Controls.Add(this.yeniSif1);
            this.Controls.Add(this.otoText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form6";
            this.Text = "ŞİFRE YENİLE";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox yeniSif1;
        private System.Windows.Forms.TextBox yeniSif2;
        private System.Windows.Forms.Button sifYenileBtn;
        public System.Windows.Forms.TextBox otoText;
        private System.Windows.Forms.Label epostaLBL;
        private System.Windows.Forms.Label yeniSifLBL;
        private System.Windows.Forms.Label yeniSif2LBL;
    }
}