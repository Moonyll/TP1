using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Program
    {
        static void Main(string[] args)
        {
        int poids;
        double taille;
        Console.WriteLine("Veuillez indiquer votre poids en kg :"); // indiquer le poids
        poids = int.Parse(Console.ReadLine());
        Console.WriteLine("Veuillez indiquer votre taille en m :"); // indiquer la taille
        taille = double.Parse(Console.ReadLine());
        double imc = (poids) / (Math.Pow(taille, 2)); // formule de l'imc
            if (imc < 16.5)
            {
                Console.WriteLine("Votre imc est de " + imc + " , vous êtes en Dénutrition");
            }
            else
                if (imc >= 16.5 && imc < 18.5)
            {
                Console.WriteLine("Votre imc est de " + imc + " , vous êtes en maigreur");
            }
            else
                    if (imc >= 18.5 && imc < 25)
            {
                    Console.WriteLine("Votre imc est de " + imc + " , vous êtes de copurlence normale");
            }
            else
                        if (imc >= 25 && imc < 30)
            {
                        Console.WriteLine("Votre imc est de " + imc + " , vous êtes en surpoids");
            }
            else
                            if (imc >= 30 && imc < 35)
            {
                                Console.WriteLine("Votre imc est de " + imc + " , vous êtes en obésité modérée");
            }
            else
                                 if (imc >= 35 && imc < 40)
            {
                                  Console.WriteLine("Votre imc est de " + imc + " , vous êtes en obésité sévère");
            }
            else
                if (imc >= 40)
            {
                Console.WriteLine("Votre imc est de " + imc + " , vous êtes en obésité morbide ou massive");
            }



        }
    }
}
