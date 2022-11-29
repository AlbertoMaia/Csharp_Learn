using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank_ADM.ParceriaComercial;

namespace ByteBank_ADM.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar(iAutenticável Funcionario, string senha)
        {
            bool usarioAutenticado = Funcionario.Autenticar(senha);
            if (usarioAutenticado == true)
            {
                Console.WriteLine("Bem vindo ao sistema, " + Funcionario.Nome + ".");
                return true;
            }

            else
            {
                Console.WriteLine("Senha incorreta");
                return false;
            }

        }

        public bool Logar(ParceiroComercial Funcionario, string senha)
        {
            bool usarioAutenticado = Funcionario.Autenticar(senha);
            if (usarioAutenticado == true)
            {
                Console.WriteLine("Bem vindo ao sistema, " + Funcionario.Nome + ".");
                return true;
            }

            else
            {
                Console.WriteLine("Senha incorreta");
                return false;
            }

        }
    }

}
