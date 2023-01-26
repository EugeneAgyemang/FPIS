
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


    /// <summary>
    /// Shows a success MessageBox with the information icon
    /// </summary>
    /// <param name="message"></param>
    /// <param name="title"></param>
    /// <returns>DialogResult</returns>
    public static DialogResult ShowMessageBox(
        string message,
        string title,
        MessageBoxButtons buttons = MessageBoxButtons.OK,
        MessageBoxIcon icon = MessageBoxIcon.Information
        )
    {
        return MessageBox.Show(message, title, buttons, icon);
    }
}
