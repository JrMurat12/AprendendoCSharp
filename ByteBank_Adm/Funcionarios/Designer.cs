using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Adm.Funcionarios
{
    public class Designer: Funcionario
    {
        public override double getBonificacao()
        {
            return Salario * 0.17;
        }

        public Designer(string cpf, double salario) : base(cpf, salario)
        {
            Console.WriteLine("Criando um Designer...");
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.11;
        }
    }
}
