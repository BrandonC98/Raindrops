using NUnit.Framework;
using Raindrop;

namespace RaindropTestFramework
{
    public class Tests
    {

        [TestCase(6, "Pling")]
        [TestCase(3, "Pling")]
        [TestCase(1, "1")]
        public void Raindrop_Returns_The_Correct_value(int input, string expected)
        {

            Assert.That(RainDrop.Raindrop(input), Is.EqualTo(expected));

        }

    }
}