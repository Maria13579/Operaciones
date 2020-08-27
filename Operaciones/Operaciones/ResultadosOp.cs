using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    class ResultadosOp
    {
        public Suma opera1 = new Suma();
        public Resta opera2 = new Resta();
        public Multiplicacion opera3 = new Multiplicacion();
        public Division opera4 = new Division();
        public Potenciacion opera5 = new Potenciacion();
        public Radicacion opera6 = new Radicacion();

        public string Resultado(char t)

        {
            double total = 0;
            
            
                if (t == 'a')
                {
                    total = opera1.SUMA(Pedir(), Pedir());
                }
                else if (t == 's')
                {
                    total = opera2.RESTA(Pedir(), Pedir());
                }
                else if (t== 'm')
                {
                    total = opera3.MULTI(Pedir(), Pedir());
                }
                else if (t == 'd')
                {
                    total = opera4.DIVI(Pedir(), Pedir());
                }
                else if (t == 'p')
                {
                    total = opera5.POTEN(Pedir(), Pedir());
                }
                else if (t == 'r')
                {
                    total = opera6.RAIZ(Pedir());
                }

            return ("el resultado es: " + total);

        }
        private double Pedir()
        {
            double valor = 0;
            bool estado = false;
            while (estado == false)
            {
                Console.Write("ingrese un valor: ");
                try
                {
                    valor = double.Parse(Console.ReadLine());
                    estado = true;
                }
                catch
                {
                    Console.WriteLine("solo valores numericos...");
                }

            }
            return valor;

        }

    }
}
