using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, string, string> func = Append;
            string fullName = func("Michael", "Jackson");
            Console.WriteLine(fullName);

            Action<string, string> action_func = AppendPrint;
            action_func("Michael", "Jackson");

            Console.ReadLine();
        }
        static string Append(string firstName, string lastName)
        {
            return firstName +" "+ lastName;
        }

        static void AppendPrint(string firstName, string lastName)
        {
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);
        }
    }
}
