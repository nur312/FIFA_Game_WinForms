namespace FIFA2020
{
    partial class NewGameForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewGameForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.short_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.height_cm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight_kg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overall = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.potential = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectedPlayers = new System.Windows.Forms.ListBox();
            this.AddPlayer = new System.Windows.Forms.Button();
            this.q_of_choosed = new System.Windows.Forms.Label();
            this.PlayBn = new System.Windows.Forms.PictureBox();
            this.NationComboBox = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.overallMinTrackBar = new System.Windows.Forms.TrackBar();
            this.FiltertabControl = new System.Windows.Forms.TabControl();
            this.overallTabpage = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.overallMaxLabel = new System.Windows.Forms.Label();
            this.overallMinLabel = new System.Windows.Forms.Label();
            this.overallMaxTrackBar = new System.Windows.Forms.TrackBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.potentialMaxLabel = new System.Windows.Forms.Label();
            this.potentialMinLabel = new System.Windows.Forms.Label();
            this.potentialMaxTrackBar = new System.Windows.Forms.TrackBar();
            this.potentialMinTrackBar = new System.Windows.Forms.TrackBar();
            this.FilterButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayBn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.overallMinTrackBar)).BeginInit();
            this.FiltertabControl.SuspendLayout();
            this.overallTabpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.overallMaxTrackBar)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.potentialMaxTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.potentialMinTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(129, -12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 73);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumSpringGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("AR JULIAN", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Brown;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.short_name,
            this.nationality,
            this.height_cm,
            this.weight_kg,
            this.overall,
            this.potential});
            this.dataGridView1.Location = new System.Drawing.Point(0, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(644, 407);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // short_name
            // 
            this.short_name.HeaderText = "short_name";
            this.short_name.Name = "short_name";
            this.short_name.ReadOnly = true;
            // 
            // nationality
            // 
            this.nationality.HeaderText = "nationality";
            this.nationality.Name = "nationality";
            this.nationality.ReadOnly = true;
            // 
            // height_cm
            // 
            this.height_cm.HeaderText = "height_cm";
            this.height_cm.Name = "height_cm";
            this.height_cm.ReadOnly = true;
            // 
            // weight_kg
            // 
            this.weight_kg.HeaderText = "weight_kg";
            this.weight_kg.Name = "weight_kg";
            this.weight_kg.ReadOnly = true;
            // 
            // overall
            // 
            this.overall.HeaderText = "overall";
            this.overall.Name = "overall";
            this.overall.ReadOnly = true;
            // 
            // potential
            // 
            this.potential.HeaderText = "potential";
            this.potential.Name = "potential";
            this.potential.ReadOnly = true;
            // 
            // SelectedPlayers
            // 
            this.SelectedPlayers.BackColor = System.Drawing.Color.RosyBrown;
            this.SelectedPlayers.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedPlayers.ForeColor = System.Drawing.Color.Black;
            this.SelectedPlayers.FormattingEnabled = true;
            this.SelectedPlayers.ItemHeight = 19;
            this.SelectedPlayers.Location = new System.Drawing.Point(659, 44);
            this.SelectedPlayers.Name = "SelectedPlayers";
            this.SelectedPlayers.Size = new System.Drawing.Size(183, 403);
            this.SelectedPlayers.TabIndex = 2;
            this.SelectedPlayers.Click += new System.EventHandler(this.SelectedPlayers_Click);
            this.SelectedPlayers.SelectedIndexChanged += new System.EventHandler(this.SelectedPlayers_SelectedIndexChanged);
            // 
            // AddPlayer
            // 
            this.AddPlayer.BackColor = System.Drawing.Color.GhostWhite;
            this.AddPlayer.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPlayer.Location = new System.Drawing.Point(0, 457);
            this.AddPlayer.Name = "AddPlayer";
            this.AddPlayer.Size = new System.Drawing.Size(644, 58);
            this.AddPlayer.TabIndex = 3;
            this.AddPlayer.Text = "Справа отображаются выбранные вами игроки. Чтобы выбрать, просто кликните по имен" +
    "и слева. Чтобы удалить кого-то из вашей команды кликните по нему на левой сторон" +
    "е.";
            this.AddPlayer.UseVisualStyleBackColor = false;
            // 
            // q_of_choosed
            // 
            this.q_of_choosed.AutoSize = true;
            this.q_of_choosed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.q_of_choosed.Location = new System.Drawing.Point(662, 23);
            this.q_of_choosed.Name = "q_of_choosed";
            this.q_of_choosed.Size = new System.Drawing.Size(157, 18);
            this.q_of_choosed.TabIndex = 5;
            this.q_of_choosed.Text = "Выберите 11 игроков";
            // 
            // PlayBn
            // 
            this.PlayBn.BackColor = System.Drawing.Color.Gainsboro;
            this.PlayBn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PlayBn.BackgroundImage")));
            this.PlayBn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PlayBn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayBn.Location = new System.Drawing.Point(868, 402);
            this.PlayBn.Name = "PlayBn";
            this.PlayBn.Size = new System.Drawing.Size(134, 45);
            this.PlayBn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlayBn.TabIndex = 6;
            this.PlayBn.TabStop = false;
            this.PlayBn.Click += new System.EventHandler(this.PlayBn_Click);
            // 
            // NationComboBox
            // 
            this.NationComboBox.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NationComboBox.FormattingEnabled = true;
            this.NationComboBox.Location = new System.Drawing.Point(857, 44);
            this.NationComboBox.Name = "NationComboBox";
            this.NationComboBox.Size = new System.Drawing.Size(150, 27);
            this.NationComboBox.Sorted = true;
            this.NationComboBox.TabIndex = 8;
            this.NationComboBox.Text = "All";
            // 
            // overallMinTrackBar
            // 
            this.overallMinTrackBar.BackColor = System.Drawing.Color.DarkSalmon;
            this.overallMinTrackBar.Location = new System.Drawing.Point(6, 23);
            this.overallMinTrackBar.Name = "overallMinTrackBar";
            this.overallMinTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.overallMinTrackBar.Size = new System.Drawing.Size(45, 140);
            this.overallMinTrackBar.TabIndex = 9;
            this.overallMinTrackBar.Scroll += new System.EventHandler(this.OverallMinTrackBar_Scroll);
            // 
            // FiltertabControl
            // 
            this.FiltertabControl.Controls.Add(this.overallTabpage);
            this.FiltertabControl.Controls.Add(this.tabPage2);
            this.FiltertabControl.Location = new System.Drawing.Point(853, 93);
            this.FiltertabControl.Name = "FiltertabControl";
            this.FiltertabControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FiltertabControl.SelectedIndex = 0;
            this.FiltertabControl.Size = new System.Drawing.Size(153, 228);
            this.FiltertabControl.TabIndex = 10;
            // 
            // overallTabpage
            // 
            this.overallTabpage.BackColor = System.Drawing.Color.Gainsboro;
            this.overallTabpage.Controls.Add(this.label2);
            this.overallTabpage.Controls.Add(this.overallMaxLabel);
            this.overallTabpage.Controls.Add(this.overallMinLabel);
            this.overallTabpage.Controls.Add(this.overallMaxTrackBar);
            this.overallTabpage.Controls.Add(this.overallMinTrackBar);
            this.overallTabpage.Location = new System.Drawing.Point(4, 22);
            this.overallTabpage.Name = "overallTabpage";
            this.overallTabpage.Padding = new System.Windows.Forms.Padding(3);
            this.overallTabpage.Size = new System.Drawing.Size(145, 202);
            this.overallTabpage.TabIndex = 0;
            this.overallTabpage.Text = "Overall Filter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("AR JULIAN", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Set min and max";
            // 
            // overallMaxLabel
            // 
            this.overallMaxLabel.AutoSize = true;
            this.overallMaxLabel.Font = new System.Drawing.Font("AR JULIAN", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overallMaxLabel.Location = new System.Drawing.Point(109, 165);
            this.overallMaxLabel.Name = "overallMaxLabel";
            this.overallMaxLabel.Size = new System.Drawing.Size(16, 17);
            this.overallMaxLabel.TabIndex = 12;
            this.overallMaxLabel.Text = "0";
            // 
            // overallMinLabel
            // 
            this.overallMinLabel.AutoSize = true;
            this.overallMinLabel.Font = new System.Drawing.Font("AR JULIAN", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overallMinLabel.Location = new System.Drawing.Point(20, 165);
            this.overallMinLabel.Name = "overallMinLabel";
            this.overallMinLabel.Size = new System.Drawing.Size(16, 17);
            this.overallMinLabel.TabIndex = 11;
            this.overallMinLabel.Text = "0";
            // 
            // overallMaxTrackBar
            // 
            this.overallMaxTrackBar.BackColor = System.Drawing.Color.DarkSalmon;
            this.overallMaxTrackBar.Location = new System.Drawing.Point(94, 23);
            this.overallMaxTrackBar.Name = "overallMaxTrackBar";
            this.overallMaxTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.overallMaxTrackBar.Size = new System.Drawing.Size(45, 140);
            this.overallMaxTrackBar.TabIndex = 10;
            this.overallMaxTrackBar.Scroll += new System.EventHandler(this.OverallMaxTrackBar_Scroll);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.potentialMaxLabel);
            this.tabPage2.Controls.Add(this.potentialMinLabel);
            this.tabPage2.Controls.Add(this.potentialMaxTrackBar);
            this.tabPage2.Controls.Add(this.potentialMinTrackBar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(145, 202);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Potential Filter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("AR JULIAN", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Set min and max";
            // 
            // potentialMaxLabel
            // 
            this.potentialMaxLabel.AutoSize = true;
            this.potentialMaxLabel.Font = new System.Drawing.Font("AR JULIAN", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.potentialMaxLabel.Location = new System.Drawing.Point(111, 171);
            this.potentialMaxLabel.Name = "potentialMaxLabel";
            this.potentialMaxLabel.Size = new System.Drawing.Size(16, 17);
            this.potentialMaxLabel.TabIndex = 12;
            this.potentialMaxLabel.Text = "0";
            // 
            // potentialMinLabel
            // 
            this.potentialMinLabel.AutoSize = true;
            this.potentialMinLabel.Font = new System.Drawing.Font("AR JULIAN", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.potentialMinLabel.Location = new System.Drawing.Point(21, 171);
            this.potentialMinLabel.Name = "potentialMinLabel";
            this.potentialMinLabel.Size = new System.Drawing.Size(16, 17);
            this.potentialMinLabel.TabIndex = 12;
            this.potentialMinLabel.Text = "0";
            // 
            // potentialMaxTrackBar
            // 
            this.potentialMaxTrackBar.BackColor = System.Drawing.Color.DarkSalmon;
            this.potentialMaxTrackBar.Location = new System.Drawing.Point(94, 28);
            this.potentialMaxTrackBar.Name = "potentialMaxTrackBar";
            this.potentialMaxTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.potentialMaxTrackBar.Size = new System.Drawing.Size(45, 140);
            this.potentialMaxTrackBar.TabIndex = 11;
            this.potentialMaxTrackBar.Scroll += new System.EventHandler(this.PotentialMaxTrackBar_Scroll);
            // 
            // potentialMinTrackBar
            // 
            this.potentialMinTrackBar.BackColor = System.Drawing.Color.DarkSalmon;
            this.potentialMinTrackBar.Location = new System.Drawing.Point(6, 28);
            this.potentialMinTrackBar.Name = "potentialMinTrackBar";
            this.potentialMinTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.potentialMinTrackBar.Size = new System.Drawing.Size(45, 140);
            this.potentialMinTrackBar.TabIndex = 10;
            this.potentialMinTrackBar.Scroll += new System.EventHandler(this.PotentialMinTrackBar_Scroll);
            // 
            // FilterButton
            // 
            this.FilterButton.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterButton.Location = new System.Drawing.Point(894, 327);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(90, 39);
            this.FilterButton.TabIndex = 16;
            this.FilterButton.Text = "Filter";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterPotentialButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(837, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 39);
            this.button1.TabIndex = 17;
            this.button1.Text = "Как работает фильтр?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // NewGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1015, 514);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.FiltertabControl);
            this.Controls.Add(this.NationComboBox);
            this.Controls.Add(this.PlayBn);
            this.Controls.Add(this.q_of_choosed);
            this.Controls.Add(this.AddPlayer);
            this.Controls.Add(this.SelectedPlayers);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewGameForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewGameForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewGameForm_FormClosed);
            this.Load += new System.EventHandler(this.NewGameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayBn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.overallMinTrackBar)).EndInit();
            this.FiltertabControl.ResumeLayout(false);
            this.overallTabpage.ResumeLayout(false);
            this.overallTabpage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.overallMaxTrackBar)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.potentialMaxTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.potentialMinTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn short_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationality;
        private System.Windows.Forms.DataGridViewTextBoxColumn height_cm;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight_kg;
        private System.Windows.Forms.DataGridViewTextBoxColumn overall;
        private System.Windows.Forms.DataGridViewTextBoxColumn potential;
        private System.Windows.Forms.ListBox SelectedPlayers;
        private System.Windows.Forms.Button AddPlayer;
        private System.Windows.Forms.Label q_of_choosed;
        private System.Windows.Forms.PictureBox PlayBn;
        private System.Windows.Forms.ComboBox NationComboBox;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TrackBar overallMinTrackBar;
        private System.Windows.Forms.TabControl FiltertabControl;
        private System.Windows.Forms.TabPage overallTabpage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TrackBar overallMaxTrackBar;
        private System.Windows.Forms.Label overallMaxLabel;
        private System.Windows.Forms.Label overallMinLabel;
        private System.Windows.Forms.Label potentialMaxLabel;
        private System.Windows.Forms.Label potentialMinLabel;
        private System.Windows.Forms.TrackBar potentialMaxTrackBar;
        private System.Windows.Forms.TrackBar potentialMinTrackBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.Button button1;
    }
}