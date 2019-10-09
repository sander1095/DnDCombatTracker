using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DnDCombatTracker.Core
{
    public class CombatManagerService
    {
        public int RoundCount { get; set; }

        public List<Character> Combatants { get; set; } = new List<Character>();

        public Character CurrentCharacter { get; set; }

        public Character NextCharacter
        {
            get
            {
                if (CurrentCharacter == null)
                {
                    return null;
                }

                var currentindex = Combatants.IndexOf(CurrentCharacter);

                if (currentindex + 1 == Combatants.Count || currentindex == -1)
                {
                    return Combatants.First();
                }
                else
                {
                    return Combatants[Combatants.IndexOf(CurrentCharacter) + 1];
                }

                
            }
        }


        public void SortCombatants()
        {
            Combatants = Combatants.OrderByDescending(x => x.Initiative).ToList();
        }

        public void AdvanceTurn()
        {
            if (Combatants.Count < 2)
            {
                return;
            }

            Character currentCharacter = Combatants.Single(x => x.Name == CurrentCharacter.Name);//InitiativeList.SelectedValue as Character;
            int currentIndex = Combatants.IndexOf(currentCharacter);
            int indexToSet = currentIndex + 1 == Combatants.Count ? 0 : currentIndex + 1; //Check if wrap around is needed

            Character newCharacter = Combatants[indexToSet];
            Character newNextCharacter = Combatants[indexToSet + 1 == Combatants.Count ? 0 : indexToSet + 1];

            if (indexToSet + 1 == Combatants.Count)
            {
                RoundCount++;
            }

            CurrentCharacter = newCharacter;
        }

        public void SaveCharacter(Character character)
        {
            if (Combatants.Any(x=>x.Name == character.Name))
            {
                Combatants[Combatants.IndexOf(Combatants.ToList().Single(x => x.Name == character.Name))] = character;
            }
            else
            {
                Combatants.Add(character);
            }

            if (Combatants.Count == 1)
            {
                CurrentCharacter = Combatants.First();
            }

            SortCombatants();
        }

        public void DeleteCharacter(Character character)
        {
            var characterToDelete = Combatants.FirstOrDefault(x => x.Name == character.Name);

            if (characterToDelete == null)
            {
                return;
            }

            var currentCharacterIndex = Combatants.IndexOf(characterToDelete);

            Combatants.Remove(characterToDelete);

            if (Combatants.Count == 0)
            {
                CurrentCharacter = null;
                return;
            }

            int newIndex = Math.Max((Combatants.Count - 1) <= currentCharacterIndex ? currentCharacterIndex - 1 : currentCharacterIndex,0);

            CurrentCharacter =  Combatants[newIndex];

            SortCombatants();
        }
    }
}
