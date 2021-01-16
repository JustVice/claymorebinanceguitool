using System.Text.Json;
using System.IO;
using System;

namespace ClaymoreUITool.Logic
{
    public class JSONHandler
    {
        private string configFileName = "config.json";

        public void saveUserConfig(UserConfig userConfig)
        {
            string jsonString = JsonSerializer.Serialize(userConfig);
            File.WriteAllText(configFileName, jsonString);
        }

        public UserConfig readUserConfig()
        {
            string jsonString = File.ReadAllText(configFileName);
            return JsonSerializer.Deserialize<UserConfig>(jsonString);
        }
    }
}
