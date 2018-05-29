using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BD_Top_lab_sqlite
{
    public partial class findChooseForm : Form
    {
        private String dbName = "";
        public findChooseForm()
        {
            InitializeComponent();
        }

        private void button_Find_all_gam_by_pla_Click(object sender, EventArgs e)
        {
            findAllGamesByPlayer findAGBP = new findAllGamesByPlayer();
            findAGBP.setDBName(dbName);
            findAGBP.Show();
            this.Close();
        }

        public void setDBName(String name)
        {
            dbName = name;
        }

        private void button_fin_all_pla_and_gam_cou_by_gam_dat_Click(object sender, EventArgs e)
        {
            findAllPlayersAndGamesCountByGameDateForm findAPAGCBGDF = new findAllPlayersAndGamesCountByGameDateForm();
            findAPAGCBGDF.setDBName(dbName);
            findAPAGCBGDF.Show();
            this.Close();
        }
    }
}
