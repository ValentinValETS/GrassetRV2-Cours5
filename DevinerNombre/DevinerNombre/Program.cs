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

            int numeroEntre;
            //
            //

            //
            //
            if (!Int32.TryParse(Console.ReadLine(), out numeroEntre))
                    Console.WriteLine("Échec de la conversion du nombre !");

            //
            //
            //
            //
      
            //
            //
            //
            Console.WriteLine("Tapez n'importe quelle touche pour terminer...");
            Console.WriteLine("---------------------------------------");
            Console.ReadLine();
        }
    }
}
