using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace registrosaude
{
	class ClasseDALLL
	{
		string Configuracao = "server=localhost;userid=root;password=1234;port=3306;database=banquinho_saude;";
		MySqlConnection conexao = null;
		MySqlCommand comando;

		public DataTable exibirDados()
		{ //string de select para selexao no banco de dados
			try
			{
				conexao = new MySqlConnection(Configuracao);
				comando = new MySqlCommand("SELECT * FROM funcionario", conexao);

				MySqlDataAdapter da = new MySqlDataAdapter();
				da.SelectCommand = comando;
				DataTable dt = new DataTable();

				da.Fill(dt);

				return dt;

			}
			catch (Exception erro)
			{
				throw erro;
			}
		}
	}
}
