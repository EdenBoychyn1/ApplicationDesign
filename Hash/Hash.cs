using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDesign.Hash
{
    abstract class Hash
    {
        public static string PasswordHash(string employee_password)
        {
            using (SHA1Managed SHA1 = new SHA1Managed())
            {
                byte[] hash = SHA1.ComputeHash(Encoding.UTF8.GetBytes(employee_password));
                StringBuilder hashedPassword = new StringBuilder(hash.Length);

                foreach (byte bit in hash)
                {
                    hashedPassword.Append(bit.ToString("X2"));
                }

                return hashedPassword.ToString();
            }
        }
    }
}
