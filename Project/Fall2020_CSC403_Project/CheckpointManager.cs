using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Fall2020_CSC403_Project
{
    public class CheckpointManager
    {
        private static string checkpointFileName = @"../../data/checkpoint.json";

        public static void SaveLevelCompletion(string level)
        {
            Dictionary<string, bool> existingData = LoadLevelCompletion();
            existingData[level] = true;
            
            // Convert the dictionary to a string format (JSON)
            string jsonData = JsonConvert.SerializeObject(existingData, Formatting.Indented);

            File.WriteAllText(checkpointFileName, jsonData);
        }

        public static Dictionary<string, bool> LoadLevelCompletion()
        {
            if (File.Exists(checkpointFileName))
            {
                string jsonData = File.ReadAllText(checkpointFileName);

                //convert jsonData to Dictionary
                return Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, bool>>(jsonData);
            }
            return new Dictionary<string, bool>(); // Default value if the file doesn't exist.
        }
    }
}
