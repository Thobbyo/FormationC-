using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace AspectAvancer
{
    class FileRR
    {
        public static void WritInBin()
        {
            List<MyPair<int, int>> paires = new List<MyPair<int, int>>() {new MyPair<int, int>(1, 1), new MyPair<int, int>(10, 10), new MyPair<int, int>(15, 20) };

            using (var stream = new FileStream("pairse.bin", FileMode.OpenOrCreate, FileAccess.Write))
            { // Memory to Disk

                var binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(stream, paires);

            }
        }

        public static string ReadInBin()
        {
            List<MyPair<int, int>> paires;
            using (var fileStreamRead = new FileStream("pairse.bin", FileMode.Open, FileAccess.Read))
            {// Disk to memory

                var binaryFormatter = new BinaryFormatter();
                paires = binaryFormatter.Deserialize(fileStreamRead) as List<MyPair<int, int>>;

            }
            string g = "";
            foreach(MyPair<int, int> p in paires)
            {
                g += p.ToString() + "\n";
            }
            return g;
        }

        public static void WrightIn()
        {
            string text = "Hello";
            using (var fileStream = new StreamWriter("log.txt", true))
            {

                fileStream.WriteLine(text);

            }
        }

        public static string ReadIn()
        {
            using (StreamReader reader = new StreamReader("log2.txt"))
            {

                string content = reader.ReadToEnd();
                return content;

            }
        }
    }
}