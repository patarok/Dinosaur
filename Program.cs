using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinoNums;

namespace Klasse
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var myTrex = new Dinosaur("T-Rex", 400, 8000, 30, 12, TrophicGuilds.Carnivore, Locomotion.Biped);


            Console.ReadKey();
        }
    }
}
