using NUnit.Framework;
using Raindrop;

namespace RaindropTestFramework
{
    public class Tests
    {

        [TestCase(6, "Pling")]
        [TestCase(3, "Pling")]
        public void Raindrop_Returns_The_Pling_when_given_factor_of_3(int input, string expected)
        {

            Assert.That(RainDrop.Raindrop(input), Is.EqualTo(expected));

        }

        [TestCase(5, "Plang")]
        [TestCase(10, "Plang")]
        public void Raindrop_Returns_The_Plang_when_given_factor_of_5(int input, string expected)
        {

            Assert.That(RainDrop.Raindrop(input), Is.EqualTo(expected));

        }

        [TestCase(7, "Plong")]
        [TestCase(14, "Plong")]
        public void Raindrop_Returns_The_Plong_when_given_factor_of_7(int input, string expected)
        {

            Assert.That(RainDrop.Raindrop(input), Is.EqualTo(expected));

        }

        [TestCase(1, "1")]
        [TestCase(11, "11")]
        [TestCase(13, "13")]
        public void Raindrop_Returns_The_number_when_given_a_number_with_no_factors(int input, string expected)
        {

            Assert.That(RainDrop.Raindrop(input), Is.EqualTo(expected));

        }

        [TestCase(30, "PlingPlang")]
        [TestCase(15, "PlingPlang")]
        [TestCase(15, "PlingPlang")]
        public void Raindrop_Returns_The_PlingPlong_when_given_factor_of_3_and_5(int input, string expected)
        {

            Assert.That(RainDrop.Raindrop(input), Is.EqualTo(expected));

        }

    }
}