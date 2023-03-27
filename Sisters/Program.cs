
internal class Program
{
    private static void Main(string[] args)
    {
        int k = 0;
        for (int i = 1; i < 14; i++)
        {
            for (int j = 0; j < 14 - i; j++)
            {
                k = 13 - i - j;
                if (i * j * k == 36) 
                {
                    Console.WriteLine($"First sister is {i} years old");
                    Console.WriteLine($"Second sister is {j} years old");
                    Console.WriteLine($"Third sister is {k} years old");
                    Console.WriteLine("\n\n");
                }
            }
        }
    }
}