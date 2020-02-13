using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace registrosaude
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id_funcionario = textBox10.Text;
            string nome = textBox1.Text;
            string sexo = textBox11.Text;
            string cpf = textBox2.Text;
            string data_nascimento = textBox3.Text;
            string email = textBox4.Text;
            string telefone = textBox5.Text;
            string funcao = textBox6.Text;
            string endereco = textBox7.Text;
            string salario = textBox8.Text;
            string pis_pasep = textBox9.Text;







            if (nome == "" || sexo == "" || cpf == "" || data_nascimento == "" || email == "" || telefone == "" || funcao == "" || endereco == "" || salario == "" || pis_pasep == "")
            {
                MessageBox.Show("você não pode deixar os campos vazios", "ERRO");
                return;
            }

            string Configuracao = "server=localhost;userid=root;password=1234;port=3306;database=banquinho_saude;";
            MySqlConnection Conexao = new MySqlConnection(Configuracao);
            try
            {
                Conexao.Open();
                MySqlCommand COMANDOSSSS = new MySqlCommand("INSERT INTO funcionario (id_funcionario,nome,sexo,cpf,data_nascimento,email,telefone,funcao,endereco,salario,pis_pasep)" + "VALUES('" + id_funcionario + "','" + nome + "','" + sexo + "','" + cpf + "','" + data_nascimento + "','" + email + "','" + telefone + "','" + funcao + "','" + endereco + "','" + salario + "','" + pis_pasep +"')", Conexao);
                COMANDOSSSS.ExecuteNonQuery();
                MessageBox.Show("Informações registrada com sucesso no banco de dados!", "Imformações registrada!");


            }
            catch
            {
                MessageBox.Show("Não foi possivel registrar as informações no banco de dados", "ERRO de conexao");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
