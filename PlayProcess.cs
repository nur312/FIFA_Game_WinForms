using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using FifaLib;
using System.Xml.Linq;

namespace FIFA2020
{
    /// <summary>
    /// Game Process.
    /// </summary>
    public partial class PlayProcess : Form
    {
        public static readonly int MaxStep = 4;
        public static readonly int QofPlayers = 11;
        public static readonly int QofRounds = 30;
        public static readonly string attack = "Attack";
        public static readonly string defend = "Defend";
        int round = 0;
        string mode0 = attack;
        string mode;
        Form _preForm;
        Team _myTeam;
        Team _enemies;
        readonly string savePath = "save.xml";

        public PlayProcess(Player[] myTeam, Player[] enemies, Form preForm) {
            InitializeComponent();
            _preForm = preForm;
            this._myTeam = new Team(myTeam);
            this._enemies = new  Team(enemies);
            manageBut.Text = attack;
            
        }
        public PlayProcess(Team myT, Team enemyT,int round,string mode, Form preForm) {
            InitializeComponent();
            this._myTeam = myT;
            this._enemies = enemyT;
            _preForm = preForm;
            this.round = round;
            this.mode = mode;

        }
        /// <summary>
        /// Displays the team as a list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayProcess_Load(object sender, EventArgs e) {
            _preForm.Hide();
            manageBut.Text = mode0;
            scoreLabel.Text = $"Score\n {_myTeam.Score} : {_enemies.Score}";
            RoundLabel.Text = $"Round {round}";
            if(enemyListBox.Items.Count == 0)
                for (int i = 0; i < QofPlayers; i++) {
                enemyListBox.Items.Add(_enemies[i].Short_name);
                myTeamListBox.Items.Add(_myTeam[i].Short_name);
                }
        }

