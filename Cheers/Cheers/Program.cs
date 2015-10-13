using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheers
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello There! What's your name?");
            string name = System.Console.ReadLine();
            System.Console.WriteLine("Hi, " + name);
            name = name.ToLower();
            foreach (char letter in name)
            {
                string a = "a";
                bool isVowel = "aefhilmnorsx".IndexOf(letter) >= 0;
                if (isVowel)
                {
                    a = "an";
                }
                System.Console.WriteLine("Give me " + a + " " + letter);
            }
            name = name.ToUpper();
            System.Console.WriteLine(name + " is just GRAND!");
            System.Console.WriteLine("Presss any key to exit");
            System.Console.ReadKey();
        }
    }
}
