using System;

class Dados
{
    static void Main(string[] args)
    {
        //Jessica Barrientos- 1097723

        Console.WriteLine("¡Bienvenido al juego de dados! Las reglas son las siguientes:");
        Console.WriteLine("Si la suma de los dados es 12 o 6 en el primer tiro, el jugador gana 12 puntos");
        Console.WriteLine("Si la suma es 4 o 10 de la primera tirada el jugador pierde y la 'Casa gana' 12 puntos.");
        Console.WriteLine("Si la suma es 2, 3, 5, 7, 8 o 9 en el tiro, la suma es el puntaje del jugador o la 'Casa'.");
        Console.WriteLine("Un jugador pierde si la suma tira un 11 antes de haber ganado un punto, y la 'Casa' gana 6 puntos.");

        Console.WriteLine("\nIngrese la cantidad de partidas: ");
        int totalPartidas = int.Parse(Console.ReadLine());

        int tirosPartida;

        do
        {
            Console.Write("Ingrese la cantidad de tiros por partida. Recuerde que deben ser valores pares: ");
            tirosPartida = int.Parse(Console.ReadLine());

            if (tirosPartida % 2 != 0)
            {
                Console.WriteLine("Error: La cantidad de tiros por partida debe ser un número par. Intente nuevamente.");
            }
        } while (tirosPartida % 2 != 0);

        Dados juego = new Dados();
        juego.Jugar(totalPartidas, tirosPartida);
        juego.MostrarResultadosFinales(totalPartidas);
    }

    private Random random;
    private int jugadorPuntos;
    private int casaPuntos;
    private int jugadorPuntosFinal;
    private int casaPuntosFinal;
    private int tirosGanadosJugador;
    private int tirosGanadosCasa;
    private int tirosPares;
    private int tirosImpares;
    private int tirosIguales;
    private int partidasGanadasJugador;
    private int partidasGanadasCasa;

    public Dados()
    {
        random = new Random();
        jugadorPuntos = 0;
        casaPuntos = 0;
        jugadorPuntosFinal = 0;
        casaPuntosFinal = 0;
        tirosGanadosJugador = 0;
        tirosGanadosCasa = 0;
        tirosPares = 0;
        tirosImpares = 0;
        tirosIguales = 0;
        partidasGanadasJugador = 0;
        partidasGanadasCasa = 0;
    }

    public void Jugar(int totalPartidas, int tirosPartida)
    {
        for (int partida = 1; partida <= totalPartidas; partida++)
        {
            Console.WriteLine("\nPARTIDA # " + partida);
            JugarPartida(tirosPartida);
            MostrarResultados(partida, tirosPartida);
        }
    }

    private void JugarPartida(int tirosPartida)
    {
        int tirosJugador = tirosPartida / 2;

        for (int tiro = 1; tiro <= tirosPartida; tiro++)
        {
            string jugador;
            if (tiro <= tirosJugador)
            {
                jugador = "\nJUGADOR: ";
            }
            else
            {
                jugador = "\nCASA: ";
            }
            Console.Write(jugador);
            int dado1 = random.Next(1, 7);
            int dado2 = random.Next(1, 7);
            int sumaDados = dado1 + dado2;
            int sumaDados2 = dado1 + dado2;

            Console.Write("Tiro " + tiro + ": Dado 1 = " + dado1 + ", Dado 2 = " + dado2);

            if (tiro <= tirosJugador)
            {
                TiroJugador(sumaDados, tiro);
            }

            else
            {
                TiroCasa(sumaDados2, tiro);
            }

            Tiro(dado1, dado2);

        }
    }

