namespace FIFA2020
{
    partial class EditDataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditDataForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sofifa_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.player_url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.short_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.long_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.height_cm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight_kg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.club = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overall = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.potential = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sofifa_id,
            this.player_url,
            this.short_name,
            this.long_name,
            this.age,
            this.dob,
            this.height_cm,
            this.weight_kg,
            this.nationality,
            this.club,
            this.overall,
            this.potential});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(897, 532);
            this.dataGridView1.TabIndex = 0;
            //this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellValueChanged);
            // 
            // sofifa_id
            // 
            this.sofifa_id.HeaderText = "sofifa_id";
            this.sofifa_id.Name = "sofifa_id";
            // 
            // player_url
            // 
            this.player_url.HeaderText = "player_url";
            this.player_url.Name = "player_url";
            // 
            // short_name
            // 
            this.short_name.HeaderText = "short_name";
            this.short_name.Name = "short_name";
            // 
            // long_name
            // 
            this.long_name.HeaderText = "long_name";
            this.long_name.Name = "long_name";
            // 
            // age
            // 
            this.age.HeaderText = "age";
            this.age.Name = "age";
            // 
            // dob
            // 
            this.dob.HeaderText = "dob";
            this.dob.Name = "dob";
            // 
            // height_cm
            // 
            this.height_cm.HeaderText = "height_cm";
            this.height_cm.Name = "height_cm";
            // 
            // weight_kg
            // 
            this.weight_kg.HeaderText = "weight_kg";
            this.weight_kg.Name = "weight_kg";
            // 
            // nationality
            // 
            this.nationality.HeaderText = "nationality";
            this.nationality.Name = "nationality";
            // 
            // club
            // 
            this.club.HeaderText = "club";
            this.club.Name = "club";
            // 
            // overall
            // 
            this.overall.HeaderText = "overall";
            this.overall.Name = "overall";
            // 
            // potential
            // 
            this.potential.HeaderText = "potential";
            this.potential.Name = "potential";
            // 
            // EditDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(897, 532);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditDataForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditDataForm_FormClosing);
            this.Load += new System.EventHandler(this.EditDataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sofifa_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn player_url;
        private System.Windows.Forms.DataGridViewTextBoxColumn short_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn long_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn height_cm;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight_kg;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationality;
        private System.Windows.Forms.DataGridViewTextBoxColumn club;
        private System.Windows.Forms.DataGridViewTextBoxColumn overall;
        private System.Windows.Forms.DataGridViewTextBoxColumn potential;
    }
}