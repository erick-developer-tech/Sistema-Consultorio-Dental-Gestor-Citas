using Microsoft.Extensions.Configuration;
using System.Configuration;
using System.IO;
using Microsoft.Extensions.Configuration.Json;

namespace Presentacion
{
    internal static class Program
    {
        public static string _cadenaConexion { get; private set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // 1. Construir la configuración desde appsettings.json
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()) // Requiere Microsoft.Extensions.Configuration.Json
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfiguration config = builder.Build();

            // 2. Leer la cadena de conexión
            _cadenaConexion = config.GetConnectionString("SqlDentalConexion")
                ?? throw new InvalidOperationException("No se encontró la cadena de conexión 'SqlDentalConexion'.");

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}