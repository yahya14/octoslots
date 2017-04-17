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
            if (!File.Exists("OctoslotsConfig.xml"))
            {
                currentConfig = new Configuration();
                currentConfig.lastIp = "192.168.1.1";

                Save();
            }
            else
            {
                using (FileStream stream = File.OpenRead("OctoslotsConfig.xml"))
                {
                    try
                    {
                        currentConfig = (Configuration)serializer.Deserialize(stream);
                    }
                    catch (InvalidOperationException)
                    {
                        stream.Close();
                        File.Delete("OctoslotsConfig.xml");
                        Load();
                    }
                }
            }
        }

        public static void Save()
        {
            File.Delete("OctoslotsConfig.xml");
            using (FileStream writer = File.OpenWrite("OctoslotsConfig.xml"))
            {
                serializer.Serialize(writer, currentConfig);
            }
        }

    }
}
