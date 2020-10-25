using System;

namespace propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a = new Alumno();
            a.id = 0405199500389;
            a.nombre = "Moises";
            a.apellido = "Orellana";

            Alumno b = new Alumno();
            a.id = 0405199600398;
            a.nombre = "Carlos";
            a.apellido = "Galamez";

            Alumno c = new Alumno(0402189700458);
            b.nombre = "Oscar";
            b.apellido = "Melgar";

            Console.WriteLine(a.id);
            Console.WriteLine(b.id);
            Console.WriteLine(c.id);
        }
    }
}
