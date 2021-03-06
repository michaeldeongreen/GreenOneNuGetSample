﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenOne.NuGet.Server.Library;

namespace GreenOne.NuGet.Server.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            int addResult = new AddThem().Add(3, 5);
            Console.WriteLine(string.Format("The add them result is {0}", addResult.ToString()));

            int subtractResult = new SubtractThem().Subtract(5, 2);
            Console.WriteLine(string.Format("The subtract them result is {0}", subtractResult.ToString()));

            int multiplyResult = new MultiplyThem().Multiply(5, 2);
            Console.WriteLine(string.Format("The multiply them result is {0}", multiplyResult.ToString()));

            string printResult = new PrintThem().Print(10, 20);
            Console.WriteLine(printResult);

            Console.ReadLine();
        }
    }
}
