namespace BD_Top_lab_sqlite
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.changePlayerButton = new System.Windows.Forms.Button();
            this.removePlayerButton = new System.Windows.Forms.Button();
            this.newPlayerButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.changeGameButton = new System.Windows.Forms.Button();
            this.removeGameButton = new System.Windows.Forms.Button();
            this.newGameButton = new System.Windows.Forms.Button();
            this.findInDatabaseButton = new System.Windows.Forms.Button();
            this.showAllPlayersButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.changePlayerButton);
            this.panel1.Controls.Add(this.removePlayerButton);
            this.panel1.Controls.Add(this.newPlayerButton);
            this.panel1.Location = new System.Drawing.Point(12, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 250);
            this.panel1.TabIndex = 0;
            // 
            // changePlayerButton
            // 
            this.changePlayerButton.Location = new System.Drawing.Point(21, 175);
            this.changePlayerButton.Name = "changePlayerButton";
            this.changePlayerButton.Size = new System.Drawing.Size(200, 50);
            this.changePlayerButton.TabIndex = 2;
            this.changePlayerButton.Text = "Change Player";
            this.changePlayerButton.UseVisualStyleBackColor = true;
            this.changePlayerButton.Click += new System.EventHandler(this.changePlayerButton_Click);
            // 
            // removePlayerButton
            // 
            this.removePlayerButton.Location = new System.Drawing.Point(21, 100);
            this.removePlayerButton.Name = "removePlayerButton";
            this.removePlayerButton.Size = new System.Drawing.Size(200, 50);
            this.removePlayerButton.TabIndex = 1;
            this.removePlayerButton.Text = "Remove Player";
            this.removePlayerButton.UseVisualStyleBackColor = true;
            this.removePlayerButton.Click += new System.EventHandler(this.removePlayerButton_Click);
            // 
            // newPlayerButton
            // 
            this.newPlayerButton.Location = new System.Drawing.Point(21, 25);
            this.newPlayerButton.Name = "newPlayerButton";
            this.newPlayerButton.Size = new System.Drawing.Size(200, 50);
            this.newPlayerButton.TabIndex = 0;
            this.newPlayerButton.Text = "New Player";
            this.newPlayerButton.UseVisualStyleBackColor = true;
            this.newPlayerButton.Click += new System.EventHandler(this.newPlayerButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.changeGameButton);
            this.panel2.Controls.Add(this.removeGameButton);
            this.panel2.Controls.Add(this.newGameButton);
            this.panel2.Location = new System.Drawing.Point(318, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 250);
            this.panel2.TabIndex = 1;
            // 
            // changeGameButton
            // 
            this.changeGameButton.Location = new System.Drawing.Point(22, 175);
            this.changeGameButton.Name = "changeGameButton";
            this.changeGameButton.Size = new System.Drawing.Size(200, 50);
            this.changeGameButton.TabIndex = 2;
            this.changeGameButton.Text = "Change Game";
            this.changeGameButton.UseVisualStyleBackColor = true;
            this.changeGameButton.Click += new System.EventHandler(this.changeGameButton_Click);
            // 
            // removeGameButton
            // 
            this.removeGameButton.Location = new System.Drawing.Point(22, 100);
            this.removeGameButton.Name = "removeGameButton";
            this.removeGameButton.Size = new System.Drawing.Size(200, 50);
            this.removeGameButton.TabIndex = 1;
            this.removeGameButton.Text = "Remove Game";
            this.removeGameButton.UseVisualStyleBackColor = true;
            this.removeGameButton.Click += new System.EventHandler(this.removeGameButton_Click);
            // 
            // newGameButton
            // 
            this.newGameButton.Location = new System.Drawing.Point(22, 25);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(200, 50);
            this.newGameButton.TabIndex = 0;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // findInDatabaseButton
            // 
            this.findInDatabaseButton.Location = new System.Drawing.Point(189, 316);
            this.findInDatabaseButton.Name = "findInDatabaseButton";
            this.findInDatabaseButton.Size = new System.Drawing.Size(200, 50);
            this.findInDatabaseButton.TabIndex = 2;
            this.findInDatabaseButton.Text = "Find in Database";
            this.findInDatabaseButton.UseVisualStyleBackColor = true;
            this.findInDatabaseButton.Click += new System.EventHandler(this.findInDatabaseButton_Click);
            // 
            // showAllPlayersButton
            // 
            this.showAllPlayersButton.Location = new System.Drawing.Point(12, 316);
            this.showAllPlayersButton.Name = "showAllPlayersButton";
            this.showAllPlayersButton.Size = new System.Drawing.Size(84, 50);
            this.showAllPlayersButton.TabIndex = 3;
            this.showAllPlayersButton.Text = "Show All Players";
            this.showAllPlayersButton.UseVisualStyleBackColor = true;
            this.showAllPlayersButton.Click += new System.EventHandler(this.showAllPlayersButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 402);
            this.Controls.Add(this.showAllPlayersButton);
            this.Controls.Add(this.findInDatabaseButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button changePlayerButton;
        private System.Windows.Forms.Button removePlayerButton;
        private System.Windows.Forms.Button newPlayerButton;
        private System.Windows.Forms.Button changeGameButton;
        private System.Windows.Forms.Button removeGameButton;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Button findInDatabaseButton;
        private System.Windows.Forms.Button showAllPlayersButton;
    }
}

