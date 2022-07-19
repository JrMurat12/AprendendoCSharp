using ByteBank_Adm.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Adm.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar(Autenticavel funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);
            if (usuarioAutenticado == true)
            {
                Console.WriteLine("Bem vindo ao sistema!");
                return true;
            } 
            else
            {
                Console.WriteLine("Senha incorreta, tente novamente");
                return false; 
            }
        }
    }
}
