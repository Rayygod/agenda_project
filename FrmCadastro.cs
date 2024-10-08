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
