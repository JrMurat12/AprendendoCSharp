namespace APILoja.Entidades
{
    public class Camiseta : Roupa
    {
        public string tamanho { get; set; }
        public Camiseta(string[] cores, string marca, double preco, string tecido, string tamanho) : base(cores, marca, preco, tecido)
        {
            this.tamanho = tamanho;    
        }
    }
}
