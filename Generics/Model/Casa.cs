using Generics.Lib.Extensions;

namespace Generics.Model
{
    internal class Casa
    {
        public string Cidade { get; set; }
        public string Endereco { get; set; }
        public Casa()
        {
            Cidade = "sao paulo";
            Endereco = "Rua x y z,12,centro";
        }
        public override string ToString()
        {
            return $"Casa: {Cidade.FirstToUpper()} - {Endereco}";
        }
    }
}
