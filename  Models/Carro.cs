namespace backend._Models
{
    public class Carro
    {
        public Carro(){}
        public Carro(int id, string tipoCombustivel, int preco, string cor)
        {
            this.id = id;
            this.tipoCombustivel = tipoCombustivel;
            this.preco = preco;
            this.cor = cor;
        }
        public int id { get; set; }
        public string tipoCombustivel { get; set; }
        public int preco { get; set; }
        public string cor {get; set;}
    }
}