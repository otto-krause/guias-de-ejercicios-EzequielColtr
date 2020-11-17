using System;
using System.Text.Json;
using System.IO;
using System.Collections.Generic;

namespace Ejercicio
{
    class Program
    {
        static void Main(string[] args  )
        {
            
            StreamReader json;
            List<int> posicion = new List<int>() {0,0};
            int resultado = 0;

            Console.WriteLine("Ingrese la latitud y longitud");
            posicion[0] = Int32.Parse(Console.ReadLine());
            posicion[1] = Int32.Parse(Console.ReadLine());


            json = File.OpenText("locales2.json");

            string linea = json.ReadToEnd();
            json.Close();

        
            using var doc = JsonDocument.Parse(linea);

            JsonElement root = doc.RootElement;

            var users = root.EnumerateArray(); 

            while (users.MoveNext())
            {
                var user = users.Current;
                //System.Console.WriteLine(user);

                var asd = user.GetProperty("coordenadas").GetProperty("latitud");

                Console.WriteLine(asd + 1);

                /* var jsona = JsonSerializer.Serialize(user.GetProperty("coordenadas").GetProperty("latitud"));
                jsona = jsona.Replace("{\"latitud\":","");
                jsona = jsona.Replace("\"longitud\":","");
                jsona = jsona.Replace("}","");

                resultado = Int32.TryParse()
                Console.WriteLine(resultado);
                Console.WriteLine(resultado + 1); */
            }
        }
    }

}
