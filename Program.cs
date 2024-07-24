using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MeetAlien();
        }
       static void MeetAlien()
        {
            Random numGen= new Random();
            string name = "z-" + numGen.Next(10, 1000);
            int age=numGen.Next(10, 500);
            Console.WriteLine("Hi, I'm "+ name);
            Console.WriteLine("i'm "+ age+ " Years Old !");
            Console.WriteLine("and I'm an alien..<>");
        }
    }
}
