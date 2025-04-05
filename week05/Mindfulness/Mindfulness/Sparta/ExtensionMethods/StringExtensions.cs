using System.Text;

namespace Mindfulness.Sparta.ExtensionMethods;

public static class StringExtensions
{
    public static string InsertSpaces(this string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            return value;

        var result = new StringBuilder();
        foreach (var c in value)
        {
            if (char.IsUpper(c) && result.Length > 0)
                result.Append(' ');
            result.Append(c);
        }

        return result.ToString();
    }
}