class Program
{
    static void Main()
    {
        Console.WriteLine("Ejercicio No. 1");
        Console.WriteLine("Ingrese número");
        int numero = Convert.ToInt32((Console.ReadLine()));
        int contador = 1;
        int sumatoria = 0;

        while (contador <= numero)
        {
            sumatoria = sumatoria + contador;
            contador++;
        }
        Console.WriteLine("La sumatoria de los números es igual a: " + sumatoria);

        Console.WriteLine("Ejercicio No. 2");

        for (int i = 1; i <= 10; i++)
        {
            Console.Write("\nTabla del " + i + ":\t");
            for (int j = 1; j <= numero; j++)
            {
                Console.Write(i * j + "\t");
            }
        }
        Console.ReadLine();
    }
}