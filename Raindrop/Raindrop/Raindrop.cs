using System;

namespace Raindrop
{
    public class RainDrop
    {

        public static string Raindrop(int num)
        {
            if (num % 3 == 0 && num % 5 == 0) return "PlingPlang";
            else if (num % 3 == 0) return "Pling";
            else if (num % 5 == 0) return "Plang";
            else if (num % 7 == 0) return "Plong";

            return num.ToString();

        }

    }
}
