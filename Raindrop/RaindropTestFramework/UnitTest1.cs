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
        [TestCase(7, "Plong")]
        [TestCase(14, "Plong")]
        [TestCase(13, "13")]
        [TestCase(30, "PlingPlang")]
        [TestCase(15, "PlingPlang")]
        public void Raindrop_Returns_The_Correct_value(int input, string expected)
        {

            Assert.That(RainDrop.Raindrop(input), Is.EqualTo(expected));

        }

    }
}