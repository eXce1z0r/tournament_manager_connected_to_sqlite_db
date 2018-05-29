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
        private String dbName = "Chess.sqlite3";
        //SQLiteConnection cn = null;
        public Form1()
        {
            InitializeComponent();
            //connectionToBD();
        }

        /*public void connectionToBD()
        {
            cn = new SQLiteConnection("Data Source =" + dbName);
            cn.Open();
        }*/

        private void showAllPlayersButton_Click(object sender, EventArgs e)
        {
            allPlayerListForm allPLF = new allPlayerListForm();
            allPLF.setDBName(dbName);
            allPLF.Show();
        }

        private void newPlayerButton_Click(object sender, EventArgs e)
        {
            newPlayerForm newPF = new newPlayerForm();
            newPF.setDBName(dbName/*"Chess.sqlite3"*/);
            newPF.Show();
        }

        private void removePlayerButton_Click(object sender, EventArgs e)
        {
            removePlayerForm removePF = new removePlayerForm();
            removePF.setDBName(dbName);
            removePF.Show();
        }

        private void changePlayerButton_Click(object sender, EventArgs e)
        {
            changePlayerForm changePF = new changePlayerForm();
            changePF.setDBName(dbName);
            changePF.Show();
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            newGameForm newGF = new newGameForm();
            newGF.setDBName(dbName);
            newGF.Show();
        }

        private void removeGameButton_Click(object sender, EventArgs e)
        {
            removeGameForm removeGF = new removeGameForm();
            removeGF.setDBName(dbName);
            removeGF.Show();
        }

        private void changeGameButton_Click(object sender, EventArgs e)
        {
            changeGameForm changeGF = new changeGameForm();
            changeGF.setDBName(dbName);
            changeGF.Show();
        }

        private void findInDatabaseButton_Click(object sender, EventArgs e)
        {
            findChooseForm findCF = new findChooseForm();
            findCF.setDBName(dbName);
            findCF.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //cn.Close();
            /*try
            {
                Close();
            }
            catch(System.StackOverflowException error)
            {
                
            }*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
