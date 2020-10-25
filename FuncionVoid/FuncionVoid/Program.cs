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
            
            Alumno d = new Alumno(0402856902158, "Alfredo", "Castro");

            a.inactivarAlumno();
            b.inactivarAlumno();
            c.inactivarAlumno();
            d.inactivarAlumno();

            

            Console.WriteLine(a.id + "|  " +  a.nombrecompleto());
            Console.WriteLine(b.id + "|  " +  b.nombrecompleto());
            Console.WriteLine(c.id + "|  " +  c.nombrecompleto());
            Console.WriteLine(d.id + "|  " +  d.nombrecompleto());

            Console.WriteLine("                                ");



            a.activarAlumno();
            b.activarAlumno();
            c.activarAlumno();
            d.activarAlumno();
            
            
            Console.WriteLine(a.id + " | " +  a.nombrecompleto());
            Console.WriteLine(b.id + " |" +  b.nombrecompleto());
            Console.WriteLine(c.id + " | " +  c.nombrecompleto());
            Console.WriteLine(d.id + " | " +  d.nombrecompleto());


            Console.WriteLine("                                ");

        }
    }
}
