using _00_Biblioteca;
using System.Text.Json;
using System.Xml.Serialization;

namespace Serealizar_Deserializar.JSON
{
    internal class GlobalSerializarJSON
    {
        internal void Serealizar()
        {
            var usuario = JsonSerializer.Serialize(MoqUsuario.SingleUsuario());
            StreamWriter stream = new StreamWriter(AttributesStrings.caminhoArquivoJson);
            stream.WriteLine(usuario);
            stream.Close();
            stream.Dispose();
        }

        internal void Deserealizar()
        {
            StreamReader stream = new StreamReader(AttributesStrings.caminhoArquivoJson);
            Usuario? usuario = JsonSerializer.Deserialize<Usuario>(stream.ReadToEnd());
            Console.WriteLine(value: $" Nome:{usuario.Nome}\n CPF:{usuario.CPF}\n Email:{usuario.Email}");
        }

    }
}
