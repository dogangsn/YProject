using Helpers.Enums;
using System; 
using System.Web; 
namespace Helpers.Settings
{

    public static class Functions
    { 

        public static string Enigma(string value, PasswordType process)
        {
            if (value == null)
                return "";
            string v = "";
            foreach (char s in value)
            {
                int charKod = (int)s;
                if (process == PasswordType.Encrypt)
                {
                    if (s == 'ü') v += '¼';
                    else if (s == 'Ü') v += '½';
                    else v += charKod % 2 == 0 ? Convert.ToChar(charKod + 1) : Convert.ToChar(charKod - 1);
                }
                else
                    if (s == '¼') v += 'ü';
                else if (s == '½') v += 'Ü';
                else v += charKod % 2 == 0 ? Convert.ToChar(charKod + 1) : Convert.ToChar(charKod - 1);
            }
            return v;
        }
    }
}
