namespace BD_Top_lab_sqlite
{
    partial class findAllPlayersAndGamesCountByGameDateForm
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
            this.white = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.black = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxPlayerName = new System.Windows.Forms.TextBox();
            this.labelPlayerName = new System.Windows.Forms.Label();
            this.findGamesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.white,
            this.black,
            this.score});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(641, 309);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // textBoxPlayerName
            // 
            this.textBoxPlayerName.Location = new System.Drawing.Point(147, 335);
            this.textBoxPlayerName.Name = "textBoxPlayerName";
            this.textBoxPlayerName.Size = new System.Drawing.Size(424, 20);
            this.textBoxPlayerName.TabIndex = 6;
            // 
            // labelPlayerName
            // 
            this.labelPlayerName.AutoSize = true;
            this.labelPlayerName.Location = new System.Drawing.Point(16, 337);
            this.labelPlayerName.Name = "labelPlayerName";
            this.labelPlayerName.Size = new System.Drawing.Size(125, 13);
            this.labelPlayerName.TabIndex = 5;
            this.labelPlayerName.Text = "Enter date (yyyy-mm-dd): ";
            // 
            // findGamesButton
            // 
            this.findGamesButton.Location = new System.Drawing.Point(577, 333);
            this.findGamesButton.Name = "findGamesButton";
            this.findGamesButton.Size = new System.Drawing.Size(75, 23);
            this.findGamesButton.TabIndex = 4;
            this.findGamesButton.Text = "Find";
            this.findGamesButton.UseVisualStyleBackColor = true;
            this.findGamesButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // findAllPlayersAndGamesCountByGameDateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 374);
            this.Controls.Add(this.textBoxPlayerName);
            this.Controls.Add(this.labelPlayerName);
            this.Controls.Add(this.findGamesButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "findAllPlayersAndGamesCountByGameDateForm";
            this.Text = "findAllPlayersAndGamesCountByGameDateForm";
            this.Load += new System.EventHandler(this.findAllPlayersAndGamesCountByGameDateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxPlayerName;
        private System.Windows.Forms.Label labelPlayerName;
        private System.Windows.Forms.Button findGamesButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn white;
        private System.Windows.Forms.DataGridViewTextBoxColumn black;
        private System.Windows.Forms.DataGridViewTextBoxColumn score;
    }
}