using Generics;
using Generics.Model;

internal class Program
{
    private static void Main(string[] args)
    {
        Carro carro = new Carro();
        Casa casa = new Casa();
        Usuario usuario = new Usuario();

        Serializador.Serializar(carro);
        Serializador.Serializar(casa);
        Serializador.Serializar(usuario);

        Carro carro2 = Serializador.Deserializar<Carro>();
        Casa casa2 = Serializador.Deserializar<Casa>();
        Usuario usuario2 = Serializador.Deserializar<Usuario>();

        Console.WriteLine(carro2.ToString());
        Console.WriteLine(casa2.ToString());
        Console.WriteLine(usuario2.ToString());
    }
}