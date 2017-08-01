using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Man_and_Robot
{
    class Program
    {
        static void Main(string[] args)
        {
            var Van = new Man();
            var armRobot = new Robot();

            Van.Clothes = "Short,Sneakers,Jeans";
            armRobot.Backpack = Van.Undress();
            Console.WriteLine(Van.Clothes);
            Van.Clothes = "Sporting short";
            Console.WriteLine(Van.Clothes);
            Van.Dress(armRobot.Backpack);
        }
    }
}
