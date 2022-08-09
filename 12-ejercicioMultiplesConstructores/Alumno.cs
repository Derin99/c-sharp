public class Alumno
{
    public int id{ get; set; }
    public string primerNombre{ get; set; }
    public string segundoNombre{ get; set; }

    public Alumno()
    {
        id = 1;
    }

    public Alumno(int Id)
    {
        id = Id;
    }

    public Alumno(string PrimerNombre, string SegundoNombre)
    {
        primerNombre = PrimerNombre;
        segundoNombre = SegundoNombre;
    }
}