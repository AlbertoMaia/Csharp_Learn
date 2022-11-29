using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank_ADM.Funcionarios;

namespace ByteBank_ADM.SistemaInterno
{
    public interface iAutenticável
    {
        string Nome { get; set; }

        public bool Autenticar(string senha);
    }
}
