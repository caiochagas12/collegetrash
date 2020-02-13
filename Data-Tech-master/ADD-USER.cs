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
using System.Runtime.InteropServices;

namespace cadastrousuario
{

    public partial class ADD_USER : UserControl
    {
        String conect = "server=localhost;user id=root;password=euteamo12;persistsecurityinfo=True;database=db";

        public ADD_USER()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            MySqlConnection CreateConection = new MySqlConnection(conect);

            // Inserir no banco de dados
            String sql = @"INSERT INTO usuarios (Usuarios, Nome, Senha, Nivel, Endereco, Telefone, Email) VALUES (@Usuarios,@Nome,@Senha,@Nivel,@Endereco,@Telefone,@Email)";
            MySqlCommand comando = new MySqlCommand(sql, CreateConection);

            // Parametros
            comando.Parameters.Add("@Usuarios", MySqlDbType.VarChar).Value = txt_user.Text;
            comando.Parameters.Add("@Nome", MySqlDbType.VarChar).Value = txt_nome.Text;
            comando.Parameters.Add("@Senha", MySqlDbType.VarChar).Value = txt_pass.Text;
            comando.Parameters.Add("@Nivel", MySqlDbType.VarChar).Value = cb_nivel.Text;
            comando.Parameters.Add("@Endereco", MySqlDbType.VarChar).Value = txt_end.Text;
            comando.Parameters.Add("@Telefone", MySqlDbType.VarChar).Value = txt_tel.Text;
            comando.Parameters.Add("@Email", MySqlDbType.VarChar).Value = txt_email.Text;

            // Abrir conexãio
            CreateConection.Open();

            // Comandos do Mysql
            MySqlDataReader dados = comando.ExecuteReader();
            MessageBox.Show("Cadastro Efetuado com Sucesso!");

            // Limpa as txts dps que finalizar o cadastro
            txt_user.Clear();
            txt_nome.Clear();
            txt_pass.Clear();
            txt_end.Clear();
            txt_tel.Clear();
            txt_email.Clear();

            if (dados.Read())
            {
                // Fechar conexão
                CreateConection.Close();
            }
        }

        private void txt_user_Validated(object sender, EventArgs e)
        {
            if (txt_user.Text.Trim() == "")
            {
                epError.SetError(txt_user, "Campo Obrigatorio!");
                txt_user.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void txt_nome_Validated(object sender, EventArgs e)
        {
            if (txt_nome.Text.Trim() == "")
            {
                epError.SetError(txt_nome, "Campo Obrigatorio!");
                txt_nome.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void txt_pass_Validated(object sender, EventArgs e)
        {
            if (txt_pass.Text.Trim() == "")
            {
                epError.SetError(txt_pass, "Campo Obrigatorio!");
                txt_pass.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void cb_nivel_Validated(object sender, EventArgs e)
        {
            if (cb_nivel.Text.Trim() == "")
            {
                epError.SetError(cb_nivel, "Campo Obrigatorio!");
                cb_nivel.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

    }
}
