public class Alumno
{
    public double id { get; set;}

    public string nombre { get; set;}

    public string apellido { get; set;}


    public Alumno()
    {
        id = 0405199500389;
    }


    public Alumno(double i)
    {
        id = i;
    }

    public Alumno(string Nombre, string Apellido)
    {
        nombre = Nombre;
        apellido = Apellido;
    }
}
