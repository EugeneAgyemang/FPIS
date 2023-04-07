using FPIS.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Environment;

namespace FPIS.Data
{
    public static class JsonParser
    {
        static string dirPath = Path.Combine(GetFolderPath(SpecialFolder.LocalApplicationData), "FPIS");
        static JsonParser()
        {
            if (!(Directory.Exists(dirPath)))
            {
                CreateDirectory();
            }
        }
        /// <summary>
        /// Serializes the given object into a JSON object
        /// </summary>
        /// <param name="obj">The object to be serialized. Can be a reference 
        /// type that stores a reference</param>
        /// <param name="fileName">The name for the JSON file that gets created</param>
        /// <returns>The path to the newly created file</returns>
        public static string Serialize<T>(object obj, string fileName)
        {
            string json = JsonSerializer.Serialize<T>((T)obj);
            string filePath = Path.Combine(dirPath, fileName);
            File.WriteAllText(filePath, json);
            return filePath;
        }
        public static object Deserialize<T>(string fileName)
        {
            string json = File.ReadAllText(Path.Combine(dirPath, fileName));
            return JsonSerializer.Deserialize<T>(json);
        }
        /// <summary>
        /// Create the FPIS default directory
        /// </summary>
        /// <returns>The DirectoryInfo instance for the created directory</returns>
        private static DirectoryInfo CreateDirectory()
        {
            return Directory.CreateDirectory(Path.Combine(dirPath));
        }
        /// <summary>
        /// Gets the files in a particular directory
        /// </summary>
        /// <param name="directory">The director to search</param>
        /// <returns>All the files in the specified directory</returns>
        public static FileInfo[] GetFIles(string directory)
        {
            return new DirectoryInfo(Path.Combine(dirPath, directory)).GetFiles();
        }
        /// <summary>
        /// Delete a file from a directory
        /// </summary>
        /// <param name="fileName">The full path to the file to be removed</param>
        public static void DeleteFile(string fileName)
        {
            File.Delete(Path.Combine(dirPath, fileName));
        }
    }
}
