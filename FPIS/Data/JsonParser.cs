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
        static string defaultDirectoryPath = Path.Combine(GetFolderPath(SpecialFolder.LocalApplicationData), "FPIS");
        static string materialReceivedDirectoryPath = Path.Combine(defaultDirectoryPath, "Material Procured");
        static string materialIssuedDirectoryPath = Path.Combine(defaultDirectoryPath, "Material Issued");
        static string superUserDirectoryPath = Path.Combine(defaultDirectoryPath, "Super Admin");
        static JsonParser()
        {
            CreateDirectory(defaultDirectoryPath, materialReceivedDirectoryPath, materialIssuedDirectoryPath, superUserDirectoryPath);
        }

        /// <summary>
        /// Writes the given string to a file
        /// </summary>
        /// <param name="obj">The string to be written</param>
        /// <param name="fileName">The name for the file that gets created. 
        /// The caller would have to specify a sub-directory as part of the filename when
        /// retrieving a file from a specific sub directory</param>
        /// <returns>The path to the newly created file</returns>
        public static string Write(string objString, string fileName)
        {
            string filePath = Path.Combine(defaultDirectoryPath, fileName);
            File.WriteAllText(filePath, objString);
            return filePath;
        }

        /// <summary>
        /// Convert a C# object to a json string
        /// </summary>
        /// <typeparam name="T">The type for the object to be converted.
        /// Any defined type of yours. For instance the 
        /// MaterialProcurementSchema</typeparam>
        /// <param name="obj">The object to be converted. Can be a reference 
        /// type</param>
        /// <returns><paramref name="obj"/> as a json string</returns>
        public static string Stringify<T>(object obj)
        {
            string json = JsonSerializer.Serialize<T>((T)obj);
            return json;
        }

        /// <summary>
        /// Reads text from a file
        /// </summary>
        /// <param name="fileName">The name for the file. The system would
        /// search the default directory FPIS. The caller would have to
        /// specify a sub-directory as part of the filename when
        /// retrieving a file from a specific sub directory</param>
        /// <returns>The text read from <paramref name="fileName"/></returns>
        public static string Read(string fileName)
        {
            string text = File.ReadAllText(Path.Combine(defaultDirectoryPath, fileName));
            return text;
        }

        /// <summary>
        /// Parse a json string to a C# object of type <typeparamref name="T"/>
        /// </summary>
        /// <typeparam name="T">The type for the object to be converted.
        /// Any defined type of yours. For instance the 
        /// MaterialProcurementSchema</typeparam>
        /// <param name="json">The json string to be converted to a C# object</param>
        /// <returns>A C# object of type <typeparamref name="T"/></returns>
        public static object Parse<T>(string json)
        {
            return JsonSerializer.Deserialize<T>(json);
        }

        /// <summary>
        /// Create a directory
        /// </summary>
        /// <param name="path">The path to the new directory. When ommited
        /// it creates the default FPIS application files directory</param>
        /// <returns>The DirectoryInfo instance for the default application
        /// folder directory</returns>
        public static DirectoryInfo CreateDirectory(params string[] paths)
        {
            foreach (string path in paths)
            {
                Directory.CreateDirectory(path);
            }
            return Directory.CreateDirectory(paths[0]);
        }

        /// <summary>
        /// Gets the files in a particular directory found in the default
        /// FPIS directory
        /// </summary>
        /// <param name="directory">The director to search</param>
        /// <returns>All the files in the specified directory</returns>
        public static FileInfo[] GetFiles(string directory)
        {
            return new DirectoryInfo(Path.Combine(defaultDirectoryPath, directory)).GetFiles();
        }

        /// <summary>
        /// Delete a file from a directory
        /// </summary>
        /// <param name="fileName">The full path to the file to be removed</param>
        public static void DeleteFile(string fileName)
        {
            File.Delete(Path.Combine(defaultDirectoryPath, fileName));
        }

        public static bool DoesFileExists(string fileName)
        {
            return File.Exists(Path.Combine(defaultDirectoryPath, fileName));
        }
    }
}
