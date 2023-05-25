using Serealizar_Deserializar.JSON;
using Serealizar_Deserializar.XML;

Console.WriteLine("Serializando objeto Usuario.");
//GlobalSerealizarXML serealizarXML = new GlobalSerealizarXML();
//serealizarXML.Serealizar();

GlobalSerializarJSON serealizarJSON = new GlobalSerializarJSON();
serealizarJSON.Serealizar();
Console.WriteLine("Usuario Serializado");
Console.ReadKey();
Console.Clear();

Console.WriteLine("Deserializando objeto Usuario.");
//serealizarXML.Deserealizar();
serealizarJSON.Deserealizar();
Console.ReadKey();
