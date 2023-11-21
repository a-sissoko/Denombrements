/**
 * titre : Dénombrements
 * description : programme effectuant des opérations sur des factorielles
 * auteur : 
 * date création : 21/11/2023
 * date dernière modification : 21/11/2023 
 */

using System;

namespace Denombrements
{
    class Program
    {
        /// <summary>
        /// fonction qui multiplie de k à n (k * k+1 * k+2... * n)
        /// </summary>
        /// <param name="k">valeur minimale</param>
        /// <param name="n">valeur maximale</param>
        /// <returns></returns>
        static long Multipli(int k, int n)
        {
            long r = 1;
            for (int i = k; k <= n; k++)
            {
                r *= k;
            }
            Console.WriteLine(r);
            return r;
        }

        static void Main(string[] args)
        {
            bool correct = false;
            int c = 1;
            while (c != 0)
            {
                while (!correct || c > 3)
                {
                    Console.WriteLine("Permutation ...................... 1");
                    Console.WriteLine("Arrangement ...................... 2");
                    Console.WriteLine("Combinaison ...................... 3");
                    Console.WriteLine("Quitter .......................... 0");
                    Console.Write("Choix :                            ");
                    try
                    {
                        c = int.Parse(Console.ReadLine());
                        correct = true;
                    }
                    catch
                    {
                        Console.WriteLine("Erreur : veuillez saisir un nombre");
                    }
                }
                
                if (c == 0) 
                {
                    Environment.Exit(0);
                }

                if (c == 1)
                {
                    Console.Write("nombre total d'éléments à gérer = "); 
                    int n = int.Parse(Console.ReadLine());
                    // calcul de r
                    long r = Multipli(1, n);
                        
                    Console.WriteLine(n + "! = " + r);
                }
                else
                {
                    if (c == 2)
                    {
                        Console.Write("nombre total d'éléments à gérer = "); 
                        int t = int.Parse(Console.ReadLine()); 
                        Console.Write("nombre d'éléments dans le sous ensemble = "); 
                        int n = int.Parse(Console.ReadLine());
                        // calcul de r
                        long r = Multipli((t - n + 1), t);
                            
                        //Console.WriteLine("résultat = " + (r1 / r2));
                        Console.WriteLine("A(" + t + "/" + n + ") = " + r);
                    }
                    else
                    {
                        Console.Write("nombre total d'éléments à gérer = ");
                        int t = int.Parse(Console.ReadLine()); 
                        Console.Write("nombre d'éléments dans le sous ensemble = "); 
                        int n = int.Parse(Console.ReadLine());
                        // calcul de r1
                        long r1 = Multipli((t - n + 1), t);


                        // calcul de r2
                        long r2 = Multipli(1, n);
                            
                        // calcul de r3
                        //Console.WriteLine("résultat = " + (r1 / r2));
                        Console.WriteLine("C(" + t + "/" + n + ") = " + (r1 / r2));
                    }
                }
            }
            Console.ReadLine();
        }
    }
}