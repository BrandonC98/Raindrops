using NUnit.Framework;
using Raindrop;

namespace RaindropTestFramework
{
    public class RaindropTests
    {

        [TestCase(6, "Pling")]
        [TestCase(3, "Pling")]
        public void Raindrop_returns_Pling_when_given_factor_of_3(int input, string expected)
        {
            Assert.That(RainDrop.Raindrop(input), Is.EqualTo(expected));
        }

        [TestCase(5, "Plang")]
        [TestCase(10, "Plang")]
        public void Raindrop_returns_Plang_when_given_factor_of_5(int input, string expected)
        {
            Assert.That(RainDrop.Raindrop(input), Is.EqualTo(expected));
        }

        [TestCase(7, "Plong")]
        [TestCase(14, "Plong")]
        [TestCase(28, "Plong")]
        public void Raindrop_returns_Plong_when_given_factor_of_7(int input, string expected)
        {
            Assert.That(RainDrop.Raindrop(input), Is.EqualTo(expected));
        }


        [TestCase(30, "PlingPlang")]
        [TestCase(15, "PlingPlang")]
        [TestCase(30, "PlingPlang")]
        public void Raindrop_returns_PlingPlong_when_given_factor_of_3_and_5(int input, string expected)
        {
            Assert.That(RainDrop.Raindrop(input), Is.EqualTo(expected));
        }

        [TestCase(21, "PlingPlong")]
        [TestCase(42, "PlingPlong")]
        public void Raindrop_returns_PlingPlong_when_given_factor_of_3_and_7(int input, string expected)
        {
            Assert.That(RainDrop.Raindrop(input), Is.EqualTo(expected));
        }


        [TestCase(70, "PlangPlong")]
        [TestCase(140, "PlangPlong")]
        public void Raindrop_returns_PlingPlong_when_given_factor_of_5_and_7(int input, string expected)
        {
            Assert.That(RainDrop.Raindrop(input), Is.EqualTo(expected));
        }

        [TestCase(1, "1")]
        [TestCase(34, "34")]
        public void Raindrop_returns_number_when_given_a_number_with_no_factors(int input, string expected)
        {
            Assert.That(RainDrop.Raindrop(input), Is.EqualTo(expected));
        }

        public void Raindrop_returns_0_when_given_0()
        {
            Assert.That(RainDrop.Raindrop(0), Is.EqualTo("0"));
        }


        public void Raindrop_returns_digits_of_max_Int_when_given_max_int()
        {
            Assert.That(RainDrop.Raindrop(int.MaxValue), Is.EqualTo(int.MaxValue.ToString()));
        }

        public void Raindrop_returns_digits_of_min_Int_when_given_min_int()
        {
            Assert.That(RainDrop.Raindrop(int.MinValue), Is.EqualTo(int.MinValue.ToString()));
        }

    }
}