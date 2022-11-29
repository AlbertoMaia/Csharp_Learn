
using bytebank.Titular;
using bytebank;

namespace bytebank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public string Nome_agencia { get; set; }

        private int _numero_agencia;
        public int Numero_Agencia
        {
            get
            {
                return _numero_agencia;
            }

            set
            {
                if (value <= 0) ;

                else
                {
                    _numero_agencia = value;
                }
            }
        }

        private string _conta;
        public string Conta 
        {
            get 
            { 
                return _conta; 
            }

            set
            {
              if  (_conta == null)
                {
                    return;
                }
                else
                {
                    _conta = value;
                }   
            }
        }

        private double saldo;

        public double Saldo;

        public ContaCorrente(int numero_agencia, string conta)
        {
            numero_agencia = numero_agencia;
            Conta = conta;
            TotalDeContasCriadas += 1;
        }

        public static int TotalDeContasCriadas { get; set; }






    }  
}


