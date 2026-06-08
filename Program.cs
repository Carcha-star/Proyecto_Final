using System;

class Program
{
    struct Capitan
    {
        public string Nombre;
        public int Edad;
        public int Goles;
        public string ClubActual;
        public string Seleccion;
    }

    static void Main(string[] args)
    {
        Capitan[] capitanes =
        {
            new Capitan
            {
                Seleccion = "Argentina",
                Nombre = "Lionel Messi",
                Edad = 39,
                Goles = 112,
                ClubActual = "Inter Miami"
            },

            new Capitan
            {
                Seleccion = "Portugal",
                Nombre = "Cristiano Ronaldo",
                Edad = 41,
                Goles = 138,
                ClubActual = "Al Nassr"
            },

            new Capitan
            {
                Seleccion = "Francia",
                Nombre = "Kylian Mbappé",
                Edad = 28,
                Goles = 52,
                ClubActual = "Real Madrid"
            },

            new Capitan
            {
                Seleccion = "Croacia",
                Nombre = "Luka Modrić",
                Edad = 41,
                Goles = 28,
                ClubActual = "AC Milan"
            }
        };

        MostrarMenu(capitanes);
    }

    static void MostrarMenu(Capitan[] capitanes)
    {
        int opcion;

        do
        {
            Console.Clear();

            Console.WriteLine("=====================================");
            Console.WriteLine("       RADAR DEL CAPITÁN");
            Console.WriteLine("=====================================");
            Console.WriteLine();

            for (int i = 0; i < capitanes.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {capitanes[i].Seleccion}");
            }

            Console.WriteLine("0. Salir");
            Console.WriteLine();
            Console.Write("Seleccione una selección: ");

            opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion > 0 && opcion <= capitanes.Length)
            {
                MostrarInformacion(capitanes[opcion - 1]);
            }

        } while (opcion != 0);
    }

    static void MostrarInformacion(Capitan capitan)
    {
        Console.Clear();

        Console.WriteLine("=====================================");
        Console.WriteLine("      INFORMACIÓN DEL CAPITÁN");
        Console.WriteLine("=====================================");
        Console.WriteLine($"Selección   : {capitan.Seleccion}");
        Console.WriteLine($"Capitán     : {capitan.Nombre}");
        Console.WriteLine($"Edad        : {capitan.Edad} años");
        Console.WriteLine($"Goles       : {capitan.Goles}");
        Console.WriteLine($"Club Actual : {capitan.ClubActual}");
        Console.WriteLine("=====================================");

        Console.WriteLine();
        Console.Write("Presione una tecla para volver...");
        Console.ReadKey();
    }
}