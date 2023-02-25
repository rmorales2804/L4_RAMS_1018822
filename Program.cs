using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4_RAMS_1018822
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 1: operaciones aritméticas");
            Console.Write("Ingrese primer número: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese segundo número: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("El número " + n1 + " sumado con el número " + n2 + " es: "); Console.WriteLine(n1 + n2); 
            Console.Write("El número " + n1 + " restado con el número " + n2 + " es: "); Console.WriteLine(n1 - n2);
            Console.Write("El número " + n1 + " multiplicado con el número " + n2 + " es: "); Console.WriteLine(n1 * n2); 
            Console.Write("El número " + n1 + " dividido con el número " + n2 + " es: "); Console.WriteLine(n1 / n2);
            Console.Write("El número " + n1 + " usando DIV con el número " + n2 + " es: "); Console.WriteLine(n1 / n2); 
            Console.Write("El número " + n1 + " usando MOD con el número " + n2 + " es: "); Console.WriteLine(n1 % n2);

            Console.WriteLine();

            Console.WriteLine("Ejercicio 2: operaciones booleanas");
            bool boolean = n1 < n2;
            bool booleana = n1 > n2;
            bool booleano = n1 == n2;

            Console.WriteLine("El número primer número es menor al segundo número: " + boolean);
            Console.WriteLine("El número primer número es mayor al segundo número: " + booleana);
            Console.WriteLine("El número primer número es igual al segundo número: " + booleano);

            Console.WriteLine();

            Console.WriteLine("Jerarquía de operaciones: ");
            Console.Write("Ingrese primer número: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese segundo número: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese tercer número: ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.Write("i: "); Console.WriteLine(a * b + c);
            Console.Write("ii: "); Console.WriteLine(a * (b + c));
            Console.Write("iii: "); Console.WriteLine(a / (b * c));
            Console.Write("iv: "); Console.WriteLine((3*a + 2*b) / c*c);

            Console.WriteLine();

            Console.WriteLine("Jerarquía de operaciones: ");
            Console.Write("Ingrese el valor de a: ");
            double aa = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el valor de b: ");
            double bb = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el valor de c: ");
            double cc = Convert.ToDouble(Console.ReadLine());
            double dd = bb*bb - 4*a*c;
            double raiz = Math.Sqrt(dd);


            Console.Write("La primer respuesta de la expresión cuadrática es: "); Console.WriteLine((- bb + raiz) / 2 * aa);
            Console.Write("La segunda respuesta de la expresión cuadrática es: "); Console.WriteLine((- bb - raiz) / 2 * aa);


            if (aa == 0)
            { 
                Console.WriteLine("Problema detectado");
            }
            if (dd <= 0)
            {
                Console.WriteLine("Problema detectado");
            }

            Console.ReadKey();
        }
    }
}
