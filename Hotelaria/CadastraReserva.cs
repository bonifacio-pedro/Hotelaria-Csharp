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
    public partial class CadastraReserva : Form
    {
        public CadastraReserva()
        {
            InitializeComponent();
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (cliente.Text != "" && cpf.MaskCompleted && quarto.Value != 0 && dataEntrada.MaskCompleted && dataSaida.MaskCompleted)
            {
                try
                {
                    Reservas reserva = new Reservas((int)quarto.Value, cliente.Text, cpf.Text, Convert.ToDateTime(dataEntrada.Text), Convert.ToDateTime(dataSaida.Text));
                    MenuPrincipal.reservas.Add(reserva);
                    Serializador.Serializa(MenuPrincipal.reservas, MenuPrincipal.caminhoReservas);
                    MessageBox.Show("Reserva cadastrada com sucesso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (System.FormatException ex)
                {
                    MessageBox.Show("Você deve inserir uma data válida!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
               
            }
            else
            {
                MessageBox.Show("Você deve inserir dados válidos!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
