using System;

class Program
{
    static void Main(string[] args)
    {
        Circulo objCirculo;

        Console.WriteLine("Ingrese el radio del círculo: ");
        double r = Convert.ToDouble(Console.ReadLine());
        objCirculo = new Circulo(r);

        double perimetro = 0;
        double area = 0;
        double volumen = 0;

        objCirculo.CalcularGeometria(ref perimetro, ref area, ref volumen);

        Console.WriteLine("Perímetro del círculo: " + perimetro + " cm");
        Console.WriteLine("Área del círculo: " + area + " cm^2");
        Console.WriteLine("Volumen del círculo: " + volumen + " cm^3");
    }

        //    Calculadora calc= new Calculadora();

        //    Console.WriteLine("Semana 12- Funciones y procedimientos");
        //    Console.WriteLine("Ingrese un número: ");
        //    int num1 = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Ingrese otro número: ");
        //    int num2 = Convert.ToInt32(Console.ReadLine());

        //    int suma = cal.suma(num1, num2);
        //    Console.WriteLine("Suma: " + num1 + " + " + num2 + " = " + suma);
        //    cal.resta(num1, num2);

        //    //int resultado_suma = suma(num1, num2);
        //    //Console.WriteLine("Suma: " + num1 + " + " + num2 + " = " + resultado_suma);
        //    //resta(num1, num2);
        //    Console.ReadKey();


        //}
        ////función para sumar
        //static int suma(int a, int b)
        //{
        //    return a + b;
        //}

        //static double pi()
        //{
        //    return 3.1415;
        //}


        ////procedimiento para restar
        //static void resta(int a, int b)
        //{
        //    int resta = a - b;
        //    Console.WriteLine("Resta: " + a + " - " + b + " = " + resta);


        //}

        ////creación clase Calculadora

        //public class Calculadora
        //{
        //    //atributos

        //    public int dato1 { get; set; }

        //    public Calculadora()
        //    {
        //        //definiendo datos por defecto
        //        this.dato1 = 0;
        //    }

        //    //función para sumar
        //    public int suma(int a, int b)
        //    {
        //        return a + b;
        //    }

        //    //procedimiento para restar
        //    public void resta(int a, int b)
        //    {
        //        int resta = a - b;
        //        Console.WriteLine("Resta: " + a + " - " + b + " = " + resta);
        //    }

        public class Circulo
    {
        //atributos

        private double radio { get; set; }

        public Circulo(double r)
        {
            //definiendo datos por defecto
            this.radio = r;
        }

        //función perímetro
        private double ObtenerPerimetro(double r)
        {
            return 2 * Math.PI * r;
        }

        //función área
        private double ObtenerArea(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }

        //función volumen
        private double ObtenerVolumen(double r)
        {
            return (4 * Math.PI * Math.Pow(r,  3) / 3);
        }

        //procedimiento para Calcular Geometría
        public void CalcularGeometria(ref double unPerimetro, ref double unArea, ref double unVolumen)
        {
            unPerimetro = ObtenerPerimetro(radio);

            unArea = ObtenerArea(radio);

            unVolumen = ObtenerVolumen(radio);
        }
    }
}
