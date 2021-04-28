using System;

namespace generateur_de_phrases_aleatoire
{
    class Program
    {

        static string ObtenirElementAleatoire(string[] t)
        {
            Random rand = new Random();
            int i = rand.Next(t.Length);

            return t[i];
        }

        static void Main(string[] args)
        {
            var sujets = new string[]
            {
                "Un lapin",
                "Une grand-mère",
                "Un chat",
                "Un bonhomme de neige",
                "Une limace",
                "Une fée",
                "Un magicien",
                "Une tortue",
                "Un papillon",
            };

            var verbes = new string[]
            {
                "mange",
                "écrase",
                "détruit",
                "observe",
                "attrape",
                "regarde",
                "avale",
                "néttoie",
                "se bat avec",
                "s'accroche à",
            };

            var complements = new string[]
            {
                "un arbre",
                "un livre",
                "la lune",
                "le soleil",
                "un serpent",
                "une carte",
                "une girafe",
                "le ciel",
                "une piscine",
                "un gateau",
                "une souris",
                "un crapaud",
            };

            
            
            const int NB_PHRASES = 10;


            for (int i = 0; i < NB_PHRASES; i++)
            {
                var sujet = ObtenirElementAleatoire(sujets);
                var verbe = ObtenirElementAleatoire(verbes);
                var complement = ObtenirElementAleatoire(complements);
                Console.WriteLine($"{sujet} {verbe} {complement}");
                Console.WriteLine();
            }

             
        }
    }
}
