namespace MBP207VİZE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.girisTB = new System.Windows.Forms.TextBox();
            this.sifreTB = new System.Windows.Forms.TextBox();
            this.girisLB = new System.Windows.Forms.Label();
            this.sifreLB = new System.Windows.Forms.Label();
            this.girisyapBtn = new System.Windows.Forms.Button();
            this.sifreUnuttumBtn = new System.Windows.Forms.Button();
            this.kayitolBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // girisTB
            // 
            this.girisTB.Location = new System.Drawing.Point(325, 191);
            this.girisTB.Name = "girisTB";
            this.girisTB.Size = new System.Drawing.Size(152, 20);
            this.girisTB.TabIndex = 0;
            this.girisTB.TextChanged += new System.EventHandler(this.girisTB_TextChanged);
            // 
            // sifreTB
            // 
            this.sifreTB.Location = new System.Drawing.Point(325, 217);
            this.sifreTB.Name = "sifreTB";
            this.sifreTB.Size = new System.Drawing.Size(152, 20);
            this.sifreTB.TabIndex = 1;
            // 
            // girisLB
            // 
            this.girisLB.AutoSize = true;
            this.girisLB.BackColor = System.Drawing.SystemColors.Window;
            this.girisLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisLB.Location = new System.Drawing.Point(198, 191);
            this.girisLB.Name = "girisLB";
            this.girisLB.Size = new System.Drawing.Size(111, 20);
            this.girisLB.TabIndex = 2;
            this.girisLB.Text = "Kullanıcı Adı:";
            this.girisLB.Click += new System.EventHandler(this.girisLB_Click);
            // 
            // sifreLB
            // 
            this.sifreLB.AutoSize = true;
            this.sifreLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreLB.Location = new System.Drawing.Point(257, 217);
            this.sifreLB.Name = "sifreLB";
            this.sifreLB.Size = new System.Drawing.Size(52, 20);
            this.sifreLB.TabIndex = 3;
            this.sifreLB.Text = "Şifre:";
            // 
            // girisyapBtn
            // 
            this.girisyapBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisyapBtn.Image = global::MBP207VİZE.Properties.Resources.Pokeball_30px;
            this.girisyapBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.girisyapBtn.Location = new System.Drawing.Point(325, 243);
            this.girisyapBtn.Name = "girisyapBtn";
            this.girisyapBtn.Size = new System.Drawing.Size(152, 45);
            this.girisyapBtn.TabIndex = 4;
            this.girisyapBtn.Text = "GİRİŞ YAP";
            this.girisyapBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.girisyapBtn.UseVisualStyleBackColor = true;
            this.girisyapBtn.Click += new System.EventHandler(this.girisyapBtn_Click);
            // 
            // sifreUnuttumBtn
            // 
            this.sifreUnuttumBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreUnuttumBtn.Image = global::MBP207VİZE.Properties.Resources.Open_Pokeball_30px;
            this.sifreUnuttumBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sifreUnuttumBtn.Location = new System.Drawing.Point(325, 345);
            this.sifreUnuttumBtn.Name = "sifreUnuttumBtn";
            this.sifreUnuttumBtn.Size = new System.Drawing.Size(152, 45);
            this.sifreUnuttumBtn.TabIndex = 5;
            this.sifreUnuttumBtn.Text = "ŞİFREMİ UNUTTUM";
            this.sifreUnuttumBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sifreUnuttumBtn.UseVisualStyleBackColor = true;
            this.sifreUnuttumBtn.Click += new System.EventHandler(this.sifreUnuttumBtn_Click);
            // 
            // kayitolBtn
            // 
            this.kayitolBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayitolBtn.Image = global::MBP207VİZE.Properties.Resources.Pokeball_30px;
            this.kayitolBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kayitolBtn.Location = new System.Drawing.Point(325, 294);
            this.kayitolBtn.Name = "kayitolBtn";
            this.kayitolBtn.Size = new System.Drawing.Size(152, 45);
            this.kayitolBtn.TabIndex = 6;
            this.kayitolBtn.Text = "KAYIT OL";
            this.kayitolBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.kayitolBtn.UseVisualStyleBackColor = true;
            this.kayitolBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MBP207VİZE.Properties.Resources.resizedimage;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kayitolBtn);
            this.Controls.Add(this.sifreUnuttumBtn);
            this.Controls.Add(this.girisyapBtn);
            this.Controls.Add(this.sifreLB);
            this.Controls.Add(this.girisLB);
            this.Controls.Add(this.sifreTB);
            this.Controls.Add(this.girisTB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CANBO POKEMON";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox sifreTB;
        private System.Windows.Forms.Label girisLB;
        private System.Windows.Forms.Label sifreLB;
        private System.Windows.Forms.Button girisyapBtn;
        private System.Windows.Forms.Button sifreUnuttumBtn;
        private System.Windows.Forms.Button kayitolBtn;
        public System.Windows.Forms.TextBox girisTB;
    }
}

