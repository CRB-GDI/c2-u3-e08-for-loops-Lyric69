namespace Exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //problem 1
            Console.Write("Hom many even number?");
            int max = int.Parse (Console.ReadLine());
            int small;
            //print even numbers up to requested max
            for (small = 0; small < max; small += 2)
            {
                Console.WriteLine (small);

            }
            //problem 2
            Console.Write("Hom wide?");
            int max2 = int.Parse(Console.ReadLine());
            for (int small2 = 0; small2 < max2; small2++)
            {
                // if user enters 5, should print *****
                Console.Write("*");
            }

        }
    }
}