namespace Appdev_W14_Praktikum
{
    partial class Form_Main
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
            this.dgv_data = new System.Windows.Forms.DataGridView();
            this.bt_Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bt_Delete = new System.Windows.Forms.Button();
            this.bt_Insert = new System.Windows.Forms.Button();
            this.tb_MatchID = new System.Windows.Forms.TextBox();
            this.tb_Minute = new System.Windows.Forms.TextBox();
            this.cb_TeamHome = new System.Windows.Forms.ComboBox();
            this.cb_TeamAway = new System.Windows.Forms.ComboBox();
            this.cb_Team = new System.Windows.Forms.ComboBox();
            this.cb_Player = new System.Windows.Forms.ComboBox();
            this.cb_Type = new System.Windows.Forms.ComboBox();
            this.dateMatch = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_data
            // 
            this.dgv_data.AllowUserToAddRows = false;
            this.dgv_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_data.Location = new System.Drawing.Point(20, 132);
            this.dgv_data.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_data.Name = "dgv_data";
            this.dgv_data.RowHeadersVisible = false;
            this.dgv_data.RowHeadersWidth = 82;
            this.dgv_data.RowTemplate.Height = 33;
            this.dgv_data.Size = new System.Drawing.Size(388, 160);
            this.dgv_data.TabIndex = 0;
            // 
            // bt_Add
            // 
            this.bt_Add.Location = new System.Drawing.Point(430, 267);
            this.bt_Add.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(70, 25);
            this.bt_Add.TabIndex = 1;
            this.bt_Add.Text = "Add";
            this.bt_Add.UseVisualStyleBackColor = true;
            this.bt_Add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Match ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Team Home";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Team Away";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Match Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 165);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Team";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(428, 134);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Minute";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(428, 220);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(428, 193);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Player";
            // 
            // bt_Delete
            // 
            this.bt_Delete.Location = new System.Drawing.Point(512, 267);
            this.bt_Delete.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Size = new System.Drawing.Size(70, 25);
            this.bt_Delete.TabIndex = 10;
            this.bt_Delete.Text = "Delete";
            this.bt_Delete.UseVisualStyleBackColor = true;
            this.bt_Delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // bt_Insert
            // 
            this.bt_Insert.Location = new System.Drawing.Point(197, 324);
            this.bt_Insert.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Insert.Name = "bt_Insert";
            this.bt_Insert.Size = new System.Drawing.Size(220, 32);
            this.bt_Insert.TabIndex = 11;
            this.bt_Insert.Text = "Insert";
            this.bt_Insert.UseVisualStyleBackColor = true;
            this.bt_Insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // tb_MatchID
            // 
            this.tb_MatchID.Enabled = false;
            this.tb_MatchID.Location = new System.Drawing.Point(92, 30);
            this.tb_MatchID.Margin = new System.Windows.Forms.Padding(2);
            this.tb_MatchID.Name = "tb_MatchID";
            this.tb_MatchID.Size = new System.Drawing.Size(150, 20);
            this.tb_MatchID.TabIndex = 12;
            // 
            // tb_Minute
            // 
            this.tb_Minute.Location = new System.Drawing.Point(476, 132);
            this.tb_Minute.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Minute.Name = "tb_Minute";
            this.tb_Minute.Size = new System.Drawing.Size(122, 20);
            this.tb_Minute.TabIndex = 13;
            // 
            // cb_TeamHome
            // 
            this.cb_TeamHome.FormattingEnabled = true;
            this.cb_TeamHome.Location = new System.Drawing.Point(92, 63);
            this.cb_TeamHome.Margin = new System.Windows.Forms.Padding(2);
            this.cb_TeamHome.Name = "cb_TeamHome";
            this.cb_TeamHome.Size = new System.Drawing.Size(150, 21);
            this.cb_TeamHome.TabIndex = 14;
            this.cb_TeamHome.SelectedIndexChanged += new System.EventHandler(this.cBox_teamHome_SelectedIndexChanged);
            // 
            // cb_TeamAway
            // 
            this.cb_TeamAway.FormattingEnabled = true;
            this.cb_TeamAway.Location = new System.Drawing.Point(358, 63);
            this.cb_TeamAway.Margin = new System.Windows.Forms.Padding(2);
            this.cb_TeamAway.Name = "cb_TeamAway";
            this.cb_TeamAway.Size = new System.Drawing.Size(182, 21);
            this.cb_TeamAway.TabIndex = 15;
            this.cb_TeamAway.SelectedIndexChanged += new System.EventHandler(this.cBox_teamAway_SelectedIndexChanged);
            // 
            // cb_Team
            // 
            this.cb_Team.FormattingEnabled = true;
            this.cb_Team.Location = new System.Drawing.Point(476, 163);
            this.cb_Team.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Team.Name = "cb_Team";
            this.cb_Team.Size = new System.Drawing.Size(122, 21);
            this.cb_Team.TabIndex = 16;
            this.cb_Team.SelectedIndexChanged += new System.EventHandler(this.cBox_teamChoose_SelectedIndexChanged);
            // 
            // cb_Player
            // 
            this.cb_Player.FormattingEnabled = true;
            this.cb_Player.Location = new System.Drawing.Point(476, 193);
            this.cb_Player.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Player.Name = "cb_Player";
            this.cb_Player.Size = new System.Drawing.Size(122, 21);
            this.cb_Player.TabIndex = 17;
            // 
            // cb_Type
            // 
            this.cb_Type.FormattingEnabled = true;
            this.cb_Type.Items.AddRange(new object[] {
            "GO",
            "GP",
            "GW",
            "CR",
            "CY",
            "PM"});
            this.cb_Type.Location = new System.Drawing.Point(476, 220);
            this.cb_Type.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Type.Name = "cb_Type";
            this.cb_Type.Size = new System.Drawing.Size(122, 21);
            this.cb_Type.TabIndex = 18;
            // 
            // dateMatch
            // 
            this.dateMatch.Location = new System.Drawing.Point(358, 28);
            this.dateMatch.Margin = new System.Windows.Forms.Padding(2);
            this.dateMatch.Name = "dateMatch";
            this.dateMatch.Size = new System.Drawing.Size(182, 20);
            this.dateMatch.TabIndex = 19;
            this.dateMatch.ValueChanged += new System.EventHandler(this.dateMatch_ValueChanged);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 381);
            this.Controls.Add(this.dateMatch);
            this.Controls.Add(this.cb_Type);
            this.Controls.Add(this.cb_Player);
            this.Controls.Add(this.cb_Team);
            this.Controls.Add(this.cb_TeamAway);
            this.Controls.Add(this.cb_TeamHome);
            this.Controls.Add(this.tb_Minute);
            this.Controls.Add(this.tb_MatchID);
            this.Controls.Add(this.bt_Insert);
            this.Controls.Add(this.bt_Delete);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Add);
            this.Controls.Add(this.dgv_data);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Main";
            this.Text = "Insert Match";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_data;
        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bt_Delete;
        private System.Windows.Forms.Button bt_Insert;
        private System.Windows.Forms.TextBox tb_MatchID;
        private System.Windows.Forms.TextBox tb_Minute;
        private System.Windows.Forms.ComboBox cb_TeamHome;
        private System.Windows.Forms.ComboBox cb_TeamAway;
        private System.Windows.Forms.ComboBox cb_Team;
        private System.Windows.Forms.ComboBox cb_Player;
        private System.Windows.Forms.ComboBox cb_Type;
        private System.Windows.Forms.DateTimePicker dateMatch;
    }
}

