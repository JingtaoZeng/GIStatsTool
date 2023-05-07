using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIStatsTool.Models
{
    internal class Character
    {
        public string Name { get; }

        private double _baseAtk;
        private double _baseHp;
        private double _baseDef;

        private double _flatAtk;
        private double _flatHp;
        private double _flatDef = 0.0;

        private double _percentAtk = 1.0;
        private double _percentHp = 1.0;
        private double _percentDef = 1.0;

        public double Atk => _flatAtk + _baseAtk * _percentAtk;
        public double Hp => _flatHp + _baseHp * _percentHp;
        public double Def => _flatDef + _baseDef * _percentDef;

        public Character(string name)
        {
            Name = name;
            _loadKnownStats(name);
        }

        private void _loadKnownStats(string name)
        {
            // TODO: 加载已知角色的基础数据
            _baseAtk = 250.0;
            _baseHp = 11680.0;
            _baseDef = 750.0;
        }

        public Character Equip(Weapon weapon)
        {
            _baseAtk += weapon.BaseAtk;
            weapon.SubStat.OnAdded(this);
            // TODO: 添加武器特效等
            return this;
        }

        public Character AddAtkBonus(double atkBonus)
        {
            _percentAtk += atkBonus;
            return this;
        }

        public Character AddHpBonus(double hpBonus)
        {
            _percentHp += hpBonus;
            return this;
        }

        public Character AddDefBonus(double defBonus)
        {
            _percentDef += defBonus;
            return this;
        }
    }
}
