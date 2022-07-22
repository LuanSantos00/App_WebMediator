namespace WebMediator.Dominio.Entidades
{
    public class Produto
    {
        public Produto(string nome, decimal valor)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Valor = valor;
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
    }
}
