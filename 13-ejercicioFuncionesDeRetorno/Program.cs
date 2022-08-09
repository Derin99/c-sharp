using System;

namespace propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
           Alumno a = new Alumno(1, "Juan", "Perez");

            Console.Writeline(a.nombreCompleto());
        }
    }
}