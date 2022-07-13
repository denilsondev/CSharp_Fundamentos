namespace bytebank
{
    public class SaldoInsulficienteException : Exception
    {
        public SaldoInsulficienteException(string mensagem) : base(mensagem)
        {
            
        }
    }
}