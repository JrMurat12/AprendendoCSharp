using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Adm.Funcionarios
{
    public class Auxiliar: Funcionario
    {
        public override double getBonificacao()
        {
            return Salario * 0.20;
        }

        public Auxiliar(string cpf, double salario) : base(cpf, salario)
        {
            Console.WriteLine("Criando um Auxiliar...");
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.10;
        }
    }
}
