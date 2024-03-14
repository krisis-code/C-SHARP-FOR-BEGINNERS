using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Kris!");

            string firstFriend = "            Gabrial           ";
            //Sondaki boşlukları siler
            firstFriend = firstFriend.TrimEnd();
            string secondFriend = "Natalia";

            String lastFriend = "      Andrea      ";
            //TrimStart Sondaki boşlukları siler
            //Trim ise tüm boşlukları siler
            Console.WriteLine($"My friends are {firstFriend.TrimStart()},{secondFriend.Trim()} and {lastFriend.Trim()}");
            Console.ReadKey();
        }
    }
}
