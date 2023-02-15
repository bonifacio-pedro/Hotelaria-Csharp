using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelaria
{
    public class Funcionarios
    {
        public string nomeFuncionario;
        public string senhaFuncionario;

        public Funcionarios(string nomeFuncionario, string senhaFuncionario)
        {
            this.nomeFuncionario = nomeFuncionario;
            this.senhaFuncionario = senhaFuncionario;
        }
        public Funcionarios()
        {

        }
    }
}
