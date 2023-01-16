
using System.Security.Cryptography;

namespace FPIS.Utils;

public class Utils
{
    /// <summary>
    /// Hashes a string with SHA-512
    /// </summary>
    /// <param name="rawPasswordString"></param>
    /// <returns>string</returns>
    public static string HashPassword(string rawPasswordString)
    {
        // TODO: Implement a true hashing for passwords

        string encryptedPassword = rawPasswordString;
        // HashAlgorithm sha512 = SHA512.Create();
        // byte[] b = new byte[32];

        // sha512.ComputeHash(rawPasswordString.ToArray());
        return $"en_-{encryptedPassword}-_ted";
    }
}
