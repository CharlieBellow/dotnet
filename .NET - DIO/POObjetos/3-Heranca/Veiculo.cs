namespace POObjetos.3_Heranca
{
    public abstract class Veiculo : IVeiculo //aqui estamos dizendo que essa classe está herdando de IVeiculo
    {
        //no C# é necessário dizer qual é a visibilidade que esse atributo vai ter e definir qual é o tipo (ex. de tipo: string, int...). Depoi disso, deve ser colocado o { get; set; } para poder acessar os atributos e alterar o valor deles

        public string marca { get; set; }
        public string cor { get; set; }
        public string modelo { get; set; }
        public string combustivel { get; set; }

        // adicionando um construtor. todo objeto criao, vai se referenciar a esse construtor. para adicionar, colaca o tipo de visibilidade e a que classe ele pertence, seguido de parenteses com as informações do construtor e as chaves
        public Veiculo()
        {

        }

        public Veiculo (string marca, string modelo, string cor, string combustivel)
        {
            //inicializando os valores:
            //1ª forma:
            this._marca = marca;
            //2ª forma:
            _modelo = modelo;
            _cor = cor
            _combustivel = combustivel;

        }

        //adicinando métodos
        public void ligar()
        {
            Console.Writeline($"O veículo {_marca} {_modelo} está ligado.");
        }

        public void acelerar()
        {
            Console.Writeline($"O veículo {_marca} {_modelo} está acelerando.");
        }

        public void desligar()
        {
            Console.Writeline($"O veículo {_marca} {_modelo} está desligando.");
        }

        //Abstração
        private void processoLigar() //quando é privado, só a classe dele pode ver
        { 
            Console.WriteLine($"   -- Colocar a chave na ignição");
            Console.WriteLine($"   -- rodar a chave");
        }
        
    }
}