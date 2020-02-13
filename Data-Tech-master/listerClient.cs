using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace cadastrousuario
{
    public partial class listerClient : Form
    {
        // Comandos do Mysql para o dataGrid
        MySqlDataAdapter sda;
        MySqlCommandBuilder scb;
        DataTable dt;

        public listerClient()
        {

            InitializeComponent();
        }

        // conexão com o banco de dados
        private void disp_data()
        {
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=euteamo12;persistsecurityinfo=True;database=db");
            sda = new MySqlDataAdapter(@"SELECT * FROM clientes", con);
            dt = new DataTable();
            
            sda.Fill(dt);
            dg_dados.DataSource = dt;

        }

        // Botão salvar
        private void salvarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            scb = new MySqlCommandBuilder(sda);
            sda.Update(dt);
        }

        // Botão deletar
        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedRow;
            selectedRow = dg_dados.CurrentCell.RowIndex;
            dg_dados.Rows.RemoveAt(selectedRow);
        }

        // Carregar o dataGrid
        private void listerClient_Load(object sender, EventArgs e)
        {
            disp_data();
        }
    }
}
