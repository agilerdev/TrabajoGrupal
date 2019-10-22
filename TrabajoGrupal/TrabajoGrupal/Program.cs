using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoGrupal.clases;
namespace TrabajoGrupal
{
    class Program
    {
        static void Main(string[] args)
        {
             Nota nota = new Nota();
             Console.WriteLine("Ingrese el nombre del estudiante");
             nota.Nombre = Console.ReadLine();
             Console.WriteLine("Ingrese la nota de actividad en clase del primer parcial");
             nota.Ac1P = float.Parse(Console.ReadLine());
             Console.WriteLine("Ingrese la nota de practicas del primer parcial");
             nota.Pr1P = float.Parse(Console.ReadLine());
             Console.WriteLine("Ingrese la nota de trabajo autonomo del primer parcial");
             nota.Ta1P = float.Parse(Console.ReadLine());
             Console.WriteLine("Ingrese la nota de evaluacion final del primer parcial");
             nota.Ef1P = float.Parse(Console.ReadLine());
             Console.WriteLine("Ingrese la nota de actividad en clase del segundo parcial");
             nota.Ac2P = float.Parse(Console.ReadLine());
             Console.WriteLine("Ingrese la nota de practicas del segundo parcial");
             nota.Pr2P = float.Parse(Console.ReadLine());;
             Console.WriteLine("Ingrese la nota de trabajo autonomo del segundo parcial");
             nota.Ta2P = float.Parse(Console.ReadLine());
             Console.WriteLine("Ingrese la nota de evaluacion final del segundo parcial");
             nota.Ef2P = float.Parse(Console.ReadLine());
             if (nota.Suma < 14)
             {
                 Console.WriteLine("Ingrese la nota de recuperacion");
                 nota.Recuperacion = float.Parse(Console.ReadLine());
             }
             Console.WriteLine("Su promedio es: " + nota.Final);
             Console.WriteLine("Usted esta: " + nota.Estado);
             Console.ReadKey();/*
            String[] numeropalabras;
            String nombre;
            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();
            numeropalabras = nombre.Split(' ');
            Console.WriteLine(numeropalabras.Length);
            Console.ReadKey();*/
                

    }
    }
}
