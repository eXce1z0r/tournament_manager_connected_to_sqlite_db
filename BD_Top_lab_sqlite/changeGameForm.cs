﻿using System;
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
    public partial class changeGameForm : Form
    {
        String dbName = "";
        SQLiteConnection cn = null;

        public changeGameForm()
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

        private void changeGameForm_Load(object sender, EventArgs e)
        {
            loadGameListFromDB();
            buttonChange.Enabled = false;
        }

        private void loadGameListFromDB()
        {
            connectionToBD();
            SQLiteCommand cmd = cn.CreateCommand();
            cmd.CommandText = "Select id_game, data, white, black, score, moves from game;";
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string movesStr = "";
                byte[] movesByte = (byte[])reader[5];
                for (int i = 0; i < movesByte.Length; i++)
                {
                    movesStr += (char)int.Parse(movesByte[i].ToString());
                }
                comboBox1.Items.Add(reader[0].ToString() + " " + DateTime.Parse(reader[1].ToString()).ToShortDateString() + " " + reader[2].ToString() + " " + reader[3].ToString() + " " + reader[4].ToString() + " " + movesStr);
            }
            cn.Close();
        }

        private void changeById(int id)
        {
            connectionToBD();
            changeGameInForm changeGIF = new changeGameInForm();
            changeGIF.setMainOptions(dbName, id);
            if (changeGIF.ShowDialog(this) == DialogResult.OK)
            {

            }

            /*SQLiteCommand cmd = cn.CreateCommand();
            cmd.CommandText = "Delete FROM game WHERE id_game = " + id + ";";
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("Fail");
            }*/
            cn.Close();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Fail");
            }
            else
            {
                if (comboBox1.Text.IndexOfAny(new char[10] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' }, 0, comboBox1.Text.Length) == -1)
                {
                    MessageBox.Show("Stop ti delaesh mne bolno!!!");
                }
                else if (comboBox1.Text.IndexOf(" ") < 0)
                {
                    MessageBox.Show("AAAAAAAAAAA!!!");
                }
                else
                {
                    int removeGameId = int.Parse(comboBox1.Text.Substring(0, comboBox1.Text.IndexOf(" ")));
                    changeById(removeGameId);
                    comboBox1.Text = "";
                    comboBox1.Items.Clear();
                    loadGameListFromDB();
                }
            }
        }

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
            buttonChange.Enabled = false;
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            buttonChange.Enabled = true;
        }
    }
}
