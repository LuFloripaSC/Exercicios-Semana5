
namespace M1S3_SistemaBanco
{
    public class PessoaJuridica : Cliente

    {
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }

        public PessoaJuridica()
        { 
        }
        public PessoaJuridica(string razaoSocial, string cnpj, string email, string telefone,
            string end, DateTime dataNascimento, int numeroConta) : base(email, telefone, end, numeroConta)
        { 
            RazaoSocial = razaoSocial;
            Cnpj = cnpj;
        }
        public override string ResumoCliente()
        {
            return $"{base.ResumoCliente()} | {RazaoSocial} | {Cnpj}";
        }
    }
}