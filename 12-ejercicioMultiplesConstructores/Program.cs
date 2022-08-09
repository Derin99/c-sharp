using System;

namespace propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a = new Alumno();
            a.primerNombre = "Juan";
            a.segundoNombre = "Perez";

            Alumno b = new Alumno();
            b.id = 2;
            b.primerNombre = "Maria";
            b.segundoNombre = "Martinez";

            Alumno c = new Alumno(3);
            b.primerNombre = "Pedro";

            Alumno d = new Alumno("Juan", "Jimenez");


            Console.WriteLine(a.primerNombre);
        }
    }
}