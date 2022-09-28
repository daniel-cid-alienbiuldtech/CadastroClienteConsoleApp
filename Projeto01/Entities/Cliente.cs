using System;
using System.Collections.Generic;
using System.Text;
//namespace -> define a localização da classe
namespace Projeto01.Entities
{
    //definição da classe..
    //public -> visibilidade total para a classe
    public class Cliente
    {
        // prop + 2x[TAB] -> propriedade
        public Guid IdCliente { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }

    }
}