    private void TiroJugador(int sumaDados, int tiro)
    {

        switch (sumaDados)
        {
            case 12:
            case 6:
                if (tiro == 1)
                {
                    jugadorPuntos += 12;
                    tirosGanadosJugador++;
                    jugadorPuntosFinal += 12;
                }
                break;
            case 4:
            case 10:
                if (tiro == 1)
                {
                    casaPuntos += 12;
                    casaPuntosFinal += 12;
                    tirosGanadosCasa++;
                }
                break;
            case 2:
            case 3:
            case 5:
            case 7:
            case 8:
            case 9:
                jugadorPuntos += sumaDados;
                tirosGanadosJugador++;
                jugadorPuntosFinal += sumaDados;
                break;
            case 11:
                if (tirosGanadosJugador == 0)
                {
                    casaPuntos += 6;
                    tirosGanadosCasa++;
                    casaPuntosFinal += 6;
                }
                break;
        }
    }

    private void TiroCasa(int sumaDados2, int tiro)
    {
        switch (sumaDados2)
        {
            case 4:
            case 10:
                if (tiro == 1)
                {
                    casaPuntos += 12;
                    tirosGanadosCasa++;
                    casaPuntosFinal += 12;
                }
                break;
            case 2:
            case 3:
            case 5:
            case 7:
            case 8:
            case 9:
                casaPuntos += sumaDados2;
                tirosGanadosCasa++;
                casaPuntosFinal += sumaDados2;
                break;
            case 11:
                if (tirosGanadosJugador == 0)
                {
                    casaPuntos += 6;
                    tirosGanadosCasa++;
                    casaPuntosFinal += 6;
                }
                break;
        }   
    }
    
    private void Tiro(int dado1, int dado2)
    {
        if ((dado1 + dado2) % 2 == 0)
        {
            tirosPares++;
        }
        else if ((dado1 + dado2) % 2 != 0)
        {
            tirosImpares++;
        }

        if (dado1 == dado2)
        {
            tirosIguales++;
        }
    }
    private void MostrarResultados(int totalPartidas, int tirosPartida)
    {
        Console.WriteLine("\n----Resultados de la partida----");
        string ganador;
        if (jugadorPuntos > casaPuntos)
        {
            ganador = "JUGADOR";
            partidasGanadasJugador++;
        }
        else if (casaPuntos > jugadorPuntos)
        {
            ganador = "CASA";
            partidasGanadasCasa++;
        }
        else
        {
            ganador = "EMPATE";
        }
        Console.WriteLine("Ganador de la partida: " + ganador);
        Console.WriteLine("Puntos del jugador: " + jugadorPuntos);
        Console.WriteLine("Puntos de la casa: " + casaPuntos);
        Console.WriteLine("Tiros ganados por el jugador: " + tirosGanadosJugador);
        Console.WriteLine("Tiros ganados por la casa: " + tirosGanadosCasa);
        double probabilidadDeGanar = (double)tirosGanadosJugador / tirosPartida;
        double probabilidadDeGanarporcentaje = probabilidadDeGanar * 100;
        probabilidadDeGanarporcentaje = Math.Round(probabilidadDeGanarporcentaje, 2);
        Console.WriteLine("Probabilidad de ganar en esta partida: " + probabilidadDeGanarporcentaje + "%");
        Console.WriteLine("Tiros con números pares: " + tirosPares);
        Console.WriteLine("Tiros con números impares: " + tirosImpares);
        Console.WriteLine("Tiros con números iguales en ambos dados: " + tirosIguales);

        jugadorPuntos = 0;
        casaPuntos = 0;
        tirosGanadosJugador = 0;
        tirosGanadosCasa = 0;
        tirosPares = 0;
        tirosImpares = 0;
        tirosIguales = 0;
    }

    public void MostrarResultadosFinales(int totalPartidas)
    {
        Console.WriteLine("\n----RESULTADOS FINALES----");
        string ganador;
        if (partidasGanadasJugador > partidasGanadasCasa)
        {
            ganador = "El jugador";
        }
        else if (partidasGanadasJugador < partidasGanadasCasa)
        {
            ganador = "La casa";
        }
        else
        {
            ganador = "Empate";
        }
        Console.WriteLine("Ganador del juego: " + ganador);
        Console.WriteLine("Puntos totales ganados por el jugador: " + jugadorPuntosFinal);
        Console.WriteLine("Puntos totales ganados por la casa: " + casaPuntosFinal);
    }
}
