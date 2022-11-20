using System;
using System.IO;

namespace SistemaCore
{
    public static class ManejadorArchivo
    {
        static string ruta;
        static ManejadorArchivo()
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);//Conseguir la ruta desde cualquier PC
            ruta += @"/Archivos"; //Indicamos la carpeta
        }

        public static bool Escribir(string mensaje, string nombreArchivo)
        {
            string rutaCompleta = ruta + @$"/{nombreArchivo}" + ".txt";
            try
            {
                if (!Directory.Exists(ruta))//Esto significa que la carpeta NO EXISTE
                {
                    Directory.CreateDirectory(ruta); //Aca la creamos
                }
                using (StreamWriter sw = new StreamWriter(rutaCompleta,true))//Si se le agrega un segundo parametro (true), si el archivo existe se le va a appendar
                {
                    sw.WriteLine(mensaje);
                }
                return true;
            }
            catch (Exception)
            {
                throw new Exception($"Error en el archivo {rutaCompleta}");
            }
        }

    }
}
