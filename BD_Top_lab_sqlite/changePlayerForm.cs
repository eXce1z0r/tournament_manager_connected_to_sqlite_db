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
    public partial class changePlayerForm : Form
    {
        private String dbName = "";
        private SQLiteConnection cn = null;
        private const String labelText = "Player name: ";
        private int selectedRowIndex = 0;
        private DataGridViewCellCollection currSelectedFields = null;

        public changePlayerForm()
        {
            InitializeComponent();
        }

        public void connectionToBD()
        {
            cn = new SQLiteConnection("Data Source =" + dbName);
            cn.Open();
        }

        private void changePlayerForm_Load(object sender, EventArgs e)
        {
            connectionToBD();
            tabLoading();
        }

        private void tabLoading()
        {
            SQLiteCommand cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT * FROM player;";

            SQLiteDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader[0].ToString(), reader[1].ToString(), DateTime.Parse(reader[2].ToString()).ToShortDateString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), DateTime.Parse(reader[6].ToString()).ToShortDateString());
            }
            reader.Close();
            cn.Close();
        }

        public void setDBName(String name)
        {
            dbName = name;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowIndex = e.RowIndex;
            if ((selectedRowIndex >= 0) && (selectedRowIndex < dataGridView1.Rows.Count))
            {
                changePlayerNameLabel.Text = labelText + dataGridView1.Rows[selectedRowIndex].Cells[1].Value;
                currSelectedFields = dataGridView1.Rows[selectedRowIndex].Cells;
            }
        }

        private void ChangeProcedure()
        {
            /*SQLiteCommand cmd = cn.CreateCommand();
            cmd.CommandText = "Delete FROM player WHERE id_player = " + dataGridView1.Rows[selectedRowIndex].Cells[0].Value + ";";
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Successfully changed.");
                updateForm();
                //this.Refresh();
            }
            else
            {
                MessageBox.Show("Shit happens!");
            }*/
            changePlayerInForm changePIF = new changePlayerInForm();
            changePIF.setMainOptions(currSelectedFields, dbName, selectedRowIndex);
            if(changePIF.ShowDialog(this) == DialogResult.OK)
            {
                updateForm();
            }
        }

        public void updateForm()
        {
            dataGridView1.Rows.Clear();
            tabLoading();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            if (changePlayerNameLabel.Text.Length == labelText.Length)
            {
                MessageBox.Show("Chto ti tvorish!!! Ostanovis' hvatit.");
            }
            else
            {
                connectionToBD();
                ChangeProcedure();
                cn.Close();
            }
        }
    }
}
