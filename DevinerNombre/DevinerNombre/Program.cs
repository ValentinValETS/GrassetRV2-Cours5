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
            Random random = new Random();
            int numeroADeviner = random.Next(10) + 1;

            int numeroEntre = 0;
            Console.WriteLine("Devinez un nombre compris entre 1 et 10");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Veuillez entrer un chiffre");

            while (numeroEntre != numeroADeviner)
            {
                if (!Int32.TryParse(Console.ReadLine(), out numeroEntre))
                    Console.WriteLine("Échec de la conversion du nombre !");
                else
                {
                    if (numeroEntre < numeroADeviner)
                        Console.WriteLine("Nombre plus grand");
                    else if(numeroEntre > numeroADeviner)
                        Console.WriteLine("Nombre plus petit");
                }
            }
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Nombre deviné !");
            Console.WriteLine("Tapez n'importe quelle touche pour terminer...");
            Console.WriteLine("---------------------------------------");
            Console.ReadLine();
        }
    }
}
