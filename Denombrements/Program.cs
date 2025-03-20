using System;

namespace Denombrements
{
    class Program
    {
        /// <summary>
        /// fonction permettant de multiplier une suite d'entier, d(une valeur à une autre
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        static long multiplicationSuite(int min, int max)
        {
            long resultat = 1;
            for (int i = min; i <= max; i++)
            {
                resultat *= i;
            }
            return resultat;
        }

        static void Main(string[] args)
        {
            int choix = 1;
            while (choix != 0)
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                choix = int.Parse(Console.ReadLine());

                if (choix == 0)
                {
                    Environment.Exit(0);
                }

                if (choix == 1)
                {
                    Console.Write("nombre total d'éléments à gérer = ");
                    int n = int.Parse(Console.ReadLine());
                    long resultat = multiplicationSuite(1, n);
                    Console.WriteLine(n + "! = " + resultat);
                }
                else
                {
                    if (choix == 2)
                    {
                        Console.Write("nombre total d'éléments à gérer = ");
                        int t = int.Parse(Console.ReadLine());
                        Console.Write("nombre d'éléments dans le sous ensemble = ");
                        int n = int.Parse(Console.ReadLine());
                        long resultat = multiplicationSuite((t - n + 1), t);
                        Console.WriteLine("A(" + t + "/" + n + ") = " + resultat);
                    }
                    else
                    {
                        Console.Write("nombre total d'éléments à gérer = ");
                        int t = int.Parse(Console.ReadLine());
                        Console.Write("nombre d'éléments dans le sous ensemble = ");
                        int n = int.Parse(Console.ReadLine());

                        long resultat1 = multiplicationSuite((t - n + 1), t);
                        long resultat2 = multiplicationSuite(1, n);
                        Console.WriteLine("C(" + t + "/" + n + ") = " + (resultat1 / resultat2));
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
