namespace APILoja.Entidades
{
    public class Calca : Roupa
    {
        public int tamanho { get; set; }
        public Calca(string[] cores, string marca, double preco, string tecido, int tamanho) : base(cores, marca, preco, tecido)
        {
            this.tamanho = tamanho;
        }

    }
}
