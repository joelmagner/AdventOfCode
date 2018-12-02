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
        StreamWriter SaveToFile();
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
            Translator _translate = new Translator();
            var path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            return Directory.GetParent(path).FullName + "/AdventOfCode/Resources/Files/";
        }

        public StreamWriter SaveToFile()
        {
            throw new NotImplementedException();
        }
    }


}