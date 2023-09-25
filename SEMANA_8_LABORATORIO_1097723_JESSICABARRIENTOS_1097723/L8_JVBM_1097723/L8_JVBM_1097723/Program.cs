class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Laboratorio semana 8");
        //Console.WriteLine("Ingrese un número");

        //int num = Convert.ToInt32(Console.ReadLine());

        //do
        //{
        //    Console.WriteLine("El numero ingresado es: " + num);
        //    Console.WriteLine("\nIngrese otro número");

        //    num = Convert.ToInt32(Console.ReadLine());
        //} while (num != 0);


        //    while (num != 0)
        //    {
        //        Console.WriteLine("El numero ingresado es: " + num);
        //        if (num>0)
        //        {
        //            Console.WriteLine("\nPositivo");
        //        }

        //        else if (num < 0)
        //        {
        //            Console.WriteLine("\nNegativo");
        //        }

        //        Console.WriteLine("\nIngrese otro número");
        //        num = Convert.ToInt32(Console.ReadLine());
        //    }
        //}


        Console.WriteLine("Laboratorio semana 8");
        Console.WriteLine("\nIngrese un número");

        int N = Convert.ToInt32(Console.ReadLine());
        int A = 0;
        int B = 1;
        int C = 0;
        int i = 2;
        string resultado = "";


        if (N > 0)
        {
            resultado = A.ToString();
 
            if (N >1)
            {
                resultado += B.ToString();

                while(i < N)
                {
                    C = A + B;
                    resultado += C.ToString();
                    A = B;
                    B = C;
                    i++;
                }
                Console.WriteLine("Resultado: " + resultado);
            }
            else
            {
                Console.WriteLine("Resultado: " +  resultado);
            }
        }
        else
        {
            Console.WriteLine("Resultado");
        }

    }
}
