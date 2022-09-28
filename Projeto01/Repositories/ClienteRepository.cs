using Projeto01.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Projeto01.Repositories
{
    public class ClienteRepository
    {
        //criando um método (função) para receber os
        //dados de um cliente grava-los em arquivo
        public void GravarArquivo(Cliente cliente)
        {
            //Abrindo um arquivo em modo de escrita
            var streamWriter = new StreamWriter("c:\\temp\\clientes.txt");

            //esvrevendo os dados do cliente dentro do arquivo
            streamWriter.WriteLine(cliente.IdCliente);
            streamWriter.WriteLine(cliente.Nome);
            streamWriter.WriteLine(cliente.Email);
            streamWriter.WriteLine(cliente.Cpf);
            streamWriter.WriteLine(cliente.DataNascimento);

            //fechar o arquivo
            streamWriter.Close();
        }
    }
}
