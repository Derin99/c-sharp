using System;

namespace Ordenes
{
    class Program
    {
        static void Main(string[] args)
        {
            DatosDePrueba datos = new DatosDePrueba();
            string opcion = "";

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Sistema de Ordenes");
                Console.WriteLine("==================");
                Console.WriteLine("");
                Console.WriteLine("1 - Lista de Productos");
                Console.WriteLine("2 - Crear Orden");
                Console.WriteLine("3 - Lista de Clientes");
                Console.WriteLine("4 - Lista de Vendedores");
                Console.WriteLine("5 - Lista de Ordenes");
                Console.WriteLine("0 - Salir");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                    datos.ListarProductos();
                        break;
                    default:
                        break;
                }

                if (opcion == "0") {
                    break;
                }
            }
        }
    }
}