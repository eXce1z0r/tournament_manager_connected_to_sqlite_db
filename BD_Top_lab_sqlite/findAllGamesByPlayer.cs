using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace BD_Top_lab_sqlite
{
    public partial class findAllGamesByPlayer : Form
    {
        private String dbName = "";
        private SQLiteConnection cn = null;
        private int playerId = 0;

        public findAllGamesByPlayer()
        {
            InitializeComponent();
        }

        public void connectionToBD()
        {
            cn = new SQLiteConnection("Data Source =" + dbName);
            cn.Open();
        }

        public void setDBName(String name)
        {
            dbName = name;
        }

        /*private void updateForm()
        {
            //name = "";
            textBoxPlayerName.Text = "";
            dataGridView1.Rows.Clear();
        }*/

        private void getPlayerIdByName(String name)
        {
            connectionToBD();
            SQLiteCommand cmd = cn.CreateCommand();
            cmd.CommandText = "Select id_player from player where fio = '"+name+"';";

            SQLiteDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                playerId = int.Parse(reader[0].ToString());
            }

            /*if(cmd.ExecuteNonQuery() == 1)
            {
                playerName
            }*/
            cn.Close();
        }

        private void showAllGames()
        {
            dataGridView1.Rows.Clear();

            connectionToBD();
            SQLiteCommand cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT * FROM game where (white = " + playerId + ") OR (black = " + playerId + ");";

            SQLiteDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                //reader[5];
                byte[] fieldAllMovesByteArr = (byte[])reader[5];
                String fieldAllMovesString = "";
                for (int i = 0; i < fieldAllMovesByteArr.Length; i++)
                {
                    int ch_num = int.Parse(fieldAllMovesByteArr.GetValue(i).ToString());
                    char ch = (char)ch_num;
                    fieldAllMovesString += ch;
                    //char letter = char.Parse(fieldAllMovesByteArr.GetValue(i).ToString());
                    //fieldAllMovesString += letter;
                    //fieldAllMovesByteArr.GetValue(i);
                    //fieldAllMovesString += fieldAllMovesByteArr.GetValue(i);
                    //fieldAllMovesString += fieldAllMovesByteArr.GetValue(i);
                }
                //int fieldAllMovesInt = System.Convert.ToInt32(fieldAllMovesByteArr);
                dataGridView1.Rows.Add(reader[0].ToString(), DateTime.Parse(reader[1].ToString()).ToShortDateString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), /*fieldAllMovesInt*/fieldAllMovesString/*reader[5].ToString()*/);
            }
            reader.Close();
            cn.Close();
        }

        private void findAllGamesByPlayer_Load(object sender, EventArgs e)
        {

        }

        private void findGamesButton_Click(object sender, EventArgs e)
        {
            getPlayerIdByName(textBoxPlayerName.Text);
            showAllGames();
            textBoxPlayerName.Text = "";
            //updateForm();
        }

        private void textBoxPlayerName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
