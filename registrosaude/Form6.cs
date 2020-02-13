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
	public partial class Form6 : Form
	{
		private object textBox15;
		private object textBox1;
		private object textBox2;
		private object textBox3;
		private object textBox4;
		private object textBox5;
		private object textBox6;
		private object textBox17;
		private object textBox7;
		public Form6()
		{
			InitializeComponent();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			textBox15 = dataGridView1.CurrentRow.Cells[0].Value.ToString();
			textBox1 = dataGridView1.CurrentRow.Cells[2].Value.ToString();

			textBox2 = dataGridView1.CurrentRow.Cells[3].Value.ToString();
			textBox3 = dataGridView1.CurrentRow.Cells[4].Value.ToString();
			textBox4 = dataGridView1.CurrentRow.Cells[5].Value.ToString();

			textBox5 = dataGridView1.CurrentRow.Cells[6].Value.ToString();



			textBox6 = dataGridView1.CurrentRow.Cells[7].Value.ToString();
			textBox17 = dataGridView1.CurrentRow.Cells[8].Value.ToString();
			textBox7 = dataGridView1.CurrentRow.Cells[9].Value.ToString();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			ClasseBLL bll = new ClasseBLL();

			try
			{
				dataGridView1.DataSource = bll.exibirdadosdal();
			}
			catch (Exception erro)
			{
				MessageBox.Show("erro ao exibir os dados" + erro); //mensagem de erro caso o problema seja nesse setor
			}
		}
	}
}
