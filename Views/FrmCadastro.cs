using agenda_project.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agenda_project
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }
        private void habilitarBotaoLogin()
        {
           bool erro = false;
        if (textBox1.Text == "")
            {
                erro = false;
            }
        if (textBox2.Text == "")
            {
                erro = false;
            }
        if (textBox3.Text == "")
            {
                erro = false;
            }
        if (textBox4.Text.Length < 8)
            {
                erro = true;
            }
        if (textBox4.Text == textBox5.Text)
            {
                erro = false;
            }

        if (erro ==false)
            {
                btn_cadastrar.Enabled = true;
            }
        else
            {
                btn_cadastrar.Enabled =false;
            }
        }  
        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = conexao_db.cria_conexao();
            // abrindo conexão
            conexao.Open();
            // criando o comando SQL para inserir o usuario
            string sql = $"INSERT INTO tb_user (nome, user, telefone, senha) VALUES(@nome, @user, @telefone, @password)";
            // executando o sql
            MySqlCommand comando = new MySqlCommand(sql, conexao);

            comando.Parameters.AddWithValue("@nome", textBox1.Text);
            comando.Parameters.AddWithValue("@user", textBox2.Text);
            comando.Parameters.AddWithValue("@telefone", textBox3.Text);
            comando.Parameters.AddWithValue("@password", textBox4.Text);
            //executando a instrução SQL no banco
            comando.ExecuteNonQuery();
            // fechando a conexão com o banco
            conexao.Close();

            MessageBox.Show("Cadastro feito \n bem vindo!");
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            habilitarBotaoLogin();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            habilitarBotaoLogin();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            habilitarBotaoLogin();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            habilitarBotaoLogin();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            habilitarBotaoLogin();
        }
    }
}
