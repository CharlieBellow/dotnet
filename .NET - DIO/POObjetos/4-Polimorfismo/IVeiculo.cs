namespace Encapsulamento
{
    public interface IVeiculo //quando é interface, não pode ter dois objetos com o mesmo nome
    {
        public void ligar();
        public void acelerar();
        public void frear();
        public void desligar();

    }
}