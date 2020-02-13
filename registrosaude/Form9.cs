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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id_medicamento = textBox6.Text;
            string nome = textBox5.Text;
            string tipo = textBox2.Text;
            string quantidade = textBox1.Text;
            string informativo = textBox4.Text;
            string validade = textBox3.Text;






            if (nome == "" || quantidade == "" || informativo == "" || tipo == "" || validade == "" )
            {
                MessageBox.Show("você não pode deixar os campos vazios", "ERRO");
                return;
            }

            string Configuracao = "server=localhost;userid=root;password=1234;port=3306;database=banquinho_saude;";
            MySqlConnection Conexao = new MySqlConnection(Configuracao);
            try
            {
                Conexao.Open();
                MySqlCommand COMANDOSSS = new MySqlCommand("INSERT INTO medicamento (id_medicamento,nome,tipo,quantidade,informativo,validade)" + "VALUES('" + id_medicamento + "','" + nome + "','" + tipo + "','" + quantidade + "','" + informativo + "','" + validade + "')", Conexao);
                COMANDOSSS.ExecuteNonQuery();
                MessageBox.Show("Informações registrada com sucesso no banco de dados!", "Imformações registrada!");


            }
            catch
            {
                MessageBox.Show("Não foi possivel registrar as informações no banco de dados", "ERRO de conexao");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
