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
    public partial class MenuPrincipal : Form
    {
        public static string caminhoReservas = @"reservas.xml";
        public static List<Reservas> reservas;
        public MenuPrincipal()
        {
            InitializeComponent();
            Serializador.EncheLista(ref reservas, caminhoReservas);
            AtualizaTabela();
        }

        private void AtualizaTabela()
        {
            dt.Rows.Clear();
            foreach (Reservas reserva in reservas)
            {
                string[] dataTemp = {reserva.nomeCliente,reserva.numeroQuarto.ToString(),
                reserva.dataEntrada.ToString("dd/MM/yy hh:mm"), reserva.dataSaida.ToString("dd/MM/yy")};
                dt.Rows.Add(dataTemp);
            }
        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void CadastroReserva()
        {
            CadastraReserva cadastraReser = (CadastraReserva)Application.OpenForms["CadastraReserva"];
            if (cadastraReser == null)
            {
                cadastraReser = new CadastraReserva();
                cadastraReser.Name = "CadastraReserva";
                cadastraReser.Show();
            }
        }

        private void ControleReserva()
        {
            ControleReserva controleReserva = (ControleReserva)Application.OpenForms["ControleReserva"];
            if (controleReserva == null)
            {
                controleReserva = new ControleReserva();
                controleReserva.Name = "ControleReserva";
                controleReserva.Show();
            }
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastraFuncionario cadastroFunc = (CadastraFuncionario)Application.OpenForms["CadastroFuncionario"];
            if(cadastroFunc == null )
            {
                cadastroFunc = new CadastraFuncionario();
                cadastroFunc.Name = "CadastroFuncionario";
                cadastroFunc.Show();
            }
        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerFuncionarios verFunc = (VerFuncionarios)Application.OpenForms["VerFuncionarios"];
            if (verFunc == null)
            {
                verFunc = new VerFuncionarios();
                verFunc.Name = "VerFuncionarios";
                verFunc.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroReserva();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AtualizaTabela();
        }

        private void novaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroReserva();
        }

        private void procurarExcluirOuEditarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleReserva();
            AtualizaTabela();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ControleReserva();
            AtualizaTabela();
        }
    }
}
