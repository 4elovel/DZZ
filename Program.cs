using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write words with how many letters do you want to print:");
            int size = Convert.ToInt32(Console.ReadLine());

            List<string> list =new List<string>()
            {
                "Hi",
                "Hello",
                "How",
                "are",
                "you",
                "?",
                " ",
                "I",
                "can",
                "say",
                "that",
                "you",
                "are",
                "so",
                "pretty",
                "and",
                "handsome",
                ".",
                " ",
                "Do",
                "You",
                "want",
                "to",
                "dance",
                "with",
                "me",
                ",",
                "please",
                "?"
            };
            var linq = from i in list
                       where i.Length == size
                       orderby list
                       select i;
            Console.WriteLine($"Words with {size} letters:");
            foreach ( var i in linq ) { Console.WriteLine(i); }
            Console.ReadKey();
        }
    }
}
