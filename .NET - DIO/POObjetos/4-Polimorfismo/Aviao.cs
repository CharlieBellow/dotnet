namespace POObjetos.4_Polimorfismo
{
    public class Aviao : Veiculo
    {
        public int _numeroDeTurbinas { get; set; }

        public Aviao(string marca, string modelo, string cor, int numeroDeTurbinas) : base(marca, modelo, cor)
        {
            
        }

        public override void ligar() // o overrride, sobrescreve a classe já definida para esse objeto. Para isso, a superclasse precisa ter o indicativo "virtual"
        {
            Console.WriteLine("- Ligar avião");
        }
    }
}