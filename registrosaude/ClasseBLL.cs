using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace registrosaude
{
	class ClasseBLL
	{
		ClasseDAL dal = null;

		public DataTable exibirdadosdal() //string de exibicao de dados
		{
			try
			{
				DataTable datat = new DataTable();
				dal = new ClasseDAL();

				datat = dal.exibirDados();

				return datat;
			}
			catch (Exception erro)
			{
				throw erro;
			}
		}
	}
}
