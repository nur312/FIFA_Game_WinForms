using System;
using FifaLib;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIFA2020
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //List<Player> players = new List<Player>();
            //MyCsvReader myCsv = new MyCsvReader(@"data\FIFA.csv");
            //for (int i = 1; i < myCsv.Data.Length; i++)
            //{
            //    players.Add(new Player(myCsv.Data[i]));
            //}
            
            //foreach (var item in players)
            //{
                
            //    Console.WriteLine(item.ToString());
            //}
        }
    }
}