        private void PlayProcess_FormClosed(object sender, FormClosedEventArgs e) {
            _preForm.Show();
        }
        /// <summary>
        /// Choosing an attacker or defender.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyTeamListBox_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                var temp = _myTeam[myTeamListBox.SelectedIndex];
                myInfoText.Text = String.Format($"{temp.Short_name}: \n\rHeight - {temp.Height} \t Weight - {temp.Weight}\n\r" +
                    $"Potential - {temp.Potential} \t Overall - {temp.Overall}\n\r Point - {temp.Points:f3}");

            } catch{
                MessageBox.Show("Select the player!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        ///  Choosing an attacker or defender.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnemyListBox_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                var temp = _enemies[enemyListBox.SelectedIndex];
                enemyPlInfoText.Text = String.Format($"{temp.Short_name}: \n\rHeight - {temp.Height} \t Weight - {temp.Weight}\n\r" +
                    $"Potential - {temp.Potential} \t Overall - {temp.Overall}\n\r Point - {temp.Points:f3}");

            } catch {
                MessageBox.Show("Select the player!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// Button for actions.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ManageBut_Click(object sender, EventArgs e) {
            try {
                var me = _myTeam[myTeamListBox.SelectedIndex];
                enemyListBox.SelectedIndex = Player.rnd.Next(11);
                var enemy = _enemies[enemyListBox.SelectedIndex];
                if(manageBut.Text == attack) {
                    if(me.Points > enemy.Points) {
                        if( MaxStep == ++_myTeam.Step) {
                            _myTeam.Score++;
                            IsRound(++round);
                            _myTeam.Step = 0;
                            manageBut.Text = defend;
                            
                        }
                        scoreLabel.Text = $"Score\n {_myTeam.Score} : {_enemies.Score}";
                        RoundLabel.Text = $"Round {round}";
                    } else {
                        manageBut.Text = defend;
                        _myTeam.Step = 0;
                    }
                } else {
                    if(enemy.Points > me.Points) {
                        if(MaxStep == ++_enemies.Step) {
                            _enemies.Score++;
                            IsRound(++round);
                            _enemies.Step = 0;
                            manageBut.Text = attack;
                        }
                        scoreLabel.Text = $"Score\n {_myTeam.Score} : {_enemies.Score}";
                        RoundLabel.Text = $"Round {round}";
                    } else {
                        manageBut.Text = attack;
                        _enemies.Step = 0;
                    }
                }

            } catch {
                MessageBox.Show("Select the player!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (round > 31)
                round = 0;
        }
        /// <summary>
        /// Checks if the game is over.
        /// </summary>
        /// <param name="r"></param>
        void IsRound(int r) {
           
            if (r == 30) {
                scoreLabel.Text = $"Score\n {_myTeam.Score} : {_enemies.Score}";
                RoundLabel.Text = $"Round {round}";
                string st = "";
                if (_myTeam.Score > _enemies.Score)
                    st = "You win!";
                else if(_myTeam.Score < _enemies.Score)
                    st = "You lose!";
               
                if (DialogResult.Yes== MessageBox.Show(st + $"\n\rScore : {_myTeam.Score} : {_enemies.Score}\nrestart?", "Finish", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information)) {

                    this.Hide();
                    _myTeam.Score = 0;
                     _enemies.Score = 0;
                    round = 0;
                    PlayProcess_Load(this, new EventArgs());
                    // (new PlayProcess(_myTeam, _enemies,0, "Attact", _preForm)).ShowDialog();

                    this.Show();


                } else {
                    this.Close();
                    _preForm.Close();
                    if (_preForm is NewGameForm) {
                        ((NewGameForm)_preForm).ClosePre();
                    } else {
                        _preForm.Close();
                    }
                }
            }
        }
        /// <summary>
        /// Simulation game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Random_button_Click(object sender, EventArgs e) {
            manageBut.Visible = false;
            //Random_button.Visible = false;
            this.ControlBox = false;
            while(round < (QofRounds)) {
                
                myTeamListBox.SelectedIndex = Player.rnd.Next(11);
                ManageBut_Click(sender, e);
                if (round == (QofRounds-1))
                    break;
                Thread.Sleep(10);
                
            }
            manageBut.Visible = true;
            //Random_button.Visible = true;
            this.ControlBox = true;
        }
        /// <summary>
        /// Saves data if the game is not completed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayProcess_FormClosing(object sender, FormClosingEventArgs e) {
            try {
                if (round < 30) {
                    XDocument doc = new XDocument(new XElement("data", new XAttribute("round", round), new XAttribute("mode", manageBut.Text),
                    new XElement("myTeam", new XAttribute("score", _myTeam.Score)),
                    new XElement("enemyTeam", new XAttribute("score", _enemies.Score))
                    ));
                    for (int i = 0; i < QofPlayers; i++) {
                        XElement myPlayer = new XElement("player",
                            new XElement("sofifa_id", _myTeam[i].Sofifa_id),
                            new XElement("player_url", _myTeam[i].Player_url),
                            new XElement("short_name", _myTeam[i].Short_name),
                            new XElement("long_name", _myTeam[i].Long_name),
                            new XElement("age", _myTeam[i].Age),
                            new XElement("dob", _myTeam[i].Dob),
                            new XElement("height_cm", _myTeam[i].Height),
                            new XElement("weight_kg", _myTeam[i].Weight),
                            new XElement("nationality", _myTeam[i].Nationality),
                            new XElement("club", _myTeam[i].Club),
                            new XElement("overall", _myTeam[i].Overall),
                            new XElement("potential", _myTeam[i].Potential)

                            );
                        XElement enemyPlayer = new XElement("player",
                            new XElement("sofifa_id", _enemies[i].Sofifa_id),
                            new XElement("player_url", _enemies[i].Player_url),
                            new XElement("short_name", _myTeam[i].Short_name),
                            new XElement("long_name", _myTeam[i].Long_name),
                            new XElement("age", _enemies[i].Age),
                            new XElement("dob", _enemies[i].Dob),
                            new XElement("height_cm", _enemies[i].Height),
                            new XElement("weight_kg", _enemies[i].Weight),
                            new XElement("nationality", _enemies[i].Nationality),
                            new XElement("club", _enemies[i].Club),
                            new XElement("overall", _enemies[i].Overall),
                            new XElement("potential", _enemies[i].Potential)

                            );
                        doc.Element("data").Element("myTeam").Add(myPlayer);
                        doc.Element("data").Element("enemyTeam").Add(enemyPlayer);
                    }

                    //сохраняем наш документ
                    doc.Save(savePath);
                    MessageBox.Show("Game saved!");
                } else {
                    try {
                        if (File.Exists(savePath))
                            File.Delete(savePath);
                    } catch {
                        MessageBox.Show("Close save.txt file.");
                    }
                }
            } catch {
                MessageBox.Show("File Problem.");
            }
            
            
        }

        private void Button1_Click(object sender, EventArgs e) {
            MessageBox.Show("Выберите игрока, нажмите на Attact\\Defend.\n" +
                "Удерживайте кнопку Enter.");
        }
    }
}
