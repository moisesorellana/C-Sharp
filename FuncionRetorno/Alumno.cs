public class Alumno
{
    public double id { get; set;}

    public string nombre { get; set;}

    public string apellido { get; set;}


       public Alumno(double ID, string Nombre, string Apellido)
    {
        nombre = Nombre;
        apellido = Apellido;
        id = ID;
        Activo = true;
    }


    public string nombrecompleto()
    {
       return nombre + "" + apellido;
    }


    public void InactivarAlumno()
}
