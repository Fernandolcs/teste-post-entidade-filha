using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestePostEntidadeFilha.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public virtual Endereco EnderecoPessoa { get; set; }
    }
}
