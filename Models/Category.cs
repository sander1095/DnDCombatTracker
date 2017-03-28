using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatTracker.Models
{
    /// <summary>
    /// For saving categories of characters
    /// </summary>
    public class Category
    {
        public string Name { get; set; }

        public List<Character> Characters { get; set; }

        public Category()
        {

        }

        public Category(string name, List<Character> characters)
        {
            Name = name;
            Characters = characters;
        }
    }
}
