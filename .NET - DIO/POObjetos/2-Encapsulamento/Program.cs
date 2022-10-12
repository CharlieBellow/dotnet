namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            var carro1 = new Veiculo("ford", "ka", "prata", "flex"); 
        //criei um objeto a partir de uma vairiável  e chamei esse objeto de carro, e disse que esse objeto está relacionado a classe veículo, depois abri parenteses para ir colocando os atributos do objeto carro. tudo que fiz aqui foi instanciar os objetos carro1 e carro2
        var carro2 = new Veiculo("volkswagen", "nivus", "cinza", "flex");

        carro1.ligar();
        carro1.acelerar();
        carro1.frear();
        carro1.desligar();

        carro2.ligar();
        carro2.acelerar();
        carro2.frear();
        carro2.desligar();

        }
    }
}