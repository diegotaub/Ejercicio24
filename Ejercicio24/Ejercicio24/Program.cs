using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese una fecha con el formato dd/MM/yyyy: ");
            if(!DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", 
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None, out DateTime Fecha))
            {
                Console.Write("La fecha no tiene formato dd/MM/yyyy");
            }
            else
            {
                Console.Write("Fecha correcta");
            }
            Console.ReadKey();
        }
    }
}
