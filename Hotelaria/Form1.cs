namespace Hotelaria
{
    public partial class Form1 : Form
    {
        public static List<Funcionarios> funcionarios;
        private string caminho = @"funcionarios.xml";
        public Form1()
        {
            InitializeComponent();
            Serializador.EncheLista(ref funcionarios, caminho);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (nome.Text != "" && senha.Text != "")
            {
                List<Funcionarios> funcionarioNome = funcionarios.Where(x => x.nomeFuncionario == nome.Text).ToList();
                List<Funcionarios> funcionarioSenha = funcionarios.Where(x => x.senhaFuncionario == senha.Text).ToList();
                if (funcionarioNome.Count > 0 && funcionarioSenha.Count > 0)
                {
                    MenuPrincipal menu = new MenuPrincipal();
                    menu.Name = "menuPrincipalForm";
                    this.Hide();
                    menu.Show();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nome.Text = "";
                    senha.Text = "";
                }
                
            }
            else
            {
                MessageBox.Show("Você deve inserir dados válidos!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            
        }
    }
}