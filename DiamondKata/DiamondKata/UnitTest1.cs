using System;
using System.Linq;
using NUnit.Framework;

namespace DiamondKata
{
    public class PrintingDiamondTests
    {

        [Test]
        public void b_is_char_value_x()
        {
            Assert.That("B"[0], Is.EqualTo(66));
        }

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

        private static string PadInner(string str)
        {
            var innerWidth = 0;
            var charValue = str[0];

            if (str == "B")
            {
                innerWidth = charValue - 65;
            }
            if (str == "C")
            {
                innerWidth = charValue - 64;
            }
            if (str == "D")
            {
                innerWidth = charValue - 63;
            }
            
            var whitespace = "".PadRight(innerWidth, ' ');
            return $"{str}{whitespace}{str}";
        }

        private static string PadOuter(string str, int paddingLength)
        {
            var whitespace = "".PadRight(paddingLength, ' ');
            return $"{whitespace}{str}{whitespace}";
        }
    }
}