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
    public partial class newGameForm : Form
    {
        String dbName = "";
        SQLiteConnection cn = null;

        public newGameForm()
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

        private void field_Dat_Of_Bir_Click(object sender, EventArgs e)
        {

        }

        private void newGameForm_Load(object sender, EventArgs e)
        {
            connectionToBD();
            SQLiteCommand cmd = cn.CreateCommand();
            cmd.CommandText = "Select fio from player;";
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ent_White_Player.Items.Add(reader[0].ToString());
                ent_Black_Player.Items.Add(reader[0].ToString());
            }
            reader.Close();
            cn.Close();
        }

        private void button_enter_data_in_db_Click(object sender, EventArgs e)
        {
            connectionToBD();
            InsertDataInDB();
            cn.Close();
        }

        private void InsertDataInDB()
        {
            if ((ent_Dat_Of_Gam.Text.IndexOf("-", 0) > 4) || (ent_Dat_Of_Gam.Text.IndexOf("-", 0) < 4))
            {
                MessageBox.Show("You make some dich format error in \"date of game\" year entering!!! ");
            }
            else if ((ent_Dat_Of_Gam.Text.IndexOf("-", 5) > 7) || (ent_Dat_Of_Gam.Text.IndexOf("-", 5) < 7))
            {
                MessageBox.Show("You make some dich format error in \"date of game\" month entering!!!");
            }
            else if ((ent_Dat_Of_Gam.Text.Length > 10) || (ent_Dat_Of_Gam.Text.Length < 10))
            {
                MessageBox.Show("You make some dich format error in \"date of game\" day entering!!! ");
            }
            else if ((int.Parse(ent_Dat_Of_Gam.Text.Substring(5, 2)) < 1) || (int.Parse(ent_Dat_Of_Gam.Text.Substring(5, 2)) > 12))
            {
                MessageBox.Show("You entered not existed month at \"date of game\" value!!! ");
            }
            else
            {
                if (ent_Dat_Of_Gam.Text == String.Empty ||
                    ent_White_Player.Text == String.Empty ||
                    ent_Black_Player.Text == String.Empty ||
                    ent_Score.Text == String.Empty ||
                    ent_Moves.Text == String.Empty)
                {
                    MessageBox.Show("All lines must be filled!!!");
                }
                else
                {
                    int whitePlayerId = -1;
                    int blackPlayerId = -1;
                    SQLiteCommand cmd1 = cn.CreateCommand();
                    cmd1.CommandText = "Select id_player from player where fio = '" + ent_White_Player.Text + "';";
                    SQLiteDataReader reader1 = cmd1.ExecuteReader();
                    while (reader1.Read())
                    {
                        whitePlayerId = int.Parse(reader1[0].ToString());
                    }
                    /*while (reader1.HasRows)
                    {
                        reader1.Read();
                        whitePlayerId = int.Parse(reader1[0].ToString());
                    }*/

                    SQLiteCommand cmd2 = cn.CreateCommand();
                    cmd2.CommandText = "Select id_player from player where fio = '" + ent_Black_Player.Text + "';";
                    SQLiteDataReader reader2 = cmd2.ExecuteReader();
                    while (reader2.Read())
                    {                        
                        blackPlayerId = int.Parse(reader2[0].ToString());
                    }

                    if(whitePlayerId == -1)
                    {
                        MessageBox.Show("Can't find player known as \"" + ent_White_Player.Text + "\"!");
                    }
                    else if (blackPlayerId == -1)
                    {
                        MessageBox.Show("Can't find player known as \"" + ent_Black_Player.Text + "\"!");
                    }
                    else
                    {
                        SQLiteCommand cmd = cn.CreateCommand();
                        cmd.CommandText = "INSERT INTO game " +
                        "(id_game, data, white, black, " +
                        "score, moves) " +
                        "VALUES (null, " + "'" + ent_Dat_Of_Gam.Text + "'," +
                        "'" + whitePlayerId.ToString() + "'," +
                        "'" + blackPlayerId.ToString() + "'," +
                        "'" + ent_Score.Text + "'," +
                        "'" + ent_Moves.Text + "');";

                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("New user successfully created!!!");
                            ent_Dat_Of_Gam.Text = ""; 
                            ent_White_Player.Text = ""; 
                            ent_Moves.Text = "";
                            ent_Black_Player.Text = ""; 
                            ent_Score.Text = ""; 
                            ent_Moves.Text = "";
                            this.Refresh();
                        }
                        else
                        {
                            MessageBox.Show("Error аppeared while I was save data into db");
                        }
                    }
                }
            }
        }
    }
}
