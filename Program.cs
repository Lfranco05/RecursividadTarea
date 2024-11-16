using System;

class Laberinto
{
    public static bool HayCamino(int[][] laberinto, int filaInicial, int columnaInicial, int filaFinal, int columnaFinal)
    {
        if (filaInicial < 0 || filaInicial >= laberinto.Length ||
            columnaInicial < 0 || columnaInicial >= laberinto[0].Length ||
            laberinto[filaInicial][columnaInicial] == 1)
        {
            return false;
        }

        if (filaInicial == filaFinal && columnaInicial == columnaFinal)
        {
            return true;
        }

        laberinto[filaInicial][columnaInicial] = 1;

        if (HayCamino(laberinto, filaInicial - 1, columnaInicial, filaFinal, columnaFinal) || 
            HayCamino(laberinto, filaInicial + 1, columnaInicial, filaFinal, columnaFinal) || 
            HayCamino(laberinto, filaInicial, columnaInicial - 1, filaFinal, columnaFinal) || 
            HayCamino(laberinto, filaInicial, columnaInicial + 1, filaFinal, columnaFinal))  
        {
            return true;
        }

        laberinto[filaInicial][columnaInicial] = 0;

        return false;
    }

    static void Main(string[] args)
    {
        int[][] laberinto1 = new int[][] {
            new int[] { 0, 1, 0, 0, 0 },
            new int[] { 0, 1, 1, 1, 0 },
            new int[] { 0, 0, 0, 1, 0 },
            new int[] { 1, 1, 0, 1, 1 },
            new int[] { 0, 0, 0, 0, 0 }
        };

        Console.WriteLine(HayCamino(laberinto1, 0, 0, 4, 4) ? "Hay camino" : "No hay camino");

        int[][] laberinto2 = new int[][] {
            new int[] { 0, 0, 1, 1, 1, 0, 0, 0 },
            new int[] { 1, 0, 1, 0, 0, 0, 1, 1 },
            new int[] { 1, 0, 0, 0, 1, 1, 0, 1 },
            new int[] { 0, 1, 1, 1, 0, 0, 0, 0 },
            new int[] { 0, 0, 0, 1, 1, 1, 1, 0 },
            new int[] { 1, 1, 0, 0, 0, 0, 1, 0 },
            new int[] { 0, 1, 1, 1, 0, 1, 0, 0 },
            new int[] { 0, 0, 0, 0, 0, 1, 1, 0 }
        };

        Console.WriteLine(HayCamino(laberinto2, 0, 0, 7, 4) ? "Hay camino" : "No hay camino");

        int[][] laberinto3 = new int[][] {
            new int[] { 0, 1, 0, 0, 0, 1, 0, 0, 0, 1 },
            new int[] { 0, 1, 1, 1, 0, 1, 1, 1, 0, 1 },
            new int[] { 0, 0, 0, 1, 0, 0, 0, 1, 0, 1 },
            new int[] { 1, 1, 0, 1, 1, 1, 0, 0, 0, 0 },
            new int[] { 0, 0, 0, 0, 0, 1, 1, 1, 1, 0 },
            new int[] { 1, 1, 1, 1, 0, 0, 0, 0, 0, 0 },
            new int[] { 0, 1, 1, 1, 1, 1, 1, 1, 1, 0 },
            new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 },
            new int[] { 1, 1, 1, 1, 1, 1, 1, 0, 1, 0 },
            new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
        };

        Console.WriteLine(HayCamino(laberinto3, 0, 0, 9, 9) ? "Hay camino" : "No hay camino");
    }
}
