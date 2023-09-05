using System;

namespace T1JVBM1097723L
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mi segundo programa");

            Console.WriteLine("Ingrese su nombre:");
            string sNombre = Console.ReadLine();

            Console.WriteLine("Ingrese su edad:");
            string sEdad = Console.ReadLine();

            Console.WriteLine("Ingrese su carrera:");
            string sCarrera = Console.ReadLine();

            Console.WriteLine("Ingrese su carné:");
            string sCarne = Console.ReadLine();


            Console.WriteLine("Mi segundo programa");
            Console.WriteLine("Nombre: " + sNombre);
            Console.WriteLine("Edad: " + sEdad);
            Console.WriteLine("Carrera: " + sCarrera);
            Console.WriteLine("Carné: " + sCarne);

            Console.Write("Soy " + sNombre);
            Console.Write(", tengo " + sEdad);
            Console.WriteLine(" años y estudio la carrera de " + sCarrera);

            Console.WriteLine("Mi número de carné es " + sCarne);

            Console.ReadKey();
        }
    }
}
