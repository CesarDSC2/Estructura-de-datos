using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//http://elfreakdelc.blogspot.com/2010/06/recursividad-en-c-desglose-de-timbres.html

namespace Franqueo_de_Cartas
{
    static class Constantes
    {
        public const double FactorI = 5; //Se definen constantes que serían 4 y 5.
        public const double FactorP = 4;
        
    }

    class Program
    {               
        static void Main(string[] args)
        {
            int cpar = 0, cimpar = 0; //Variables auxiliares.
            int n;
            do
            {                
                Console.Write("¿Valor de los timbres fiscales?: ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n < 12); //Mientras sea menor a 12 el programa va a seguir pidiendo un valor mayor a este.
            Console.WriteLine("Sellos equivalentes: ");
            Descomponer(n, cpar, cimpar);
            if (cpar > 0) 
            {
                Console.WriteLine("{0} timbres de {1}", cpar, Constantes.FactorP);
            }
            else
            {
                cpar = 1;
            }
            if (cimpar > 0)
            {
                Console.WriteLine("{0} timbres de {1}", cimpar, Constantes.FactorI);
            }
            else
            {
                cimpar = 1;
            }
            Console.ReadKey();
        }
    
        static void Descomponer(int num, int cpar, int cimpar)
        {
            if (num > 0)
            {
                if (num % Constantes.FactorI == 0)
                {
                    DescNumI(num);
                    cimpar = cimpar + 1;
                }
                else
                {
                    DescNumP(num);
                    cpar = cpar + 1;
                }
                Descomponer(num, cpar, cimpar);
            }
        }

        static double DescNumI(double n)
        {
            DescNumI(n - Constantes.FactorI);
            return DescNumI(n);
        }
        static double DescNumP(double n)
        {
            DescNumP(n - Constantes.FactorP);
            return DescNumP(n);
        }
        
    }
}
