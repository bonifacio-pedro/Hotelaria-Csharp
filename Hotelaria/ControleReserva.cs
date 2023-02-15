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
    public partial class ControleReserva : Form
    {
        public ControleReserva()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Reservas> procura = MenuPrincipal.reservas.Where(x => x.numeroQuarto == quarto.Value).ToList();
            if(procura.Count > 0)
            {
                quartoEdit.Enabled = true;
                cliente.Enabled = true;
                cpf.Enabled = true;
                dataEntrada.Enabled = true;
                dataSaida.Enabled = true;

                foreach(Reservas reserva in procura)
                {
                    quartoEdit.Value = reserva.numeroQuarto;
                    cliente.Text = reserva.nomeCliente;
                    cpf.Text = reserva.cpfCliente;
                    dataEntrada.Text = reserva.dataEntrada.ToString("dd/MM/yy hh:mm");
                    dataSaida.Text = reserva.dataSaida.ToString("dd/MM/yy hh:mm");
                }
            }
            else
            {
                quartoEdit.Enabled = false;
                cliente.Enabled = false;
                cpf.Enabled = false;
                dataEntrada.Enabled = false;
                dataSaida.Enabled = false;
                MessageBox.Show("Não encontramos nenhuma reserva neste quarto!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Reservas> procura = MenuPrincipal.reservas.Where(x => x.numeroQuarto == quarto.Value).ToList();
            if(procura.Count > 0)
            {
                try
                {
                    if (cliente.Text != "" && cpf.MaskCompleted && quartoEdit.Value != 0 && dataEntrada.MaskCompleted && dataSaida.MaskCompleted)
                    {
                        foreach (Reservas res in procura)
                        {
                            MenuPrincipal.reservas.Remove(res);
                        }
                        Reservas reserva = new Reservas((int)quartoEdit.Value, cliente.Text, cpf.Text, Convert.ToDateTime(dataEntrada.Text), Convert.ToDateTime(dataSaida.Text));
                        MenuPrincipal.reservas.Add(reserva);

                        Serializador.Recria(MenuPrincipal.reservas, MenuPrincipal.caminhoReservas);
                        MessageBox.Show("Reserva editada com sucesso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                catch (System.FormatException ex)
                {
                    MessageBox.Show("Você deve inserir uma data válida!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Erro ao remover a reserva!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Reservas> procura = MenuPrincipal.reservas.Where(x => x.numeroQuarto == quarto.Value).ToList();
            if (procura.Count > 0)
            {

                foreach (Reservas reserva in procura)
                {
                    MenuPrincipal.reservas.Remove(reserva);
                }
                Serializador.Recria(MenuPrincipal.reservas, MenuPrincipal.caminhoReservas);
                MessageBox.Show("Reserva removida com sucesso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao remover a reserva!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
