using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing.Drawing2D;

namespace cadastrousuario
{
    public partial class Inicio : UserControl
    {

        string conexao = "server=localhost;user id=root;password=euteamo12;persistsecurityinfo=True;database=db";

        public Inicio()
        {
            InitializeComponent();

            GraphicsPath forma = new GraphicsPath();
            forma.AddEllipse(0, 0, panel1.Width, panel1.Height);
            panel1.Region = new Region(forma);

            GraphicsPath forma2 = new GraphicsPath();
            forma2.AddEllipse(0, 0, panel2.Width, panel2.Height);
            panel2.Region = new Region(forma2);
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
           // Usuarios
            string sql = "SELECT ID from usuarios";
            MySqlConnection conn = new MySqlConnection(conexao);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Connection = conn;
            conn.Open();

            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    lb_usuarios.Text = dr["ID"].ToString();

                }
                conn.Close();

                // Clientes
                string sqll = "SELECT ID from clientes";
                MySqlConnection connn = new MySqlConnection(conexao);
                MySqlCommand cmdd = new MySqlCommand(sqll, connn);
                cmdd.Connection = connn;
                connn.Open();

                MySqlDataReader drr = cmdd.ExecuteReader();

                if (drr.HasRows)
                {
                    while (drr.Read())
                    {
                        lb_clientes.Text = drr["ID"].ToString();

                    }
                }
                connn.Close();
            }
        }
    }
}
    

