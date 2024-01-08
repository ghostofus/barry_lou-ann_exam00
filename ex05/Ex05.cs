using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo5
{
    internal class Program
    {
        static void ft_print_alphabet()
        {
            char lettre = 'a';

            while (lettre <= 'z')
            {
                Console.Write(lettre);
                lettre++;
            }

            Console.WriteLine(); // Ajouter une nouvelle ligne à la fin pour un meilleur affichage
        }

        static void Main()
        {
            // Appel de la fonction depuis la fonction Main
            ft_print_alphabet();
        }
    }
}
