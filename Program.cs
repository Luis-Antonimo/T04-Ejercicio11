using System;

namespace T04Ejercicio11
{
    class Program
    {
        static void Main()
        {
            int a = 10;
            int b = 40;
            if (a > b)
            {
                Console.WriteLine("El número A es mayor que B.");
            }
            else
            {
                if (a == b)
                {
                    Console.WriteLine("El número A es igual a B.");
                }
                else
                {
                    Console.WriteLine("El número B es mayor que A.");
                }
            }
        }
    }
}
