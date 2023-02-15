using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelaria
{
    public class Reservas
    {
        public int numeroQuarto;
        public string nomeCliente;
        public string cpfCliente;
        public DateTime dataEntrada;
        public DateTime dataSaida;

        public Reservas(int numeroQuarto, string nomeCliente, string cpfCliente, DateTime dataEntrada, DateTime dataSaida)
        {
            this.numeroQuarto = numeroQuarto;
            this.nomeCliente = nomeCliente;
            this.cpfCliente = cpfCliente;
            this.dataEntrada = dataEntrada;
            this.dataSaida = dataSaida;
        }

        public Reservas()
        {

        }

    }
}
