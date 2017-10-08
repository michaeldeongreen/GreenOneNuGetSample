using System;
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

            Console.ReadLine();
        }
    }
}
