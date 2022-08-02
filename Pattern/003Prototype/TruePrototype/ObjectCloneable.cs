using System.IO;
using System.Xml.Serialization;
using System.Text.Json;

namespace TruePrototype
{
    public static class ObjectCloneable
    {
        static public Address DeepCloneable(Address obj)
        {
            using (var stream = new MemoryStream())
            {
               
                XmlSerializer xmlFormat = new XmlSerializer(obj.GetType());
                xmlFormat.Serialize(stream, obj);

                stream.Seek(0, SeekOrigin.Begin);
                return (Address)(xmlFormat.Deserialize(stream));
               }             
        }

        static public T DeepCloneable<T>(this T obj) =>
            JsonSerializer.Deserialize<T>(JsonSerializer.Serialize<T>(obj));
    }

     
}