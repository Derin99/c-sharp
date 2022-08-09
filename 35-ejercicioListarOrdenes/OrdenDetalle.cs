public class OrdenDetalle
{
    public int Codigo { get; set; }
    public int Cantidad { get; set; }
    public double Precio { get; set; }
    public Producto Producto { get; set; }

    public OrdenDetalle(int codigo, int cantidad, double precio, Producto producto)
    {
        Codigo = codigo;
        Cantidad = cantidad;
        Precio = producto.Precio;
        Producto = producto;
    }
}