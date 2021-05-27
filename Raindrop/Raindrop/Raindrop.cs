
namespace Raindrop
{
    public class RainDrop
    {

        public static string Raindrop(int num)
        {

            if (num == 0) return num.ToString();

            string result = "";

            if (num % 3 == 0) result += "Pling";
            if (num % 5 == 0) result += "Plang";
            if (num % 7 == 0) result += "Plong";
            if (result == "") result = num.ToString();

            return result;

        }

    }
}
