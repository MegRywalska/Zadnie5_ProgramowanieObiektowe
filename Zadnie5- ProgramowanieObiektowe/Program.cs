namespace Zadnie5__ProgramowanieObiektowe
{
    class Program
    {
        static void Main(string[] args)
        {
            // Przykład dla macierzy typu int
            Macierz<int> macierz1 = new Macierz<int>(2, 2);
            macierz1[0, 0] = 1;
            macierz1[0, 1] = 2;
            macierz1[1, 0] = 3;
            macierz1[1, 1] = 4;

            Macierz<int> macierz2 = new Macierz<int>(2, 2);
            macierz2[0, 0] = 1;
            macierz2[0, 1] = 2;
            macierz2[1, 0] = 3;
            macierz2[1, 1] = 4;

            Macierz<int> macierz3 = new Macierz<int>(2, 2);
            macierz3[0, 0] = 1;
            macierz3[0, 1] = 2;
            macierz3[1, 0] = 3;
            macierz3[1, 1] = 5;

            Console.WriteLine("Macierz 1:");
            WyswietlMacierz(macierz1);

            Console.WriteLine("\nMacierz 2:");
            WyswietlMacierz(macierz2);

            Console.WriteLine("\nMacierz 3:");
            WyswietlMacierz(macierz3);

            // Testowanie operatorów ==
            Console.WriteLine("\nPorównanie macierzy 1 i 2:");
            Console.WriteLine(macierz1 == macierz2); // powinno zwrócić true

            Console.WriteLine("\nPorównanie macierzy 1 i 3:");
            Console.WriteLine(macierz1 == macierz3); // powinno zwrócić false

            // Testowanie operatora !=
            Console.WriteLine("\nPorównanie macierzy 1 i 2:");
            Console.WriteLine(macierz1 != macierz2); // powinno zwrócić false

            Console.WriteLine("\nPorównanie macierzy 1 i 3:");
            Console.WriteLine(macierz1 != macierz3); // powinno zwrócić true

            Console.ReadKey();
        }

        static void WyswietlMacierz<T>(Macierz<T> macierz)
        {
            for (int i = 0; i < macierz.WymiarWierszy; i++)
            {
                for (int j = 0; j < macierz.WymiarKolumn; j++)
                {
                    Console.Write($"{macierz[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}