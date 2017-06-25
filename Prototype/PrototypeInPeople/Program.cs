using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeInPeople
{
    class Program
    {
        static void Main(string[] args)
        {
            Prototype prototype = new Prototype();
            prototype.Class = "Biological system";
            prototype.State = string.Empty;
            Console.WriteLine(prototype.Class + " " + prototype.State);
            Console.WriteLine(new string('-',50));

            //------------------------------------

            Prototype human = prototype.Clone() as Prototype;
            human.Class = "human";
            human.State += " Common signs of a person";
            Console.WriteLine(human.Class + " " + human.State);
            Console.WriteLine(new string('-', 50));

            //-------------------------------------

            Prototype man = human.Clone() as Prototype;
            man.Class = "Man";
            man.State += " Signs of men";
            Console.WriteLine(man.Class+" "+man.State);
            Console.WriteLine(new string('-', 50));

            //--------------------------------------------

            Prototype woman = human.Clone() as Prototype;
            woman.Class = "Woman";
            woman.State += " Signs of woman";
            Console.WriteLine(woman.Class + " " + woman.State);



            Console.WriteLine(new string('-', 50));
            //another variant

            var adam = human.Clone();
            adam.State = "Adam";
            Console.WriteLine(adam.State+" "+ adam.Class);
            var eva = adam.Clone();
            eva.State = "Eva";
            Console.WriteLine(eva.State+" "+ eva.Class);

        }
    }
}
