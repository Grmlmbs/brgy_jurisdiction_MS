using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    // This method class will be used to Hash password after registering and using it for login.
    internal class Hashhelper
    {
        public static string Hashstring(string text_to_hash)
        {
            using (SHA1 sha1 = SHA1.Create())
            {
                byte[] hashbytes = sha1.ComputeHash(Encoding.UTF8.GetBytes(text_to_hash));

                StringBuilder sb = new StringBuilder();
                foreach(byte b in hashbytes)
                {
                    sb.Append(b.ToString("x2"));
                }

                return sb.ToString();
            }
        }
    }

    // This method class will be used to create an autofill function to comboboxes (for age).
    internal class age_autofiller
    {
        public static int CalculateAge(DateTime birthdate)
        {
            DateTime currentDate = DateTime.Now;
            int age = currentDate.Year - birthdate.Year;
            if(birthdate > currentDate.AddYears(-age))
            {
                age--;
            }
            return age;
        }
    }
}
