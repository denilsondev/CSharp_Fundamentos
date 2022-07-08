using bytebank_ADM.Funcionarios;

namespace bytebank_ADM.SistemaInterno
{
    public abstract class Autenticavel : Funcionario
    {
        public Autenticavel(string cpf, double salario) : base(salario, cpf)
        {

        }

        public string Senha { get; set; }

        public bool Autenticar(string senha)
        {
            return this.Senha == Senha;
        }
    }
}