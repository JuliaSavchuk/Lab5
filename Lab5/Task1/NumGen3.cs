namespace PrimeNumber
{
    public class GenerateNum
    {
        public static bool GenerateNumber()
        {
            int number = Number();
            if (number <= 1)
                return false;
            if (number <= 3)
                return true;

            if (number % 2 == 0 || number % 3 == 0)
                return false;

            for (int i = 5; i * i <= number; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                    return false;
            }

            return true;
        }

        public static int Number()
        {
            Random rand = new Random();
            int num = rand.Next(1, 100 + 1); 
            Console.WriteLine(num);
            return num;
        }

    }
}


