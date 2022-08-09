using System;
using System.Collections.Generic;

public class DatosDePrueba
{
    public List<Producto> ListadeProductos { get; set; }

    public DatosDePrueba()
    {
        ListadeProductos = new List<Producto>();
        cargarProductos();
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
}

