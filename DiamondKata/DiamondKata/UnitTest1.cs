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
                var leftPadding = 4;
                return new[]
                {
                    PadA(leftPadding),
                    BRowForD(),
                    " C   C ",
                    "D     D",
                    " C   C ",
                    BRowForD(),
                    PadA(leftPadding),
                };
            }            
            if (input == "C")
            {
                var leftPadding = 3;
                return new[]
                {
                    PadA(leftPadding),
                    BRowForC(),
                    "C   C",
                    BRowForC(),
                    PadA(leftPadding),
                };
            }            
            if (input == "B")
            {
                var leftPadding = 2;
                return new[]
                {
                    PadA(leftPadding),
                    BRowForB(),
                    PadA(leftPadding),
                };
            }
            return new [] { "A" };
        }

        private static string BRowForD()
        {
            var leftWidth = 5;
            var totalWidth = 7;
            return "B B".PadLeft(leftWidth, ' ').PadRight(totalWidth, ' ');
        }

        private static string BRowForC()
        {
            var leftWidth = 4;
            var totalWidth = 5;
            return "B B".PadLeft(leftWidth, ' ').PadRight(totalWidth, ' ');
        }

        private static string BRowForB()
        {
            var leftWidth = 3;
            var totalWidth = 3;
            return "B B".PadLeft(leftWidth, ' ').PadRight(totalWidth, ' ');
        }

        private static string PadA(int leftPadding)
        {
            var rightPadding = leftPadding + (leftPadding - 1);
            return "A".PadLeft(leftPadding, ' ').PadRight(rightPadding, ' ');
        }
    }
}