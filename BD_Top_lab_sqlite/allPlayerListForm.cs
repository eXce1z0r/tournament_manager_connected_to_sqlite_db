using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.Common;

namespace BD_Top_lab_sqlite
{
    public partial class allPlayerListForm : Form
    {
        private String dbName = "";
        private SQLiteConnection cn = null;
        public allPlayerListForm()
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
            showAllPlayers();
        }

        private void showAllPlayers()
        {
            connectionToBD();
            SQLiteCommand cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT * FROM player;";

            SQLiteDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                //DateTime dateST = reader.Va
                //label1.Text = reader.GetValue(2);
                //DateTime dateST = DateTime.ParseExact(reader.GetValue(2));
                //DateTime dateST = DateTime.Parse(reader[2].ToString()); 
                //DateTime dateST = DateTime.Parse(String.Parreader[2]); 
                //dataGridView1.Rows.Add(reader[0].ToString(), reader[1].ToString()/*, reader[2].ToString("yyyy/mm/dd")*/, reader[3].ToString(), reader[4].ToString(), reader[5].ToString());
                dataGridView1.Rows.Add(reader[0].ToString(), reader[1].ToString(), DateTime.Parse(reader[2].ToString()).ToShortDateString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), DateTime.Parse(reader[6].ToString()).ToShortDateString());
            }
            //label1.Text = reader

            //while (reader.Read())
            //{
                //Console.WriteLine(String.Format("{0}", reader[0]));
                
                /*String id_player = reader[0].ToString();
                String fio = reader[1].ToString();
                String birthday = reader[2].ToString();
                String address = reader[3].ToString();
                String phone = reader[4].ToString();
                String rank = reader[5].ToString();
                String careerstart = reader[6].ToString();
                String[] res = { id_player, fio, birthday, address, phone, rank, careerstart };*/
                /*label1.Text = reader.GetString(1);*/

                /*String id_player = record.GetValue(0).ToString();
                String fio = record.GetValue(1).ToString();
                String birthday = record.GetValue(2).ToString();
                String address = record.GetValue(3).ToString();
                String phone = record.GetValue(4).ToString();
                String rank = record.GetValue(5).ToString();
                String careerstart = record.GetValue(6).ToString();
                String[] res = { id_player, fio, birthday, address, phone, rank, careerstart };*/

           //     DateTime res = reader.GetDateTime(2);
           //     label1.Text = res.ToString();
           //     dataGridView1.Rows.Add(reader[0].ToString(), reader[1].ToString()/*, str*//*reader.GetDateTime(2),*/ , reader[3].ToString(), reader[4].ToString(), reader[5].ToString());
           //}

            /*(cmd.ExecuteNonQuery()==1)
            {

            }*/
            /*SQLiteDataReader reader = cmd.ExecuteReader(); //3
            label1.Text = reader.GetValue(0).ToString();
            foreach (DbDataRecord record in reader) //4
            {
                String id_player = record.GetValue(0).ToString();
                String fio = record.GetValue(1).ToString();
                String birthday = record.GetValue(2).ToString();
                String address = record.GetValue(3).ToString();
                String phone = record.GetValue(4).ToString();
                String rank = record.GetValue(5).ToString();
                String careerstart = record.GetValue(6).ToString();
                String[] res = {id_player, fio, birthday, address, phone, rank, careerstart};
                dataGridView1.Rows.Add(record);
                //selectBox.Text += record["id_player"] + " " + record["fio"] + Environment.NewLine;
            }*/
            reader.Close();
            cn.Close();
        }

        private void allPlayerListForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
