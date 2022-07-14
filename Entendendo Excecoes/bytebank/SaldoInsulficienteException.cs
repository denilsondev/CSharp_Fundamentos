namespace bytebank
{
    public class SaldoInsulficienteException : OperacaoFinanceiraException
    {
        public SaldoInsulficienteException(string mensagem) : base(mensagem)
        {
            
        }
    }
}