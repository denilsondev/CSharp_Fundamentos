using bytebank;
using bytebank.Titular;

namespace ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }

        public static int TotalDeContasCriadas { get; private set; }


        private int _agencia;
        public int Agencia
        {
            get
            {
                return _agencia;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }

                _agencia = value;
            }
        }
        public int Numero { get; }

        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }


        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            if(agencia <= 0)
            {
                throw new ArgumentException("Os argumentos tem que ser maiores que zero", nameof(agencia));
            }

            if(numero <= 0)
            {
                throw new ArgumentException("Os argumentos tem que ser maiores que zero", nameof(numero));
            }
            

            TotalDeContasCriadas++;
        }


        public void Sacar(double valor)
        {
            if (_saldo < valor)
            {
                throw new SaldoInsulficienteException("Saldo insulficiente para saque no valor de " + valor);
            }
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }


        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            try
            {
                Sacar(valor);

            }
            catch(SaldoInsulficienteException ex)
            {
                throw new OperacaoFinanceiraException("Operacao nao realizada", ex);


            }

            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}