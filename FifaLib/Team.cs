using System;

namespace FifaLib
{
    
    public class Team
    {
        Player[] players;
        
        public Team(Player[] plrs) {
            if (plrs.Length != 11)
                throw new Exception();
            players = plrs;
        }
        /// <summary>
        /// Returns the player by its number in the array.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Player this[int index]
        {
            get {
                return players[index];
            }
        }
        int step, score;
        public int Step {
            get => step;
            set {
                if (value >= 0 && value <= 30)
                    step = value;
                else
                    throw new ArgumentException("0 <= step\\score <= 30");
            }
        }
        public int Score {
            get => score;
            set {
                if (value >= 0 && value <= 30)
                    score = value;
                else
                    throw new ArgumentException("0 <= step\\score <= 30");
            }
        }
    }
}
