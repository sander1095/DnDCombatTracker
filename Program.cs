using CombatTracker.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CombatTracker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //Create/Check save data
            var x = DataSaver.Instance;


            var o = DataSaver.Instance.ReadFromJsonFile();

            //Test some stuff
            var condition_list_1 = new List<Conditions>() { Conditions.Blinded, Conditions.Deafened, Conditions.Grappled };
            var condition_list_2 = new List<Conditions>() { Conditions.Incapacitated };
            var condition_list_3 = new List<Conditions>() { Conditions.Stunned };
            var condition_list_4 = new List<Conditions>() { Conditions.Prone };
            var condition_list_5 = new List<Conditions>() { Conditions.Unconscious };
            var condition_list_6 = new List<Conditions>();

            Character character_1_1 = new Character("Flyrion", 15, 0, 0, condition_list_1, 52, 22, null);
            Character character_1_2 = new Character("Yuri", 18, 1, 1, condition_list_5, 48, 0, null);
            Character character_1_3 = new Character("Xerxes", 8, 0, 0, condition_list_6, null, null, null);
            Character character_1_4 = new Character("Lea", 20, 0, 0, condition_list_3, 77, 77, 15);

            Character character_2_1 = new Character("Kollis", 14, 0, 0, condition_list_2, 38, 1, null);
            Character character_2_2 = new Character("Torrin", 3, 2, 0, condition_list_5, null, null, null);
            Character character_2_3 = new Character("Tasha", 17, 0, 0, condition_list_4, 47, 43, 4);

            Character character_3_1 = new Character("Mardik", 18, 0, 2, condition_list_6, 20, 20, null);
            Character character_3_2 = new Character("Treak", 11, 0, 0, condition_list_3, 33, 30, 0);

            Category category_1 = new Category("Aryeh", new List<Character>() { character_1_1, character_1_2, character_1_3, character_1_4 });
            Category category_2 = new Category("Robin", new List<Character>() { character_2_1, character_2_2, character_2_3 });
            Category category_3 = new Category("YourHosting", new List<Character>() { character_3_1, character_3_2 });
            Category category_4 = new Category("Empty", new List<Character>());


            var listOfCategories = new List<Category>() { category_1, category_2, category_3, category_4 };

            DataSaver.Instance.WriteToJsonFile(listOfCategories);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new OverviewForm());


        }
    }
}
