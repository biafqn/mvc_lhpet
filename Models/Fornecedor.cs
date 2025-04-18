using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LHPet.Models
{
    public class Fornecedor
    {
        public int? Id { get; set; }

        public string? Nome { get; set; }

        public string? Cnpj { get; set; }

        public string? Email { get; set; }

        public Fornecedor(int Id, string Nome, string Cnpj, string Email)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Cnpj = Cnpj;
            this.Email = Email;
        }
    }
}