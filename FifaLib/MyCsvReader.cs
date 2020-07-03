using System;
using System.IO;

namespace FifaLib
{
    public class MyCsvReader
    {
        string _path;
        public MyCsvReader(string path)
        {
            _path = path;
            Data = File.ReadAllLines(_path);
            //@"..\\..\\data\FIFA.csv"
        }
        /// <summary>
        /// Checks whether the csv file is correct.
        /// </summary>
        public void CheckFile() {
            Player item;
            string FString = "sofifa_id;player_url;short_name;long_name;age;" +
                "dob;height_cm;weight_kg;nationality;club;overall;potential";
            if (FString != Data[0])
                throw new Exception("Format of csv file is invalid.");
            for (int i = 1; i < Data.Length; i++) {
                item = new Player(Data[i]);
            }

        }
        /// <summary>
        /// Returns the read data as an array of strings.
        /// </summary>
        public string[] Data
        {
            get;
        }
    }
}
