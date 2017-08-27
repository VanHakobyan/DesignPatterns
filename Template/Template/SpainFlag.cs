using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    class SpainFlag : TreeColorFlag
    {
        protected override void DrawName()
        {
            Type type = typeof(SpainFlag);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("\n"+type.Name+"\n");
        }
        protected override void DrawFirstPart()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(new string('-', 15));
        }

        protected override void DrawSecondPart()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine(new string('-', 15));
        }

        protected override void DrawThirdPart()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(new string('-', 15));
        }
    }
}
