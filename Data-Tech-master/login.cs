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
using System.Runtime.InteropServices;


namespace cadastrousuario
{
    public partial class login : Form

    {

        public login()
        {

            InitializeComponent();
            
            // Marca D'agua
            List<TextBox> tList = new List<TextBox>();
            List<string> sList = new List<string>();
            tList.Add(txt_user);
            sList.Add("USUARIO");
            tList.Add(txt_pass);
            sList.Add("SENHA");
            Setcadastrousuario(ref tList, sList);

            // Apertar ENTER no formulario login
            this.AcceptButton = btn_entrar;
        }

        private void txt_user_Validated(object sender, EventArgs e)
        {
            if (txt_user.Text.Trim() == "")
            {
                epError.SetError(txt_user, "Campo Obrigatorio!");
                txt_user.Focus();
            }
            else
            {
                epError.Clear();
            }

        }

        private void txt_pass_Validated(object sender, EventArgs e)
        {
            if (txt_pass.Text.Trim() == "")
            {
                epError.SetError(txt_pass, "Campo Obrigatorio!");
                txt_pass.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint msg, IntPtr i, string str);
        
        void Setcadastrousuario(ref List<TextBox> textBox, List<string> CueText)
        {
            for(int x = 0; x < textBox.Count; x++)
                {
                    SendMessage(textBox[x].Handle, 0x1501, (IntPtr)1, CueText[x]);


                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            // String de conexão
            String conect = "server=localhost;user id=root;password=euteamo12;persistsecurityinfo=True;database=db";

            // Conexão com a string
            MySqlConnection CreateConection = new MySqlConnection(conect);

            // String do txtbox usuario e senha
            String User = txt_user.Text;
            String Senha = txt_pass.Text;

            // String de selecionar usuario, senha e nivel no banco
            String sql = @"SELECT Usuarios, Senha, nivel FROM usuarios where Usuarios = @user AND Senha = @senha";

            // Comando para execultar as strings (sql, Conect)
            MySqlCommand comando = new MySqlCommand(sql, CreateConection);

            // Declarando parametros User e SENHA
            comando.Parameters.AddWithValue("@user", User);
            comando.Parameters.AddWithValue("@senha", Senha);

            // Abrir Conexão
            CreateConection.Open();

            // Ler Dados
            MySqlDataReader dados = comando.ExecuteReader();
            if (dados.Read())
            {
                // String de Nivel
                string nivel = dados.GetString("nivel");

                // Usuario
                if (nivel.Equals("usuario"))
                {
                    this.Hide();
                    painelUSUARIO ss = new painelUSUARIO();
                    ss.Show();
                }

                // ADM
                if (nivel.Equals("adm"))
                {
                    this.Hide();
                    PAINEL_ADM ss = new PAINEL_ADM(txt_user.Text);
                    ss.Show();
                }
            }
            else
            {
                // Msg box User/Senha incorreto(a)
                MessageBox.Show("Usuario e/ou Senha estão Incorretos!", "AVISO");
                txt_user.Clear();
                txt_pass.Clear();
            }





            CreateConection.Close();
        }
    }
}
