using System;
using System.IO;
using System.Xml.Serialization;

namespace Octoslots
{
    [Serializable]
    public class Configuration
    {
        public String lastIp;

        private static XmlSerializer serializer = new XmlSerializer(typeof(Configuration));
        public static Configuration currentConfig;
    
        public static void Load()
        {
            if (!File.Exists("Configuration.xml"))
            {
                currentConfig = new Configuration();
                currentConfig.lastIp = "";

                Save();
            }
            else
            {
                using (FileStream stream = File.OpenRead("Configuration.xml"))
                {
                    currentConfig = (Configuration)serializer.Deserialize(stream);
                }
            }
        }

        public static void Save()
        {
            File.Delete("Configuration.xml");
            using (FileStream writer = File.OpenWrite("Configuration.xml"))
            {
                serializer.Serialize(writer, currentConfig);
            }
        }

    }
}
