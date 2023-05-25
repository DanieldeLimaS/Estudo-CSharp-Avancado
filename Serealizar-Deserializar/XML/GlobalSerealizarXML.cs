using _00_Biblioteca;
using System.Xml.Serialization;

namespace Serealizar_Deserializar.XML
{
    public class GlobalSerealizarXML
    {
        public void Serealizar()
        {
            var usuario = MoqUsuario.SingleUsuario();
            XmlSerializer serializador = new XmlSerializer(typeof(Usuario));
            StreamWriter stream = new StreamWriter(AttributesStrings.caminhoArquivoXml);
            serializador.Serialize(stream, usuario);
            stream.Close();
            stream.Dispose();
        }
        public void Deserealizar()
        {
            StreamReader stream = new StreamReader(AttributesStrings.caminhoArquivoXml);
            XmlSerializer serializador = new XmlSerializer(typeof(Usuario));
            Usuario? usuario = serializador.Deserialize(stream) as Usuario;
            Console.WriteLine(value: $" Nome:{usuario.Nome}\n CPF:{usuario.CPF}\n Email:{usuario.Email}");
        }
    }
}
