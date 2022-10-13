using System;
namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 0, resultado = 0;
            Console.WriteLine("Ingrese 2 numeros y se mostrara el resultado");
            Console.Clear();
            Console.WriteLine("Ingrese el primer numero: ");

            //Console.ReadKey(); esto esta mal
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
            Console.WriteLine("Ingrese el segundo numero: ");
            //Console.ReadKey(); esto esta mal
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            resultado = n1 + n2;
            Console.WriteLine("Su resultado a la suma es: {0}", resultado);
            Console.ReadKey();
        }
    }
}
