using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Commons
    {
        public static void SaveOnDiskUser(User value)
        {
            string serializedValue = JsonConvert.SerializeObject(value);

            var filePath = string.Format("C:\\Test2\\User\\{0}.json", value.Id);

            File.WriteAllText(filePath, serializedValue);
        }
        public static User ReadUser(int id)
        {
            var filePath = string.Format("C:\\Test2\\User\\{0}.json", id);

            if (!File.Exists(filePath))
            {
                return null;
            }

            var serializedValue = File.ReadAllText(filePath);

            return JsonConvert.DeserializeObject<User>(serializedValue);
        }
        
        public static void SaveOnDiskFlight(Flight value)
        {
            string serializedValue = JsonConvert.SerializeObject(value);

            var filePath = string.Format("C:\\Test2\\Flight\\{0}.json", value.Id);

            File.WriteAllText(filePath, serializedValue);
        }
        public static Flight ReadFlight(int id)
        {
            var filePath = string.Format("C:\\Test2\\Flight\\{0}.json", id);

            if (!File.Exists(filePath))
            {
                return null;
            }

            var serializedValue = File.ReadAllText(filePath);

            return JsonConvert.DeserializeObject<Flight>(serializedValue);
        }
        public static Flight ReadFlight(string path)
        {
            var filePath = path;

            if (!File.Exists(filePath))
            {
                return null;
            }

            var serializedValue = File.ReadAllText(filePath);

            return JsonConvert.DeserializeObject<Flight>(serializedValue);
        }
        public static User ReadUser(string path)
        {
            var filePath = path;

            if (!File.Exists(filePath))
            {
                return null;
            }

            var serializedValue = File.ReadAllText(filePath);

            return JsonConvert.DeserializeObject<User>(serializedValue);
        }

        public static bool DeleteFlightFromDisk(int id)
        {
            bool borrado = false;
            var filePath = string.Format("C:\\Test2\\Flight\\{0}.json", id);

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                borrado = true;
            }
            return borrado;
        }
        
        //Devuelve un string con todos las rutas de todos los vuelos
        public static string[] ReadFlightFiles()
        {
            string path = string.Format("C:\\Test2\\Flight\\");
            string[] fileEntries = Directory.GetFiles(path);
            return fileEntries;

        }
        public static string[] ReadUserFiles()
        {
            string path = string.Format("C:\\Test2\\User\\");
            string[] fileEntries = Directory.GetFiles(path);
            return fileEntries;

        }

    }
}

