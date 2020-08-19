using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_Cipher
{
    class Program
    {
        static string Encrypt(string originalText, int shift)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
 
            char[] secretMessageArr = originalText.ToLower().ToCharArray();

            //encryptedMessage and have a length equal to the length of secretMessage

            char[] encryptedMessage = new char[secretMessageArr.Length]; 

            for (int i = 0; i < secretMessageArr.Length; i++)
            {
                char letter = secretMessageArr[i];
                if (char.IsLetter(letter))
                {
                    int letterPosition = Array.IndexOf(alphabet, letter);
                    int newLetterPosition = (letterPosition + shift) % 26;
                    char letterEncoded = alphabet[newLetterPosition];
                    encryptedMessage[i] = letterEncoded;
                }
            }

            return new string(encryptedMessage);  
        }
        static string Decrypt(string cipheredText, int shift)
        {
            return Encrypt(cipheredText, shift * (-1));
        }
        static void Main(string[] args)
        {
            string cipher = Encrypt("Cityzen", 3);
            Console.WriteLine("Your encoded message is:{0}",cipher);

            string decipher = Decrypt(cipher, 3);
            Console.WriteLine("Your decoded message is:{0}",decipher);

            Console.ReadKey();
        }
    }
}
