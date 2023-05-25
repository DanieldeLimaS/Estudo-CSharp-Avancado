namespace Generics.Model
{
    internal class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public Carro()
        {
            Marca = "FIAT";
            Modelo = "UNO";
        }
        public override string ToString()
        {
            return $"Carro: {Marca} - {Modelo}";
        }
    }
}
