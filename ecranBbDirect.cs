using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data.OleDb;
using System.Windows.Forms;

namespace proj_event_app
{
    public partial class ficBbDirect : Form
    {


        public ficBbDirect()
        {
            InitializeComponent();


        }

        // On utilise une propriété pour recalculer le chemin proprement au besoin
        static string cheminFinal = System.IO.Path.GetFullPath(
            System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\..\perso\perso.mdb")
        );

        // 3. Ta chaîne de connexion devient universelle
        string connection = $@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={cheminFinal};";
        private void bConsulter_Click(object sender, EventArgs e)
        {
            lbConsole.Items.Clear();
            using (OleDbConnection con = new OleDbConnection(connection))
            {
                string sql = "SELECT NUMCLI, NOM, PRE FROM Client";
                OleDbCommand cmd = new OleDbCommand(sql, con);

                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
              
                    lbConsole.Items.Add($"{reader["PRE"]} {reader["NOM"]} ({reader["NUMCLI"]})");
                }
            }
        }

        private void bDemonbrer_Click(object sender, EventArgs e)
        {
            using (OleDbConnection con = new OleDbConnection(connection))
            {
                string sql = "SELECT COUNT(*) FROM Client";
                OleDbCommand cmd = new OleDbCommand(sql, con);
                con.Open();
                int nb = (int)cmd.ExecuteScalar();
                lbConsole.Items.Add($"Nombre de clients : {nb}");
            }
        }

        private void bAjouter_Click(object sender, EventArgs e)
        {
            using (OleDbConnection con = new OleDbConnection(connection))
            {
                
                string sql = "INSERT INTO Client (NOM, PRE) VALUES (?, ?)";
                OleDbCommand cmd = new OleDbCommand(sql, con);
                cmd.Parameters.AddWithValue("?", tbNom.Text);
                cmd.Parameters.AddWithValue("?", tbPrenom.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                lbConsole.Items.Add($"Ajouté : {tbPrenom.Text} {tbNom.Text}");

                
                tbNom.Clear();
                tbPrenom.Clear();
            }
        }
    }
}
