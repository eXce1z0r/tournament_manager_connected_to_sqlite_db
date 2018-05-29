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
    public partial class changeGameInForm : Form
    {
        private String dbName = "";
        private SQLiteConnection cn = null;
        private int id = 0;

        public changeGameInForm()
        {
            InitializeComponent();
        }

        public void connectionToBD()
        {
            cn = new SQLiteConnection("Data Source =" + dbName);
            cn.Open();
        }

        public void setMainOptions(string dbName, int id)
        {
            this.dbName = dbName;
            this.id = id;
        }

        private void changeGameInForm_Load(object sender, EventArgs e)
        {
            connectionToBD();
            SQLiteCommand cmd = cn.CreateCommand();
            cmd.CommandText = "Select data, white, black, score, moves from game where id_game = "+id+";";
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ent_Dat_Of_Gam.Text = DateTime.Parse(reader[0].ToString()).ToShortDateString();
                ent_White_Player.Text = reader[1].ToString();
                ent_Black_Player.Text = reader[2].ToString();
                ent_Score.Text = reader[3].ToString();
                byte[] byteArray = (byte[])reader[4];
                string moves = "";
                for(int i = 0; i < byteArray.Length; i++)
                {
                    moves += (char)int.Parse(byteArray[i].ToString());
                }
                ent_Moves.Text = moves;
            }

            cn.Close();
        }

        private void ent_Dat_Of_Gam_TextChanged(object sender, EventArgs e)
        {

        }

        private void ent_White_Player_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ent_Black_Player_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ent_Score_TextChanged(object sender, EventArgs e)
        {

        }

        private void ent_Moves_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_change_data_in_db_Click(object sender, EventArgs e)
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
                    connectionToBD();
                    int whitePlayer = 0;
                    int blackPlayer = 0;
                    SQLiteCommand cmd1 = cn.CreateCommand();
                    cmd1.CommandText = "Select id_player from player where fio = '" + ent_White_Player.Text + "';";
                    SQLiteDataReader reader1 = cmd1.ExecuteReader();
                    while (reader1.Read())
                    {
                        whitePlayer = int.Parse(reader1[0].ToString());
                    }

                    SQLiteCommand cmd2 = cn.CreateCommand();
                    cmd2.CommandText = "Select id_player from player where fio = '" + ent_Black_Player.Text + "';";
                    SQLiteDataReader reader2 = cmd2.ExecuteReader();
                    while (reader2.Read())
                    {
                        blackPlayer = int.Parse(reader2[0].ToString());
                    }

                    SQLiteCommand cmd = cn.CreateCommand();
                    cmd.CommandText = "Update game set data = '" + /*DateTime.Parse(*/ent_Dat_Of_Gam.Text/*).ToShortDateString()*/ + "', white = '" + whitePlayer.ToString() + "', black = '" + blackPlayer.ToString() + "', score = '" + ent_Score.Text + "', score = '" + ent_Moves.Text + "' where id_game = " + id + ";";
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Success!!!");
                    }
                    else
                    {

                    }
                    cn.Close();
                }
            }
        }
    }
}
