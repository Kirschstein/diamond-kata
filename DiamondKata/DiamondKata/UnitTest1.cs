using NUnit.Framework;

namespace DiamondKata
{
    public class PrintingDiamondTests
    {
        [Test]
        public void input_a()
        {
            var result = GetLines("A");

            Assert.Multiple(() =>
            {
                Assert.That(result.Length, Is.EqualTo(1));
                Assert.That(result[0], Is.EqualTo("A"));
            });
        }

        [Test]
        public void input_b()
        {
            var result = GetLines("B");

            Assert.Multiple(() =>
            {
                Assert.That(result.Length, Is.EqualTo(3));
                Assert.That(result[0], Is.EqualTo(" A "));
                Assert.That(result[1], Is.EqualTo("B B"));
                Assert.That(result[2], Is.EqualTo(" A "));
            });
        }

        [Test]
        public void input_c()
        {
            var result = GetLines("C");

            Assert.Multiple(() =>
            {
                Assert.That(result.Length, Is.EqualTo(5));
                Assert.That(result[0], Is.EqualTo("  A  "));
                Assert.That(result[1], Is.EqualTo(" B B "));
                Assert.That(result[2], Is.EqualTo("C   C"));
                Assert.That(result[3], Is.EqualTo(" B B "));
                Assert.That(result[4], Is.EqualTo("  A  "));
            });
        }

        [Test]
        public void input_d()
        {
            var result = GetLines("D");

            Assert.Multiple(() =>
            {
                Assert.That(result.Length, Is.EqualTo(7));
                Assert.That(result[0], Is.EqualTo("   A   "));
                Assert.That(result[1], Is.EqualTo("  B B  "));
                Assert.That(result[2], Is.EqualTo(" C   C "));
                Assert.That(result[3], Is.EqualTo("D     D"));
                Assert.That(result[4], Is.EqualTo(" C   C "));
                Assert.That(result[5], Is.EqualTo("  B B  "));
                Assert.That(result[6], Is.EqualTo("   A   "));

            });
        }

        private static string[] GetLines(string input)
        {
            if (input == "D")
            {
                var aPadding = 4;
                var bPadding = 5;
                return new[]
                {
                    PadA(aPadding),
                    PadB(bPadding),
                    " C   C ",
                    "D     D",
                    " C   C ",
                    PadB(bPadding),
                    PadA(aPadding),
                };
            }            
            if (input == "C")
            {
                var aPadding = 3;
                var bPadding = 4;
                return new[]
                {
                    PadA(aPadding),
                    PadB(bPadding),
                    "C   C",
                    PadB(bPadding),
                    PadA(aPadding),
                };
            }            
            if (input == "B")
            {
                var aPadding = 2;
                var bPadding = 3;
                return new[]
                {
                    PadA(aPadding),
                    PadB(bPadding),
                    PadA(aPadding),
                };
            }
            return new [] { "A" };
        }

        private static string PadB(int leftWidth)
        {
            return Pad("B B", leftWidth);
        }

        private static string PadA(int leftPadding)
        {
            return Pad("A", leftPadding);
        }

        private static string Pad(string str, int leftPadding)
        {
            var rightPadding = leftPadding + (leftPadding - str.Length);
            return str.PadLeft(leftPadding, ' ').PadRight(rightPadding, ' ');
        }
    }
}