using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piedra_Papel_Tijera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Piedra, Papel o Tijera");
            while (true)
            {
                Console.WriteLine("Coloca la opcion con la que quieras comenzar: ");
                string eleccion = Console.ReadLine().ToUpper();
                if (eleccion == "SALIR")
                {
                    break;
                }
                if (eleccion == "PIEDRA" || eleccion == "PAPEL" || eleccion == "TIJERA")
                {
              Random rnd = new Random();
                    int numeroAleatorio = rnd.Next(0, 3);
                    string[] opciones = new string[] { "PIEDRA", "PAPEL", "TIJERA" };
                    string eleccionMaquina = opciones[numeroAleatorio];
                    Console.WriteLine("La máquina escogio: " + eleccionMaquina);
                    if (eleccion == eleccionMaquina)
                    {
                        Console.WriteLine("EMPATE");
                    }
                    else if (eleccion == "PIEDRA" && eleccionMaquina == "TIJERA")
                    {
                        Console.WriteLine("GANASTE");
                    }
                    else if (eleccion == "PAPEL" && eleccionMaquina == "PIEDRA")
                    {
                        Console.WriteLine("GANASTE");
                    }
                    else if (eleccion == "TIJERA" && eleccionMaquina == "PAPEL")
                    {
                        Console.WriteLine("GANASTE");
                    }
                    else
                    {
                        Console.WriteLine("PERDISTE");
                    }
                }
                else
                {
                    Console.WriteLine("Error: Escribe Piedra, Papel o Tijera");
                }
            }


        }
    }
}
