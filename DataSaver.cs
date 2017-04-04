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
                    File.Create(FILE_PATH);
                }
                catch (Exception)
                {
                    //TODO: Handle Exception (Maybe tell the user that things cannot be saved and thus saving data will be disabled for the user (To implement later)
                }
            }
        }


        /// <summary>
        /// Writes the given object instance to a Json file.
        /// </summary>
        /// <typeparam name="T">The type of object being written to the file.</typeparam>
        /// <param name="filePath">The file path to write the object instance to.</param>
        /// <param name="objectToWrite">The object instance to write to the file.</param>
        /// <param name="append">If false the file will be overwritten if it already exists. If true the contents will be appended to the file.</param>
        /// <returns>True if writing succeeded, false otherwise</returns>
        public bool WriteToJsonFile(List<Category> objectToWrite, bool append = false)
        {
            TextWriter writer = null;
            try
            {
                string contentsToWriteToFile = JsonConvert.SerializeObject(objectToWrite);
                writer = new StreamWriter(FILE_PATH, append);
                writer.Write(contentsToWriteToFile);
            }
            catch (Exception ex) //TODO: Implement better exception handling
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
        /// Reads an object instance from an Json file.
        /// </summary>
        /// <para>Object type must have a parameterless constructor.</para>
        /// <typeparam name="T">The type of object to read from the file.</typeparam>
        /// <param name="filePath">The file path to read the object instance from.</param>
        /// <returns>Returns a new instance of the object read from the Json file.</returns>
        public List<Category> ReadFromJsonFile()
        {
            TextReader reader = null;
            try
            {
                reader = new StreamReader(FILE_PATH);
                var fileContents = reader.ReadToEnd();
                var deserialized = JsonConvert.DeserializeObject<List<Category>>(fileContents);
                return deserialized; //TODO: Error handling! if file is wrong, tell user file is corrupt.
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }
    }
}
