using System;
using System.Collections.Generic;
using FifaLib;
using System.Windows.Forms;

namespace FIFA2020
{
    /// <summary>
    /// Select and sort form.
    /// </summary>
    public partial class NewGameForm : Form
    {
        Form preForm;
        Form nextForm;
        int overallMin = int.MaxValue;
        int overallMax = int.MinValue;
        int potentialMin = int.MaxValue;
        int potentialMax = int.MinValue;
        List<Player> players = new List<Player>();
        
        public NewGameForm(Form f) {
            InitializeComponent();
            //f.Close();
            preForm = f;
            AddData();
        }
        /// <summary>
        /// Fills empty objects with data.  Analyzes the data.
        /// </summary>
        private void AddData() {
            //preForm.Close();
            MyCsvReader myCsv;
            try {
                myCsv = new MyCsvReader(@"..\\..\\data\FIFA.csv");
               
                for (int i = 1; i < myCsv.Data.Length; i++) {
                    players.Add(new Player(myCsv.Data[i]));
                }
                NationComboBox.Items.Add("All");
                foreach (var item in players) {
                    dataGridView1.Rows.Add(new string[] { item.Short_name, item.Nationality,
                        item.Height, item.Weight, item.Overall, item.Potential });
                    DetermineNation(item.Nationality);
                    DetermineMaxMin(item);
                    
                }
                // dataGridView1.
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                SetScrolls();

            } catch {
                
                MessageBox.Show("Close CSV File in other app or incorrect problems with file.");
                preForm.Close();
            }
            
        }
        /// <summary>
        /// Closes the previous and this form.
        /// </summary>
        public void ClosePre() {
            preForm.Close();
        }
        /// <summary>
        /// Sets values for the filter.
        /// </summary>
        void SetScrolls() {
            overallMaxTrackBar.Maximum = overallMax;
            overallMinTrackBar.Minimum = overallMin;
            potentialMaxTrackBar.Maximum = potentialMax;
            potentialMinTrackBar.Minimum = potentialMin;

            overallMaxTrackBar.Minimum = overallMin;
            overallMinTrackBar.Maximum = overallMax;
            potentialMaxTrackBar.Minimum = potentialMin;
            potentialMinTrackBar.Maximum = potentialMax;

            overallMaxTrackBar.Value = overallMaxTrackBar.Maximum;
            potentialMaxTrackBar.Value = overallMaxTrackBar.Maximum;

            potentialMaxLabel.Text = potentialMax.ToString();
            potentialMinLabel.Text = potentialMin.ToString();
            overallMaxLabel.Text = overallMax.ToString();
            overallMinLabel.Text = overallMin.ToString();

        }
        /// <summary>
        /// Adds a non-repeating nationality.
        /// </summary>
        /// <param name="nationality"></param>
        void DetermineNation(string nationality) {
            bool NationAdd = true;
            foreach (var nation in NationComboBox.Items) {
                if (nation.ToString() == nationality) {
                    NationAdd = false;
                    break;
                }

            }
            if (NationAdd)
                NationComboBox.Items.Add(nationality);
        }
        /// <summary>
        ///  Analyzes the data.
        /// </summary>
        /// <param name="item"></param>
        void DetermineMaxMin(Player item) {
            if (int.Parse(item.Overall) > overallMax)
                overallMax = int.Parse(item.Overall);
            if (int.Parse(item.Overall) < overallMin)
                overallMin = int.Parse(item.Overall);
            if (int.Parse(item.Potential) > potentialMax)
                potentialMax = int.Parse(item.Potential);
            if (int.Parse(item.Potential) < potentialMin)
                potentialMin = int.Parse(item.Potential);
        }

