using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerCsharp1
{
    public class ejercicio01
    {
        public void areaTriangulo()
        {
            //Definir variables
            //float s,area; s=semiperimetro

            //Solicitar los datos
            Console.WriteLine("Ingrese el lado a: ");

            //Guardar los datos en la consola
            var a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el lado b: ");
            var b = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el lado c: ");
            var c = int.Parse(Console.ReadLine());

            //Proceso
            //s =(a+b+c)/2; 
            var s = (a + b + c) / 2;
            var area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            //Salida de datos
            Console.WriteLine($"El area del triangulo es, segun los lados {a},{b},{c} es: {area}");

            //Detener la pantalla
            Console.ReadKey();

        }
    }
}
