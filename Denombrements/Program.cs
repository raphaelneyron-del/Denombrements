using System;

namespace Denombrements
{
    /// <summary>
    /// programme permettant de permuter, arranger ou combiner un nombre
    /// </summary>
    class Program
    {
        /// <summary>
        /// module permettant d'eviter la repetition de code
        /// </summary>
        static void Saisie()
        {
            Console.Write("nombre total d'éléments à gérer = ");
            int t = int.Parse(Console.ReadLine());
            Console.Write("nombre d'éléments dans le sous ensemble = ");
            int n = int.Parse(Console.ReadLine());
        }

        /// <summary>
        /// module principal avec choix
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // déclarations
            int choix = 1, n = 0, t = 0;
            // affichage du menu avec controle du choix
            while (choix != 0)
            {
                do
                {
                    Console.WriteLine("Permutation ...................... 1");
                    Console.WriteLine("Arrangement ...................... 2");
                    Console.WriteLine("Combinaison ...................... 3");
                    Console.WriteLine("Quitter .......................... 0");
                    Console.Write("Choix :                            ");
                    choix = int.Parse(Console.ReadLine());
                } while (choix != 0 && choix != 1 && choix != 2 && choix != 3);
                // affichage en fonction du choix
                switch (choix)
                {
                    case 1:
                        Console.Write("nombre total d'éléments à gérer = ");
                        n = int.Parse(Console.ReadLine());
                        // calcul                       
                        long r = 1;
                        for (int k = 1; k <= n; k++)
                            r *= k;
                        // affichage résultat
                        Console.WriteLine("La permutation de " + n + " = " + r);
                        break;
                    case 2:
                        Saisie();
                        // calcul
                        r = 1;
                        for (int k = (t - n + 1); k <= t; k++)
                            r *= k;
                        // affichage résultat
                        Console.WriteLine("L'arrangement de (" + t + "/" + n + ") = " + r);
                        break;
                    case 3:
                        Saisie();
                        // calcul
                        long r1 = 1;
                        for (int k = (t - n + 1); k <= t; k++)
                            r1 *= k;
                        long r2 = 1;
                        for (int k = 1; k <= n; k++)
                            r2 *= k;
                        // affichage résultat
                        Console.WriteLine("La combinaison de (" + t + "/" + n + ") = " + (r1 / r2));
                        break;
                    case 0:
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
