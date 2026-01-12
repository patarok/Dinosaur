using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinoNums;

namespace Klasse
{
    internal class Dinosaur
    {
        private static int DinoCount;

        private string speciesName;

        public string SpeciesName
        {
            get { 
                if(speciesName.Length > 0)
                    return speciesName;
                return "";  
            }
            set { speciesName = value; }
        }


        private int shoulderHeightCm;
        private int weightKg;
        private int maxAge;
        private int clutchSize;




        public TrophicGuilds Guild;
        public Locomotion LocomotionProfile;

        public Dinosaur(string speciesName, int shoulderHeightCm, int weightKg, int maxAge, int clutchSize, TrophicGuilds guild, Locomotion locomotionProfile)
        {
            DinoCount++;
            this.speciesName = speciesName;
            this.shoulderHeightCm = shoulderHeightCm;
            this.weightKg = weightKg;
            this.maxAge = maxAge;
            this.clutchSize = clutchSize;
            Guild = guild;
            LocomotionProfile = locomotionProfile;
            SpeciesName = "derTutorIstSchonEinWenigQuazy";
        }

        ~Dinosaur() {
            DinoCount--;
        }



        public void Eat()
        {
            Console.WriteLine($"I am a {speciesName} dinosaur and I belong to the trophic profile '{Guild}',\nand you may also want to know that I am a {LocomotionProfile}");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"---Dinosaur Info---");
            Console.WriteLine($"Species: {speciesName}");
            Console.WriteLine($"Locomotion: {LocomotionProfile}");
            Console.WriteLine($"Dietary Guild: {Guild}");
            Console.WriteLine($"Max Age: {maxAge} years.");
            Console.WriteLine($"Clutch Size: {clutchSize}");
            Console.WriteLine($"--------------------");
        }
    }
}
