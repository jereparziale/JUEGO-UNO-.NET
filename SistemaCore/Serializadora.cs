using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Reflection.Emit;

namespace SistemaCore
{
    public class Serializadora<T>
    {
        static string ruta;
        static Serializadora()
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);//Conseguir la ruta desde cualquier PC
            ruta += @"/Archivos-Serializacion"; //Crea una carpeta
        }

        public static void EscribirJSON(T datos, string archivo)
        {
            string completa = ruta + @"/" + archivo + ".json";

            if (!Directory.Exists(ruta))//Esto significa que la carpeta NO EXISTE
            {
                Directory.CreateDirectory(ruta); //Aca la creamos
            }
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) },
            };
            options.WriteIndented = true;

            string objetoJson = JsonSerializer.Serialize(datos, options);

            File.WriteAllText(completa, objetoJson);

        }

        public static T LeerJSON(string nombre)
        {
            T datos = default;
            string completa = ruta + @"/" + nombre + ".json";

            if (!Directory.Exists(ruta))//Esto significa que la carpeta NO EXISTE
            {
                Directory.CreateDirectory(ruta); //Aca la creamos
            }

            JsonSerializerOptions options = new JsonSerializerOptions
            {
            Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) },
            };
            options.WriteIndented = true;


            string archivoJson = File.ReadAllText(completa);
            datos = JsonSerializer.Deserialize<T>(archivoJson, options);

            return datos;

        }

        public static void EscribirXML(T datos, string archivo)
        {
            string completa = ruta + @"/" + archivo + ".xml";

            if (!Directory.Exists(ruta))//Esto significa que la carpeta NO EXISTE
            {
                Directory.CreateDirectory(ruta); //Aca la creamos
            }

            using (StreamWriter sw = new StreamWriter(completa))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                xmlSerializer.Serialize(sw, datos);
            }
        }

        public static T LeerXML(string nombre)
        {
            string archivo = string.Empty;
            T datos = default;
            string completa = ruta + @"/" + nombre + ".xml";

            if (Directory.Exists(ruta))//Esto significa que la carpeta NO EXISTE
            {
                /* if (!Directory.Exists(ruta))//Esto significa que la carpeta NO EXISTE
                 {
                     Directory.CreateDirectory(ruta); //Aca la creamos
                 }*/

                using (StreamReader sr = new StreamReader(completa))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                    datos = (T)xmlSerializer.Deserialize(sr);
                }
            }
            return datos;
        }
    }
}
