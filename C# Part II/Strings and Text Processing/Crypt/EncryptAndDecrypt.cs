/*Write a program that encodes and decodes a string using given encryption key (cipher). 
 *The key consists of a sequence of characters. The encoding/decoding is done by performing XOR (exclusive or)
 *operation over the first letter of the string with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypt
{
    class EncryptAndDecrypt
    {
        static void Main()
        {
        Console.Write("Enter a text: ");
        string text = Console.ReadLine();
        Console.Write("Enter a key: ");
        string key = Console.ReadLine();

        if (key.Length < text.Length)//I want to make the length of the key same to the text length or bigger
        {
            while (key.Length < text.Length)
            {
                key += key;
            }
        }

        string encryptedText = EncryptingTheString(text, key);
        string decryptedText = EncryptingTheString(encryptedText, key);

        Console.WriteLine("The encrypted text is: {0}", encryptedText);
        Console.WriteLine("The decrypted text is: {0}", decryptedText);
    }

    private static string EncryptingTheString(string text, string key)
    {
        StringBuilder encryptedString = new StringBuilder();

        for (int i = 0; i < text.Length; i++)
        {
            encryptedString.Append((char)(text[i] ^ key[i]));
        }
        return encryptedString.ToString();
    }
        
    }
}
