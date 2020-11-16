/**
 * titre : Denombrements
 * description : effectuer un calcul mathématique parmis trois choix : permutation, arrangement, combinaison
 * auteur : CNED
 * date de création : 13/06/2020
 * date dernière modification : 12/11/2020
 */

using System;

namespace Denombrements
{
    class Program
    {
        // module de saisies du nombre d'éléments à gérer
        static int Nombre(string message)
        {
            bool correct = false;
            int nombre = 0;
            while (!correct)
            {
                try
                {
                    Console.Write(message);
                    nombre = int.Parse(Console.ReadLine());
                    correct = true;
                }
                catch
                {
                    Console.WriteLine("Erreur de saisie : saisissez un nombre entier");
                }
            }
            return nombre;
        }
        // module de calcul de r1
        static long CalculR1(int t, int n)
        {
            long r1 = 1;
            for (int k = (t - n + 1); k <= t; k++)
            {
                r1 *= k;
            }
            return r1;
        }
        //module de calcul de r2
        static long CalculR2(int n)
        {
            long r2 = 1;
            for (int k = 1; k <= n; k++)
            {
                r2 *= k;
            }
            return r2;
        }
        // module principal
        static void Main(string[] args)
        {
            int choix = 1, t, n;
            long r, r1, r2;
            string msgGerer = "nombre total d'éléments à gérer = ";
            string msgSousEnsemble = "nombre d'éléments dans le sous ensemble = ";
            while (choix != 0)
            {
                // choix du type de calcul
                bool correct = false;
                while (!correct)
                {
                    try
                    {
                        Console.WriteLine("Permutation ...................... 1");
                        Console.WriteLine("Arrangement ...................... 2");
                        Console.WriteLine("Combinaison ...................... 3");
                        Console.WriteLine("Quitter .......................... 0");
                        Console.Write("Choix :                            ");
                        choix = int.Parse(Console.ReadLine());
                        correct = true;
                    }
                    catch
                    {
                        Console.WriteLine("Erreur de saisie : saisissez un nombre entier");
                    }
                }
                // quitter
                if (choix == 0)
                {
                    Environment.Exit(0);
                }
                // permutation
                if (choix == 1)
                {
                    // saisie du nombre d'éléments à gérer
                    t = Nombre(msgGerer);
                    // calcul de r
                    r = CalculR2(t);
                        Console.WriteLine(t + "! = " + r);
                }
                // arrangement
                else if (choix == 2)
                {
                    // saisies du nombre d'éléments à gérer et du sous ensemble
                    t = Nombre(msgGerer);
                    n = Nombre(msgSousEnsemble);
                    // calcul de r
                    r = CalculR1(t, n);
                    //Console.WriteLine("résultat = " + (r1 / r2));
                    Console.WriteLine("A(" + t + "/" + n + ") = " + r);
                    }
                // combinaison
                else if (choix == 3)
                {
                    // saisies du nombre d'éléments à gérer et du sous ensemble
                    t = Nombre(msgGerer);
                    n = Nombre(msgSousEnsemble);
                    // calculs de r1 et r2
                    r1 = CalculR1(t, n);
                    r2 = CalculR2(n);
                    //Console.WriteLine("résultat = " + (r1 / r2));
                    Console.WriteLine("C(" + t + "/" + n + ") = " + (r1 / r2));
                }
                else
                {
                    Console.WriteLine("Erreur dans la saisie du choix");
                }
            }
            Console.ReadLine();
        }
    }
}