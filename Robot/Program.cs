using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{

    class Program
    {
        static void Main(string[] args)
        {
            Monster ganon = new Monster("Ganon",0,25,30,true);
            Monster dodongo = new Monster("Dodongo", 1, 10, 20, true);
            Monster dragon = new Monster("Dragon", 1, 10, 10, true);
            Fight fight = new Fight();
           
            ganon.Print();
            dodongo.Print();
            dragon.Print();

            fight.addAttack(ganon);
            fight.addAttack(dodongo);
            Console.WriteLine("Dan said I made lemmings");
        }
    }
}
