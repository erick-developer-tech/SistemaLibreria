using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace SistemaLibreria.Utilidades
{
    public class Encriptacion
    {
        public Encriptacion() { }

        // Método que convierte un texto plano en hash, especial para contraseñas
        public static byte[] CalcularHash(string texto) 
        {
            using (SHA256 sha256 = SHA256.Create()) 
            {
                return sha256.ComputeHash(Encoding.UTF8.GetBytes(texto));
            }
        }

        // Método que compara hashes ideal para el login
        public static bool EsIgualHash(byte[] hash, string texto)
        {
            // COnvierte en hash la contraseña ingresada
            SHA256 sha256 = SHA256.Create();
            byte[] nuevoHash = sha256.ComputeHash(Encoding.UTF8.GetBytes(texto));

            // Retorna si la contraseña ingresada es igual a la almacenada en la base de datos
            return CryptographicOperations.FixedTimeEquals(hash, nuevoHash);
        }
    }
}
