using System;
using System.Collections.Generic;

public class DatosDePrueba
{
    public List<Producto> ListadeProductos { get; set; }
    public List<Cliente> ListadeClientes { get; set; }
    public List<Vendedor> ListadeVendedores { get; set; }
    public List<Orden> ListaOrdenes { get; set; }

    public DatosDePrueba()
    {
        ListadeProductos = new List<Producto>();
        cargarProductos();

        ListadeClientes = new List<Cliente>();
        cargarClientes();

        ListadeVendedores = new List<Vendedor>();
        cargarVendedores();

        ListaOrdenes = new List<Orden>();
    }

    private void cargarProductos()
    {
        Producto p1 = new Producto(1, "Mouse", 250);
        ListadeProductos.Add(p1);
        
        Producto p2 = new Producto(2, "Monitor", 350);
        ListadeProductos.Add(p2);
        
        Producto p3 = new Producto(3, "Teclado", 4000);
        ListadeProductos.Add(p3);
    }

    private void cargarClientes()
    {
        Cliente c1 = new Cliente(1, "Juan", "77777");
        ListadeClientes.Add(c1);

        Cliente c2 = new Cliente(2, "Pedro", "99999");
        ListadeClientes.Add(c2);
    }

    private void cargarVendedores()
    {
        Vendedor v1 = new Vendedor(1, "Jose", "V001");
        ListadeVendedores.Add(v1);

        Vendedor v2 = new Vendedor(2, "Pablo", "V002");
        ListadeVendedores.Add(v2);
    }

    public void ListarProductos()
    {
        foreach (var producto in ListadeProductos)
        {
            Console.Clear();
            Console.WriteLine("Lista De Productos");
            Console.WriteLine("==================");
            Console.WriteLine("");
            Console.WriteLine(producto.Codigo + " | " + producto.Descripcion + " | " + producto.Precio);
            Console.ReadLine();
        }
    }

    public void ListarClientes()
    {
        Console.Clear();
        Console.WriteLine("Lista de Clientes");
        Console.WriteLine("=================");
        Console.WriteLine("");
        
        foreach (var cliente in ListadeClientes)
        {
            Console.WriteLine(cliente.Codigo + " | " + cliente.Nombre + " | " + cliente.Telefono);
        }

        Console.ReadLine();
    }

    public void ListarVendedores()
    {
        Console.Clear();
        Console.WriteLine("Lista de Vendedores");
        Console.WriteLine("===================");
        Console.WriteLine("");
        
        foreach (var vendedor in ListadeVendedores)
        {
            Console.WriteLine(vendedor.Codigo + " | " + vendedor.Nombre + " | " + vendedor.CodigoVendedor);
        }

        Console.ReadLine();
    }

    public void CrearOrden(int codigoCliente, int CodigoVendedor)
    {
        Cliente cliente = ListadeClientes.Find(c => c.Codigo == codigoCliente);
        Vendedor vendedor = ListadeVendedores.Find(v => v.Codigo == codigoVendedor);

        Orden nuevaOrden = new Orden(1, DateTime.Now, "SPS001", cliente, vendedor);
        ListaOrdenes.Add(nuevaOrden);
    }

}

