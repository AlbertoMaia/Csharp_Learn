using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank_ADM.Funcionarios;
using ByteBank_ADM.SistemaInterno;

namespace ByteBank_ADM.ParceriaComercial
{
    public  class ParceiroComercial: iAutenticável
    {
        
        public string Senha { get; set; }
        public string Nome { get; set; }
        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }
        public bool Logar(ParceiroComercial funcionario, string senha)
        {
            bool usarioAutenticado = funcionario.Autenticar(senha);
            if (usarioAutenticado == true)
            {
                Console.WriteLine("Bem vindo ao sistema, " + funcionario.Nome + ".");
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
