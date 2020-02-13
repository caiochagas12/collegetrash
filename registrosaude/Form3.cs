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
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{
			string id_dono = textBox15.Text;
			string nomes = textBox1.Text;
			string cpf = textBox2.Text;
			string email = textBox3.Text;
			string endereco = textBox4.Text;
			string telefone = textBox5.Text;
			string cidade = textBox6.Text;
			string estado = textBox17.Text;
			string data_nascimentos= textBox7.Text;
			



			
				


			if (nomes == "" || cpf == "" || endereco == "" || email == "" || telefone == "" || cidade == "" || estado == "" || data_nascimentos == "" )
			{
				MessageBox.Show("você não pode deixar os campos vazios", "ERRO");
				return;
			}
			
			string Configuracao = "server=localhost;userid=root;password=1234;port=3306;database=banquinho_saude;";
			MySqlConnection Conexao = new MySqlConnection(Configuracao);
			try
			{
				Conexao.Open();
				MySqlCommand COMANDOS = new MySqlCommand("INSERT INTO dono (id_dono,nomes, cpf , email, endereco,telefone, cidade, estado,data_nascimentos)" + "VALUES('" + id_dono + "','" + nomes + "','" + cpf + "','" +email + "','" + endereco + "','" + telefone + "','" + cidade + "','" + estado + "','" + data_nascimentos + "')", Conexao);
				COMANDOS.ExecuteNonQuery();
				
				MessageBox.Show("Informações registrada com sucesso no banco de dados!", "Imformações registrada!");
				
				
			}
			catch
			{
				MessageBox.Show("Não foi possivel registrar as informações no banco de dados", "ERRO de conexao");
			}
		}

		private void label2_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void label6_Click(object sender, EventArgs e)
		{
			
		}

	}
}

