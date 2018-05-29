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
    public partial class removePlayerForm : Form
    {
        private String dbName = "";
        private  SQLiteConnection cn = null;
        private const String labelText = "Player name: ";
        private int selectedRowIndex = 0;

        public removePlayerForm()
        {
            InitializeComponent();
        }

        public void connectionToBD()
        {
            cn = new SQLiteConnection("Data Source =" + dbName);
            cn.Open();
        }

        private void removePlayerForm_Load(object sender, EventArgs e)
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
            //removedPlayerNameLabel.Text = labelText + dataGridView1.Rows.SharedRow(e.RowIndex).Cells.;
            selectedRowIndex = e.RowIndex;
            if ((selectedRowIndex >= 0) && (selectedRowIndex < dataGridView1.Rows.Count))
            {
                removedPlayerNameLabel.Text = labelText + dataGridView1.Rows[selectedRowIndex].Cells[1].Value;
            }
        }

        private void RemoveProcedure()
        {
            SQLiteCommand cmd = cn.CreateCommand();
            //label1.Text = dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString();
            cmd.CommandText = "Delete FROM player WHERE id_player = "+ dataGridView1.Rows[selectedRowIndex].Cells[0].Value + ";";
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Successfully deleted.");
                updateForm();
                this.Refresh();
            }
            else
            {
                MessageBox.Show("Shit happens!");
            }
        }

        private void updateForm()
        {
            dataGridView1.Rows.Clear();
            tabLoading();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (removedPlayerNameLabel.Text.Length == labelText.Length)
            {
                MessageBox.Show("Chto ti tvorish!!! Ostanovis' hvatit.");
            }
            else
            {
                connectionToBD();
                RemoveProcedure();
                cn.Close();
            }
        }
    }
}
