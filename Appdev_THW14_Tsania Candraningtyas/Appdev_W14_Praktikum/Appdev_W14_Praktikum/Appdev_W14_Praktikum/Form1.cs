using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Appdev_W14_Praktikum
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        MySqlConnection sqlconnection;
        MySqlCommand sqlcommand;
        MySqlDataAdapter sqldataadapter;
        string query;
        DataTable TeamHome;
        DataTable TeamAway;
        DataTable TeamPilih;
        DataTable DMatch;
        DataTable Player;
        DataTable Tanggal;
        DataTable TanggalPilih;
        DataTable DGV;

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlconnection = new MySqlConnection("server=localhost;uid=root;pwd=leetaeyog00;database=premier_league");
            TeamHome = new DataTable();
            query = "SELECT * from team;";
            sqlcommand = new MySqlCommand(query, sqlconnection);
            sqldataadapter = new MySqlDataAdapter(sqlcommand);
            TeamHome = new DataTable();
            sqldataadapter.Fill(TeamHome);

            cb_TeamHome.DataSource = TeamHome;
            cb_TeamHome.DisplayMember = "team_name";
            cb_TeamHome.ValueMember = "team_id";

            TeamAway = new DataTable();
            query = "SELECT * from team;";
            sqlcommand = new MySqlCommand(query, sqlconnection);
            sqldataadapter = new MySqlDataAdapter(sqlcommand);
            TeamHome = new DataTable();
            sqldataadapter.Fill(TeamAway);

            cb_TeamAway.DataSource = TeamAway;
            cb_TeamAway.DisplayMember = "team_name";
            cb_TeamAway.ValueMember = "team_id";

            DGV = new DataTable();
            DGV.Columns.Add("Team");
            DGV.Columns.Add("Player");
            DGV.Columns.Add("Type");
            dgv_data.DataSource = DGV;

            DMatch = new DataTable();
            DMatch.Columns.Add("minute");
            DMatch.Columns.Add("team_id");
            DMatch.Columns.Add("player_id");
            DMatch.Columns.Add("type");
        }

        private void cBox_teamAway_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_TeamAway.Text == cb_TeamHome.Text)
            {
                MessageBox.Show("Cannot choose the same team!", "ERROR");
            }
            else
            {
                TeamPilih = new DataTable();
                query = $"Select team_name, team_id FROM team WHERE team_id = '{cb_TeamAway.SelectedValue}' OR  team_id = '{cb_TeamHome.SelectedValue}';";
                sqlcommand = new MySqlCommand(query, sqlconnection);
                sqldataadapter = new MySqlDataAdapter(sqlcommand);
                sqldataadapter.Fill(TeamPilih);
                cb_Team.DataSource = TeamPilih;
                cb_Team.DisplayMember = "team_name";
                cb_Team.ValueMember = "team_id";
            }
        }

        private void cBox_teamHome_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_TeamAway.Text == cb_TeamHome.Text)
            {
                MessageBox.Show("Cannot choose the same team!", "ERROR");
            }
            else
            {
                TeamPilih = new DataTable();
                query = $"Select team_name, team_id FROM team WHERE team_id = '{cb_TeamAway.SelectedValue}' OR team_id = '{cb_TeamHome.SelectedValue}';";
                sqlcommand = new MySqlCommand(query, sqlconnection);
                sqldataadapter = new MySqlDataAdapter(sqlcommand);
                sqldataadapter.Fill(TeamPilih);
                cb_Team.DataSource = TeamPilih;
                cb_Team.DisplayMember = "team_name";
                cb_Team.ValueMember = "team_id";
            }
        }

        private void cBox_teamChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            Player = new DataTable();
            query = $"SELECT player_name, player_id FROM player p WHERE team_id = '{cb_Team.SelectedValue}';";
            sqlcommand = new MySqlCommand(query, sqlconnection);
            sqldataadapter = new MySqlDataAdapter(sqlcommand);
            sqldataadapter.Fill(Player);
            cb_Player.DataSource = Player;
            cb_Player.DisplayMember = "player_name";
            cb_Player.ValueMember = "player_id";
        }
        int goalHome = 0;
        int goalAway = 0;
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (tb_Minute.Text == "" || cb_Team.Text == "" || cb_Player.Text == "" || cb_Type.Text == "" || tb_MatchID.Text == "")
            {
                MessageBox.Show("Fill all the fields!", "ERROR");
            }
            else
            {
                DGV.Rows.Add(cb_Team.Text, cb_Player.Text, cb_Type.Text);

                if (cb_Type.Text == "GO" || cb_Type.Text == "GP")
                {
                    if (cb_TeamAway.Text == cb_Team.Text)
                    {
                        goalAway++;
                    }
                    else
                    {
                        goalHome++;
                    }
                }
                else if (cb_Type.Text == "GW")
                {
                    if (cb_TeamAway.Text == cb_Team.Text)
                    {
                        goalHome++;
                    }
                    else
                    {
                        goalAway++;
                    }
                }

                DMatch.Rows.Add(tb_Minute.Text, cb_Team.SelectedValue, cb_Player.SelectedValue, cb_Type.Text);
                cb_Type.Text = "";
                tb_Minute.Clear();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DataGridViewRow view = dgv_data.CurrentRow;
            int indexRemove = 0;

            if (dgv_data.Rows.Count != 0)
            {
                for (int i = 0; i < DGV.Rows.Count; i++)
                {
                    if (DGV.Rows[i][0].ToString().Contains(view.Cells[0].Value.ToString()))
                    {
                        indexRemove = i;
                    }

                }
                if (view.Cells[2].Value.ToString() == "GO" || view.Cells[2].Value.ToString() == "GP")
                {
                    if (cb_TeamAway.Text == cb_Team.Text)
                    {
                        goalAway--;
                    }
                    else
                    {
                        goalHome--;
                    }
                }
                else if (view.Cells[2].Value.ToString() == "GW")
                {
                    if (cb_TeamAway.Text == cb_Team.Text)
                    {
                        goalHome--;
                    }
                    else
                    {
                        goalAway--;
                    }
                }
                DGV.Rows.RemoveAt(indexRemove);
                DMatch.Rows.RemoveAt(indexRemove);
            }

            dgv_data.DataSource = DGV;
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (tb_MatchID.Text != "")
            {
                for (int i = 0; i < dgv_data.Rows.Count; i++)
                {
                    query = $"INSERT INTO DMatch VALUES ('{tb_MatchID.Text}', '{DMatch.Rows[i][0].ToString()}', '{DMatch.Rows[i][1].ToString()}', '{DMatch.Rows[i][2].ToString()}', '{DMatch.Rows[i][3].ToString()}', '0');";
                    sqlconnection.Open();
                    sqlcommand = new MySqlCommand(query, sqlconnection);
                    sqlcommand.ExecuteNonQuery();
                    sqlconnection.Close();
                }

                query = $"INSERT INTO `match` VALUES ('{tb_MatchID.Text}', '{year}-{month}-{day}', '{cb_TeamHome.SelectedValue}', '{cb_TeamAway.SelectedValue}', '{goalHome.ToString()}', '{goalAway.ToString()}', 'M002', '0');";
                sqlconnection.Open();
                sqlcommand = new MySqlCommand(query, sqlconnection);
                sqlcommand.ExecuteNonQuery();
                sqlconnection.Close();
                cb_TeamAway.Text = "";
                cb_TeamHome.Text = "";
                tb_Minute.Text = "";
                cb_Type.Text = "";
                cb_Team.Text = "";
                cb_Player.Text = "";
                tb_MatchID.Text = "";

                DGV.Rows.Clear();
                DMatch.Rows.Clear();
                goalAway = 0;
                goalHome = 0;

            }
            else
            {
                MessageBox.Show("Fill all the fields!", "ERROR");
            }
        }
        string day = "";
        string month = "";
        string year = "";
        private void dateMatch_ValueChanged(object sender, EventArgs e)
        {
            query = $"SELECT concat(date_format(match_date, '%Y'), date_format(match_date, '%m'), date_format(match_Date, '%d')) FROM `match` ORDER BY 1 desc LIMIT 1;";
            sqlcommand = new MySqlCommand(query, sqlconnection);
            sqldataadapter = new MySqlDataAdapter(sqlcommand);
            Tanggal = new DataTable();
            sqldataadapter.Fill(Tanggal);
            day = dateMatch.Value.Day.ToString();
            if (Convert.ToInt32(day) < 10)
            {
                day = $"0{day}";
            }
            month = dateMatch.Value.Month.ToString();
            if (Convert.ToInt32(month) < 10)
            {
                month = $"0{month}";
            }
            year = dateMatch.Value.Year.ToString();
            int dateChoose = Convert.ToInt32($"{year}{month}{day}");
            int dateLast = Convert.ToInt32(Tanggal.Rows[0][0]);

            if (dateChoose >= Convert.ToInt32(Tanggal.Rows[0][0]))
            {
                query = $@"SELECT match_id FROM `match` WHERE match_id like '{year}%' ORDER BY 1 desc LIMIT 1;";
                sqlcommand = new MySqlCommand(query, sqlconnection);
                sqldataadapter = new MySqlDataAdapter(sqlcommand);
                TanggalPilih = new DataTable();
                sqldataadapter.Fill(TanggalPilih);
                if (TanggalPilih.Rows.Count == 0)
                {
                    tb_MatchID.Text = $"{year}001";
                }
                else if (TanggalPilih.Rows.Count == 1)
                {
                    int jumlahMatch = Convert.ToInt32(TanggalPilih.Rows[0][0]) + 1;
                    tb_MatchID.Text = $"{jumlahMatch}";
                }
            }
            else
            {
                MessageBox.Show("Date cannot be before the last match date!");
            }
        }
    }
}
