using ByteBank_Adm.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Adm.Funcionarios
{
    public abstract class FuncionarioAutenticado : Funcionario, Autenticavel
    {
        protected FuncionarioAutenticado(string cpf, double salario) : base(cpf, salario)
        {
        }

        public string Senha { get; set; }

        public bool Autenticar (string senha)
        {
            return Senha == senha;
        }
    }
}
