
namespace Tabuleiro
{
    internal class Posicao
    {
        public int linha {  get; set; }// get e set esse e um principio de encapsulamento
       public int coluna {  get; set; }// podem ser assessados e alterados por outras classes

        public Posicao(int linha, int coluna)// construtures
        {
            this.linha = linha;//instaciando os objetos
            this.coluna = coluna;
        }
        public override string ToString()
        {
            return linha
                + ", "
                + coluna;
        }
    }
}
