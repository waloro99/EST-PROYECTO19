using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace EST19PROYECTO
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static string RecibirParametros(string completo)
        {
            string dpi = "";
            string []nuevo_envio = { ",",","}; //mediador de separadores
            //dpi
            //valido o no el voto
            int count = 2; //cantidad de parametros que nos van a pasar
            String[] listParametros = completo.Split(nuevo_envio, count, StringSplitOptions.RemoveEmptyEntries);
            //foreach (String s in listParametros)
            //{
            //    Console.WriteLine(s); //obtiene valor de cada split
            //}
            //segundo parametro verificar 
            if (listParametros[1] == "no")
            {
                dpi = "no";
            }
            else
            {
                dpi = listParametros[0];
            }
            return dpi;
        }

        public static void Completo(string dpi, string verificado)
        {
            if(verificado == "si")
            {
                Console.WriteLine ("1");
            }
            else
            {

            }

        }


        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
