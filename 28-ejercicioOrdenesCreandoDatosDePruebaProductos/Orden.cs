using System;
public class Orden
{
    public int Codigo { get; set; }
    public DateTime Fecha { get; set; }
    public string NumeroDeOrden { get; set; }
    public Cliente Cliente { get; set; }
    public Vendedor Vendedor { get; set; }

    public Orden(int codigo, DateTime fecha, string numeroDeOrden, Cliente cliente, Vendedor vendedor)
    {
        Codigo = codigo;
        Fecha = fecha;
        NumeroDeOrden = numeroDeOrden;
        Cliente = cliente;
        Vendedor = vendedor;
    }
}