namespace Diamond;

public static class Diamond
{
    private static string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

    public static string[] GetLines(string targetLetter)
    {
        if (targetLetter == "A")
            return new [] { "A" };

        return GetDiamondLines(targetLetter).ToArray();
    }

    private static IEnumerable<string> GetDiamondLines(string targetLetter)
    {
        var index = Alphabet.IndexOf(targetLetter[0]);
        foreach (var row in CreateTopRows(index)) yield return row;
        yield return CreateMiddleRow(targetLetter);
        foreach (var row in CreateBottomRows(index)) yield return row;
    }

    private static string CreateMiddleRow(string input)
    {
        return PadOuter(PadInner(input), 0);
    }

    private static IEnumerable<string> CreateBottomRows(int targetLetter)
    {
        var i = 1;

        while (i < targetLetter)
        {
            yield return PadOuter(PadInner(Alphabet[targetLetter - i]), i);
            i++;
        }

        yield return PadOuter("A", targetLetter);
    }

    private static IEnumerable<string> CreateTopRows(int targetLetter)
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
        return PadInner(letter[0]);
    }

    private static string PadInner(char letter)
    {
        var bValue = "B"[0];
        var index = Alphabet.IndexOf(letter);

        var innerWidth = letter - bValue + index;

        var whitespace = "".PadRight(innerWidth, ' ');
        return $"{letter}{whitespace}{letter}";
    }

    private static string PadOuter(string str, int paddingLength)
    {
        var whitespace = "".PadRight(paddingLength, ' ');
        return $"{whitespace}{str}{whitespace}";
    }
}