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
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			

			}

		private void button2_Click(object sender, EventArgs e)
		{
		
		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{
		
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
            string ID = textBox6.Text;
			string Firstname = textBox1.Text;
			string Lastname = textBox2.Text;
            string Senha = textBox4.Text;
			string cSenha = textBox5.Text;
			string Email = textBox3.Text;
			
            
			

			if (Firstname == "" || Senha == "" || cSenha == "" || Email == "")
			{
				MessageBox.Show("você não pode deixar os campos vazios", "ERRO");
				return;
			}
			if (Senha != cSenha)
			{
				MessageBox.Show("as senhas estão diferente favor colocar igual", "ERRO");
				return;
			}
			string Configuracao = "server=localhost;userid=root;password=1234;port=3306;database=banquinho_saude;";
			MySqlConnection Conexao = new MySqlConnection(Configuracao);
			try
			{
				Conexao.Open();
				MySqlCommand COMANDO = new MySqlCommand("INSERT INTO login_cadastro (ID , Firstname, Lastname , Senha, Email)" + "VALUES('" + ID + "','" + Firstname + "','" + Lastname + "','" + Senha + "','" + Email + "')", Conexao);
				COMANDO.ExecuteNonQuery();
				MessageBox.Show("Conta registrada com sucesso no banco de dados!", "Conta registrada!");
			}
			catch
			{
				MessageBox.Show("Não foi possivel conectar-se com o banco de dados", "ERRO de conexao");
			}
		}

		private void label1_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
	}

