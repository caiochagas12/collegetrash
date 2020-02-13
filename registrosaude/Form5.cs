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
	public partial class Form5 : Form
	{
		public Form5()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form3 lal = new Form3();
			lal.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Form4 las = new Form4();
			las.Show();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Form6 sas = new Form6();
			sas.Show();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			Form7 sass = new Form7();
			sass.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Form8 lab = new Form8();
			lab.Show();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Form9 labb = new Form9();
			labb.Show();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			Form10 na = new Form10();
			na.Show();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			Form11 ma = new Form11();
			ma.Show();
		}
	}
}
