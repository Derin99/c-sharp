public class Usuarios
{
    public int PIN { get; set; }
    public string? Nombre { get; set; }
    public string? Telefono { get; set; }
    public string? NoCuenta { get; set; }
    public double Saldo { get; set; }

    public Usuarios(int pin, string nombre, string telefono, string noCuenta, double saldo)
    {
        PIN = pin;
        Nombre = nombre;
        Telefono = telefono;
        NoCuenta = noCuenta;
        Saldo = saldo;
    }
}