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
    public partial class Form1 : Form
    {
        String dbName = "Chess.sqlite3";
        SQLiteConnection cn = null;
        public Form1()
        {
            InitializeComponent();
            connectionToBD();
        }

        public void connectionToBD()
        {
            cn = new SQLiteConnection("Data Source =" + dbName);
            cn.Open();
        }

        private void newPlayerButton_Click(object sender, EventArgs e)
        {
            newPlayerForm newPF = new newPlayerForm();
            newPF.Show();
        }

        private void removePlayerButton_Click(object sender, EventArgs e)
        {

        }

        private void changePlayerButton_Click(object sender, EventArgs e)
        {

        }

        private void newGameButton_Click(object sender, EventArgs e)
        {

        }

        private void removeGameButton_Click(object sender, EventArgs e)
        {

        }

        private void changeGameButton_Click(object sender, EventArgs e)
        {

        }

        private void findInDatabaseButton_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //cn.Close();
            try
            {
                Close();
            }
            catch(System.StackOverflowException error)
            {
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
