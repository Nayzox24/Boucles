namespace Boucles;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consigne générale : faites un commit entre chaque étape !
         */
        // Etape 1 : faire un compteur qui va de 1 à 10
        int compteur = 1;
        while (compteur <= 10)
        {
            Console.WriteLine(compteur);
            compteur++;
        }
        // Etape 2 : faire un décompte qui va de 5 à 1 puis qui dit "Bonne année !"
        int decompte = 5;
        while (decompte >= 1)
        {
            Console.WriteLine(decompte);
            decompte--;
        }
        Console.WriteLine("Bonne année !");
        // Etape 3 : faire un compteur qui va de -4 à 2
        int compteur3 = -4;
        while (compteur3 <= 2)
        {
            Console.WriteLine(compteur3);
            compteur3++;
        }

        // Etape 4 : faire un compteur qui compte 2 par 2 de 0 à 15
        int compteur4 = 0;
        while (compteur4 <= 15)
        {
            Console.WriteLine(compteur4);
            compteur4 += 2;
        }

        // Etape 5 : faire une boucle qui se répète à chaque fois que l'utilisateur écrit autre chose que "oui"
        Console.WriteLine("Entrez 'oui' pour continuer :");
        string reponse = Console.ReadLine();
        while (reponse != "oui")
        {
            Console.WriteLine("Entrez 'oui' pour continuer :");
            reponse = Console.ReadLine();
        }

        /*
         * Après votre dernier commit, faites un push de votre projet pour qu'il soit accessible sur github.com
         */
    }
}