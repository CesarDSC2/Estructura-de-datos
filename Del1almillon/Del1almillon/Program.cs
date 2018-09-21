using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Del1almillon
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime time = DateTime.Now;

            double suma = 0;
            Console.WriteLine("\t°Suma del 1 al 1,000,000°");
            for (int i = 1; i <= 1000000; i++)
            {
                suma = suma + i;
            }
            Console.WriteLine("\nLa suma total es: {0}", suma);

            DateTime time2 = DateTime.Now;
            TimeSpan total = new TimeSpan(time2.Ticks - time.Ticks);
            Console.Write("\nTiempo de ejecución: " + total.ToString());
            Console.ReadKey();
        }
    }
}
