namespace FIFA2020
{
    partial class PlayProcess
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayProcess));
            this.myTeamListBox = new System.Windows.Forms.ListBox();
            this.enemyListBox = new System.Windows.Forms.ListBox();
            this.myInfoText = new System.Windows.Forms.Button();
            this.enemyPlInfoText = new System.Windows.Forms.Button();
            this.manageBut = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.RoundLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // myTeamListBox
            // 
            this.myTeamListBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.myTeamListBox.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myTeamListBox.ForeColor = System.Drawing.Color.Black;
            this.myTeamListBox.FormattingEnabled = true;
            this.myTeamListBox.ItemHeight = 19;
            this.myTeamListBox.Location = new System.Drawing.Point(12, 133);
            this.myTeamListBox.Name = "myTeamListBox";
            this.myTeamListBox.Size = new System.Drawing.Size(232, 289);
            this.myTeamListBox.TabIndex = 0;
            this.myTeamListBox.SelectedIndexChanged += new System.EventHandler(this.MyTeamListBox_SelectedIndexChanged);
            // 
            // enemyListBox
            // 
            this.enemyListBox.BackColor = System.Drawing.Color.Coral;
            this.enemyListBox.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyListBox.ForeColor = System.Drawing.Color.Black;
            this.enemyListBox.FormattingEnabled = true;
            this.enemyListBox.ItemHeight = 19;
            this.enemyListBox.Location = new System.Drawing.Point(617, 133);
            this.enemyListBox.Name = "enemyListBox";
            this.enemyListBox.Size = new System.Drawing.Size(232, 289);
            this.enemyListBox.TabIndex = 2;
            this.enemyListBox.SelectedIndexChanged += new System.EventHandler(this.EnemyListBox_SelectedIndexChanged);
            // 
            // myInfoText
            // 
            this.myInfoText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.myInfoText.Font = new System.Drawing.Font("AR JULIAN", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.myInfoText.Location = new System.Drawing.Point(12, 428);
            this.myInfoText.Name = "myInfoText";
            this.myInfoText.Size = new System.Drawing.Size(232, 87);
            this.myInfoText.TabIndex = 3;
            this.myInfoText.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.myInfoText.UseVisualStyleBackColor = true;
            // 
            // enemyPlInfoText
            // 
            this.enemyPlInfoText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.enemyPlInfoText.Font = new System.Drawing.Font("AR JULIAN", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enemyPlInfoText.Location = new System.Drawing.Point(617, 428);
            this.enemyPlInfoText.Name = "enemyPlInfoText";
            this.enemyPlInfoText.Size = new System.Drawing.Size(232, 87);
            this.enemyPlInfoText.TabIndex = 4;
            this.enemyPlInfoText.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.enemyPlInfoText.UseVisualStyleBackColor = true;
            // 
            // manageBut
            // 
            this.manageBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageBut.Font = new System.Drawing.Font("AR JULIAN", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageBut.Location = new System.Drawing.Point(264, 374);
            this.manageBut.Name = "manageBut";
            this.manageBut.Size = new System.Drawing.Size(120, 48);
            this.manageBut.TabIndex = 5;
            this.manageBut.Text = "Attack";
            this.manageBut.UseVisualStyleBackColor = true;
            this.manageBut.Click += new System.EventHandler(this.ManageBut_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.scoreLabel.Location = new System.Drawing.Point(416, 20);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(60, 48);
            this.scoreLabel.TabIndex = 6;
            this.scoreLabel.Text = "Score\r\n0 : 0";
            // 
            // RoundLabel
            // 
            this.RoundLabel.AutoSize = true;
            this.RoundLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RoundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoundLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RoundLabel.Location = new System.Drawing.Point(403, 467);
            this.RoundLabel.Name = "RoundLabel";
            this.RoundLabel.Size = new System.Drawing.Size(82, 24);
            this.RoundLabel.TabIndex = 7;
            this.RoundLabel.Text = "Round 1";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(261, 482);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Как играть быстро?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // PlayProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(861, 527);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RoundLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.manageBut);
            this.Controls.Add(this.enemyPlInfoText);
            this.Controls.Add(this.myInfoText);
            this.Controls.Add(this.enemyListBox);
            this.Controls.Add(this.myTeamListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlayProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlayProcess";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlayProcess_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PlayProcess_FormClosed);
            this.Load += new System.EventHandler(this.PlayProcess_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox myTeamListBox;
        private System.Windows.Forms.ListBox enemyListBox;
        private System.Windows.Forms.Button myInfoText;
        private System.Windows.Forms.Button enemyPlInfoText;
        private System.Windows.Forms.Button manageBut;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label RoundLabel;
        private System.Windows.Forms.Button button1;
    }
}