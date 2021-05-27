using NUnit.Framework;
using Raindrop;

namespace RaindropTestFramework
{
    public class Tests
    {

        [TestCase(6, "Pling")]
        [TestCase(3, "Pling")]
        [TestCase(1, "1")]
        [TestCase(5, "Plang")]
        [TestCase(10, "Plang")]
        [TestCase(11, "11")]
        public void Raindrop_Returns_The_Correct_value(int input, string expected)
        {

            Assert.That(RainDrop.Raindrop(input), Is.EqualTo(expected));

        }

    }
}