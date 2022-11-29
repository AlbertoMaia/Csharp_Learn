using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank_ADM.Funcionarios;

namespace ByteBank_ADM.Utiliátios
{
    public class GerenciadorDeBonificação
    {
        private double totalBonificacao;

        public double Salario { get; set; }

        public void Registrar(Funcionario funcionario)
        {
            this.totalBonificacao += funcionario.getBonificacao();
        }
        public double getBonificacao()
        {
            return Salario * 0.5;
        }
        public string Senha { get; set; }
        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }  
    }
}
