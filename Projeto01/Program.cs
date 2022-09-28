using System;
using Projeto01.Entities; //importando
using Projeto01.Repositories;

//namespace -> localização da classe no projeto
namespace Projeto01
{
    //definição da classe
    internal class Program
    {
        //método (Função) principal da classe Program.cs
        static void Main(string[] args)
        {
            //imprimindo mensagem no prompt
            Console.WriteLine("\n *** CADASTRO DE CLIENTES *** \n");

            //declarando um objeto
            var cliente = new Cliente();

            //gerando o ID do cliente (GUID)
            cliente.IdCliente = Guid.NewGuid();

            //cw + 2x[TAB]
            Console.WriteLine("\n Informe o nome do cliente: ");
            cliente.Nome = Console.ReadLine();

            Console.WriteLine("\n Informe o Email do cliente: ");
            cliente.Email = Console.ReadLine();

            Console.WriteLine("\n Informe o CPF do cliente: ");
            cliente.Cpf = Console.ReadLine();

            Console.WriteLine("\n Informe a data de nascimento: ");
            cliente.DataNascimento = DateTime.Parse(Console.ReadLine());

            //imprimir os dados do cliente no console..
            Console.WriteLine("\nDADOS DO CLIENTE:");
            Console.WriteLine("ID do Cliente..........: " + cliente.IdCliente);
            Console.WriteLine("Nome do Cliente........: " + cliente.Nome);
            Console.WriteLine("Email..................: " + cliente.Email);
            Console.WriteLine("CPF....................: " + cliente.Cpf);
            Console.WriteLine("Data de Nascimento.....: " + cliente.DataNascimento);

            //criando um objeto para classe ClienteRepository
            var clienteRepository = new ClienteRepository();

            //gravar o cliente em arquivo..
            clienteRepository.GravarArquivo(cliente);

            //parar a execução do prompt  
            Console.ReadKey();
        }
    }
}