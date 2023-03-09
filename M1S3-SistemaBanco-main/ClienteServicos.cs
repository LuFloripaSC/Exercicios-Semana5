﻿using M1S3_SistemaBanco;
namespace M1S3_SistemaBanco
{
    public class ClienteServicos : IClienteServicos
    {
        public static List<Cliente> clientes = new List<Cliente>();
        public virtual Cliente BuscarPorNumeroDeConta(int numeroConta)
        {
            return clientes.Find(x => x.NumeroConta == numeroConta);
        }
        public void ExibirClientes()
        {
            Console.WriteLine("Número da conta        | Nome         | CPF    ");
            for (int i = 0; i < clientes.Count; i++)
            {
                Console.WriteLine(clientes[i].ResumoCliente());
            }
        }
        public void CriarConta(string tipoConta)
        { //Variavel indica tipo de conta
            if (tipoConta == "1")
            { //identificar tipo de conta
                PessoaFisica clientePf = new PessoaFisica();// instaciada classe Pessoa Fisica e criação de construtor vazio.
                Console.WriteLine("Data de Nascimento do cliente:");
                clientePf.DataNascimento = DateTime.Parse(Console.ReadLine());

                if (!clientePf.EhMaior())// verificação maioridade
                {
                    Console.WriteLine("não é possivel abrir a conta pois o CLiente é menor de idade");
                    return;
                }
                Console.WriteLine("A idade do cliente é " + clientePf.Idade);
                Console.WriteLine("Nome do cliente:");
                clientePf.Nome = Console.ReadLine();
                Console.WriteLine("CPF do cliente:");
                clientePf.CPF = Console.ReadLine();
                Console.WriteLine("Endereco do cliente:");
                clientePf.Endereco = Console.ReadLine();
                Console.WriteLine("Telefone do cliente:");
                clientePf.Telefone = Console.ReadLine();
                Console.WriteLine("Email do cliente:");
                clientePf.Email = Console.ReadLine();
                Console.WriteLine("Numero Da Conta");
                clientePf.NumeroConta = int.Parse(Console.ReadLine());
                clientes.Add(clientePf);
            }
            else if (tipoConta == "2")
            {
                PessoaJuridica clientePj = new PessoaJuridica();


                Console.WriteLine("Razão Social:");
                clientePj.RazaoSocial = Console.ReadLine();
                Console.WriteLine("CNPJ do cliente:");
                clientePj.Cnpj = Console.ReadLine();
                Console.WriteLine("Endereco do cliente:");
                clientePj.Endereco = Console.ReadLine();
                Console.WriteLine("Telefone do cliente:");
                clientePj.Telefone = Console.ReadLine();
                Console.WriteLine("Email do cliente:");
                clientePj.Email = Console.ReadLine();
                Console.WriteLine("Numero Da Conta");
                clientePj.NumeroConta = int.Parse(Console.ReadLine());
                clientes.Add(clientePj);

            }
        }

        internal static Cliente BuscarClientePorNumeroDeConta(int numeroConta)
        {
            throw new NotImplementedException();
        }

        Cliente IClienteServicos.BuscarClientePorNumeroDeConta(int numeroConta)
        {
            throw new NotImplementedException();
        }
    }
}