using System;

namespace FifaLib
{
     public  class Player
    {
        public static readonly Random rnd = new Random();
        public Player(string info) {
            FillInfo(info);
        }
        int sofifa_id;
        string player_url;
        string short_name;
        string long_name;
        int age;
        string dob;
        int height;
        int weight;
        string nationality;
        string club;
        int overall;
        int potential;
        /// <summary>
        /// Calculates points and returns them.
        /// </summary>
        public double Points
        {
            get => ((height - weight) / 10.0) * ((double)overall) / Math.Max(overall - potential, 1);
        }
        /// <summary>
        /// Check the value and set them.
        /// </summary>
        public string Sofifa_id
        {
            get => sofifa_id.ToString();
            set {
                
                int t = -1;
                if (int.TryParse(value, out t) && t > 0)
                    sofifa_id = t;
                else
                    throw new ArgumentException("Cannot be converted to N, try again!");
            }
        }
        /// <summary>
        /// Check the value and set them.
        /// </summary>
        public string Player_url
        {
            get => player_url;
            set {
                if (value.IndexOf(';') != -1)
                    throw new ArgumentException("invalid symbol ';' ");
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                    throw new Exception("Empty or White Space cannot be name of player_url.");
                player_url = value;
            }
        }
        /// <summary>
        /// Check the value and set them.
        /// </summary>
        public string Short_name
        {
            get => short_name;
            set {
                if (value.IndexOf(';') != -1)
                    throw new ArgumentException("invalid symbol ';' ");
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                    throw new Exception("Empty or White Space cannot be name of short_name.");
                short_name = value;
            }
        }
        /// <summary>
        /// Check the value and set them.
        /// </summary>
        public string Long_name
        {
            get => long_name;
            set {
                if (value.IndexOf(';') != -1)
                    throw new ArgumentException("invalid symbol ';' ");
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                    throw new Exception("Empty or White Space cannot be name of long_name.");
                long_name = value;
            }
        }
        /// <summary>
        /// Check the value and set them.
        /// </summary>
        public string Age
        {
            get => age.ToString();
            set {
                int t = -1;
                if (int.TryParse(value, out t) && t > 0)
                    age = t;
                else
                    throw new ArgumentException("Cannot be converted to natural number, try again!");
            }
        }
        /// <summary>
        /// Check the value and set them.
        /// </summary>
        public string Dob
        {
            get => dob;
            set {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                    throw new Exception("Empty or White Space cannot be name of dob.");
                dob = value;
            }
        }
        /// <summary>
        /// Check the value and set them.
        /// </summary>
        public string Height
        {
            get => height.ToString();
            set {
                int t = -1;
                if (int.TryParse(value, out t) && t > 0)
                    height = t;
                else
                    throw new ArgumentException("Cannot be converted to natural number, try again!");
            }
        }
        /// <summary>
        /// Check the value and set them.
        /// </summary>
        public string Weight
        {
            get => weight.ToString();
            set {
                int t = -1;
                if (int.TryParse(value, out t) && t > 0)
                    weight = t;
                else
                    throw new ArgumentException("Cannot be converted to natural number, try again!");
            }
        }
        /// <summary>
        /// Check the value and set them.
        /// </summary>
        public string Nationality
        {
            get => nationality; set {
                if (value.IndexOf(';') != -1)
                    throw new ArgumentException("invalid symbol ';' ");
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                    throw new Exception("Empty or White Space cannot be name of nationality.");
                nationality = value;
            }
        }
        /// <summary>
        /// Check the value and set them.
        /// </summary>
        public string Club
        {
            get => club;
            set {
                if (value.IndexOf(';') != -1)
                    throw new ArgumentException("invalid symbol ';' ");
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                    throw new Exception("Empty or White Space cannot be name of club.");
                club = value;
            }
        }
        /// <summary>
        /// Check the value and set them.
        /// </summary>
        public string Overall
        {
            get => overall.ToString();
            set {
                int t = -1;
                if (int.TryParse(value, out t) && t > 0)
                    overall = t;
                else
                    throw new ArgumentException("Cannot be converted to natural number, try again!");
            }
        }
        /// <summary>
        /// Check the value and set them.
        /// </summary>
        public string Potential
        {
            get => potential.ToString();
            set {
                int t = -1;
                if (int.TryParse(value, out t) && t > 0)
                    potential = t;
                else
                    throw new ArgumentException("Cannot be converted to natural number, try again!");
            }
        }
        /// <summary>
        /// Returns data as a csv string.
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            string temp =
            Sofifa_id + ";" +
            Player_url + ";" +
            Short_name + ";" +
            Long_name + ";" +
            Age + ";" +
            Dob + ";" +
            Height + ";" +
            Weight + ";" +
            Nationality + ";" +
            Club + ";" +
            Overall + ";" +
            Potential;
            return temp;
        }
        /// <summary>
        /// Set values.
        /// </summary>
        /// <param name="info"></param>
        void FillInfo(string info) {
            string[] temp = info.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            Sofifa_id = temp[0];
            Player_url = temp[1];
            Short_name = temp[2];
            Long_name = temp[3];
            Age = temp[4];
            Dob = temp[5];
            Height = temp[6];
            Weight = temp[7];
            Nationality = temp[8];
            Club = temp[9];
            Overall = temp[10];
            Potential = temp[11];
        }
    }
}
