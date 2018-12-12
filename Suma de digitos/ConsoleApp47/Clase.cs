using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp47
{
    class Clase
    {
        public int Suma(int n) //Función recursiva.f
        {
            if (n == 0)
            {      
                return n; //Caso Base
            }
            else
            {
                return Suma(n / 10) + (n % 10); //Va a ejecutar el método hasta que se cumpla el caso base, es decir, cuando n sea igual a 0, se función recursiva terminará.
                //Ejemplo, si tecleamos 123, obtendremos de primero: return Suma(12) + (3) = 15, 15 no es igual a 0, entonces vuelve a llamar al método, y tendremos: return Suma(1) + (5) = 6, 6 no es igual a 0, pero si 
                //intentamos llamar nuevamente al método, al dividir 6 entre 10, ya obtenemos un valor de 0, por lo tanto entra el caso base y termina la función. Al ser "n" de tipo int, no tomará decimales y va a tomar solamente el entero.
            }
        }

        public void Play()
        {
            x: //Marca
            Console.Write("Ingrese un número ó ingrese (00) para salir: "); //
            string opc = Console.ReadLine();
            if (opc == "00") //Condición para salir.
            {
                Console.Write("Presione enter para salir...");
            }
            else
            {
                Console.Write("Suma: " + Suma(int.Parse(opc))); //Imprime el resultado.
                Console.ReadKey();
                Console.Clear();
                goto x; //Referencia.
            }
            
            Console.ReadKey();
        }
    }
}
