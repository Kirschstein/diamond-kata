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

        if (input == "D")
        {
            yield return PadOuter(PadInner("B"), index - 1);
            yield return PadOuter(PadInner("C"), index - 2);
            yield return PadOuter(PadInner("D"), index - index);
            yield return PadOuter(PadInner("C"), index - 2);
            yield return PadOuter(PadInner("B"), index - 1);

        }
        else if (input == "C")
        {
            yield return PadOuter(PadInner("B"), 1);
            yield return PadOuter(PadInner("C"), 0);
            yield return PadOuter(PadInner("B"), 1);
        }
        else
        {
            yield return PadOuter(PadInner("B"), 0);
        }

        yield return PadOuter("A", index);
    }

    private static string PadInner(string letter)
    {
        var bValue = "B"[0];
        var letterValue = letter[0];
        var index = Alphabet.IndexOf(letterValue);

        var innerWidth = letterValue - bValue + index;

        var whitespace = "".PadRight(innerWidth, ' ');
        return $"{letter}{whitespace}{letter}";
    }

    private static string PadOuter(string str, int paddingLength)
    {
        var whitespace = "".PadRight(paddingLength, ' ');
        return $"{whitespace}{str}{whitespace}";
    }
}