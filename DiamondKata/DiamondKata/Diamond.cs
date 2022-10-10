using System.Collections.Generic;
using System.Collections.Specialized;
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

        var countdown = index - 1;

        while (countdown > 0)
        {
            yield return PadOuter(PadInner(Alphabet[index - countdown]), countdown);
            countdown--;
        }

        yield return PadOuter(PadInner(input), index - index);

        var countup = 1;

        while (countup < index)
        {
            yield return PadOuter(PadInner(Alphabet[index - countup]), countup);
            countup++;
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