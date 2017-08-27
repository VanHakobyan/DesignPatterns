using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            var armeniabFlag = new ArmenianFlag();
            armeniabFlag.Draw();
            var spainFlag = new SpainFlag();
            spainFlag.Draw();
        }
    }
}
