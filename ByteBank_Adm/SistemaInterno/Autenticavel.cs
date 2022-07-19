using ByteBank_Adm.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Adm.SistemaInterno
{
    public interface Autenticavel
    {
        //public Autenticavel(string cpf, double salario) : base(cpf, salario)
        //{
        //}

        public bool Autenticar(string senha);

        //public override double getBonificacao()
        //{
        //    return 0;
        //}

        //public override void AumentarSalario()
        //{
        //    Console.WriteLine("Implementar AumentarSalario");
        //}
    }
}
