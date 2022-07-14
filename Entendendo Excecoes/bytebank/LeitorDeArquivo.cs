namespace bytebank
{
    public class LeitorDeArquivo
    {
        public string Arquivo { get; set; }

        public LeitorDeArquivo(string arquivo)
        {
            Arquivo = arquivo;
            System.Console.WriteLine("Abrindo arquivo: " + arquivo);
        }

        public string LerProximaLinha()
        {
            System.Console.WriteLine("Lendo linha....");
            System.Console.WriteLine("Lendo linha....");
            System.Console.WriteLine("Lendo linha....");
            throw new IOException();
            return "Linha do arquivo";
        }

        public void Fechar()
        {
            System.Console.WriteLine("Fechando arquivo.");
        }

    }
}