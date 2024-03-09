namespace OddNumber
{
    public class GenerateNum
    {
        public static int GenerateNumber(int min, int max)
        {
            Random rand = new Random();
            int num = rand.Next(min, max);

            if (num % 2 == 0)
            {
                num++;
            }
            return num;
        }
    }
}
