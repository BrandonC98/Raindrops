using NUnit.Framework;
using Raindrop;

namespace RaindropTestFramework
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Raindrop_Returns_The_Correct_value()
        {

            Assert.That(RainDrop.Raindrop(1), Is.EqualTo("1"));

        }
    }
}