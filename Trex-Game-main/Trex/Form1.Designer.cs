namespace Trex_Game
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.çiftliengel = new System.Windows.Forms.PictureBox();
            this.tekliengel = new System.Windows.Forms.PictureBox();
            this.trex = new System.Windows.Forms.PictureBox();
            this.txtSkor = new System.Windows.Forms.Label();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.çiftliengel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tekliengel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // çiftliengel
            // 
            this.çiftliengel.Image = global::Trex_Game.Properties.Resources.obstacle_2;
            this.çiftliengel.Location = new System.Drawing.Point(642, 377);
            this.çiftliengel.Name = "çiftliengel";
            this.çiftliengel.Size = new System.Drawing.Size(32, 33);
            this.çiftliengel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.çiftliengel.TabIndex = 1;
            this.çiftliengel.TabStop = false;
            this.çiftliengel.Tag = "engel";
            // 
            // tekliengel
            // 
            this.tekliengel.Image = global::Trex_Game.Properties.Resources.obstacle_1;
            this.tekliengel.Location = new System.Drawing.Point(433, 364);
            this.tekliengel.Name = "tekliengel";
            this.tekliengel.Size = new System.Drawing.Size(23, 46);
            this.tekliengel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.tekliengel.TabIndex = 2;
            this.tekliengel.TabStop = false;
            this.tekliengel.Tag = "engel";
            // 
            // trex
            // 
            this.trex.Image = global::Trex_Game.Properties.Resources.running;
            this.trex.Location = new System.Drawing.Point(138, 367);
            this.trex.Name = "trex";
            this.trex.Size = new System.Drawing.Size(40, 43);
            this.trex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.trex.TabIndex = 3;
            this.trex.TabStop = false;
            // 
            // txtSkor
            // 
            this.txtSkor.AutoSize = true;
            this.txtSkor.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSkor.Location = new System.Drawing.Point(12, 9);
            this.txtSkor.Name = "txtSkor";
            this.txtSkor.Size = new System.Drawing.Size(150, 33);
            this.txtSkor.TabIndex = 4;
            this.txtSkor.Text = "Skor : 0 ";
            // 
            // gametimer
            // 
            this.gametimer.Interval = 20;
            this.gametimer.Tick += new System.EventHandler(this.oyunsüresiolayı);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(1, 416);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(850, 50);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(837, 449);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSkor);
            this.Controls.Add(this.tekliengel);
            this.Controls.Add(this.çiftliengel);
            this.Controls.Add(this.trex);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Trex";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.çiftliengel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tekliengel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox çiftliengel;
        private System.Windows.Forms.PictureBox tekliengel;
        private System.Windows.Forms.PictureBox trex;
        private System.Windows.Forms.Label txtSkor;
        private System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

