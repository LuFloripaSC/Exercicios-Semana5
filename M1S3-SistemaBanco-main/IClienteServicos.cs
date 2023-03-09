using M1S3_SistemaBanco;
namespace M1S3_SistemaBanco
{
    public interface IClienteServicos
    {
        Cliente BuscarClientePorNumeroDeConta(int numeroConta);
        void CriarConta(string tipoConta);
        void ExibirClientes();
    }
}