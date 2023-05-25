// See https://aka.ms/new-console-template for more information
using _00_Biblioteca;
using System.Xml.Serialization;

Usuario user = new Usuario()
{
    Nome = "Daniel de Lima",
    CPF = "123.123.123-12",
    Email = "meuemail@gmail.com"
};
XmlSerializer serializador = new XmlSerializer(typeof(Usuario));
StreamWriter strem = new StreamWriter(@"D:\Documents\dev\Course\Estudo-CSharp-Avancado\01_SerializarXML.xml");
serializador.Serialize(strem, user);
