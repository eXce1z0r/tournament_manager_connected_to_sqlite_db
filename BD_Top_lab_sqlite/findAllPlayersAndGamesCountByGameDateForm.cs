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
    public partial class findAllPlayersAndGamesCountByGameDateForm : Form
    {
        private String dbName = "";
        private SQLiteConnection cn = null;
        //private int gamesId = 0;
        //private List<int> gamesIds = new List<int>();
        private int[] gamesIds = new int[1];
        private string[,] gameInfoForVisualization = new string[0,3];

        public findAllPlayersAndGamesCountByGameDateForm()
        {
            InitializeComponent();
        }

        private void findAllPlayersAndGamesCountByGameDateForm_Load(object sender, EventArgs e)
        {

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

        private void getPlayerIdByDate(String date)
        {
            if ((date.IndexOf("-", 0) > 4) || (date.IndexOf("-", 0) < 4))
            {
                MessageBox.Show("You make some dich format error in \"date of birth\" year entering!!! ");
            }
            else if ((date.IndexOf("-", 5) > 7) || (date.IndexOf("-", 5) < 7))
            {
                MessageBox.Show("You make some dich format error in \"date of birth\" month entering!!!");
            }
            else if ((date.Length > 10) || (date.Length < 10))
            {
                MessageBox.Show("You make some dich format error in \"date of birth\" day entering!!! ");
            }
            else if ((int.Parse(date.Substring(5, 2)) < 1) || (int.Parse(date.Substring(5, 2)) > 12))
            {
                MessageBox.Show("You entered not existed month at \"date of birth\" value!!! ");
            }
            else
            {
                connectionToBD();
                SQLiteCommand cmd = cn.CreateCommand();
                cmd.CommandText = "Select id_game from game where data = '" + date + "';";

                SQLiteDataReader reader = cmd.ExecuteReader();
                int counter = 0;
                while (reader.Read())
                {
                    counter++;
                    if (counter > gamesIds.Length)
                    {
                        int[] tempArr = new int[gamesIds.Length];
                        gamesIds.CopyTo(tempArr, 0);
                        gamesIds = new int[counter];
                        tempArr.CopyTo(gamesIds, 0);
                    }
                    gamesIds[counter-1] = int.Parse(reader[0].ToString());
                    //gamesIds.Add(int.Parse(reader[0].ToString()));
                }
                cn.Close();
            }
        }

        private void showAllPlayersAndScoreInDate()
        {
            //int readedDataAmount = 0;
            dataGridView1.Rows.Clear();

            //label4.Text = "gamesIds: " + gamesIds.Length.ToString();

            
            connectionToBD();

            SQLiteCommand cmd;
            SQLiteDataReader reader;

            int counter = 0;
            String p1 = "Unknown";
            String p2 = "Unknown";

            for (int i = 0; i < gamesIds.Length; i++)
            {

                cmd = cn.CreateCommand();
                cmd.CommandText = "SELECT white, black, score FROM game where id_game = " + gamesIds[i] + ";";
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    SQLiteCommand cmd2 = cn.CreateCommand();
                    cmd2.CommandText = "SELECT fio FROM player where id_player = " + int.Parse(reader[0].ToString()) + ";";
                    SQLiteDataReader reader2 = cmd2.ExecuteReader();
                    while (reader2.Read())
                    {
                        p1 = reader2[0].ToString();
                    }
                    reader2.Close();

                    SQLiteCommand cmd3 = cn.CreateCommand();
                    cmd3.CommandText = "SELECT fio FROM player where id_player = " + int.Parse(reader[1].ToString()) + ";";
                    SQLiteDataReader reader3 = cmd3.ExecuteReader();
                    while (reader3.Read())
                    {
                        p2 = reader3[0].ToString();
                    }
                    reader3.Close();

                    dataGridView1.Rows.Add(p1, p2, reader[2].ToString());
                }
                reader.Close();
            }

            cn.Close();
                
                /*int rowToFill = 0;
                while (reader.Read())
                {
                    //label1.Text += reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString() + "; ";
                    if(gameInfoForVisualization.Length <= rowToFill)
                    {
                        label3.Text += " 1 ";
                        string[,] tmpGIFV = new string[gameInfoForVisualization.Length, 3];
                        for (int a = 0; a < gameInfoForVisualization.Length; a++)
                        {
                            for (int b = 0; b < 3; b++)
                            {
                                tmpGIFV[a, b] = gameInfoForVisualization[a, b];
                            }
                        }

                        gameInfoForVisualization = new string[3, 3];
                        for (int a = 0; a < tmpGIFV.Length; a++)
                        {
                            for (int b = 0; b < 3; b++)
                            {
                                gameInfoForVisualization[a, b] = tmpGIFV[a, b];
                            }
                        }

                    }
                    else
                    {
                        label3.Text += " 0 ";
                        gameInfoForVisualization[rowToFill, 0] = reader[0].ToString();
                        gameInfoForVisualization[rowToFill, 1] = reader[1].ToString();
                        gameInfoForVisualization[rowToFill, 2] = reader[2].ToString();
                    }
                    rowToFill++;
                }
            }*/

            /*label2.Text = "gameInfoForVisualization.Length: "+gameInfoForVisualization.Length.ToString();

            for (int i = 0; i < gameInfoForVisualization.Length; i++)
            {
                label1.Text += gameInfoForVisualization[i, 0] + " " + gameInfoForVisualization[i, 1] + " " + gameInfoForVisualization[i, 2] + "; "; 
            }*/
        }

        private void findAllGamesByPlayer_Load(object sender, EventArgs e)
        {

        }

        private void findButton_Click(object sender, EventArgs e)
        {
            gamesIds = new int[1];
            getPlayerIdByDate(textBoxPlayerName.Text);
            showAllPlayersAndScoreInDate();
            textBoxPlayerName.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
