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
            int result = new AddThem().Add(3, 5);
            Console.WriteLine(string.Format("Result is {0}", result.ToString()));
            Console.ReadLine();
        }
    }
}
