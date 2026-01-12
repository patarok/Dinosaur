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
            // Collections

            List<Dinosaur> jurassicPark = new List<Dinosaur>();


            jurassicPark.Add(new Dinosaur("T-Rex", 400, 8000, 30, 12, TrophicGuilds.Carnivore, Locomotion.Biped));
            jurassicPark.Add(new Dinosaur("Allosaurus", 500, 9000, 25, 10, TrophicGuilds.Carnivore, Locomotion.Biped));
            jurassicPark.Add(new Dinosaur("Triceratops", 300, 6000, 25, 15, TrophicGuilds.Herbivore, Locomotion.Quadruped));
            jurassicPark.Add(new Dinosaur("Velociraptor", 80, 15, 15, 8, TrophicGuilds.Carnivore, Locomotion.Biped));
            jurassicPark.Add(new Dinosaur("Brachiosaurus", 600, 50000, 40, 10, TrophicGuilds.Herbivore, Locomotion.Quadruped));
            jurassicPark.Add(new Dinosaur("Pteranodon", 100, 25, 20, 2, TrophicGuilds.Carnivore, Locomotion.Volant));

            Console.WriteLine("adding all Dinosaurs from a list to a dictionary in a foreach loop");

            var jurassicDictionary = new Dictionary<string, Dinosaur>();
            foreach(Dinosaur dinoItem in jurassicPark)
            {
                jurassicDictionary[dinoItem.SpeciesName] = dinoItem;
            }

            var carnivoresList = new List<Dinosaur>();
            foreach(Dinosaur dinoItem in jurassicPark)
            {
                if (dinoItem.Guild == TrophicGuilds.Carnivore)
                    carnivoresList.Add(dinoItem);
            }

            var carnivoresLINQList = jurassicDictionary.Where(d => d.Value.Guild == TrophicGuilds.Carnivore).ToList();

            // UMSTÄNDLICH mit foreach -- MAP
            List<string> namesOld = new List<string>();
            foreach (var dino in jurassicPark)
            {
                namesOld.Add(dino.SpeciesName.ToUpper());
            }
            Console.WriteLine("Vorher (foreach): " + string.Join(", ", namesOld));

            var names = jurassicPark.Select(d => d.SpeciesName.ToUpper()).ToList();

            // UMSTÄNDLICH mit foreach -- REDUCE
            int totalWeightOld = 0;
            foreach (var dino in jurassicPark)
            {
                totalWeightOld += dino.WeightKg;
            }
            Console.WriteLine($"Vorher (foreach): {totalWeightOld}kg");

            var totalWeight = jurassicPark.Sum(d => d.WeightKg);


            Console.WriteLine("\n\nHello from your LINQ aggregate function: {0}", totalWeight);

            var filteredList = jurassicPark.Where(d => d.WeightKg > 5000).Where(d => d.Guild == TrophicGuilds.Carnivore);

            foreach (Dinosaur d in filteredList) {
                Console.WriteLine(d.SpeciesName);
            }

            var firstHit = jurassicPark.Where(d => d.WeightKg > 5000).Where(d => d.Guild == TrophicGuilds.Carnivore).LastOrDefault();

            Console.WriteLine("\n\nErster Treffer: {0}", firstHit.SpeciesName);

            Console.ReadKey();
        }
    }
}
