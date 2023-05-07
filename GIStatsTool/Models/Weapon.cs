using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIStatsTool.Models
{
    internal class Weapon
    {
        public string Name { get; }

        public Weapon(string name)
        {
            Name = name;
        }

        public double BaseAtk { get; init; }

        public AttrBonus SubStat { get; init; }
    }
}
