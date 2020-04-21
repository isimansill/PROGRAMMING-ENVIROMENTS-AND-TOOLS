using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using WindowsFormsApp1.Entities;

namespace WindowsFormsApp1
{
    public static class Commons
    {

        public static Property ReadFromDisk(int id)
        {
            var filePath = string.Format("C:\\Test\\Data\\{0}.json", id);

            if (!File.Exists(filePath))
            {
                return null;
            }
            
            var serializedValue = File.ReadAllText(filePath);

            return JsonConvert.DeserializeObject<Property>(serializedValue);
        }

        public static Property ReadFromDiskFilePath(string filePath)
        {

            if (!File.Exists(filePath))
            {
                return null;
            }

            var serializedValue = File.ReadAllText(filePath);

            return JsonConvert.DeserializeObject<Property>(serializedValue);
        }

        public static bool DeleteFromDisk(int id)
        {
            bool borrado = false;
            var filePath = string.Format("C:\\Test\\Data\\{0}.json", id);

            if (File.Exists(filePath))
            {
                File.Delete(filePath);            
                borrado = true;
            }
            return borrado;
        }

        public static void SaveOnDiskAsJson(Property value)
        {
            string serializedValue = JsonConvert.SerializeObject(value);

            var filePath = string.Format("C:\\Test\\Data\\{0}.json", value.Id);

            File.WriteAllText(filePath, serializedValue);
        }
        public static void SavePic(Image File, int id)
        {
            string path = string.Format("C:\\Test\\Pictures\\{0}\\", id);
            if (Directory.Exists(path))
            {
                Console.WriteLine("That path exists already.");
            }
            else
            {
                DirectoryInfo di = Directory.CreateDirectory(path);
                Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(path));
            }
            
            string[] dirs = Directory.GetFiles("C:\\Test\\Pictures\\" + id , "*.jpg");
            int cantidad = dirs.Length;
            Console.WriteLine(cantidad);

            string filePath = string.Format("C:\\Test\\Pictures\\{0}\\picture{1}.jpg", id, cantidad+1);
            File.Save(filePath);
            
        }

        public static void DeletePic(Image File)
        {
            
        }



    }
}
