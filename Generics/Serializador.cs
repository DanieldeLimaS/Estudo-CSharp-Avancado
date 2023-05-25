using Serealizar_Deserializar;
using System.Text.Json;

namespace Generics
{
    internal class  Serializador
    {
        public static void Serializar(Object obj)
        {
            StreamWriter sw = new StreamWriter(AttributesStrings.CaminhoPadrao + @$"Generics{obj.GetType().Name}.txt");


            var objSerializado = JsonSerializer.Serialize(obj, new JsonSerializerOptions
            {
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                WriteIndented = true
            });
            sw.WriteLine(objSerializado);
            sw.Close();
            sw.Dispose();
        }
        public static T Deserializar<T>()
        {
            StreamReader stream = new StreamReader(AttributesStrings.CaminhoPadrao + @$"Generics{typeof(T).Name}.txt");
            var conteudo = stream.ReadToEnd();

            T obj = (T)JsonSerializer.Deserialize(conteudo, typeof(T));
            return obj;
        }
    }
}
