internal class Program
{
    static void Main()
    {
        Console.WriteLine("Пианино.Октавы и переключение");
        ccc();
    }
    static void ccc()
    {
        int[] one = new int[12] { 3270, 3460, 3670, 3880, 4120, 4360, 4620, 4900, 5190, 5500, 5820, 6170 };
        int[] two = new int[12] { 6540, 6930, 7340, 7770, 8240, 8730, 9250, 9800, 10300, 11000, 11600, 12300 };

        while (true)
        {

            ConsoleKeyInfo x = Console.ReadKey();


            if (x.Key == ConsoleKey.F1)
            {
                oct(one);
            }
            if (x.Key == ConsoleKey.F2)
            {
                oct(two);
            }
        }
    }
    static void oct(int[] rer)
    {
        ConsoleKeyInfo i = Console.ReadKey();
        while (i.Key != ConsoleKey.Escape)
        {
            if (i.Key == ConsoleKey.A)
            {
                Console.Beep(rer[0], 400);
            }
            if (i.Key == ConsoleKey.B)
            {
                Console.Beep(rer[1], 400);
            }
            if (i.Key == ConsoleKey.C)
            {
                Console.Beep(rer[2], 400);
            }
            if (i.Key == ConsoleKey.D)
            {
                Console.Beep(rer[3], 400);
            }
            if (i.Key == ConsoleKey.E)
            {
                Console.Beep(rer[4], 400);
            }
            if (i.Key == ConsoleKey.F)
            {
                Console.Beep(rer[5], 400);
            }
            if (i.Key == ConsoleKey.G)
            {
                Console.Beep(rer[6], 400);
            }
            if (i.Key == ConsoleKey.H)
            {
                Console.Beep(rer[7], 400);
            }
            if (i.Key == ConsoleKey.I)
            {
                Console.Beep(rer[8], 400);
            }
            if (i.Key == ConsoleKey.G)
            {
                Console.Beep(rer[9], 400);
            }
            if (i.Key == ConsoleKey.K)
            {
                Console.Beep(rer[10], 400);
            }
            if (i.Key == ConsoleKey.L)
            {
                Console.Beep(rer[11], 400);
            }
            i = Console.ReadKey();
        }
    }
}
