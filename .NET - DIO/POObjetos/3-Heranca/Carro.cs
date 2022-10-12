namespace Heranca
{
    public class Carro: Veiculo //aqui eu tô dizendo que um carro faz tudo que um veículo faz
    {
        //aqui abaixo tô passanso pra o carro a marca, modelo e cor na classe base
        public Carro(string marca, string modelo, string cor) : base(marca, modelo, cor) 
        {
            Console,WriteLine("Eu sou um carro");
        }
    }
}