using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIStatsTool.Models
{
    internal abstract class AttrBonus
    {
        protected readonly double _value;
        protected AttrBonus(double value)
        {
            _value = value;
        }
        
        public abstract void OnAdded(Character character);
    }

    internal class AtkBonus : AttrBonus
    {
        public AtkBonus(double value) : base(value) { }

        public override void OnAdded(Character character)
        {
            character.AddAtkBonus(_value);
        }
    }

    internal class HpBonus : AttrBonus
    {
        public HpBonus(double value) : base(value) { }

        public override void OnAdded(Character character)
        {
            character.AddHpBonus(_value);
        }
    }

    internal class DefBonus : AttrBonus
    {
        public DefBonus(double value) : base(value) { }

        public override void OnAdded(Character character)
        {
            character.AddDefBonus(_value);
        }
    }
}
