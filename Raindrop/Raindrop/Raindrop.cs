using System;

namespace Raindrop
{
    public class RainDrop
    {

        public static string Raindrop(int num)
        {

            if (num % 3 == 0) return "Pling";

            return num.ToString();

        }

    }
}
