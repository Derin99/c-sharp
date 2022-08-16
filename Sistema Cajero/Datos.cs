using System;
using System.Collections.Generic;

public class Datos
{
    public List<Usuarios> ListadeUsuarios { get; set; }

    public Datos()
    {
        ListadeUsuarios = new List<Usuarios>();
        cargarUsuarios();
    }

    public void cargarUsuarios()
    {
        Usuarios u1 = new Usuarios(1, "Derin Orellana", "93683578", "001001", 5000);
        ListadeUsuarios.Add(u1);
        Usuarios u2 = new Usuarios(2, "Bily Fer", "98756423", "001002", 1000);
        ListadeUsuarios.Add(u2);
        Usuarios u3 = new Usuarios(3, "Alex Sabillon", "33250833", "001003", 1500);
        ListadeUsuarios.Add(u3);
        Usuarios u4 = new Usuarios(4, "Angie Bonilla", "92919495", "001004", 3450);
        ListadeUsuarios.Add(u4);
        Usuarios u5 = new Usuarios(5, "Oskar Maldonado", "33239845", "001005", 200);
        ListadeUsuarios.Add(u5);
    }
    
    public void ListarUsuarios()
    {
        Console.Clear();
        Console.WriteLine("****************************");
        Console.WriteLine("Lista de Usuarios Bancarios");
        Console.WriteLine("****************************");
        Console.WriteLine("");
        Console.WriteLine("No.Cuenta | Nombre | Telefono | Saldo ");
        Console.WriteLine("");
        
        foreach (var Usuarios in ListadeUsuarios)
        {
            Console.WriteLine(Usuarios.NoCuenta + " | " + Usuarios.Nombre + " | " + Usuarios.Telefono + " | " + Usuarios.Saldo);
        }

        Console.ReadLine();
    }

    public void Deposito()
    {
        Console.Clear();
        Console.WriteLine("*****************");
        Console.WriteLine("Deposito Bancario");
        Console.WriteLine("*****************");
        Console.WriteLine("");
        
        Console.WriteLine("Ingrese Su PIN: ");
        Console.WriteLine("");
        int pin = Convert.ToInt32(Console.ReadLine());
        Usuarios usuarios = ListadeUsuarios.Find(u => u.PIN == pin)!;
        if (usuarios == null)
        {
            Console.WriteLine("Cuenta Bancaria no encontrada");
            Console.ReadLine();
            Console.WriteLine("");
            return;
        } else
        {
            Console.WriteLine("Deposito a cuenta numero: " + usuarios.NoCuenta + "    Nombre del usuario: " + usuarios.Nombre);
            Console.WriteLine("");

            Console.WriteLine("Ingrese la cantidad que desea depositar: ");
            double deposito = Convert.ToDouble(Console.ReadLine());

            usuarios.Saldo += deposito;
            Console.WriteLine("Deposito realizado correctamente");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Su saldo actual es de: " + usuarios.Saldo);
            Console.WriteLine("");
            Console.ReadLine();
        }
    }

    public void Retiro()
    {
        Console.Clear();
        Console.WriteLine("***************");
        Console.WriteLine("Retiro Bancario");
        Console.WriteLine("***************");
        Console.WriteLine("");
        
        Console.WriteLine("Ingrese Su PIN: ");
        Console.WriteLine("");
        int pin = Convert.ToInt32(Console.ReadLine());
        Usuarios usuarios = ListadeUsuarios.Find(u => u.PIN == pin)!;
        if (usuarios == null)
        {
            Console.WriteLine("Cuenta Bancaria no encontrada");
            Console.ReadLine();
            Console.WriteLine("");
            return;
        } else
        {
            Console.WriteLine("Retiro a cuenta numero: " + usuarios.NoCuenta + "    Nombre del usuario: " + usuarios.Nombre);
            Console.WriteLine("");

            Console.WriteLine("Ingrese la cantidad que desea retirar: ");
            double retiro = Convert.ToDouble(Console.ReadLine());
            if (retiro > usuarios.Saldo)
            {
                Console.WriteLine("No se puede realizar el retiro");
                Console.WriteLine("Su saldo es insuficiente");
                Console.ReadLine();
            } else
            {
                usuarios.Saldo -= retiro;
                Console.WriteLine("Retiro realizado correctamente");
                Console.WriteLine("");
                Console.WriteLine("Su saldo actual es de: " + usuarios.Saldo);
                Console.ReadLine();
            }
        }   
    }

    public void Transferencia()
    {
        Console.Clear();
        Console.WriteLine("**********************");
        Console.WriteLine("Transferencia Bancaria");
        Console.WriteLine("**********************");
        Console.WriteLine("");
        
        Console.WriteLine("Ingrese Su PIN: ");
        Console.WriteLine("");
        int pin = Convert.ToInt32(Console.ReadLine());
        Usuarios usuarios = ListadeUsuarios.Find(u => u.PIN == pin)!;
        if (usuarios == null)
        {
            Console.WriteLine("Cuenta Bancaria no encontrada");
            Console.ReadLine();
            Console.WriteLine("");
            return;
        } else
        {
            Console.WriteLine("Ingrese el numero de la cuenta a la cual desea hacer la transferencia: ");
            Console.WriteLine("");
            string? noCuenta = Console.ReadLine();
            Usuarios usuarios2 = ListadeUsuarios.Find(u => u.NoCuenta == noCuenta)!;
            if (usuarios2 == null)
            {
                Console.WriteLine("Cuenta Bancaria no encontrada");
                Console.ReadLine();
                Console.WriteLine("");
                return;
            } else
            {
                Console.WriteLine("Transferencia de cuenta numero: " + usuarios.NoCuenta + "    Nombre del usuario: " + usuarios.Nombre);
                Console.WriteLine("");
                Console.WriteLine("Hacia la cuenta numero: " + usuarios2.NoCuenta + "    Nombre del usuario: " + usuarios2.Nombre);
                Console.WriteLine("");

                Console.WriteLine("Ingrese la cantidad que desea transferir: ");
                Console.WriteLine("");
                double transferencia = Convert.ToDouble(Console.ReadLine());
                if (transferencia > usuarios.Saldo)
                {
                    Console.WriteLine("No se puede realizar la transferencia");
                    Console.WriteLine("Su saldo es insuficiente");
                    Console.ReadLine();
                } else
                {
                    usuarios.Saldo -= transferencia;
                    usuarios2.Saldo += transferencia;
                    Console.WriteLine("Transferencia realizada correctamente");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Su saldo actual es de: " + usuarios.Saldo);
                    Console.ReadLine();
                    Console.WriteLine("");
                }
            }
        }
    }
}