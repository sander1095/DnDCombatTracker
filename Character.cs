using System;
using System.Collections.Generic;

namespace CombatTracker
{

    public enum Conditions
    {
        Blinded,
        Charmed,
        Deafened,
        Frightened,
        Grappled,
        Incapacitated,
        Invisible,
        Paralyzed,
        Petrified,
        Poisoned,
        Prone,
        Restrained,
        Stunned,
        Unconscious
    }

    public class Character : IComparable<Character>
    {
        public string Name { get; set; }

        public short Initiative { get; set; }

        public short? MaxHP { get; set; }

        public short? HP { get; set; }

        public short? TempHP { get; set; }

        public short DeathSaves_Fail { get; set; }

        public short DeathSaves_Success { get; set; }

        public List<Conditions> Conditions { get; set; }

        public Character(string name, short initiative, short? maxHP, short? HP, short? tempHP, short fail, short success, List<Conditions> conditions)
        {
            Name = name;
            Initiative = initiative;
            MaxHP = maxHP;
            this.HP = HP;
            TempHP = tempHP;
            DeathSaves_Fail = fail;
            DeathSaves_Success = success;
            Conditions = conditions;
        }

        public override string ToString()
        {
            //Determine if the HP part should be shown or not:
            if (HP.HasValue)
            {
                return $"({Initiative})\t{Name}\tHP:{HP}";
            }
            return $"({Initiative})\t{Name}";
        }

        public int CompareTo(Character other)
        {
            return this.Initiative < other.Initiative ? -1 : (this.Initiative == other.Initiative) ? 0 : 1;
        }
    }
}
