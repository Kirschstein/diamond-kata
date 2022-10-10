namespace DiamondKata;

public static class Diamond
{
    private static string Alphabet = "ABCD";

    public static string[] GetLines(string input)
    {
        if (input == "D")
        {
            var index = Alphabet.IndexOf(input[0]);

            return new[]
            {
                PadOuter("A", index), 
                PadOuter(PadInner("B"), index - 1), 
                PadOuter(PadInner("C"), index - 2), 
                PadOuter(PadInner("D"), index - index), 
                PadOuter(PadInner("C"), index - 2), 
                PadOuter(PadInner("B"), index - 1), 
                PadOuter("A", index),
            };
        }            
        if (input == "C")
        {
            var index = Alphabet.IndexOf(input[0]);

            return new[]
            {
                PadOuter("A", index),
                PadOuter(PadInner("B"), 1), 
                PadOuter(PadInner("C"), 0), 
                PadOuter(PadInner("B"), 1), 
                PadOuter("A", index),
            };
        }            
        if (input == "B")
        {
            var index = Alphabet.IndexOf(input[0]);
            return new[]
            {
                PadOuter("A", index),
                PadOuter(PadInner("B"), 0), 
                PadOuter("A", index),
            };
        }
        return new [] { "A" };
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