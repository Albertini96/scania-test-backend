namespace backend._Models
{
    public class Caminhao
    {
        public Caminhao(){}
        public Caminhao(int id, string tipoCombustivel, int preco, int tamanho)
        {
            this.id = id;
            this.tipoCombustivel = tipoCombustivel;
            this.preco = preco;
            this.tamanho = tamanho;

        }
        public int id { get; set; }
        public string tipoCombustivel { get; set; }
        public int preco { get; set; }
        public int tamanho { get; set; }
    }
}