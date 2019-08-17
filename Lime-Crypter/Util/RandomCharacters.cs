using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lime_Crypter.Util
{
    public class RandomCharacters
    {
        private readonly Random random = new Random();
        const string alphabet = "asdfghjklqwertyuiopmnbvcxz";

        public string getRandomCharacters(int length)
        {
            var sb = new StringBuilder();
            for (int i = 1; i <= length; i++)
            {
                var randomCharacterPosition = random.Next(0, alphabet.Length);
                sb.Append(alphabet[randomCharacterPosition]);
            }
            return sb.ToString();
        }
    }
}
