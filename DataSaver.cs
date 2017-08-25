//Retrieved from: http://blog.danskingdom.com/saving-and-loading-a-c-objects-data-to-an-xml-json-or-binary-file/

using CombatTracker.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatTracker
{
    public class DataSaver
    {
        private const string FILE_NAME = "Characters.json";
        private const string FOLDER_NAME = "D&D Combat Tracker";

        private readonly string FOLDER_PATH = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\{FOLDER_NAME}";
        private readonly string FILE_PATH = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\{FOLDER_NAME}\{FILE_NAME}";

        private static DataSaver _instance;

        public static DataSaver Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DataSaver();
                }
                return _instance;
            }
        }

        /// <summary>
        /// Creates
        /// </summary>
        private DataSaver()
        {
            if (!Directory.Exists(FOLDER_PATH))
            {
                try
                {
                    Directory.CreateDirectory(FOLDER_PATH);

                    using (FileStream fs = File.Create(FILE_PATH)) { };
                   
                }
                catch
                {
                    //TODO: Handle Exception (Maybe tell the user that things cannot be saved and thus saving data will be disabled for the user (To implement later)
                }
            }
                if (!File.Exists(FILE_PATH))
                {
                    try
                    {
                        using (FileStream fs = File.Create(FILE_PATH)) { };
                    }
                    catch
                    {
                        //TODO: Handle Exception (Maybe tell the user that things cannot be saved and thus saving data will be disabled for the user (To implement later)
                    }
                }
        }


        public bool SaveCategories(List<Category> objectToWrite)
        {
            TextWriter writer = null;
            try
            {
                string contentsToWriteToFile = JsonConvert.SerializeObject(objectToWrite);

                using (writer = new StreamWriter(FILE_PATH, false))
                {
                    writer.Write(contentsToWriteToFile);
                }
            }
            catch (Exception) //TODO: Implement better exception handling
            {
                return false;
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
            return true;
        }

        /// <summary>
        /// Returns all categories. Returns an empty list when none are found.
        /// </summary>
        /// <returns>Returns all categories. Returns an empty list when none are found.</returns>
        public List<Category> GetCategories()
        {
            TextReader reader = null;
            try
            {
                string fileContents;
                using (reader = new StreamReader(FILE_PATH))
                {
                    fileContents = reader.ReadToEnd();
                }
                var deserialized = JsonConvert.DeserializeObject<List<Category>>(fileContents) ?? new List<Category>();
                return deserialized; //TODO: Error handling! if file is wrong, tell user file is corrupt.
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }

        /// <returns>The category if found. Otherwise null.</returns>
        public Category GetCategory(string name)
        {
            try
            {
                return GetCategories().Single(x => x.Name == name);
            }
            catch(Exception e)
            {
                return null;
            }
        }

        public void AddCategory(Category category)
        {
            var categories = GetCategories();
            categories.Add(category);
            SaveCategories(categories);
        }

        public void EditCategory(Category category)
        {
            var categories = GetCategories();
            categories.Single(x => x.Name == category.Name).Characters = category.Characters;

            SaveCategories(categories);
        }

        //TODO: We are using the name here with a .Single instead of a normal .Remove(category) cuz it cannot find it. Fix this.
        public void DeleteCategory(Category category)
        {
            var categories = GetCategories();

            categories.Remove(categories.Single(x => x.Name == category.Name));
            SaveCategories(categories);
        }
    }
}