        /// <summary>
        /// Checks whether the player is selected or not.
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        bool IsChoosed(string st) {
            foreach (var item in SelectedPlayers.Items) {
                if (st == item.ToString()) {
                    MessageBox.Show("You have already picked up it!");
                    return true;
                }
                    
            }
            return false;
        }
        /// <summary>
        /// The process of selecting players.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectedPlayers_Click(object sender, EventArgs e) {
            try {
                SelectedPlayers.Items.RemoveAt(SelectedPlayers.SelectedIndex);
                q_of_choosed.Text = SelectedPlayers.Items.Count.ToString();
            } catch {

            }
        }
        /// <summary>
        /// Starts the game process.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayBn_Click(object sender, EventArgs e) {
            if (SelectedPlayers.Items.Count == 11) {
                NamesToPlayesAndNextForm();
            } else {
                MessageBox.Show("You don't have enough players!", "Choose players",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Loads players from SelectedPlayers to list.
        /// </summary>
        public void NamesToPlayesAndNextForm() {
            List<Player> myTeam = new List<Player>();
            List<Player> enemyTeam = new List<Player>();
            foreach (var name in SelectedPlayers.Items) {
                foreach (var player in players) {
                    if (name.ToString() == player.Short_name)
                        myTeam.Add(player);
                }
            }

            foreach (var player in players) {
                bool ind = true;
                foreach (var name in SelectedPlayers.Items) {
                    if (name.ToString() == player.Short_name) {
                        ind = false;
                    }

                }

                if (ind) {
                    enemyTeam.Add(player);
                }
                if (enemyTeam.Count == 11)
                    break;
            }

            nextForm = new PlayProcess(myTeam.ToArray(), enemyTeam.ToArray(), this);
            nextForm.Show();
        }

        private void NewGameForm_FormClosed(object sender, FormClosedEventArgs e) {
            preForm.Show();

        }

        private void NewGameForm_Load(object sender, EventArgs e) {
            preForm.Hide();

        }
        /// <summary>
        /// Seclect process.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectedPlayers_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                SelectedPlayers.Items.RemoveAt(SelectedPlayers.SelectedIndex);
                q_of_choosed.Text = SelectedPlayers.Items.Count.ToString();
            } catch {

            }
        }

        /// <summary>
        /// Seclect process.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="cell"></param>
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs cell) {
            int indexRow = cell.RowIndex;
            int indexCol = cell.ColumnIndex;

            try {
                var temp = dataGridView1.Rows[indexRow].Cells;
                if (SelectedPlayers.Items.Count < 11 && !IsChoosed(dataGridView1.Rows[indexRow].Cells[0].Value.ToString()))
                    SelectedPlayers.Items.Add(dataGridView1.Rows[indexRow].Cells[0].Value);
                q_of_choosed.Text = SelectedPlayers.Items.Count.ToString();
            } catch {

            }
        }

        private void OverallMinTrackBar_Scroll(object sender, EventArgs e) {
            overallMinLabel.Text = overallMinTrackBar.Value.ToString();
        }

        private void OverallMaxTrackBar_Scroll(object sender, EventArgs e) {
            overallMaxLabel.Text = overallMaxTrackBar.Value.ToString();
        }

        private void PotentialMinTrackBar_Scroll(object sender, EventArgs e) {
            potentialMinLabel.Text = potentialMinTrackBar.Value.ToString();
        }

        private void PotentialMaxTrackBar_Scroll(object sender, EventArgs e) {
            potentialMaxLabel.Text = potentialMaxTrackBar.Value.ToString();
        }
        /// <summary>
        /// Filters by 3 properties.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FilterPotentialButton_Click(object sender, EventArgs e) {
            int maxP, minP, max, min;
            if (potentialMaxTrackBar.Value > potentialMinTrackBar.Value) {
                maxP = potentialMaxTrackBar.Value; minP = potentialMinTrackBar.Value;
            } else {
                minP = potentialMaxTrackBar.Value; maxP = potentialMinTrackBar.Value;
            }
            if (overallMaxTrackBar.Value > overallMinTrackBar.Value) {
                max = overallMaxTrackBar.Value; min = overallMinTrackBar.Value;
            } else {
                min = overallMaxTrackBar.Value; max = overallMinTrackBar.Value;
            }
            dataGridView1.Rows.Clear();
            foreach (var item in players) {
                if (int.Parse(item.Potential) >= minP && int.Parse(item.Potential) <= maxP &&
                    int.Parse(item.Overall) >= min && int.Parse(item.Overall) <= max) {

                    if (NationComboBox.Text == "All") {

                        dataGridView1.Rows.Add(new string[] { item.Short_name, item.Nationality,
                        item.Height, item.Weight, item.Overall, item.Potential });

                    } else if(NationComboBox.Text == item.Nationality) {

                        dataGridView1.Rows.Add(new string[] { item.Short_name, item.Nationality,
                        item.Height, item.Weight, item.Overall, item.Potential });
                    }
                }

            }

        }
        /// <summary>
        /// Tips.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, EventArgs e) {
            MessageBox.Show("Фильтр работает следующим образом:\nВыбираете макисмальное и минимальное значение " +
                "по каждому параметру, затем нажимаете конпку Фильтр.\nВыведутся игроки, у которых подошли все параметры.\n" +
                "Например если выберите максимум потенциала равным 93, Месси уже не выведится, если у него 94.\n" +
                "Поэтому лучше, если один всегда будет на максимум и регулировать только нижнюю.");

        }

        private void NewGameForm_FormClosing(object sender, FormClosingEventArgs e) {
            nextForm?.Close();
        }
    }
}
