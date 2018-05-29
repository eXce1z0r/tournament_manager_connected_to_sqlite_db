namespace BD_Top_lab_sqlite
{
    partial class findAllGamesByPlayer
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.findGamesButton = new System.Windows.Forms.Button();
            this.labelPlayerName = new System.Windows.Forms.Label();
            this.textBoxPlayerName = new System.Windows.Forms.TextBox();
            this.id_game = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.white = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.black = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moves = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_game,
            this.data,
            this.white,
            this.black,
            this.score,
            this.moves});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(641, 309);
            this.dataGridView1.TabIndex = 0;
            // 
            // findGamesButton
            // 
            this.findGamesButton.Location = new System.Drawing.Point(577, 333);
            this.findGamesButton.Name = "findGamesButton";
            this.findGamesButton.Size = new System.Drawing.Size(75, 23);
            this.findGamesButton.TabIndex = 1;
            this.findGamesButton.Text = "Find";
            this.findGamesButton.UseVisualStyleBackColor = true;
            this.findGamesButton.Click += new System.EventHandler(this.findGamesButton_Click);
            // 
            // labelPlayerName
            // 
            this.labelPlayerName.AutoSize = true;
            this.labelPlayerName.Location = new System.Drawing.Point(16, 337);
            this.labelPlayerName.Name = "labelPlayerName";
            this.labelPlayerName.Size = new System.Drawing.Size(71, 13);
            this.labelPlayerName.TabIndex = 2;
            this.labelPlayerName.Text = "Player name: ";
            // 
            // textBoxPlayerName
            // 
            this.textBoxPlayerName.Location = new System.Drawing.Point(93, 335);
            this.textBoxPlayerName.Name = "textBoxPlayerName";
            this.textBoxPlayerName.Size = new System.Drawing.Size(478, 20);
            this.textBoxPlayerName.TabIndex = 3;
            this.textBoxPlayerName.TextChanged += new System.EventHandler(this.textBoxPlayerName_TextChanged);
            // 
            // id_game
            // 
            this.id_game.Frozen = true;
            this.id_game.HeaderText = "id_game";
            this.id_game.Name = "id_game";
            this.id_game.ReadOnly = true;
            // 
            // data
            // 
            this.data.Frozen = true;
            this.data.HeaderText = "data";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            // 
            // white
            // 
            this.white.Frozen = true;
            this.white.HeaderText = "white";
            this.white.Name = "white";
            this.white.ReadOnly = true;
            // 
            // black
            // 
            this.black.Frozen = true;
            this.black.HeaderText = "black";
            this.black.Name = "black";
            this.black.ReadOnly = true;
            // 
            // score
            // 
            this.score.Frozen = true;
            this.score.HeaderText = "score";
            this.score.Name = "score";
            this.score.ReadOnly = true;
            // 
            // moves
            // 
            this.moves.Frozen = true;
            this.moves.HeaderText = "moves";
            this.moves.Name = "moves";
            this.moves.ReadOnly = true;
            // 
            // findAllGamesByPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 374);
            this.Controls.Add(this.textBoxPlayerName);
            this.Controls.Add(this.labelPlayerName);
            this.Controls.Add(this.findGamesButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "findAllGamesByPlayer";
            this.Text = "findAllGamesByPlayer";
            this.Load += new System.EventHandler(this.findAllGamesByPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button findGamesButton;
        private System.Windows.Forms.Label labelPlayerName;
        private System.Windows.Forms.TextBox textBoxPlayerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_game;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn white;
        private System.Windows.Forms.DataGridViewTextBoxColumn black;
        private System.Windows.Forms.DataGridViewTextBoxColumn score;
        private System.Windows.Forms.DataGridViewTextBoxColumn moves;
    }
}