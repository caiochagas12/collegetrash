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

namespace registrosaude
{
	public partial class Form4 : Form
	{
		public Form4()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string id_animal = textBox9.Text;
			string nome = textBox1.Text;
			string raca = textBox2.Text;
			string idade = textBox3.Text;
			string data_nascimento = textBox6.Text;
			string tipo = textBox4.Text;
			string porte = textBox5.Text;
			string sexo = textBox7.Text;
			string descri = textBox8.Text;







			if (nome == "" || data_nascimento == "" || nome == "" || raca == "" || idade == "" || porte == "" || tipo == "" || data_nascimento == "" || sexo == "" || descri == "")
			{
				MessageBox.Show("você não pode deixar os campos vazios", "ERRO");
				return;
			}

			string Configuracao = "server=localhost;userid=root;password=1234;port=3306;database=banquinho_saude;";
			MySqlConnection Conexao = new MySqlConnection(Configuracao);
			try
			{
				Conexao.Open();
				MySqlCommand COMANDO = new MySqlCommand("INSERT INTO animal (id_animal,nome,sexo,raca,idade,data_nascimento, tipo,porte, descri)" + "VALUES('" + id_animal + "','" + nome + "','" + sexo + "','" + raca + "','" + idade + "','" + porte + "','" + tipo + "','" + data_nascimento + "','" + descri + "')", Conexao);
				COMANDO.ExecuteNonQuery();
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

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
