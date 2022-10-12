namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            var carro = new Carro("ford", "ka", "prata", 4); 
        //criei um objeto a partir de uma vairiável  e chamei esse objeto de carro, e disse que esse objeto está relacionado a classe veículo, depois abri parenteses para ir colocando os atributos do objeto carro. tudo que fiz aqui foi instanciar os objetos carro1 e carro2
        var aviao = new Aviao("Airbus", "A320", "Branco", 4);

        carro1.ligar();
        carro1.acelerar();
        carro1.frear();
        carro1.desligar();

        aviao.ligar();
        aviao.acelerar();
        aviao.frear();
        aviao.desligar();

        }
    }
}