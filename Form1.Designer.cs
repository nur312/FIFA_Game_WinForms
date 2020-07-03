namespace FIFA2020
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.NewGamePB = new System.Windows.Forms.PictureBox();
            this.ContinuePB = new System.Windows.Forms.PictureBox();
            this.HowToPlayPB = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.NewGamePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContinuePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HowToPlayPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NewGamePB
            // 
            this.NewGamePB.BackColor = System.Drawing.Color.Transparent;
            this.NewGamePB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NewGamePB.BackgroundImage")));
            this.NewGamePB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NewGamePB.Location = new System.Drawing.Point(284, 169);
            this.NewGamePB.Name = "NewGamePB";
            this.NewGamePB.Size = new System.Drawing.Size(346, 73);
            this.NewGamePB.TabIndex = 0;
            this.NewGamePB.TabStop = false;
            this.NewGamePB.Click += new System.EventHandler(this.NewGamePB_Click);
            // 
            // ContinuePB
            // 
            this.ContinuePB.BackColor = System.Drawing.Color.Transparent;
            this.ContinuePB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ContinuePB.BackgroundImage")));
            this.ContinuePB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ContinuePB.Location = new System.Drawing.Point(284, 248);
            this.ContinuePB.Name = "ContinuePB";
            this.ContinuePB.Size = new System.Drawing.Size(346, 73);
            this.ContinuePB.TabIndex = 1;
            this.ContinuePB.TabStop = false;
            this.ContinuePB.Click += new System.EventHandler(this.ContinuePB_Click);
            // 
            // HowToPlayPB
            // 
            this.HowToPlayPB.BackColor = System.Drawing.Color.Transparent;
            this.HowToPlayPB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HowToPlayPB.BackgroundImage")));
            this.HowToPlayPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HowToPlayPB.Location = new System.Drawing.Point(284, 327);
            this.HowToPlayPB.Name = "HowToPlayPB";
            this.HowToPlayPB.Size = new System.Drawing.Size(346, 73);
            this.HowToPlayPB.TabIndex = 2;
            this.HowToPlayPB.TabStop = false;
            this.HowToPlayPB.Click += new System.EventHandler(this.HowToPlayPB_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(284, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 73);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(892, 508);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.HowToPlayPB);
            this.Controls.Add(this.ContinuePB);
            this.Controls.Add(this.NewGamePB);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NewGamePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContinuePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HowToPlayPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox NewGamePB;
        private System.Windows.Forms.PictureBox ContinuePB;
        private System.Windows.Forms.PictureBox HowToPlayPB;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

