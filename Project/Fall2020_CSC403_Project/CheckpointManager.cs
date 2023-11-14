using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Fall2020_CSC403_Project.code;
using static Fall2020_CSC403_Project.code.InventorySystem;
using System.Collections;

namespace Fall2020_CSC403_Project
{
    public class CheckpointManager
    {
        private static string checkpointFileName = @"../../data/checkpoint.json";
        private static string InventoryFileName = @"../../data/inventory.json";

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

        public static void SaveInventory(){
            Dictionary<String, int> inventory = new Dictionary<String, int>();

            foreach (var record in MyApplicationContext.inventory.InventoryRecords)
            {
                inventory.Add(record.InventoryItem.Name, record.Quantity);
            }

            string jsonData = JsonConvert.SerializeObject(inventory, Formatting.Indented);
            File.WriteAllText(InventoryFileName, jsonData);
        }

        public static void LoadInventory() 
        {
            Dictionary<string, int> inventory = new Dictionary<string, int>();
            if (File.Exists(InventoryFileName))
            {
                string jsonData = File.ReadAllText(InventoryFileName);

                //convert jsonData to Dictionary
                inventory = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, int>>(jsonData);
            }

            foreach (var kvp in inventory)
            {
                // Assuming ObtainableItem has a constructor that takes a name (string) and a maximum stackable quantity (int)
                if (kvp.Key == "Health Potion")
                {
                    MyApplicationContext.inventory.AddItem(MyApplicationContext.potion, kvp.Value);
                }
                
            }
        }
    }
}
