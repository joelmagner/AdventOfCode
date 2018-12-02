using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace AdventOfCode
{

    public interface IFileManager
    {
        List<T> ReadFromFileToList<T>(int day);
        string ReadLineFromFile(int day);
        void SaveToFile(string fileName);
        string Path();
    }

    public class FileManager : IFileManager
    {
        public List<T> ReadFromFileToList<T>(int day)
        {
            Translator _translate = new Translator();
            List<T> data = new List<T>();
            const Int32 BufferSize = 128;
            using (var fileStream = File.OpenRead(Path() + _translate.Day(day) + ".txt"))
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
            {
                String line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    data.Add((T)Convert.ChangeType(line, typeof(T)));
                }
            }
            return data;
        }

        public string ReadLineFromFile(int day)
        {
            Translator _translate = new Translator();
            const Int32 BufferSize = 128;
            using (var fileStream = File.OpenRead(Path() + _translate.Day(day) + ".txt"))
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
            {
                String line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    return line;
                }
            }

            return ":( wääääh ):";
        }

        public string Path()
        {
            var directory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            return Directory.GetParent(directory).FullName + "/AdventOfCode/Resources/Files/";
        }

        public void SaveToFile(string fileName, string message, bool writeAllAtOnce)
        {
            StringBuilder sb = new StringBuilder();
            if (writeAllAtOnce)
            {
                sb.Append(message);
            }

            if (!File.Exists(Path() + fileName + ".txt") && !writeAllAtOnce)
            {
                using (StreamWriter file = new StreamWriter(Path() + fileName + ".txt"))
                {
                    if (writeAllAtOnce)
                    {
                        file.Write(sb.ToString()); //write a bunch
                    }
                    else
                    {
                        file.WriteLine(message); //write a line to a file
                    }
                }
            }
        }
    }


}