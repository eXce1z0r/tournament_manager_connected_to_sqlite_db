namespace BD_Top_lab_sqlite
{
    partial class changePlayerInForm
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
            this.field_Sur_Nam_Pat = new System.Windows.Forms.Label();
            this.field_Dat_Of_Bir = new System.Windows.Forms.Label();
            this.field_Hom_Adr = new System.Windows.Forms.Label();
            this.field_Tel_Num = new System.Windows.Forms.Label();
            this.field_Rank = new System.Windows.Forms.Label();
            this.field_Dat_Of_Car_Sta = new System.Windows.Forms.Label();
            this.ent_Sur_Nam_Pat = new System.Windows.Forms.TextBox();
            this.ent_Dat_Of_Bir = new System.Windows.Forms.TextBox();
            this.ent_Hom_Adr = new System.Windows.Forms.TextBox();
            this.ent_Tel_Num = new System.Windows.Forms.TextBox();
            this.ent_Ran = new System.Windows.Forms.ComboBox();
            this.ent_Dat_Of_Car_Sta = new System.Windows.Forms.TextBox();
            this.button_change_data_in_db = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // field_Sur_Nam_Pat
            // 
            this.field_Sur_Nam_Pat.AutoSize = true;
            this.field_Sur_Nam_Pat.Location = new System.Drawing.Point(34, 23);
            this.field_Sur_Nam_Pat.Name = "field_Sur_Nam_Pat";
            this.field_Sur_Nam_Pat.Size = new System.Drawing.Size(135, 13);
            this.field_Sur_Nam_Pat.TabIndex = 0;
            this.field_Sur_Nam_Pat.Text = "Surname Name Patronymic";
            // 
            // field_Dat_Of_Bir
            // 
            this.field_Dat_Of_Bir.AutoSize = true;
            this.field_Dat_Of_Bir.Location = new System.Drawing.Point(37, 51);
            this.field_Dat_Of_Bir.Name = "field_Dat_Of_Bir";
            this.field_Dat_Of_Bir.Size = new System.Drawing.Size(129, 13);
            this.field_Dat_Of_Bir.TabIndex = 1;
            this.field_Dat_Of_Bir.Text = "Date of Birth (yyyy-mm-dd)";
            // 
            // field_Hom_Adr
            // 
            this.field_Hom_Adr.AutoSize = true;
            this.field_Hom_Adr.Location = new System.Drawing.Point(37, 79);
            this.field_Hom_Adr.Name = "field_Hom_Adr";
            this.field_Hom_Adr.Size = new System.Drawing.Size(75, 13);
            this.field_Hom_Adr.TabIndex = 3;
            this.field_Hom_Adr.Text = "Home address";
            // 
            // field_Tel_Num
            // 
            this.field_Tel_Num.AutoSize = true;
            this.field_Tel_Num.Location = new System.Drawing.Point(37, 140);
            this.field_Tel_Num.Name = "field_Tel_Num";
            this.field_Tel_Num.Size = new System.Drawing.Size(96, 13);
            this.field_Tel_Num.TabIndex = 4;
            this.field_Tel_Num.Text = "Telephone number";
            // 
            // field_Rank
            // 
            this.field_Rank.AutoSize = true;
            this.field_Rank.Location = new System.Drawing.Point(40, 172);
            this.field_Rank.Name = "field_Rank";
            this.field_Rank.Size = new System.Drawing.Size(33, 13);
            this.field_Rank.TabIndex = 5;
            this.field_Rank.Text = "Rank";
            // 
            // field_Dat_Of_Car_Sta
            // 
            this.field_Dat_Of_Car_Sta.AutoSize = true;
            this.field_Dat_Of_Car_Sta.Location = new System.Drawing.Point(40, 202);
            this.field_Dat_Of_Car_Sta.Name = "field_Dat_Of_Car_Sta";
            this.field_Dat_Of_Car_Sta.Size = new System.Drawing.Size(98, 13);
            this.field_Dat_Of_Car_Sta.TabIndex = 6;
            this.field_Dat_Of_Car_Sta.Text = "Date of career start";
            // 
            // ent_Sur_Nam_Pat
            // 
            this.ent_Sur_Nam_Pat.Location = new System.Drawing.Point(180, 22);
            this.ent_Sur_Nam_Pat.Name = "ent_Sur_Nam_Pat";
            this.ent_Sur_Nam_Pat.Size = new System.Drawing.Size(272, 20);
            this.ent_Sur_Nam_Pat.TabIndex = 7;
            this.ent_Sur_Nam_Pat.TextChanged += new System.EventHandler(this.ent_Sur_Nam_Pat_TextChanged);
            // 
            // ent_Dat_Of_Bir
            // 
            this.ent_Dat_Of_Bir.Location = new System.Drawing.Point(180, 52);
            this.ent_Dat_Of_Bir.Name = "ent_Dat_Of_Bir";
            this.ent_Dat_Of_Bir.Size = new System.Drawing.Size(272, 20);
            this.ent_Dat_Of_Bir.TabIndex = 8;
            this.ent_Dat_Of_Bir.TextChanged += new System.EventHandler(this.ent_Dat_Of_Bir_TextChanged);
            // 
            // ent_Hom_Adr
            // 
            this.ent_Hom_Adr.Location = new System.Drawing.Point(180, 82);
            this.ent_Hom_Adr.Multiline = true;
            this.ent_Hom_Adr.Name = "ent_Hom_Adr";
            this.ent_Hom_Adr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ent_Hom_Adr.Size = new System.Drawing.Size(272, 52);
            this.ent_Hom_Adr.TabIndex = 9;
            this.ent_Hom_Adr.TextChanged += new System.EventHandler(this.ent_Hom_Adr_TextChanged);
            // 
            // ent_Tel_Num
            // 
            this.ent_Tel_Num.Location = new System.Drawing.Point(180, 140);
            this.ent_Tel_Num.Name = "ent_Tel_Num";
            this.ent_Tel_Num.Size = new System.Drawing.Size(272, 20);
            this.ent_Tel_Num.TabIndex = 10;
            this.ent_Tel_Num.TextChanged += new System.EventHandler(this.ent_Tel_Num_TextChanged);
            // 
            // ent_Ran
            // 
            this.ent_Ran.FormattingEnabled = true;
            this.ent_Ran.Items.AddRange(new object[] {
            "Little Bad Boy",
            "Little Ugly Boy",
            "Little Good Boy",
            "Middle Bad Boy",
            "Middle Ugly Boy",
            "Middle Good Boy",
            "Big Bad Boy",
            "Big Ugly Boy",
            "Big Good Boy",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""});
            this.ent_Ran.Location = new System.Drawing.Point(180, 170);
            this.ent_Ran.Name = "ent_Ran";
            this.ent_Ran.Size = new System.Drawing.Size(272, 21);
            this.ent_Ran.TabIndex = 11;
            this.ent_Ran.SelectedIndexChanged += new System.EventHandler(this.ent_Ran_SelectedIndexChanged);
            // 
            // ent_Dat_Of_Car_Sta
            // 
            this.ent_Dat_Of_Car_Sta.Location = new System.Drawing.Point(180, 200);
            this.ent_Dat_Of_Car_Sta.Name = "ent_Dat_Of_Car_Sta";
            this.ent_Dat_Of_Car_Sta.Size = new System.Drawing.Size(272, 20);
            this.ent_Dat_Of_Car_Sta.TabIndex = 12;
            this.ent_Dat_Of_Car_Sta.TextChanged += new System.EventHandler(this.ent_Dat_Of_Car_Sta_TextChanged);
            // 
            // button_change_data_in_db
            // 
            this.button_change_data_in_db.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_change_data_in_db.Location = new System.Drawing.Point(323, 230);
            this.button_change_data_in_db.Name = "button_change_data_in_db";
            this.button_change_data_in_db.Size = new System.Drawing.Size(129, 36);
            this.button_change_data_in_db.TabIndex = 13;
            this.button_change_data_in_db.Text = "Change this data in DB";
            this.button_change_data_in_db.UseVisualStyleBackColor = true;
            this.button_change_data_in_db.Click += new System.EventHandler(this.button_change_data_in_db_Click);
            // 
            // changePlayerInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 278);
            this.Controls.Add(this.button_change_data_in_db);
            this.Controls.Add(this.ent_Dat_Of_Car_Sta);
            this.Controls.Add(this.ent_Ran);
            this.Controls.Add(this.ent_Tel_Num);
            this.Controls.Add(this.ent_Hom_Adr);
            this.Controls.Add(this.ent_Dat_Of_Bir);
            this.Controls.Add(this.ent_Sur_Nam_Pat);
            this.Controls.Add(this.field_Dat_Of_Car_Sta);
            this.Controls.Add(this.field_Rank);
            this.Controls.Add(this.field_Tel_Num);
            this.Controls.Add(this.field_Hom_Adr);
            this.Controls.Add(this.field_Dat_Of_Bir);
            this.Controls.Add(this.field_Sur_Nam_Pat);
            this.Name = "changePlayerInForm";
            this.Text = "changePlayerInForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.changePlayerInForm_FormClosed);
            this.Load += new System.EventHandler(this.changePlayerInForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label field_Sur_Nam_Pat;
        private System.Windows.Forms.Label field_Dat_Of_Bir;
        private System.Windows.Forms.Label field_Hom_Adr;
        private System.Windows.Forms.Label field_Tel_Num;
        private System.Windows.Forms.Label field_Rank;
        private System.Windows.Forms.Label field_Dat_Of_Car_Sta;
        private System.Windows.Forms.TextBox ent_Sur_Nam_Pat;
        private System.Windows.Forms.TextBox ent_Dat_Of_Bir;
        private System.Windows.Forms.TextBox ent_Hom_Adr;
        private System.Windows.Forms.TextBox ent_Tel_Num;
        private System.Windows.Forms.ComboBox ent_Ran;
        private System.Windows.Forms.TextBox ent_Dat_Of_Car_Sta;
        private System.Windows.Forms.Button button_change_data_in_db;
    }
}