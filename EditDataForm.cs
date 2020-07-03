using System;
using FifaLib;
using System.IO;
using System.Windows.Forms;

namespace FIFA2020
{
    /// <summary>
    /// Dara edit.
    /// </summary>
    public partial class EditDataForm : Form
    {
        Form preForm;
        string[] data;
        public EditDataForm(Form preF) {
            InitializeComponent();
            preForm = preF;
            try {
                MyCsvReader csv = new MyCsvReader(@"..\\..\\data\FIFA.csv");
                data = csv.Data;
            }catch {
                MessageBox.Show("Close CSV File in other app.");
                preForm.Close();
            }
            

        }
        /// <summary>
        /// Fills empty objects with data.  Analyzes the data.
        /// </summary>
        private void AddData() {
            MyCsvReader myCsv;
            try {
                myCsv = new MyCsvReader(@"..\\..\\data\FIFA.csv");
                
                Player item;
                for (int i = 1; i < myCsv.Data.Length; i++) {
                    item = new Player(myCsv.Data[i]);
                    dataGridView1.Rows.Add(new string[] { item.Sofifa_id, item.Player_url, item.Short_name, item.Long_name,
                        item.Age, item.Dob, item.Height, item.Weight, item.Nationality, item.Club, item.Overall, item.Potential });
                }
                
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            } catch {

                MessageBox.Show("Close CSV File in other app or promlems with file.");
                preForm.Close();
            }
        }
        /// <summary>
        /// Add data to table.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditDataForm_Load(object sender, EventArgs e) {
            AddData();
        }

        private void EditDataForm_FormClosing(object sender, FormClosingEventArgs e) {
            preForm.Show();
            MessageBox.Show("Saved!");
        }
        /// <summary>
        /// Checks the input and set new values.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="cell"></param>
        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs cell) {
            if (cell.RowIndex >= 0) {
                
                
                try {
                    string tempStr = string.Join("", RowsToString(dataGridView1.Rows[cell.RowIndex].Cells));
                    if (tempStr.IndexOf(';') != -1)
                        throw new ArgumentException("invalid symbol ';' ");
                    string str = string.Join(";", RowsToString(dataGridView1.Rows[cell.RowIndex].Cells));
                    Player temp = new Player(str);
                    SaveFile(str, cell.RowIndex);
                    //this.Text = String.Join(";",RowsToString(dataGridView1.Rows[cell.RowIndex].Cells));

                    //dataGridView1.Columns.Count;

                } catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string[] values = data[cell.RowIndex + 1].Split(new char[] { ';' });
                    for (int i = 0; i < dataGridView1.Rows[cell.RowIndex].Cells.Count; i++) {
                        dataGridView1.Rows[cell.RowIndex].Cells[i].Value = values[i];
                    }
                    
                    //if(cell.RowIndex > -1 && cell.ColumnIndex > -1)
                    //    dataGridView1.Rows[cell.RowIndex].Cells[cell.ColumnIndex].Value = players[cell.RowIndex].ToString().Split(
                    //        new char[] { ';'})[cell.ColumnIndex];
                }
            }
        }
        /// <summary>
        /// Save the changes to file.
        /// </summary>
        /// <param name="str"></param>
        /// <param name="index"></param>
        void SaveFile(string str, int index) {
            try {
                var temp = File.ReadAllLines(@"..\\..\\data\FIFA.csv");
                temp[index+1] = str;
                //var temp1 = dataGridView1.Rows.
                File.WriteAllLines(@"..\\..\\data\FIFA.csv", temp);
                data = temp;

            } catch {
                MessageBox.Show("Close CSV File!");
                preForm.Close();
            }
            
        }
        /// <summary>
        /// Transforms Rows to string.
        /// </summary>
        /// <param name="cells"></param>
        /// <returns></returns>
        string[] RowsToString(DataGridViewCellCollection cells) {
            string[] temp = new string[cells.Count];
            
            for (int i = 0; i < cells.Count - 1; i++) {
                temp[i] = cells[i].Value.ToString();
            }
            temp[cells.Count-1] = cells[cells.Count - 1].Value.ToString();
            return temp;
        }
    }
}
