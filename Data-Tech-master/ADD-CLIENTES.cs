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
    public partial class CLIENTS : UserControl
    {
        String conect = "server=localhost;user id=root;password=euteamo12;persistsecurityinfo=True;database=db";

        public CLIENTS()
        {
            InitializeComponent();


        }


        private void btn_save_Click(object sender, EventArgs e)
        {
            MySqlConnection CreateConection = new MySqlConnection(conect);

            // Inserir no banco de dados
            String sql = @"INSERT INTO clientes (Nome, Cep, Endereco, Telefone, Nascimento, Email, Descricao) VALUES (@Nome,@Cep,@Endereco,@Telefone,@Nascimento,@Email, @Descricao)";
            MySqlCommand comando = new MySqlCommand(sql, CreateConection);

            // Parametros
            comando.Parameters.Add("@Nome", MySqlDbType.VarChar).Value = txt_name.Text;
            comando.Parameters.Add("@Cep", MySqlDbType.VarChar).Value = txt_cep.Text;
            comando.Parameters.Add("@Endereco", MySqlDbType.VarChar).Value = txt_dress.Text;
            comando.Parameters.Add("@Telefone", MySqlDbType.VarChar).Value = txt_tel.Text;
            comando.Parameters.Add("@Nascimento", MySqlDbType.VarChar).Value = txt_nasc.Text;
            comando.Parameters.Add("@Email", MySqlDbType.VarChar).Value = txt_email.Text;
            comando.Parameters.Add("@Descricao", MySqlDbType.VarChar).Value = txt_desc.Text;


            try
            {
                // Abrir conexãio
                CreateConection.Open();
                // Comandos do Mysql
                MySqlDataReader dados = comando.ExecuteReader();
                MessageBox.Show("Cadastro Efetuado com Sucesso!");
                // Limpa as txts dps que finalizar o cadastro
                txt_name.Clear();
                txt_dress.Clear();
                txt_email.Clear();
                txt_tel.Clear();
                txt_cep.Clear();
                txt_nasc.Clear();
                txt_desc.Clear();

            }


            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            finally
            {
                // Fechar conexão
                CreateConection.Close();
            }

        }

        private void txt_name_Validated(object sender, EventArgs e)
        {
            if (txt_name.Text.Trim() == "")
            {
                epError.SetError(txt_name, "Campo Obrigatorio!");
                txt_name.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

    }
}
