using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevinerNombre
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sortir un nombre aléatoire compris entre 1 et 10
            Random random = new Random();
            int numeroADeviner = random.Next(10) + 1;

            //Initialisation du nombre que l'utilisateur va rentrer
            int numeroEntre;
            //
            //

            //
            //

            //Récupère le nombre entré par l'utilisateur et le convertit en entier
            if (!Int32.TryParse(Console.ReadLine(), out numeroEntre))
                    Console.WriteLine("Échec de la conversion du nombre !");

            //
            //
            //
            //
      
            //
            //
            //

            //Une fois l'opération effectuée, message d'attente avant de fermer le programme
            Console.WriteLine("Tapez n'importe quelle touche pour terminer...");
            Console.WriteLine("---------------------------------------");
            Console.ReadLine();
        }
    }
}
