using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Presentacion.Utilidades
{
    public class UHash
    {
        public byte[] GenerarHash(string password) 
        {
            SHA256 sha = SHA256.Create();
            return sha.ComputeHash(Encoding.UTF8.GetBytes(password));
        }

        public bool CompararHash(string passwordIngresado, byte[] passwordAlmacenado)
        {
            SHA256 sha = SHA256.Create();
            byte[] nuevoHash = sha.ComputeHash(Encoding.UTF8.GetBytes(passwordIngresado));

            // Retorna un true si ambos hashes con integros
            return CryptographicOperations.FixedTimeEquals(nuevoHash, passwordAlmacenado);
        }
    }
}
