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
    public partial class addclient : Form
    {
        public addclient()
        {
            InitializeComponent();
        }

        // Botão adicionar cliene
        private void btn_add_Click(object sender, EventArgs e)
        {
            // Conexão com o banco de dados
            String conect = "server=localhost;user id=root;password=euteamo12;persistsecurityinfo=True;database=db";
            MySqlConnection CreateConection = new MySqlConnection(conect);

            // Inserir no banco de dados
            String sql = @"INSERT INTO clientes (Nome, Cep, Endereco, Telefone, Nascimento, Email) VALUES (@Nome,@Cep,@Endereco,@Telefone,@Nascimento,@Email)";
            MySqlCommand comando = new MySqlCommand(sql, CreateConection);
            
            // Parametros
            comando.Parameters.Add("@Nome", MySqlDbType.VarChar).Value = txt_nome.Text;
            comando.Parameters.Add("@Cep", MySqlDbType.VarChar).Value = txt_cep.Text;
            comando.Parameters.Add("@Endereco", MySqlDbType.VarChar).Value = txt_ende.Text;
            comando.Parameters.Add("@Telefone", MySqlDbType.VarChar).Value = txt_tel.Text;
            comando.Parameters.Add("@Nascimento", MySqlDbType.VarChar).Value = txt_nasc.Text;
            comando.Parameters.Add("@Email", MySqlDbType.VarChar).Value = txt_email.Text;

            // Abrir conexão
            CreateConection.Open();

            // Comandos do Mysql
            MySqlDataReader dados = comando.ExecuteReader();
            MessageBox.Show("Cadastro Efetuado com Sucesso!");

            // Limpa as txts dps que finalizar o cadastro
            txt_nome.Clear();
            txt_ende.Clear();
            txt_email.Clear();
            txt_tel.Clear();
            txt_cep.Clear();
            txt_nasc.Clear();

            if (dados.Read())
            {
                // Fechar conexão
                CreateConection.Close();
            }
        }
    }
}
