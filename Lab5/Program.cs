namespace Lab5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n-----Task1-----\n");
            Console.WriteLine("Even Numbers:" + EvenNumber.GenerateNum.GenerateNumber(0, 100));
            Console.WriteLine("Odd Numbers:" + OddNumber.GenerateNum.GenerateNumber(0, 100));
            Console.WriteLine("Prime Numbers:" + PrimeNumber.GenerateNum.GenerateNumber());
            Console.WriteLine("Fibonacci Numbers:" + FibonacciNum.GenerateNum.GenerateNumber(7));
            Console.WriteLine("---------------");


            Console.WriteLine("\n-----Task2-----\n");
            Console.WriteLine("Triangle:\n");
            Triangle.Figure.Figur(5);
            Console.WriteLine("Rectangle:\n");
            Rectangle.Figure.Figur(5,6);
            Console.WriteLine("Square:\n");
            Square.Figure.Figur(5);
            Console.WriteLine("\n---------------\n");

            Console.WriteLine("\n-----Task3-----\n");
            GameNum.NumGame.Game();
            Console.WriteLine("\n---------------\n");
        }
    }
}
