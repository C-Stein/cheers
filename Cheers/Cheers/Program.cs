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
            System.Console.WriteLine("When is your birthday? (mm/dd)");
            String inputBirthday = System.Console.ReadLine();
            System.Console.WriteLine("Hi, " + name);
            foreach (char letter in name.ToLower())
            {
                if (Char.IsLetter(letter))
                {
                    string a = "a";
                    bool isVowel = "aefhilmnorsx".IndexOf(letter) >= 0;
                    if (isVowel)
                    {
                        a = "an";
                    }
                    System.Console.WriteLine("Give me " + a + "... " + letter);
                }
            }
            name = name.ToUpper();
            System.Console.WriteLine(name + " is just GRAND!");
            DateTime birthday = DateTime.Parse(inputBirthday);
            DateTime today = DateTime.Today;
            DateTime next = new DateTime(today.Year, birthday.Month, birthday.Day);
            if (next < today)
            {
                next = next.AddYears(1);
            }
            int numDays = (next - today).Days;
            if (numDays == 0)
            {
                System.Console.WriteLine("Happy Birthday!!");
            }
            else
            {
                System.Console.WriteLine("It is " + numDays + " days until your birthday!");
            }
            System.Console.WriteLine("Presss any key to exit");
            System.Console.ReadKey();
        }
    }
}
