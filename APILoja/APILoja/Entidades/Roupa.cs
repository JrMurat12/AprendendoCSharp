namespace APILoja.Entidades
{
    public abstract class Roupa
    {
        public string[] cores { get; set; }
        public string marca { get; set; }
        public double preco { get; set; }
        public string tecido { get; set; }
        public int id { get; set; }
        public string data { get; set; } = DateTime.Now.ToString();



        public Roupa(string[] cores, string marca, double preco, string tecido)
        {
            this.cores = cores;
            this.marca = marca;
            this.preco = preco;
            this.tecido = tecido;
            this.id = id;
        }
    }
}
