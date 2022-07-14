namespace bytebank
{
    public class OperacaoFinanceiraException : Exception
    {
        public OperacaoFinanceiraException()
        {
            
        }
        public OperacaoFinanceiraException(string mensagem):base(mensagem)
        {
            
        }

        public OperacaoFinanceiraException(string mensagem, Exception excessaoInterna): base(mensagem, excessaoInterna)
        {
            
        }

        
    }
}