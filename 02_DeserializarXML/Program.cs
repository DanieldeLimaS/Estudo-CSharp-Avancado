using _00_Biblioteca;
using System.Xml.Serialization;


StreamReader stream = new StreamReader(@"D:\Documents\dev\Course\Estudo-CSharp-Avancado\01_SerializarXML.xml");

XmlSerializer serializador = new XmlSerializer(typeof(Usuario));
Usuario? usuario = serializador.Deserialize(stream) as Usuario;
Console.WriteLine($" Nome:{usuario.Nome}\n CPF:{usuario.CPF}\n Email:{usuario.Email}");
Console.ReadKey();
    
