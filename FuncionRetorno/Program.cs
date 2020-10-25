using System;

namespace propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a = new Alumno(0405199500389, "Moises", "Orellana");
            
            Alumno b = new Alumno(0405199600289, "Carlos", "Galdamez");
            
            Alumno c = new Alumno(0402189700458, "Oscar", "Melgar");
            
            Alumno d = new Alumno(040285690215, "Alfredo", "Castro");

            Console.WriteLine(a.id + "  " +  a.nombrecompleto());
            Console.WriteLine(b.id + "  " +  b.nombrecompleto());
            Console.WriteLine(c.id + "  " +  c.nombrecompleto());
            Console.WriteLine(d.id + "  " +  d.nombrecompleto());
        }
    }
}

