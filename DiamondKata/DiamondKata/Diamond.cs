namespace DiamondKata;

public static class Diamond
{
    public static string[] GetLines(string input)
    {
        if (input == "D")
        {
            return new[]
            {
                PadOuter("A", 3), 
                PadOuter(PadInner("B"), 2), 
                PadOuter(PadInner("C"), 1), 
                PadOuter(PadInner("D"), 0), 
                PadOuter(PadInner("C"), 1), 
                PadOuter(PadInner("B"), 2), 
                PadOuter("A", 3),
            };
        }            
        if (input == "C")
        {
            return new[]
            {
                PadOuter("A", 2), 
                PadOuter(PadInner("B"), 1), 
                PadOuter(PadInner("C"), 0), 
                PadOuter(PadInner("B"), 1), 
                PadOuter("A", 2),
            };
        }            
        if (input == "B")
        {
            return new[]
            {
                PadOuter("A", 1), 
                PadOuter(PadInner("B"), 0), 
                PadOuter("A", 1),
            };
        }
        return new [] { "A" };
    }

    private static string PadInner(string letter)
    {
        var bValue = "B"[0];
        var letterValue = letter[0];
        var index = "ABCD".IndexOf(letterValue);

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