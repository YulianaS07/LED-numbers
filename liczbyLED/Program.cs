using System;

internal class Program
{
    private static void Main(string[] args)
    {
        string liczba = Console.ReadLine();

        string[,] cyfry =
        {
            {" _ ", "| |", "|_|"},
            {"   ", "  |", "  |"},
            {" _ ", " _|", "|_ "},
            {" _ ", " _|", " _|"},
            {"   ", "|_|", "  |"},
            {" _ ", "|_ ", " _|"},
            {" _ ", "|_ ", "|_|"},
            {" _ ", "  |", "  |"},
            {" _ ", "|_|", "|_|"},
            {" _ ", "|_|", "  |"}
        };

        int wys = 3;
        int szer = 3;

        for (int i = 0; i < wys; i++)
        {
            foreach (char cyfra in liczba)
            {
                int indeks = int.Parse(cyfra.ToString());
                Console.Write(cyfry[indeks, i]);
            }

            Console.WriteLine();
        }
    }
}


