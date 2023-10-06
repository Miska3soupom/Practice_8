using Newtonsoft.Json;

namespace ClassLibrary1
{
    public class Class1
    {
        static string path = $@"{Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)}\json\TOPFILESECRET.json";

        public static void Serialization<T>(List<T> cc)
        {
            string json = JsonConvert.SerializeObject(cc);
            if (!File.Exists(path))
                Directory.CreateDirectory($@"{Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)}\json");
            File.WriteAllText(path, json);
        }

        public static List<T> Deserialization<T>()
        {
            List<T> cc = new List<T>();
            if (!File.Exists(path))
                return cc;
            string json = File.ReadAllText(path);
            cc = JsonConvert.DeserializeObject<List<T>>(json);
            return cc;
        }
    }
}