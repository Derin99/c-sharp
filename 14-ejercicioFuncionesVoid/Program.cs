﻿using System;

namespace propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
           Alumno a = new Alumno(1, "Juan", "Perez");
           Alumno b = new Alumno(2, "Maria", "Martinez");

           a.inactivarAlumno(); 

            Console.Writeline(a.nombreCompleto());
            Console.Writeline(b.nombreCompleto());

            a.ativarAlumno();

            Console.Writeline("");

            Console.Writeline(a.nombreCompleto());
            Console.Writeline(b.nombreCompleto());
        }
    }
}