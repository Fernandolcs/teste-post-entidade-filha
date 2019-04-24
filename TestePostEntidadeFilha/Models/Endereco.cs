namespace TestePostEntidadeFilha.Models
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public int PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }
    }
}
