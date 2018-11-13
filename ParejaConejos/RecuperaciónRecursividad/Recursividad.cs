using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperaciónRecursividad
{
    class Recursividad
    {
        static int Fibo(int n) //Iniciamos un método tipo int.
        {
            if (n == 1 || n == 0)

                return n;
            else
                return Fibo(n - 1) + Fibo(n - 2); //Si queremos saber el Fibonacci del número "n" se necesitaría el Fibonaccí
            //de el elemento anterior a "n" y sumarle el elemento antes del anterior a "n" y asi sucesivamente.
            //Por eso que hacemos este método e iniciando desde cero se detendrá hasta llegar al límite que sería el número "n". 
        }

        public void Play()
        {
            Console.WriteLine("Un granjero ha comprado una pareja de conejos para criarlos y luego venderlos.\nSi la pareja de conejos produce una nueva pareja cada mes y la nueva pareja\ntarda un mes más en ser también productiva. \n¿cuántos pares de conejos podrá poner a la venta al cabo de un año?\n-    -   -   -   -   -   -   -   -   -   -   -   -");
            for (int i = 0; i <= 12; i++)
            {
                if (Fibo(i) == 0)
                {
                    Console.WriteLine("Inicio."); //Simplemente para que no imprima el mes 0.
                }
                else
                {
                    Console.WriteLine("Mes: {0} - Parejas: {1}", i, Fibo(i)); //Despliega las parejas que aparecen mes por mes.
                }

            }
            //Resultado.
            Console.Write("Total de parejas en 12 meses (1 año): {0}", Fibo(12)); //Mandamos un párametro al método recursivo, en este caso es 12 porque cada número representaría un mes.
        }
    }
}
