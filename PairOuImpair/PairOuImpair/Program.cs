using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairOuImpair
{
    class Program
    {
        static void Main()
        {
            //Déclaration de variables (entiers)
            int num1;
            int num2;
            Console.WriteLine("Please Enter Any Number Check Even or odd.");

            //Initialisation des variables
            //Initialiser num1 avec le nombre rentré par l'utilisateur
            num1 = Convert.ToInt32(Console.ReadLine());
            //Initialiser num2 avec le résultat de l'opération faite avec num1
            num2 = num1 % 2;

            //Si num2 est égal à 0 alors num1 est pair
            if (num2 == 0)
            {
                Console.WriteLine("\n{0} is Even Number.", num1);
            }                
            else
            {
                Console.WriteLine("\n{0} is odd Number.", num1);
            }
               
            Console.ReadKey();
        }
    }
}
