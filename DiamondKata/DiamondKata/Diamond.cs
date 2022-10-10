using System.Collections.Generic;
using System.Linq;

namespace DiamondKata;

public static class Diamond
{
    private static string Alphabet = "ABCD";

    public static string[] GetLines(string input)
    {
        if (input == "A")
            return new [] { "A" };

        return GetStringsAsEnumerable(input).ToArray();
    }

    private static IEnumerable<string> GetStringsAsEnumerable(string input)
    {
        var index = Alphabet.IndexOf(input[0]);

        yield return PadOuter("A", index);

        if (index == 3)
        {
            yield return PadOuter(PadInner(Alphabet[index - 2]), index - 1);
            yield return PadOuter(PadInner(Alphabet[index - 1]), index - 2);
        }
        if (index == 2)
        {
            yield return PadOuter(PadInner(Alphabet[index - 1]), index - 1); 
        }

        yield return PadOuter(PadInner(input), index - index);

        if (index == 2)
        {
            yield return PadOuter(PadInner(Alphabet[index - 1]), index - 1);
        }

        if (index == 3)
        {
            yield return PadOuter(PadInner(Alphabet[index - 1]), index - 2);
            yield return PadOuter(PadInner(Alphabet[index - 2]), index - 1);
        }

        yield return PadOuter("A", index);
    }

    private static string PadInner(string letter)
    {
        var letterValue = letter[0];
        return PadInner(letterValue);
    }

    private static string PadInner(char letterValue)
    {
        var bValue = "B"[0];
        var index = Alphabet.IndexOf(letterValue);

        var innerWidth = letterValue - bValue + index;

        var whitespace = "".PadRight(innerWidth, ' ');
        return $"{letterValue}{whitespace}{letterValue}";
    }

    private static string PadOuter(string str, int paddingLength)
    {
        var whitespace = "".PadRight(paddingLength, ' ');
        return $"{whitespace}{str}{whitespace}";
    }
}