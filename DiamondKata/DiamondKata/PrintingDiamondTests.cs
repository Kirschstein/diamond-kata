using System;
using System.Linq;
using NUnit.Framework;

namespace DiamondKata
{
    public class PrintingDiamondTests
    {
        [Test]
        public void input_a()
        {
            var result = Diamond.GetLines("A");

            Assert.Multiple(() =>
            {
                Assert.That(result.Length, Is.EqualTo(1));
                Assert.That(result[0], Is.EqualTo("A"));
            });
        }

        [Test]
        public void input_b()
        {
            var result = Diamond.GetLines("B");

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
            var result = Diamond.GetLines("C");

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
            var result = Diamond.GetLines("D");

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

        [Test]
        public void input_e()
        {
            var result = Diamond.GetLines("E");

            Assert.Multiple(() =>
            {
                Assert.That(result.Length, Is.EqualTo(9));
                Assert.That(result[0], Is.EqualTo("    A    "));
                Assert.That(result[1], Is.EqualTo("   B B   "));
                Assert.That(result[2], Is.EqualTo("  C   C  "));
                Assert.That(result[3], Is.EqualTo(" D     D "));
                Assert.That(result[4], Is.EqualTo("E       E"));
                Assert.That(result[5], Is.EqualTo(" D     D "));
                Assert.That(result[6], Is.EqualTo("  C   C  "));
                Assert.That(result[7], Is.EqualTo("   B B   "));
                Assert.That(result[8], Is.EqualTo("    A    "));
            });
        }
    }
}