using System;

class Program
{
    static void Main()
    {
        decimal totalGasto = 0;
        int tiempoTotalViajando = 0;
        int estacionPartida = 0; 
        bool primerViaje = true; 

        Console.WriteLine("Bienvenido al sistema de Trasmetro.");
        Console.WriteLine("\nPrevio a comenzar, le recordamos las opciones de las rutas: ");
        Console.WriteLine("Estación Javier: 51");
        Console.WriteLine("Estación Trébol: 61");
        Console.WriteLine("Estación Don Bosco: 71");
        Console.WriteLine("Estación Plaza Municipal: 82");

        do
        {
            int estacionDestino;
            int edad;
            bool estaEmbarazada;
            bool viajaConNino;

            Console.WriteLine("\nPor favor, ingrese los detalles de su viaje:");

            if (primerViaje)
            {
                Console.Write("Código de la estación de partida: ");
                estacionPartida = int.Parse(Console.ReadLine());
                primerViaje = false;
            }

            Console.Write("Código de la estación de destino: ");
            estacionDestino = int.Parse(Console.ReadLine());

            if (!ExisteRuta(estacionPartida, estacionDestino))
            {
                Console.WriteLine("Lo siento, no existe una ruta válida para los destinos ingresados.");
                continue;
            }

            Console.Write("Fecha de viaje (dd/mm/yyyy): ");
            DateTime fechaViaje = DateTime.Parse(Console.ReadLine());

            Console.Write("Edad: ");
            edad = int.Parse(Console.ReadLine());

            Console.Write("¿Está embarazada? (Sí/No): ");
            estaEmbarazada = Console.ReadLine().Equals("Sí", StringComparison.OrdinalIgnoreCase);

            Console.Write("¿Viaja con un niño menor de 3 años? (Sí/No): ");
            viajaConNino = Console.ReadLine().Equals("Sí", StringComparison.OrdinalIgnoreCase);

            int distancia = CalcularDistancia(estacionPartida, estacionDestino);
            decimal precio = CalcularPrecio(distancia, edad, estaEmbarazada, viajaConNino);
            int tiempoViaje = CalcularTiempoViaje(distancia);

            totalGasto += precio;
            tiempoTotalViajando += tiempoViaje;

            Console.WriteLine("----- Resumen del Boleto -----");
            Console.WriteLine("Ruta: " + estacionPartida + " -> " + estacionDestino);
            Console.WriteLine("Distancia: " + distancia);
            Console.WriteLine("Tiempo estimado de viaje: " + tiempoViaje + " minutos");
            Console.WriteLine("Precio del boleto: Q" + precio);

            estacionPartida = estacionDestino;

            Console.Write("¿Desea realizar otro viaje? (Sí/No): ");
        } while (Console.ReadLine().Equals("Sí", StringComparison.OrdinalIgnoreCase));

        Console.WriteLine("----- Resumen General -----");
        Console.WriteLine("Tiempo total viajando: " + tiempoTotalViajando + " minutos");
        Console.WriteLine("Total gastado en boletos: Q" + totalGasto);
    }
static bool ExisteRuta(int estacionPartida, int estacionDestino)
    {
        int[,] rutas = {
            { 51, 61 }, { 51, 72 }, { 71, 82 }, { 61, 51 }, { 82, 51 }
        };

        for (int i = 0; i < rutas.GetLength(0); i++)
        {
            if ((rutas[i, 0] == estacionPartida && rutas[i, 1] == estacionDestino) ||
                (rutas[i, 0] == estacionDestino && rutas[i, 1] == estacionPartida))
            {
                return true;
            }
        }

        return false;
    }

    static int CalcularDistancia(int estacionPartida, int estacionDestino)
    {
        int[,] distancias = {
            { 51, 61, 14 }, { 51, 72, 28 }, { 71, 82, 13 }, { 61, 51, 7 }, { 82, 51, 21 }
        };

        for (int i = 0; i < distancias.GetLength(0); i++)
        {
            if ((distancias[i, 0] == estacionPartida && distancias[i, 1] == estacionDestino) ||
                (distancias[i, 0] == estacionDestino && distancias[i, 1] == estacionPartida))
            {
                return distancias[i, 2];
            }
        }

        return 0;
    }

    static decimal CalcularPrecio(int distancia, int edad, bool estaEmbarazada, bool viajaConNino)
    {
        decimal precioBase = 0.07m;
        if (distancia > 10)
        {
            decimal kmAdicionales = distancia - 10;
            precioBase = precioBase + (kmAdicionales * 0.02m);
        }

        if (estaEmbarazada || viajaConNino)
        {
            return 0;
        }
        else if (edad >= 15 && edad <= 25)
        {
            return (decimal)(precioBase * 0.79m);
        }
        else
        {
            return precioBase;
        }
    }

    static int CalcularTiempoViaje(int distancia)
    {
        int velocidad = 40;
        return distancia * 60 / velocidad;
    }
}