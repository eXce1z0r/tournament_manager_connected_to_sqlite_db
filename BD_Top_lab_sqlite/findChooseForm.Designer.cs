namespace BD_Top_lab_sqlite
{
    partial class findChooseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Find_all_gam_by_pla = new System.Windows.Forms.Button();
            this.button_fin_all_pla_and_gam_cou_by_gam_dat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Find_all_gam_by_pla
            // 
            this.button_Find_all_gam_by_pla.Location = new System.Drawing.Point(0, 0);
            this.button_Find_all_gam_by_pla.Name = "button_Find_all_gam_by_pla";
            this.button_Find_all_gam_by_pla.Size = new System.Drawing.Size(150, 265);
            this.button_Find_all_gam_by_pla.TabIndex = 0;
            this.button_Find_all_gam_by_pla.Text = "Find all games by player";
            this.button_Find_all_gam_by_pla.UseVisualStyleBackColor = true;
            this.button_Find_all_gam_by_pla.Click += new System.EventHandler(this.button_Find_all_gam_by_pla_Click);
            // 
            // button_fin_all_pla_and_gam_cou_by_gam_dat
            // 
            this.button_fin_all_pla_and_gam_cou_by_gam_dat.Location = new System.Drawing.Point(150, 0);
            this.button_fin_all_pla_and_gam_cou_by_gam_dat.Name = "button_fin_all_pla_and_gam_cou_by_gam_dat";
            this.button_fin_all_pla_and_gam_cou_by_gam_dat.Size = new System.Drawing.Size(150, 265);
            this.button_fin_all_pla_and_gam_cou_by_gam_dat.TabIndex = 1;
            this.button_fin_all_pla_and_gam_cou_by_gam_dat.Text = "Find all players, and game count by game date";
            this.button_fin_all_pla_and_gam_cou_by_gam_dat.UseVisualStyleBackColor = true;
            this.button_fin_all_pla_and_gam_cou_by_gam_dat.Click += new System.EventHandler(this.button_fin_all_pla_and_gam_cou_by_gam_dat_Click);
            // 
            // findChooseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 261);
            this.Controls.Add(this.button_fin_all_pla_and_gam_cou_by_gam_dat);
            this.Controls.Add(this.button_Find_all_gam_by_pla);
            this.Name = "findChooseForm";
            this.Text = "findChooseForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Find_all_gam_by_pla;
        private System.Windows.Forms.Button button_fin_all_pla_and_gam_cou_by_gam_dat;
    }
}