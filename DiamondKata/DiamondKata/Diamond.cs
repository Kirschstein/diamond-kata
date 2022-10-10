using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace DiamondKata;

public static class Diamond
{
    private static string Alphabet = "ABCD";

    public static string[] GetLines(string targetLetter)
    {
        if (targetLetter == "A")
            return new [] { "A" };

        return GetDiamondLines(targetLetter).ToArray();
    }

    private static IEnumerable<string> GetDiamondLines(string targetLetter)
    {
        var index = Alphabet.IndexOf(targetLetter[0]);
        foreach (var row in CreateRowsUpToInput(index)) yield return row;
        yield return CreateInnerRow(targetLetter);
        foreach (var row in CreateRowsDownFromInput(index)) yield return row;
    }

    private static string CreateInnerRow(string input)
    {
        return PadOuter(PadInner(input), 0);
    }

    private static IEnumerable<string> CreateRowsDownFromInput(int targetLetter)
    {
        var i = 1;

        while (i < targetLetter)
        {
            yield return PadOuter(PadInner(Alphabet[targetLetter - i]), i);
            i++;
        }

        yield return PadOuter("A", targetLetter);
    }

    private static IEnumerable<string> CreateRowsUpToInput(int targetLetter)
    {
        yield return PadOuter("A", targetLetter);

        var i = targetLetter - 1;

        while (i > 0)
        {
            yield return PadOuter(PadInner(Alphabet[targetLetter - i]), i);
            i--;
        }
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