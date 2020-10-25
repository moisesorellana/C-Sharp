public class Alumno
{
    public double id { get; set;}

    public string nombre { get; set;}

    public string apellido { get; set;}


    public bool Activo {get; set;}


       public Alumno(double ID, string Nombre, string Apellido)
    {
        nombre = Nombre;
        apellido = Apellido;
        id = ID;
    }


    public string nombrecompleto()
    {
        if(Activo == true)
        {
            return nombre + " " + apellido;
        }
       return "Alumno Inactivo";
    }


    public void inactivarAlumno()
    {
        Activo = false;
    }

     public void activarAlumno()
    {
        Activo = true;
    }
}
