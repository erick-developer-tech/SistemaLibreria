using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Data
{
    public class ConexionHelper
    {
        public static IConfiguration ObtenerConfiguracion()
        {
            return new ConfigurationBuilder()
        .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
        .AddJsonFile("Data/Connection.json", optional: false, reloadOnChange: true)
        .Build();
        }
    }
}
