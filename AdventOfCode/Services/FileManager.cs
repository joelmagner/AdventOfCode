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
        string[] ReadFromFile(int day);
        string Path(int day);
    }

    public class FileManager : IFileManager
    {
        private readonly Translator _translate = new Translator();

        public List<T> ReadFromFileToList<T>(int day)
        {
            
            List<T> data = new List<T>();
            const Int32 BufferSize = 128;
            using (var fileStream = File.OpenRead(Path(day)))
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
            const Int32 BufferSize = 128;
            using (var fileStream = File.OpenRead(Path(day)))
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

        public string[] ReadFromFile(int day)
        {
            return File.ReadAllLines(Path(day));
        }

        public string Path(int day)
        {
            var directory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            return Directory.GetParent(directory).FullName + "/AdventOfCode/Resources/Files/"+_translate.Day(day)+".txt";
        }

    }


}