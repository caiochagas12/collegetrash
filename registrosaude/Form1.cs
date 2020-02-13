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

	public partial class Form1 : Form
	{

		MySqlConnection conn = new MySqlConnection("server = localhost; userid = root; password = 1234; port = 3306; database = banquinho_saude; ");
		int i;
		public Form1()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Form2 outro = new Form2();
			outro.ShowDialog();
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{
			Form2 outro = new Form2();
			outro.ShowDialog();

		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			i = 0;
			conn.Open();
			MySqlCommand cmd = conn.CreateCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "select * from login_cadastro where Email='" + textBox1.Text + "' and Senha='" + textBox2.Text + "' ";
			cmd.ExecuteNonQuery();

			DataTable dtt = new DataTable();
			MySqlDataAdapter daa = new MySqlDataAdapter(cmd);
			daa.Fill(dtt);
			i = Convert.ToInt32(dtt.Rows.Count.ToString());

			if (i == 0)
			{
				MessageBox.Show ("voce colocou o usuario ou senha incorreto");
			}
			else
			{
				this.Hide();
				Form5 fm = new Form5();
				fm.Show();
			}
			conn.Close();

			if (textBox1.Text == "" || textBox2.Text == "")
			{
				MessageBox.Show("não pode deixar os campos vazios!", "ERRO Campos vazios!");
			}

		}

	}
}
