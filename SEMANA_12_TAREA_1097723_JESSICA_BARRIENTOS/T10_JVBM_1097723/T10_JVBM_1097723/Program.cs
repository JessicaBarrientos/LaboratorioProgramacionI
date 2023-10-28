using System;

class Program
{
    //Tarea semana 12: Siguiendo con las indicaciones, al proyecto anterior se le agregó una nueva clase
    //con sus indicaciones y códigos pertinentes.
    static void Main(string[] args)
    {
        Circulo objCirculo;

        Console.WriteLine("Ingrese el radio del círculo en centímetros: ");
        double r = Convert.ToDouble(Console.ReadLine());
        objCirculo = new Circulo(r);

        double perimetro = 0;
        double area = 0;
        double volumen = 0;

        objCirculo.CalcularGeometria(ref perimetro, ref area, ref volumen);

        Console.WriteLine("Perímetro del círculo: " + perimetro + " cm");
        Console.WriteLine("Área del círculo: " + area + " cm^2");
        Console.WriteLine("Volumen del círculo: " + volumen + " cm^3");

        TrianguloRectangulo objTriangulo;
        Console.WriteLine("Tarea semana 2. Ingrese los datos sobre un triángulo.");
        Console.WriteLine("Ingrese la longitud del cateto A en metros: ");
        double catetoA = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese la longitud del ángulo opuesto de A en grados: ");
        double anguloOpuestoA = Convert.ToDouble(Console.ReadLine());
        objTriangulo = new TrianguloRectangulo(catetoA, anguloOpuestoA);

        Console.WriteLine("Resultados:");
        Console.WriteLine("Valor de cateto A: " + objTriangulo.ObtenerCatetoA() + " m");
        Console.WriteLine("Valor de cateto B: " + objTriangulo.ObtenerCatetoB() + " m");
        Console.WriteLine("Valor de hipotenusa: " + objTriangulo.ObtenerHipotenusa() + " m");
        Console.WriteLine("Valor de ángulo opuesto de A: " + objTriangulo.ObtenerAnguloOpuestoA() + " grados");
        Console.WriteLine("Valor de ángulo opuesto de B: " + objTriangulo.ObtenerAnguloOpuestoB() + " grados");
        Console.WriteLine("Valor de área: " + objTriangulo.ObtenerArea() + " m^2");
    }
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
           double perimetro = 2 * Math.PI * r;
            return Math.Round(perimetro, 3);
        }

        //función área
        private double ObtenerArea(double r)
        {
            double area = Math.PI * Math.Pow(r, 2);
            return Math.Round(area, 3);
        }

        //función volumen
        private double ObtenerVolumen(double r)
        {
            double volumen = (4 * Math.PI * Math.Pow(r, 3) / 3);
            return Math.Round(volumen, 3);

        }

        //procedimiento para Calcular Geometría
        public void CalcularGeometria(ref double unPerimetro, ref double unArea, ref double unVolumen)
        {
            unPerimetro = ObtenerPerimetro(radio);

            unArea = ObtenerArea(radio);

            unVolumen = ObtenerVolumen(radio);
        }
    }

    public class TrianguloRectangulo
    {
        //atributos
        private double catetoA { get; set; }

        private double anguloOpuestoA { get; set; }

        public TrianguloRectangulo()
        {
            catetoA = 0;
            anguloOpuestoA = 0;
        }

        public TrianguloRectangulo(double catetoA, double anguloOpuestoA)
        {
            //definiendo datos por defecto
            this.catetoA = catetoA;
            this.anguloOpuestoA = anguloOpuestoA;
        }

        //función CatetoA
        public double ObtenerCatetoA()
        {
            return catetoA;
        }

        //función CatetoB
        public double ObtenerCatetoB()
        {
            double catetoB = catetoA / Math.Tan(anguloOpuestoA * Math.PI / 180.0);
            return Math.Round(catetoB, 3);
        }

        //función Hipotenusa
        public double ObtenerHipotenusa()
        {
            double catetoB = ObtenerCatetoB();
            double hipotenusa = Math.Sqrt(catetoA * catetoA + catetoB * catetoB);
            return Math.Round(hipotenusa, 3);
        }

        //función Obtener ángulo opuesto A
        public double ObtenerAnguloOpuestoA()
        {
            return anguloOpuestoA;
        }

        //función Obtener ángulo opuesto B
        public double ObtenerAnguloOpuestoB()
        {
            return 90 - anguloOpuestoA;
        }

        //función Obtener área
        public double ObtenerArea()
        {
            double catetoB = ObtenerCatetoB();
            double area = 0.5 * catetoA * catetoB;
            return Math.Round(area, 3);
        }
    }
}
