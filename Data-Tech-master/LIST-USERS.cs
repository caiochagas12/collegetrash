using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace cadastrousuario
{
    public partial class LIST_USERS : UserControl
    {
        // Comandos do Mysql para o dataGrid
        MySqlDataAdapter sda;
        MySqlCommandBuilder scb;
        DataTable dt;

        public LIST_USERS()
        {
            InitializeComponent();
        }
        private void disp_data()
        {
            // conexão com o banco de dados
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=euteamo12;persistsecurityinfo=True;database=db");
            sda = new MySqlDataAdapter(@"SELECT * FROM usuarios", con);
            dt = new DataTable();
            sda.Fill(dt);
            dg_dados.DataSource = dt;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            scb = new MySqlCommandBuilder(sda);
            sda.Update(dt);
            MessageBox.Show("Salvo com sucesso!", "AVISO");

        }

        private void btn_dell_Click(object sender, EventArgs e)
        {
            int selectedRow;
            selectedRow = dg_dados.CurrentCell.RowIndex;
            dg_dados.Rows.RemoveAt(selectedRow);
            if (MessageBox.Show("Deseja deletar o usuario?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Usuario deletado com sucesso.", "AVISO");
            }
            

        }

        private void LIST_USERS_Load(object sender, EventArgs e)
        {
            disp_data();
        }
    }
}
