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
    public partial class removeGameForm : Form
    {
        String dbName = "";
        SQLiteConnection cn = null;

        public removeGameForm()
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

        private void removeGameForm_Load(object sender, EventArgs e)
        {
            loadGameListFromDB();
            buttonRemove.Enabled = false;
        }

        private void loadGameListFromDB()
        {
            connectionToBD();
            SQLiteCommand cmd = cn.CreateCommand();
            cmd.CommandText = "Select * from game;";
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string movesStr = "";
                byte[] movesByte = (byte[])reader[5];
                for (int i = 0; i < movesByte.Length; i++)
                {
                    movesStr += (char)int.Parse(movesByte[i].ToString());
                }
                comboBox1.Items.Add(reader[0].ToString() + " " + DateTime.Parse(reader[1].ToString()).ToShortDateString().ToString() + " " + reader[2].ToString() + " " + reader[3].ToString() + " " + reader[4].ToString() + " " + movesStr);
            }
            cn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void removeById(int id)
        {
            connectionToBD();
            SQLiteCommand cmd = cn.CreateCommand();
            cmd.CommandText = "Delete FROM game WHERE id_game = " + id + ";";
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("Fail");
            }
            cn.Close();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            //connectionToBD();
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Fail");
            }
            else
            {
                //label1.Text = comboBox1.Text.IndexOfAny(new char[10] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' }, 0, comboBox1.Text.Length).ToString();
                if (comboBox1.Text.IndexOfAny(new char[10] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' }, 0, comboBox1.Text.Length) == -1)
                {
                    MessageBox.Show("Stop ti delaesh mne bolno!!!");
                }
                else if(comboBox1.Text.IndexOf(" ") < 0)
                {
                    MessageBox.Show("AAAAAAAAAAA!!!");
                }
                else
                {
                    int removeGameId = int.Parse(comboBox1.Text.Substring(0, comboBox1.Text.IndexOf(" ")));
                    removeById(removeGameId);
                    comboBox1.Text = "";
                    comboBox1.Items.Clear();
                    loadGameListFromDB();
                }
                //label1.Text = "|" + comboBox1.Text.Substring(0, comboBox1.Text.IndexOf(" ")) + "| - " + comboBox1.Text.IndexOf(" ");
                //cn.Close();
            }
        }

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
            buttonRemove.Enabled = false;
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            buttonRemove.Enabled = true;
        }
    }
}
