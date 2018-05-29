namespace BD_Top_lab_sqlite
{
    partial class changeGameInForm
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
            this.ent_Black_Player = new System.Windows.Forms.ComboBox();
            this.ent_White_Player = new System.Windows.Forms.ComboBox();
            this.ent_Score = new System.Windows.Forms.TextBox();
            this.field_Score = new System.Windows.Forms.Label();
            this.button_change_data_in_db = new System.Windows.Forms.Button();
            this.ent_Moves = new System.Windows.Forms.TextBox();
            this.ent_Dat_Of_Gam = new System.Windows.Forms.TextBox();
            this.Moves = new System.Windows.Forms.Label();
            this.field_Black_Player = new System.Windows.Forms.Label();
            this.field_Dat_Of_Gam = new System.Windows.Forms.Label();
            this.field_White_Player = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ent_Black_Player
            // 
            this.ent_Black_Player.FormattingEnabled = true;
            this.ent_Black_Player.Location = new System.Drawing.Point(169, 77);
            this.ent_Black_Player.Name = "ent_Black_Player";
            this.ent_Black_Player.Size = new System.Drawing.Size(272, 21);
            this.ent_Black_Player.TabIndex = 41;
            this.ent_Black_Player.SelectedIndexChanged += new System.EventHandler(this.ent_Black_Player_SelectedIndexChanged);
            // 
            // ent_White_Player
            // 
            this.ent_White_Player.FormattingEnabled = true;
            this.ent_White_Player.Location = new System.Drawing.Point(169, 47);
            this.ent_White_Player.Name = "ent_White_Player";
            this.ent_White_Player.Size = new System.Drawing.Size(272, 21);
            this.ent_White_Player.TabIndex = 40;
            this.ent_White_Player.SelectedIndexChanged += new System.EventHandler(this.ent_White_Player_SelectedIndexChanged);
            // 
            // ent_Score
            // 
            this.ent_Score.Location = new System.Drawing.Point(168, 107);
            this.ent_Score.Name = "ent_Score";
            this.ent_Score.Size = new System.Drawing.Size(272, 20);
            this.ent_Score.TabIndex = 39;
            this.ent_Score.TextChanged += new System.EventHandler(this.ent_Score_TextChanged);
            // 
            // field_Score
            // 
            this.field_Score.AutoSize = true;
            this.field_Score.Location = new System.Drawing.Point(24, 110);
            this.field_Score.Name = "field_Score";
            this.field_Score.Size = new System.Drawing.Size(41, 13);
            this.field_Score.TabIndex = 38;
            this.field_Score.Text = "Score: ";
            // 
            // button_change_data_in_db
            // 
            this.button_change_data_in_db.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_change_data_in_db.Location = new System.Drawing.Point(312, 225);
            this.button_change_data_in_db.Name = "button_change_data_in_db";
            this.button_change_data_in_db.Size = new System.Drawing.Size(129, 36);
            this.button_change_data_in_db.TabIndex = 37;
            this.button_change_data_in_db.Text = "Change data in DB";
            this.button_change_data_in_db.UseVisualStyleBackColor = true;
            this.button_change_data_in_db.Click += new System.EventHandler(this.button_change_data_in_db_Click);
            // 
            // ent_Moves
            // 
            this.ent_Moves.Location = new System.Drawing.Point(169, 150);
            this.ent_Moves.Multiline = true;
            this.ent_Moves.Name = "ent_Moves";
            this.ent_Moves.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ent_Moves.Size = new System.Drawing.Size(272, 52);
            this.ent_Moves.TabIndex = 36;
            this.ent_Moves.TextChanged += new System.EventHandler(this.ent_Moves_TextChanged);
            // 
            // ent_Dat_Of_Gam
            // 
            this.ent_Dat_Of_Gam.Location = new System.Drawing.Point(169, 17);
            this.ent_Dat_Of_Gam.Name = "ent_Dat_Of_Gam";
            this.ent_Dat_Of_Gam.Size = new System.Drawing.Size(272, 20);
            this.ent_Dat_Of_Gam.TabIndex = 35;
            this.ent_Dat_Of_Gam.TextChanged += new System.EventHandler(this.ent_Dat_Of_Gam_TextChanged);
            // 
            // Moves
            // 
            this.Moves.AutoSize = true;
            this.Moves.Location = new System.Drawing.Point(24, 153);
            this.Moves.Name = "Moves";
            this.Moves.Size = new System.Drawing.Size(45, 13);
            this.Moves.TabIndex = 34;
            this.Moves.Text = "Moves: ";
            // 
            // field_Black_Player
            // 
            this.field_Black_Player.AutoSize = true;
            this.field_Black_Player.Location = new System.Drawing.Point(24, 80);
            this.field_Black_Player.Name = "field_Black_Player";
            this.field_Black_Player.Size = new System.Drawing.Size(71, 13);
            this.field_Black_Player.TabIndex = 33;
            this.field_Black_Player.Text = "Black player: ";
            // 
            // field_Dat_Of_Gam
            // 
            this.field_Dat_Of_Gam.AutoSize = true;
            this.field_Dat_Of_Gam.Location = new System.Drawing.Point(24, 20);
            this.field_Dat_Of_Gam.Name = "field_Dat_Of_Gam";
            this.field_Dat_Of_Gam.Size = new System.Drawing.Size(140, 13);
            this.field_Dat_Of_Gam.TabIndex = 32;
            this.field_Dat_Of_Gam.Text = "Date of game (yyyy-mm-dd): ";
            // 
            // field_White_Player
            // 
            this.field_White_Player.AutoSize = true;
            this.field_White_Player.Location = new System.Drawing.Point(24, 50);
            this.field_White_Player.Name = "field_White_Player";
            this.field_White_Player.Size = new System.Drawing.Size(72, 13);
            this.field_White_Player.TabIndex = 31;
            this.field_White_Player.Text = "White player: ";
            // 
            // changeGameInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 278);
            this.Controls.Add(this.ent_Black_Player);
            this.Controls.Add(this.ent_White_Player);
            this.Controls.Add(this.ent_Score);
            this.Controls.Add(this.field_Score);
            this.Controls.Add(this.button_change_data_in_db);
            this.Controls.Add(this.ent_Moves);
            this.Controls.Add(this.ent_Dat_Of_Gam);
            this.Controls.Add(this.Moves);
            this.Controls.Add(this.field_Black_Player);
            this.Controls.Add(this.field_Dat_Of_Gam);
            this.Controls.Add(this.field_White_Player);
            this.Name = "changeGameInForm";
            this.Text = "changeGameInForm";
            this.Load += new System.EventHandler(this.changeGameInForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ent_Black_Player;
        private System.Windows.Forms.ComboBox ent_White_Player;
        private System.Windows.Forms.TextBox ent_Score;
        private System.Windows.Forms.Label field_Score;
        private System.Windows.Forms.Button button_change_data_in_db;
        private System.Windows.Forms.TextBox ent_Moves;
        private System.Windows.Forms.TextBox ent_Dat_Of_Gam;
        private System.Windows.Forms.Label Moves;
        private System.Windows.Forms.Label field_Black_Player;
        private System.Windows.Forms.Label field_Dat_Of_Gam;
        private System.Windows.Forms.Label field_White_Player;
    }
}