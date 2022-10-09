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
                return new[]
                {
                    Pad("A", 4 - 1),
                    Pad("B B", 5 - 3),
                    Pad("C   C", 6 - 5),
                    Pad("D     D", 7 - 7),
                    Pad("C   C", 6 - 5),
                    Pad("B B", 5 - 3),
                    Pad("A", 4 - 1),
                };
            }            
            if (input == "C")
            {
                return new[]
                {
                    Pad("A", 3 - 1),
                    Pad("B B", 4 - 3),
                    Pad("C   C", 5 - 5),
                    Pad("B B", 4 - 3),
                    Pad("A", 3 - 1),
                };
            }            
            if (input == "B")
            {
                return new[]
                {
                    Pad("A", 2 - 1),
                    Pad("B B", 3 - 3),
                    Pad("A", 2 - 1),
                };
            }
            return new [] { "A" };
        }

        private static string Pad(string str, int paddingLength)
        {
            var whitespace = "".PadRight(paddingLength, ' ');
            return $"{whitespace}{str}{whitespace}";
        }
    }
}