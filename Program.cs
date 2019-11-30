using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio2Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] tablero = new char[3, 3];
            InicializarTablero(ref tablero);
            char caracterUsado = '0';
            string coordenada = "";

            do
            {
                Console.Clear();
                Console.WriteLine(tableroVisual(tablero));
                Console.WriteLine($"introduce la coordenada que quieres cambiar.");
                Console.WriteLine("Por ejemplo, A1.");
                coordenada = Console.ReadLine().ToUpper();

                while (!EsCoordenadaValida(coordenada))
                {
                    Console.Clear();
                    //PonerCoordenadas(ref tablero, coordenada, caracterUsado);
                    Console.WriteLine(tableroVisual(tablero));
                    Console.WriteLine("Entrada Incorrecta");
                    Console.WriteLine($"introduce la coordenada que quieres cambiar.");
                    Console.WriteLine("Por ejemplo, A1.");
                    coordenada = Console.ReadLine().ToUpper();
                }
                if (EsCoordenadaValida(coordenada))
                {
                    Console.Clear();
                    PonerCoordenadas(ref tablero, coordenada, caracterUsado);
                    Console.WriteLine(tableroVisual(tablero));
                }
                if (EstaElTableroLleno(tablero))
                {
                    Console.WriteLine("Juego terminado");
                    Thread.Sleep(2000);
                    Console.WriteLine("Adiós....."); 
                    Thread.Sleep(1200);
                    Environment.Exit(0);
                }                
            }
            while (EsCoordenadaValida(coordenada));
            

        }
        static void InicializarTablero(ref char[,] tablero)
        {
            for (int contador1 = 0; contador1 < 3; contador1++)
            {
                for (int contador2 = 0; contador2 < 3; contador2++)
                {
                    tablero[contador1, contador2] = '1';
                }
            }
        }
        static string tableroVisual(char[,] tablero)
        {
            string tv = "";

            tv += "   1   2   3  " + Environment.NewLine;
            tv += " ┌───┬───┬───┐" + Environment.NewLine;
            tv += $"A│ {tablero[0, 0]} │ {tablero[0, 1]} │ {tablero[0, 2]} │" + Environment.NewLine;
            tv += " ├───┼───┼───┤" + Environment.NewLine;
            tv += $"B│ {tablero[1, 0]} │ {tablero[1, 1]} │ {tablero[1, 2]} │" + Environment.NewLine;
            tv += " ├───┼───┼───┤" + Environment.NewLine;
            tv += $"C│ {tablero[2, 0]} │ {tablero[2, 1]} │ {tablero[2, 2]} │" + Environment.NewLine;
            tv += " └───┴───┴───┘" + Environment.NewLine;

            return tv;
        }
        static bool EsCoordenadaValida(string coordenada)
        {
            switch (coordenada)
            {
                case "A1":
                case "A2":
                case "A3":
                case "B1":
                case "B2":
                case "B3":
                case "C1":
                case "C2":
                case "C3":
                    return true;
                default:
                    return false;
            }
        }
        static void PonerCoordenadas(ref char[,] tablero, string coordenada, char numero)
        {
            coordenada = coordenada.ToUpper();
            switch (coordenada)
            {
                case "A1":
                    tablero[0, 0] = numero;
                    return;

                case "A2":
                    tablero[0, 1] = numero;
                    return;

                case "A3":
                    tablero[0, 2] = numero;
                    return;

                case "B1":
                    tablero[1, 0] = numero;
                    return;

                case "B2":
                    tablero[1, 1] = numero;
                    return;

                case "B3":
                    tablero[1, 2] = numero;
                    return;

                case "C1":
                    tablero[2, 0] = numero;
                    return;

                case "C2":
                    tablero[2, 1] = numero;
                    return;

                case "C3":
                    tablero[2, 2] = numero;
                    return;
            }
        }
        static bool EstaElTableroLleno(char[,] tablero)
        {
            if (
                tablero[0, 0] == tablero[0, 1] && tablero[0, 1] == tablero[0, 2] &&
                tablero[1, 0] == tablero[1, 1] && tablero[1, 1] == tablero[1, 2] &&
                tablero[2, 0] == tablero[2, 1] && tablero[2, 1] == tablero[2, 2] &&
                tablero[2, 1] != '1'
                )
            {
                return true;
                            }
            else
            {
                return false;
            }
        }
    }
}
