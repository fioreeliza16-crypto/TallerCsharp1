using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerCsharp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribir un titulo o descripcion
            Console.WriteLine("Bueno, este es el tercer intento jsjsjjs");

            //Definir variables
            int a, b, producto;

            //Entrada de datos
            Console.WriteLine("Ingrese el primer numero, porfis: ");
            //Guardar valores en la consola
            a = int.Parse(Console.ReadLine());
            //a = Convert.ToInt32(Console.ReadLine());
            //a = int.TryParse(Console.ReadLine());me devuelve un booleano true o false

            Console.WriteLine("Ingrese el segundo numero: ");
            b = Convert.ToInt32(Console.ReadLine());

            //Proceso
            producto = a * b;

            //Salida de datos
            Console.WriteLine("El producto es: " + (producto+2));
            Console.WriteLine($"El producto de {a}*{b}={producto + 2}");

            Console.WriteLine();//Salto de linea
            Console.WriteLine("Algoritmo area del Triangulo");

            ejercicio01 eje1 = new ejercicio01();//Decirle a chatgtp que me explique esto
            eje1.areaTriangulo();


            //Detener la pantalla
            Console.ReadKey();

        }
    }
}
