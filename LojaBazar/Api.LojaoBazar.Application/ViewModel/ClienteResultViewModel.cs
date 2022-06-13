using Api.LojaoBazar.Domain.Entities;
using System;

namespace Api.LojaoBazar.Application.ViewModel
{
    public class ClienteResultViewModel
    {
        public int Id { get; set; }
        public string nome { get; set; }

        public string cpf { get; set; }

        public Endereco endereco { get; set; }

        public DateTime datanascimento { get; set; }
    }
}
