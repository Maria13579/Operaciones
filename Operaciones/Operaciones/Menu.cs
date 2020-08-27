using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    class Menu
    {
    
        public int ListMenu()
        {
            int op = 0;

            bool estado = true;
                Console.WriteLine("---------Menu de Opciones---------");
                Console.WriteLine("1. Adicion ");
                Console.WriteLine("2. Sustraccion");
                Console.WriteLine("3. Multiplicacion");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Potenciación");
                Console.WriteLine("6. Radicación");
                Console.WriteLine("7. Salir");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Digite el numero de opcion que desea");
            while (estado == true)
            {
                try
                {
                    op = int.Parse(Console.ReadLine());
                    estado = false;
                   
                  
                }
                catch
                {
                    Console.WriteLine("Solo valores numericos...");
                }

            }
            return op;

        }

    }
}
