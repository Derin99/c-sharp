using System;

namespace SistemaCajero
{
    class Program
    {
        static void Main(string[] args)
        {
            Datos datos = new Datos();
            string? opcion = "";

            while (true)
            {
                Console.Clear();
                Console.WriteLine("****************************");
                Console.WriteLine("BIENVENIDO AL CAJERO VIRTUAL");
                Console.WriteLine("****************************");
                Console.WriteLine("");

                Console.WriteLine("Seleccione la opcion a realizar:");
                Console.WriteLine("");
                Console.WriteLine("1. Listado de Cuentas");
                Console.WriteLine("2. Deposito");
                Console.WriteLine("3. Retiro");
                Console.WriteLine("4. Transferencia");
                Console.WriteLine("0. Salir");
                Console.WriteLine("");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        datos.ListarUsuarios();
                        break;
                    case "2":
                        datos.Deposito();
                        break;
                    case "3":
                        datos.Retiro();
                        break;                                         
                    case "4":
                        datos.Transferencia();
                        break;                                         
                    case "0":
                        
                        break;                                         
                    default:
                        Console.WriteLine("Seleccione una opcion valida");
                        Console.ReadLine();
                        break;
                }

                if (opcion == "0")
                {
                    Console.Clear();
                    break;
                }
            }
        }
    }
}