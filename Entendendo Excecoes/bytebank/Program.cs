
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
        //   CarregarContas();
        CarregarArquivo();
        }

        private static void CarregarArquivo()
        {
            LeitorDeArquivo leitor = new LeitorDeArquivo("contas.txt"); 
            try 
            {
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();


            }
            catch(IOException ex)
            {
                System.Console.WriteLine("Excecao do tipo IOException capturada e tratada");
            }
            finally
            {
                leitor.Fechar();
            }
        }

        private static void CarregarContas()
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(5425, 52665);
                ContaCorrente conta2 = new ContaCorrente(5245, 52425);

                conta.Depositar(50);
                System.Console.WriteLine(conta.Saldo);
                conta.Transferir(500, conta2);
                System.Console.WriteLine(conta.Saldo);

            }
            catch (OperacaoFinanceiraException ex)
            {
                System.Console.WriteLine(ex.Message);
                System.Console.WriteLine(ex.StackTrace);
                System.Console.WriteLine("Informacoes do inner exception");
                System.Console.WriteLine(ex.InnerException.Message);
                System.Console.WriteLine(ex.InnerException.StackTrace);

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