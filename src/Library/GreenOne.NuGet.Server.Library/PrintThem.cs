using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenOne.NuGet.Server.Library
{
    public class PrintThem
    {
        public string Print(int x, int y)
        {
            return string.Format("X is: {0}.  Y is: {1}",x,y);
        }
    }
}
