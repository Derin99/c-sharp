public class Vendedor
{
    public int Codigo { get; set; }
    public string Nombre { get; set; }
    public string CodigoVendedor { get; set; }

    public Vendedor(int codigo, string nombre, string codigoVendedor)
    {
        Codigo = codigo;
        Nombre = nombre;
        CodigoVendedor = codigoVendedor;
    }
}