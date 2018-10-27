using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWorld
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(CreateMessage());
        }

        public static string CreateMessage()
        {
            string name = "Hello Abhishek";
            return name;
        }
    }
}