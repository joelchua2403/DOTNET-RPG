using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DOTNET_RPG.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Frodo";
        public int HitPoints { get; set; } = 100;

        public int Strength { get; set; } = 10;

        public int Skill { get; set; } = 10;

        public int Agility { get; set; } = 10;

        public RpgClass Class { get; set; } = RpgClass.Scrambler;

    }
}