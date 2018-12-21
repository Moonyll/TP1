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
            Console.WriteLine("Veuillez indiquer votre poids en kg :"); // indiquer le poids
            int poids = int.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez indiquer votre taille en m :" + "\n" + "(la virgule est le séparateur décimal)"); // indiquer la taille
            double taille = double.Parse(Console.ReadLine()); // déclaration double car la taille déclarée en m donc chiffre avec virgule possible
            double imc = Math.Round((poids) / (Math.Pow(taille, 2)), 2); // formule de l'imc avec arrondi à deux décimales pour confort de lecture
            if (imc < 16.5)
            {
                Console.WriteLine("Votre imc est de " + imc + " , vous êtes en dénutrition."); // Dénutrition. Méthode du else if aussi...
                Console.ReadKey();
            } // on peut aussi inclure la condition : if (imc < 10 || imc > 60) || op. de comparaison ou. c'est un pipe ! donc double pipe...
            else
                if (imc >= 16.5 && imc < 18.5)
            {
                Console.WriteLine("Votre imc est de " + imc + " , vous êtes en maigreur."); // Maigreur.
                Console.ReadKey();
            }
            else
                    if (imc >= 18.5 && imc < 25)
            {
                Console.WriteLine("Votre imc est de " + imc + " , vous êtes de copurlence normale."); // Normale.
                Console.ReadKey();
            }
            else
                        if (imc >= 25 && imc < 30)
            {
                Console.WriteLine("Votre imc est de " + imc + " , vous êtes en surpoids."); // Surpoids.
                Console.ReadKey();
            }
            else
                            if (imc >= 30 && imc < 35)
            {
                Console.WriteLine("Votre imc est de " + imc + " , vous êtes en obésité modérée."); // Obésité modérée.
                Console.ReadKey();
            }
            else
                                 if (imc >= 35 && imc < 40)
            {
                Console.WriteLine("Votre imc est de " + imc + " , vous êtes en obésité sévère."); // Obésité sévère.
                Console.ReadKey();
            }
            else
                if (imc >= 40)
            {
                Console.WriteLine("Votre imc est de " + imc + " , vous êtes en obésité morbide ou massive.");
                Console.ReadKey();
            }
        }
    }
}
