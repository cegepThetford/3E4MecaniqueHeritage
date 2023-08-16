using MecaniqueHeritage_Affaires;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MecaniqueHeritage_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Premier premier = new Premier(10);
            Console.WriteLine("Premier.calculer(): {0}", premier.calculer());

            Second second = new Second(5, 20);
            Console.WriteLine("Second.calculer(): {0}", second.calculer());

            Troisieme troisieme = new Troisieme(3);
            Console.WriteLine("Troisieme.calculer(): {0}", troisieme.calculer());

            Console.ReadLine();
        }
    }
}
