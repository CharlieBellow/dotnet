//exemplo de classe
public class Produto //Nome da classe 
//é publica pq pode ser acessada de qualquer parte do programa
{

    private int codigo; //Atributo da classe
                        //o códdigo é privado pq pertence a um produto, é inteiro pq recebe um número inteiro
    private string nome; //Atributo da classe 
    private decimal preco; //Atributo da classe

    public int Codigo
    {
        get => codigo; set > codigo = value; } //Propriedade da classe (pega o atributo e seta o atributo)
    public string Nome { get => nome; set => nome value; } //Propriedade da classe

    public decimal Preco { get => preco; set => preco = value; } //Propriedade da classe
}
