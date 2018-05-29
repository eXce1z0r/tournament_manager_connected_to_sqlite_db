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
    public partial class newPlayerForm : Form
    {
        String dbName = "";
        SQLiteConnection cn = null;
        public newPlayerForm()
        {
            InitializeComponent();

            //this.ent_Ran.MatchRequired = false;
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

        private void button_ent_dat_in_db(object sender, EventArgs e)
        {
            connectionToBD();
            InsertDataInDB();
            cn.Close();
        }

        private void InsertDataInDB()
        {
            if ((ent_Dat_Of_Bir.Text.IndexOf("-", 0) > 4) || (ent_Dat_Of_Bir.Text.IndexOf("-", 0) < 4))
            {
                MessageBox.Show("You make some dich format error in \"date of birth\" year entering!!! ");
            }
            else if ((ent_Dat_Of_Bir.Text.IndexOf("-", 5) > 7) || (ent_Dat_Of_Bir.Text.IndexOf("-", 5) < 7))
            {
                MessageBox.Show("You make some dich format error in \"date of birth\" month entering!!!");
            }
            else if ((ent_Dat_Of_Bir.Text.Length > 10) || (ent_Dat_Of_Bir.Text.Length < 10))
            {
                MessageBox.Show("You make some dich format error in \"date of birth\" day entering!!! ");
            }
            else if ((int.Parse(ent_Dat_Of_Bir.Text.Substring(5, 2)) < 1) || (int.Parse(ent_Dat_Of_Bir.Text.Substring(5, 2)) > 12))
            {
                MessageBox.Show("You entered not existed month at \"date of birth\" value!!! ");
            }

            else if ((ent_Dat_Of_Car_Sta.Text.IndexOf("-", 0) > 4) || (ent_Dat_Of_Car_Sta.Text.IndexOf("-", 0) < 4))
            {
                MessageBox.Show("You make some dich format error in \"date of career start\" year entering!!! ");
            }
            else if ((ent_Dat_Of_Car_Sta.Text.IndexOf("-", 5) > 7) || (ent_Dat_Of_Car_Sta.Text.IndexOf("-", 5) < 7))
            {
                MessageBox.Show("You make some dich format error in \"date of career start\" month entering!!!");
            }
            else if ((ent_Dat_Of_Car_Sta.Text.Length > 10) || (ent_Dat_Of_Car_Sta.Text.Length < 10))
            {
                MessageBox.Show("You make some dich format error in \"date of career start\" day entering!!! ");
            }
            else if ((int.Parse(ent_Dat_Of_Car_Sta.Text.Substring(5, 2)) < 1) || (int.Parse(ent_Dat_Of_Car_Sta.Text.Substring(5, 2)) > 12))
            {
                MessageBox.Show("You entered not existed month at \"date of career start\" value!!! ");
            }
            else
            {
                if (ent_Sur_Nam_Pat.Text == String.Empty ||
                    ent_Dat_Of_Bir.Text == String.Empty ||
                    ent_Hom_Adr.Text == String.Empty ||
                    ent_Tel_Num.Text == String.Empty ||
                    ent_Ran.Text == String.Empty ||
                    ent_Dat_Of_Car_Sta.Text == String.Empty)
                {
                    MessageBox.Show("All lines must be filled!!!");
                }
                else
                {
                    SQLiteCommand cmd = cn.CreateCommand();
                    cmd.CommandText = "INSERT INTO player " +
                    "(id_player, fio, birthday, address, " +
                    "phone, rank, careerstart) " +
                    "VALUES (null, " + "'" + ent_Sur_Nam_Pat.Text + "'," +
                    "'" + ent_Dat_Of_Bir.Text + "'," +
                    "'" + ent_Hom_Adr.Text + "'," +
                    "'" + ent_Tel_Num.Text + "'," +
                    "'" + ent_Ran.Text + "'," +
                    "'" + ent_Dat_Of_Car_Sta.Text + "');";

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("New user successfully created!!!");
                        ent_Sur_Nam_Pat.Text = ""; ent_Dat_Of_Bir.Text = ""; ent_Hom_Adr.Text = "";
                        ent_Tel_Num.Text = ""; ent_Ran.Text = ""; ent_Dat_Of_Car_Sta.Text = "";
                        this.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Error аppeared while I was save data into db");
                    }
                }
            }
        }

        private void ent_Sur_Nam_Pat_TextChanged(object sender, EventArgs e)
        {

        }

        private void ent_Dat_Of_Bir_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ent_Hom_Adr_TextChanged(object sender, EventArgs e)
        {

        }

        private void ent_Tel_Num_TextChanged(object sender, EventArgs e)
        {

        }

        private void ent_Ran_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ent_Dat_Of_Car_Sta_ValueChanged(object sender, EventArgs e)
        {

        }

        private void newPlayerForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void newPlayerForm_Load(object sender, EventArgs e)
        {

        }

        /*private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }*/
    }
}
