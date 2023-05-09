
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

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

    /// <summary>
    /// Test if a name matches our name regular expression
    /// </summary>
    /// <param name="name"></param>
    /// <returns>boolean</returns>
    public static bool TestNameRegex(string name)
    {
        return new Regex("^[a-zA-Z ]{3,}$").IsMatch(name);
    }

    /// <summary>
    /// Prevent users from entering some characters. Only digits, period and backspace keys are allowed
    /// </summary>
    /// <param name="characterPressed">The character the user pressed</param>
    /// <returns>A value indicating whether the key accepted is not handled by us or otherwise. In which case the caller would have to handle the character by displaying to an output stream</returns>
    public static bool IsCharacterPressedHandled(char characterPressed)
    {
        bool isKeyHandled = true;
        if (characterPressed >= '0' && characterPressed <= '9' || characterPressed == '\b' || characterPressed == '.')
        {
            isKeyHandled = false;
        }
        return isKeyHandled;
    }
    /// <summary>
    /// Retrieve the last characters from the right of the given string
    /// </summary>
    /// <param name="length">Number of characters needed</param>
    /// <returns>A string with four dots followed by the number of characters requested</returns>
    public static string GetLastCharacters(string text, int length)
    {
        StringBuilder builder = new StringBuilder("....");
        int len = text.Length;
        if (length >= len)
            len = 4;
        int i = len - length;
        while (i < len)
        {
            builder.Append(text[i++]);
        }
        return builder.ToString();
    }

    /// <summary>
    /// Test if quantity received matches our name regular expression
    /// </summary>
    /// <param quantity="quantity"></param>
    /// <returns>boolean</returns>
    public static bool TestQuantityRegex(string quantity)
    {
        return new Regex("^[0-9]").IsMatch(quantity);
    }

    public static float GetParameterValue(float? currentValue)
    {
        if (currentValue == null)
        {
            return 0;
        }

        return (float)currentValue;
    }
}
