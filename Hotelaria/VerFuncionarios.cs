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
    public partial class VerFuncionarios : Form
    {
        public VerFuncionarios()
        {
            InitializeComponent();
            if(Form1.funcionarios.Count > 0)
            {
                foreach(Funcionarios funcionarios in Form1.funcionarios)
                {
                    if(funcionarios.nomeFuncionario != "admin")
                    {
                        string novaLinha = funcionarios.nomeFuncionario;
                        dt.Rows.Add(novaLinha);
                    }
                }
            }
        }
    }
}
