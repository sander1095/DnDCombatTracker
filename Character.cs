using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitiativeTracker
{
    public class Character : IComparable<Character>
    {
        public string Name { get; set; }

        public int Initiative { get; set; }

        public int MaxHP { get; set; }

        public int HP { get; set; }

        public int TempHP { get; set; }

        public int DeathSaves_Fail { get; set; }

        public int DeathSaves_Success { get; set; }

        public Character(string name, int dex, int maxHP, int HP, int tempHP, int fail, int success)
        {
            Name = name;
            Initiative = dex;
            MaxHP = maxHP;
            this.HP = HP;
            TempHP = tempHP;
            DeathSaves_Fail = fail;
            DeathSaves_Success = success;

        }

        public Character()
        {

        }

        public override string ToString()
        {
            return $"({Initiative})\t{Name}\tHP:{HP}\tTemp HP:{TempHP}";
        }

        public int CompareTo(Character other)
        {
            return this.Initiative < other.Initiative ? -1 : (this.Initiative == other.Initiative) ? 0 : 1;
        }
    }
}
