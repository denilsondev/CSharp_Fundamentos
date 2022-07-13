
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytebank;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(5025, 52665);
                conta.Depositar(50);
                System.Console.WriteLine(conta.Saldo);
                conta.Sacar(500);
                System.Console.WriteLine(conta.Saldo);

            }
            catch (ArgumentException ex)
            {
                System.Console.WriteLine("Problema no parametro", ex.ParamName);
                System.Console.WriteLine("Ocorreu um erro do tipo argument exceptio");
                System.Console.WriteLine(ex.Message);

            }
            catch (DivideByZeroException)
            {
                System.Console.WriteLine("Não é possivel fazer uma divisao por 0!");
            }
               catch (SaldoInsulficienteException)
            {
                System.Console.WriteLine("Saldo insulficiente");
            }


        }

        private static void Metodo()
        {
            TestaDivisao(10);
        }

        public static void TestaDivisao(int divisor)
        {

            int resultado = Dividir(10, divisor);
            System.Console.WriteLine("Resultado desta divisao eh " + resultado);
        }


        private static int Dividir(int numero, int divisor)
        {
            ContaCorrente conta = null;
            return numero / divisor;
        }
    }

}