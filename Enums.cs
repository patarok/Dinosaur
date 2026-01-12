using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoNums
{
    public enum TrophicGuilds
    {
        Carnivore,
        Herbivore,
        Ominovore 
    }

    public enum CarnivoreTrophics
    {
        Predators, Necrophage, Piscivore, Insectivore
    }

    public enum OmnivoreTrophics
    {
        Generalist, Entomovore, FrugivorCarnivor
    }

    public enum HerbivoreTrophics
    {
        Graminivore, Folivore, Frugivore, Granivore
    }

    public enum Locomotion
    {
        Biped,
        Quadruped,
        Facultative, // Iguanodon
        Volant
    }
}
