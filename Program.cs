using System;

namespace ITLA.resumen01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaras variables
            int numero1 = 0;
            int numero2 = 0;
            Console.WriteLine("Resumen de clases");
            Console.WriteLine("Ingrese el valor de numero 1");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de numero 2");
            numero2 = int.Parse(Console.ReadLine());
            //Operaciones atritmeticas
            int suma = numero1 + numero2;
            int resta = numero1 - numero2;
            int multiplicacion = numero1 * numero2;
            int division = numero1 / numero2;
            int residuo = numero1 % numero2;
            double division2 = (double)numero1 / numero2;
            //Imprimir resultados
            Console.WriteLine("La suma de los numeros es: " + suma);
            Console.WriteLine("La resta de los numeros es: " + resta);
            Console.WriteLine("La multiplicacion de los numeros es: " + multiplicacion);
            Console.WriteLine("La division de los numeros es: " + division);
            Console.WriteLine("El residuo de los numeros es: " + residuo);
            Console.WriteLine("La division de los numeros es: " + division2);
            //operadores comparacion
            bool mayor = numero1 > numero2;
            bool menor = numero1 < numero2;
            bool igual = numero1 == numero2;
            bool diferente = numero1 != numero2;
            bool mayorIgual = numero1 >= numero2;
            bool menorIgual = numero1 <= numero2;
            //Imprimir resultados
            Console.WriteLine("El numero 1 es mayor que el numero 2: " + mayor);
            Console.WriteLine("El numero 1 es menor que el numero 2: " + menor);
            Console.WriteLine("El numero 1 es igual que el numero 2: " + igual);
            Console.WriteLine("El numero 1 es diferente que el numero 2: " + diferente);
            Console.WriteLine("El numero 1 es mayor o igual que el numero 2: " + mayorIgual);
            Console.WriteLine("El numero 1 es menor o igual que el numero 2: " + menorIgual);
            //Operadores logicos and or not
            bool and = mayor && menor;
            bool or = mayor || menor;
            bool not = !mayor;
            //Imprimir resultados
            Console.WriteLine("El resultado de la operacion and es: " + and);
            Console.WriteLine("El resultado de la operacion or es: " + or);
            Console.WriteLine("El resultado de la operacion not es: " + not);            
            //Operadores de asignacion
            numero1 += 10;
            numero1 -= 10;
            numero1 *= 10;
            numero1 /= 10;
            numero1 %= 10;
            //Imprimir resultados
            Console.WriteLine("El valor de numero 1 es: " + numero1); 


        }
    }
}