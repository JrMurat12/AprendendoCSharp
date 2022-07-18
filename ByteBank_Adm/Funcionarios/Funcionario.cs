using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Adm.Funcionarios
{
    public class Funcionario
    {
        // 0 - Funcionário
        // 1 - Diretor
        // 2 - Designer
        // N - ...
        // private int _tipo;

        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; set; }

        public double getBonificacao()
        {
                return Salario * 0.1;
        }
    }
}
