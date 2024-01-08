using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo5
{
    internal class Program
    {
        static void ft_is_negative(int n)
        {
            if ( n < 0)
            {
                Console.WriteLine("N");
            }
            if (n >= 0)
            {
                Console.WriteLine("P");
            }
        }
        static void Main()
        {
            // Exemple d'appel de la fonction
            ft_is_negative(6);
        }

    }
}