using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    class Program
    {
        static Menu me = new Menu();
        static ResultadosOp res=new ResultadosOp();
        static void Main(string[] args)
        {
            int opciones = 0;
            while (opciones != 7)
            {
                opciones = me.ListMenu();
                Console.Clear();
                if (opciones == 1)
                {
                    Console.WriteLine(res.Resultado('a'));
                }
                else if (opciones == 2)
                {
                    Console.WriteLine(res.Resultado('s'));
                }
                else if (opciones == 3)
                {
                    Console.WriteLine(res.Resultado('m'));
                }
                else if (opciones == 4)
                {
                    Console.WriteLine(res.Resultado('d'));
                }
                else if (opciones == 5)
                {
                    Console.WriteLine(res.Resultado('p'));
                }
                else if (opciones == 6)
                {
                    Console.WriteLine(res.Resultado('r'));
                }


            }
            Console.ReadKey();


    

        }
    }
}
