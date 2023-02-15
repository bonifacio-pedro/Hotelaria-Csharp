using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotelaria
{
    public partial class CadastraFuncionario : Form
    {
        private string caminho = @"funcionarios.xml";
        public CadastraFuncionario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nome.Text != "" && senha.Text != "")
            {
                Funcionarios funcionario = new Funcionarios(nome.Text, senha.Text);
                Form1.funcionarios.Add(funcionario);
                Serializador.Serializa(Form1.funcionarios,caminho);
                MessageBox.Show("Funcionário adicionado com sucesso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Você deve inserir dados válidos!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
