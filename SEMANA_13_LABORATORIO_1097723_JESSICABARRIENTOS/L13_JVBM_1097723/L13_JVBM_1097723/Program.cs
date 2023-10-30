
internal class Program
{
    static void Main(string[] args)
    {
        //    //Declaración
        //    int[] vector = new int[5];
        //    string[] vector2 = new string[5];

        //    string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };

        //    //Console.WriteLine(dias[0]);

        //    for(int i = 0; i< dias.Length; i++)
        //    {
        //        Console.WriteLine(dias[i]);
        //    }
        //    Console.ReadKey();

        Console.WriteLine("Primera parte");
        int[] vector = new int[8];
        int nota = 0;
        double promedio = 0;
        int suma = 0;
        int Max = 0;

        for (int i = 0; i < vector.Length; i++)
        {
            Console.WriteLine("Ingresar notas: ");
            nota = int.Parse(Console.ReadLine());
            vector[i] = nota;
            suma += vector[i];

            if (vector[i] > Max)
            {
                Max = vector[i];

            }
        }

        promedio = suma / vector.Length;
        Console.WriteLine("Promedio: " + promedio);
        Console.WriteLine("Nota más alta: " + Max);

        Console.WriteLine("Segunda parte");

        string palabra;
        string letra;
        int cont = 0;

        Console.WriteLine("Escriba una palabra para su análisis");
        palabra = Console.ReadLine();

        Console.WriteLine("Escriba una letra para su análisis");
        letra = Console.ReadLine();


        string[] vector_palabra = new string[palabra.Length];

        for (int i = 0; i < palabra.Length; i++)
        {
            vector_palabra[i] = palabra[i].ToString();
        }

        for (int i = 0; i < vector_palabra.Length; i++)
        {
            if (vector_palabra[i].Equals(letra))
            {
                cont++;
            }
        }
        Console.WriteLine("Número de letras: " + cont);
        if(cont > 0)
        {
            Console.WriteLine("la letra fue encontrada.");
        }
        else
        {
            Console.WriteLine("La letra no fue encontrada.");
        }


        Console.ReadKey();
    }
}

