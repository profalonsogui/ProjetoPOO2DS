namespace ExemploAula
{
    public class Pessoa
    {
        // Atributos Privados (Fields) - O "interior da geladeira"
        private string _nome;
        private int _idade;

        // Propriedades Públicas - A "porta de vidro"
        public string Nome 
        { 
            get { return _nome; } 
            private set { _nome = value; } // Set privado: só a classe muda
        }

        public int Idade 
        { 
            get { return _idade; } 
            set 
            { 
                // Exemplo de validação no SET
                if (value >= 0) _idade = value; 
            } 
        }

        // Construtor: Obriga a pessoa a ter um nome ao "nascer"
        public Pessoa(string nomeInicial, int idadeInicial)
        {
            _nome = nomeInicial;
            Idade = idadeInicial;
        }

        // Método de Comportamento
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
        }
    }
}