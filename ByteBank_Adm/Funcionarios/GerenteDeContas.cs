using ByteBank_Adm.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Adm.Funcionarios
{
    public class GerenteDeContas: FuncionarioAutenticado
    {
        public override double getBonificacao()
        {
            return Salario * 0.25;
        }

        public GerenteDeContas(string cpf, double salario) : base(cpf, salario)
        {
            Console.WriteLine("Criando um Gerente...");
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.05;
        }

        //public string Senha { get; set; }

        //public bool Autenticar(string senha)
        //{
        //    return this.Senha == senha;
        //}
    }
}
