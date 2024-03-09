namespace Triangle
{
    public class Figure
    {
        public static void Figur(int height)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
