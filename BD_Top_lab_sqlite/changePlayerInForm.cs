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
    public partial class changePlayerInForm : Form
    {
        private String dbName = "";
        private int change_Index = 0;
        private SQLiteConnection cn = null;
        DataGridViewCellCollection defaultFields = null;

        public changePlayerInForm()
        {
            InitializeComponent();
        }

        private void changePlayerInForm_Load(object sender, EventArgs e)
        {
            if (defaultFields == null)
            {
                MessageBox.Show("Somthing wrong with field which you choose!");
            }
            else
            {
                ent_Sur_Nam_Pat.Text = defaultFields[1].Value.ToString();
                ent_Dat_Of_Bir.Text = defaultFields[2].Value.ToString();
                ent_Hom_Adr.Text = defaultFields[3].Value.ToString();
                ent_Tel_Num.Text = defaultFields[4].Value.ToString();
                ent_Ran.Text = defaultFields[5].Value.ToString();
                ent_Dat_Of_Car_Sta.Text = defaultFields[6].Value.ToString();
            }
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
                    /*cmd.CommandText = "UPDATE player SET id_player = null, fio = '" + ent_Sur_Nam_Pat.Text + 
                        "', birthday = '" + ent_Dat_Of_Bir.Text + 
                        "', address = '" + ent_Hom_Adr.Text + 
                        "', phone = '" + ent_Tel_Num.Text + 
                        "', rank = '" + ent_Ran.Text + 
                        "', careerstart = '" + ent_Dat_Of_Car_Sta.Text + "';";*/

                    cmd.CommandText = "UPDATE player SET fio = '" + ent_Sur_Nam_Pat.Text +
                        "', birthday = '" + ent_Dat_Of_Bir.Text +
                        "', address = '" + ent_Hom_Adr.Text +
                        "', phone = '" + ent_Tel_Num.Text +
                        "', rank = '" + ent_Ran.Text +
                        "', careerstart = '" + ent_Dat_Of_Car_Sta.Text + "' WHERE id_player = " + defaultFields[0].Value.ToString() +";";


                    /*                    "VALUES (null, " + "'" + ent_Sur_Nam_Pat.Text + "'," +
                    "'" + ent_Dat_Of_Bir.Text + "'," +
                    "'" + ent_Hom_Adr.Text + "'," +
                    "'" + ent_Tel_Num.Text + "'," +
                    "'" + ent_Ran.Text + "'," +
                    "'" + ent_Dat_Of_Car_Sta.Text + "');";*/

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Date successfully changed!");
                        ent_Sur_Nam_Pat.Text = ""; ent_Dat_Of_Bir.Text = ""; ent_Hom_Adr.Text = "";
                        ent_Tel_Num.Text = ""; ent_Ran.Text = ""; ent_Dat_Of_Car_Sta.Text = "";
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error happened while I was try to save changes to DB");
                    }
                }
            }
        }

        public void connectionToBD()
        {
            cn = new SQLiteConnection("Data Source =" + dbName);
            cn.Open();
        }

        public void setMainOptions(DataGridViewCellCollection defaultFields, String dbName, int index)
        {
            this.dbName = dbName;
            change_Index = index;
            this.defaultFields = defaultFields;
        }

        private void button_change_data_in_db_Click(object sender, EventArgs e)
        {
            connectionToBD();
            InsertDataInDB();
            cn.Close();
        }

        private void ent_Sur_Nam_Pat_TextChanged(object sender, EventArgs e)
        {

        }

        private void ent_Dat_Of_Bir_TextChanged(object sender, EventArgs e)
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

        private void ent_Dat_Of_Car_Sta_TextChanged(object sender, EventArgs e)
        {

        }

        private void changePlayerInForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            /*if (this.ParentForm is changePlayerForm)
            {
                changePlayerForm tmp = this.ParentForm as changePlayerForm;
                tmp.updateForm();
            }*/
        }



    }
}
