using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public class Fibonacci
    {
        public Fibonacci(int n)
        {
        }

        public static int FiboIterativo(int n)
        {

            int i = 1, j = 0;

            for (int k = 0
                ; k < n; k++)
            {
                int t;
                t = i + j;
                i = j;
                j = t;
            }
            return j;
        }

        public static int FiboRecursivo(int n)
        {
            if (n < 2)
            {
                return n;
            }
            else
            {
                return FiboRecursivo(n - 2) + FiboRecursivo(n - 1);
            }
        }

        public void Desplegar(int n, int opc)
        {
            for (int i = 0; i < n; i++)
            {
                if (opc == 1)
                {
                    Console.WriteLine(FiboIterativo(i));
                }
                else if (opc == 2)
                {
                    Console.WriteLine(FiboRecursivo(i));
                }
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            DateTime t1 = DateTime.Now;

            int n = 0, met = 0;

            Console.WriteLine("¿Qué método quieres utilizar?\n1.-Iterativo\n2.-Recursivo");
            Console.Write("Opción: ");
            met = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la cantidad de términos: ");
            n = int.Parse(Console.ReadLine());
            Fibonacci obj = new Fibonacci(n);

            obj.Desplegar(n, met);

            DateTime t2 = DateTime.Now;
            TimeSpan total = new TimeSpan(t2.Ticks - t1.Ticks);
            Console.Write("\nTiempo de ejecución: " + total.ToString());
            Console.ReadKey();
        }
    }
}
