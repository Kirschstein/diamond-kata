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



        private static string[] GetLines(string input)
        {
            if (input == "C")
            {
                return new[]
                {
                    "  A  ",
                    " B B ",
                    "C   C",
                    " B B ",
                    "  A  ",
                };
            }            
            if (input == "B")
            {
                return new[]
                {
                    " A ",
                    "B B",
                    " A ",
                };
            }
            return new [] { "A" };
        }
    }
}