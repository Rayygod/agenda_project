namespace agenda_project
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void verificador_botao()
        {
            if (textBox1.Text.Length > 0 && textBox2.Text.Length >= 8)
            {
                btn_entrar.Enabled = true;
                btn_entrar.Cursor = Cursors.WaitCursor;
            }
            else
            {
                btn_entrar.Enabled = false;
            }
        }



        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            FrmCadastro cadastro = new FrmCadastro();
            cadastro.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            verificador_botao();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            verificador_botao();
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
