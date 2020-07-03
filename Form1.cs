using System;
using FifaLib;
using System.Xml.Linq;
using System.Linq;
using System.IO;
using System.Windows.Forms;

namespace FIFA2020
{
    /// <summary>
    /// Menu.
    /// </summary>
    public partial class Form1 : Form
    {
        readonly string  savePath = "save.xml";
        NewGameForm newGameForm;
        PlayProcess nextForm;
        EditDataForm editDataForm;

        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Launches a new game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewGamePB_Click(object sender, EventArgs e)
        {
            newGameForm = new NewGameForm(this);
            newGameForm.Show();
        }
        /// <summary>
        /// Launches a saved game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBox1_Click(object sender, EventArgs e) {
            editDataForm = new EditDataForm(this);
            Hide();
            editDataForm.Show();
        }
        /// <summary>
        /// Tips.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HowToPlayPB_Click(object sender, EventArgs e) {
            MessageBox.Show("Редактирование в разделе Edit the data\n" +
                "Игра сохраняется автоматически при закрытии, если игра не завершилась( раундов менее 30)\n" +
                "Фильтр - пояснения по кнопке \"Как работает фильтр\"\n" +
                "Есть кнопка  Random, чтобы было удобно тебе проверять)\n" +
                "Данные хранятся в формате csv, если будешь менять файл, то можно привести к такому формату в exel.\n" +
                "Удачной игры!");

        }
        /// <summary>
        /// Launches a saved game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContinuePB_Click(object sender, EventArgs e) {
            Player[] myTeamPl = new Player[11];
            Player[] enemyTeamPl = new Player[11];
            try {
                if (File.Exists(savePath)) {

                    XDocument doc = XDocument.Load(savePath);

                    var myT = Array.ConvertAll<XElement, string>(doc.Element("data").Element("myTeam").Elements("player").ToArray(),
                            new Converter<XElement, string>(r => string.Join(";", Array.ConvertAll<XElement, string>(r.Elements().ToArray(),
                            new Converter<XElement, string>(r0 => r0.Value)))));

                    var enemyT = Array.ConvertAll<XElement, string>(doc.Element("data").Element("enemyTeam").Elements("player").ToArray(),
                            new Converter<XElement, string>(r => string.Join(";", Array.ConvertAll<XElement, string>(r.Elements().ToArray(),
                            new Converter<XElement, string>(r0 => r0.Value)))));
                    myTeamPl = Array.ConvertAll<string, Player>(myT, new Converter<string, Player>(el => new Player(el)));
                    enemyTeamPl = Array.ConvertAll<string, Player>(enemyT, new Converter<string, Player>(el => new Player(el)));
                    Team myTeam = new Team(myTeamPl);
                    myTeam.Score = int.Parse(doc.Element("data").Element("myTeam").Attribute("score").Value);
                    Team enemyTeam = new Team(enemyTeamPl);
                    enemyTeam.Score = int.Parse(doc.Element("data").Element("enemyTeam").Attribute("score").Value);
                    int round = int.Parse(doc.Element("data").Attribute("round").Value);
                    if ((myTeam.Score + enemyTeam.Score) != round)
                        throw new Exception();
                    string mode = doc.Element("data").Attribute("mode").Value;
                    nextForm = new PlayProcess(myTeam, enemyTeam, round, mode, this);
                    nextForm.Show();

                } else {
                    MessageBox.Show("You have no unfinished game!");
                }
            } catch {
                MessageBox.Show("The data has been corrupted");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            try {
                newGameForm?.Close();
                nextForm?.Close();
                editDataForm?.Close();
            } catch {
                MessageBox.Show("System cant close Forms.");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e) {

        }
    }
}
