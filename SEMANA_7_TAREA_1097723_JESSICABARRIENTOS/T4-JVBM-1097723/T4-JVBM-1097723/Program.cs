class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Tarea 1: calculadora de fórmulas de movimiento rectilíneo");

        Console.WriteLine("Con el siguiente programa calculará la variable faltante de la fórmula Vf=Vo + at");

        Console.WriteLine("Ingrese un valor para la velocidad final, en caso de desconocerla coloque NA: ");
        string numero1 = Console.ReadLine();
        double VF=0;

        if (numero1 != "NA")
        {
          VF = Convert.ToDouble(numero1);
        }
       
        Console.WriteLine("Ingrese un valor para la velocidad inicial, en caso de desconocerla coloque NA: ");
        string numero2 = Console.ReadLine();
        double VO=0;

        if (numero2 != "NA")
        {
            VO = Convert.ToDouble(numero2);
        }

        Console.WriteLine("Ingrese un valor para la aceleración, en caso de desconocerla coloque NA: ");
        string numero3 = Console.ReadLine();
        double AC=0;

        if (numero3 != "NA")
        {
            AC = Convert.ToDouble(numero3);
        }

        Console.WriteLine("Ingrese un valor para el tiempo, en caso de desconocerla coloque NA: ");
        string numero4 = Console.ReadLine();
        double TIEM = 0;

        if (numero4 != "NA")
        {
            TIEM = Convert.ToDouble(numero4);
        }

        double respuesta1 = VO + AC * TIEM;

        double respuesta2 = VF - (AC * TIEM);

        double respuesta3 = (VF - VO) / TIEM;

        double respuesta4 = (VF - VO) / AC;

        if (numero1 == "NA" && numero2 == "NA" && numero3 == "NA" && numero4 == "NA") 
        {
            Console.WriteLine("Debe ingresar mínimo tres variables");
        }
        else if (numero1 == "NA")
        {
            Console.WriteLine("La respuesta a la velocidad final es: " + respuesta1);
        }
        else if (numero2 == "NA")
        {
            Console.WriteLine("La respuesta a la velocidad inicial es: " + respuesta2);
        }
        else if (numero3 == "NA")
        {
            Console.WriteLine("La respuesta a la aceleración es: " + respuesta3);
        }
        else if (numero4 == "NA")
        {
            Console.WriteLine("La respuesta al tiempo es: " + respuesta4);
        }
        else
        {
            Console.WriteLine("Debe ingresar únicamente tres valores");
        }

        Console.WriteLine("Fin del programa");
    }
}
