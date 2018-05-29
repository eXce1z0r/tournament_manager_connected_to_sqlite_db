namespace BD_Top_lab_sqlite
{
    partial class changePlayerForm
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
            this.changeButton = new System.Windows.Forms.Button();
            this.changePlayerNameLabel = new System.Windows.Forms.Label();
            this.id_player = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.careerstart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_player,
            this.fio,
            this.birthday,
            this.address,
            this.phone,
            this.rank,
            this.careerstart});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(742, 394);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(30, 420);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(75, 23);
            this.changeButton.TabIndex = 1;
            this.changeButton.Text = "Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // changePlayerNameLabel
            // 
            this.changePlayerNameLabel.AutoSize = true;
            this.changePlayerNameLabel.Location = new System.Drawing.Point(150, 425);
            this.changePlayerNameLabel.Name = "changePlayerNameLabel";
            this.changePlayerNameLabel.Size = new System.Drawing.Size(71, 13);
            this.changePlayerNameLabel.TabIndex = 2;
            this.changePlayerNameLabel.Text = "Player name: ";
            // 
            // id_player
            // 
            this.id_player.Frozen = true;
            this.id_player.HeaderText = "id_player";
            this.id_player.Name = "id_player";
            this.id_player.ReadOnly = true;
            // 
            // fio
            // 
            this.fio.Frozen = true;
            this.fio.HeaderText = "fio";
            this.fio.Name = "fio";
            this.fio.ReadOnly = true;
            // 
            // birthday
            // 
            this.birthday.Frozen = true;
            this.birthday.HeaderText = "birthday";
            this.birthday.Name = "birthday";
            this.birthday.ReadOnly = true;
            // 
            // address
            // 
            this.address.Frozen = true;
            this.address.HeaderText = "address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.Frozen = true;
            this.phone.HeaderText = "phone";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // rank
            // 
            this.rank.Frozen = true;
            this.rank.HeaderText = "rank";
            this.rank.Name = "rank";
            this.rank.ReadOnly = true;
            // 
            // careerstart
            // 
            this.careerstart.Frozen = true;
            this.careerstart.HeaderText = "careerstart";
            this.careerstart.Name = "careerstart";
            this.careerstart.ReadOnly = true;
            // 
            // changePlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 447);
            this.Controls.Add(this.changePlayerNameLabel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "changePlayerForm";
            this.Text = "changePlayerForm";
            this.Load += new System.EventHandler(this.changePlayerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label changePlayerNameLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_player;
        private System.Windows.Forms.DataGridViewTextBoxColumn fio;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn rank;
        private System.Windows.Forms.DataGridViewTextBoxColumn careerstart;
    }
}