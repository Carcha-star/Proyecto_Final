using System;

class Program
{
    struct Capitan
    {
        public string Grupo;
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
            new Capitan { Grupo="A", Seleccion="México", Nombre="Edson Álvarez", Edad=28, Goles=5, ClubActual="West Ham United" },
            new Capitan { Grupo="A", Seleccion="Sudáfrica", Nombre="Ronwen Williams", Edad=34, Goles=0, ClubActual="Mamelodi Sundowns" },
            new Capitan { Grupo="A", Seleccion="Corea del Sur", Nombre="Son Heung-min", Edad=34, Goles=55, ClubActual="Tottenham Hotspur" },
            new Capitan { Grupo="A", Seleccion="Chequia", Nombre="Tomáš Souček", Edad=31, Goles=14, ClubActual="West Ham United" },

            new Capitan { Grupo="B", Seleccion="Canadá", Nombre="Alphonso Davies", Edad=25, Goles=17, ClubActual="Bayern Múnich" },
            new Capitan { Grupo="B", Seleccion="Bosnia", Nombre="Edin Džeko", Edad=40, Goles=68, ClubActual="Fiorentina" },
            new Capitan { Grupo="B", Seleccion="Qatar", Nombre="Hassan Al-Haydos", Edad=36, Goles=41, ClubActual="Al Sadd" },
            new Capitan { Grupo="B", Seleccion="Suiza", Nombre="Granit Xhaka", Edad=34, Goles=16, ClubActual="Bayer Leverkusen" },

            new Capitan { Grupo="C", Seleccion="Brasil", Nombre="Marquinhos", Edad=32, Goles=7, ClubActual="Paris Saint-Germain" },
            new Capitan { Grupo="C", Seleccion="Marruecos", Nombre="Achraf Hakimi", Edad=27, Goles=11, ClubActual="Paris Saint-Germain" },
            new Capitan { Grupo="C", Seleccion="Haití", Nombre="Ricardo Adé", Edad=36, Goles=3, ClubActual="LDU Quito" },
            new Capitan { Grupo="C", Seleccion="Escocia", Nombre="Andrew Robertson", Edad=32, Goles=4, ClubActual="Liverpool" },

            new Capitan { Grupo="D", Seleccion="Estados Unidos", Nombre="Christian Pulisic", Edad=27, Goles=35, ClubActual="AC Milan" },
            new Capitan { Grupo="D", Seleccion="Paraguay", Nombre="Gustavo Gómez", Edad=33, Goles=6, ClubActual="Palmeiras" },
            new Capitan { Grupo="D", Seleccion="Australia", Nombre="Mathew Ryan", Edad=34, Goles=0, ClubActual="Lens" },
            new Capitan { Grupo="D", Seleccion="Turquía", Nombre="Hakan Çalhanoğlu", Edad=32, Goles=21, ClubActual="Inter de Milán" },

            new Capitan { Grupo="E", Seleccion="Alemania", Nombre="Joshua Kimmich", Edad=31, Goles=8, ClubActual="Bayern Múnich" },
            new Capitan { Grupo="E", Seleccion="Curazao", Nombre="Cuco Martina", Edad=36, Goles=1, ClubActual="Breda" },
            new Capitan { Grupo="E", Seleccion="Costa de Marfil", Nombre="Franck Kessié", Edad=29, Goles=10, ClubActual="Al Ahli" },
            new Capitan { Grupo="E", Seleccion="Ecuador", Nombre="Enner Valencia", Edad=36, Goles=41, ClubActual="Internacional" },

            new Capitan { Grupo="F", Seleccion="Países Bajos", Nombre="Virgil van Dijk", Edad=35, Goles=10, ClubActual="Liverpool" },
            new Capitan { Grupo="F", Seleccion="Japón", Nombre="Wataru Endo", Edad=33, Goles=4, ClubActual="Liverpool" },
            new Capitan { Grupo="F", Seleccion="Suecia", Nombre="Victor Lindelöf", Edad=31, Goles=3, ClubActual="Manchester United" },
            new Capitan { Grupo="F", Seleccion="Túnez", Nombre="Youssef Msakni", Edad=35, Goles=23, ClubActual="Al Arabi" },

            new Capitan { Grupo="G", Seleccion="Bélgica", Nombre="Kevin De Bruyne", Edad=35, Goles=31, ClubActual="Napoli" },
            new Capitan { Grupo="G", Seleccion="Egipto", Nombre="Mohamed Salah", Edad=34, Goles=56, ClubActual="Liverpool" },
            new Capitan { Grupo="G", Seleccion="Irán", Nombre="Ehsan Hajsafi", Edad=36, Goles=7, ClubActual="AEK Atenas" },
            new Capitan { Grupo="G", Seleccion="Nueva Zelanda", Nombre="Chris Wood", Edad=34, Goles=36, ClubActual="Nottingham Forest" },

            new Capitan { Grupo="H", Seleccion="España", Nombre="Álvaro Morata", Edad=33, Goles=39, ClubActual="Galatasaray" },
            new Capitan { Grupo="H", Seleccion="Cabo Verde", Nombre="Ryan Mendes", Edad=36, Goles=16, ClubActual="Fatih Karagümrük" },
            new Capitan { Grupo="H", Seleccion="Arabia Saudita", Nombre="Salman Al-Faraj", Edad=37, Goles=8, ClubActual="NEOM SC" },
            new Capitan { Grupo="H", Seleccion="Uruguay", Nombre="Federico Valverde", Edad=28, Goles=12, ClubActual="Real Madrid" },

            new Capitan { Grupo="I", Seleccion="Francia", Nombre="Kylian Mbappé", Edad=27, Goles=52, ClubActual="Real Madrid" },
            new Capitan { Grupo="I", Seleccion="Senegal", Nombre="Kalidou Koulibaly", Edad=35, Goles=1, ClubActual="Al Hilal" },
            new Capitan { Grupo="I", Seleccion="Irak", Nombre="Jalal Hassan", Edad=35, Goles=0, ClubActual="Al-Zawraa" },
            new Capitan { Grupo="I", Seleccion="Noruega", Nombre="Martin Ødegaard", Edad=27, Goles=3, ClubActual="Arsenal" },

            new Capitan { Grupo="J", Seleccion="Argentina", Nombre="Lionel Messi", Edad=39, Goles=112, ClubActual="Inter Miami" },
            new Capitan { Grupo="J", Seleccion="Argelia", Nombre="Riyad Mahrez", Edad=35, Goles=31, ClubActual="Al Ahli" },
            new Capitan { Grupo="J", Seleccion="Austria", Nombre="David Alaba", Edad=34, Goles=15, ClubActual="Real Madrid" },
            new Capitan { Grupo="J", Seleccion="Jordania", Nombre="Ihsan Haddad", Edad=32, Goles=2, ClubActual="Al-Hussein" },

            new Capitan { Grupo="K", Seleccion="Portugal", Nombre="Cristiano Ronaldo", Edad=41, Goles=138, ClubActual="Al Nassr" },
            new Capitan { Grupo="K", Seleccion="RD Congo", Nombre="Chancel Mbemba", Edad=31, Goles=6, ClubActual="Olympique de Marsella" },
            new Capitan { Grupo="K", Seleccion="Uzbekistán", Nombre="Eldor Shomurodov", Edad=31, Goles=40, ClubActual="Roma" },
            new Capitan { Grupo="K", Seleccion="Colombia", Nombre="James Rodríguez", Edad=35, Goles=30, ClubActual="Club León" },

            new Capitan { Grupo="L", Seleccion="Inglaterra", Nombre="Harry Kane", Edad=32, Goles=75, ClubActual="Bayern Múnich" },
            new Capitan { Grupo="L", Seleccion="Croacia", Nombre="Luka Modrić", Edad=40, Goles=28, ClubActual="AC Milan" },
            new Capitan { Grupo="L", Seleccion="Ghana", Nombre="André Ayew", Edad=36, Goles=24, ClubActual="Le Havre" },
            new Capitan { Grupo="L", Seleccion="Panamá", Nombre="Aníbal Godoy", Edad=36, Goles=2, ClubActual="Nashville SC" }
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
            Console.WriteLine("       RADAR DEL CAPITÁN FIFA");
            Console.WriteLine("=====================================");
            Console.WriteLine();

            string grupoActual = "";

            for (int i = 0; i < capitanes.Length; i++)
            {
                if (grupoActual != capitanes[i].Grupo)
                {
                    grupoActual = capitanes[i].Grupo;
                    Console.WriteLine();
                    Console.WriteLine($"========== GRUPO {grupoActual} ==========");
                }

                Console.WriteLine($"{i + 1}. {capitanes[i].Seleccion}");
            }

            Console.WriteLine();
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
        int opcion;

        do
        {
            Console.Clear();

            Console.WriteLine("=====================================");
            Console.WriteLine("      INFORMACIÓN DEL CAPITÁN");
            Console.WriteLine("=====================================");
            Console.WriteLine($"Grupo     : {capitan.Grupo}");
            Console.WriteLine($"Selección : {capitan.Seleccion}");
            Console.WriteLine($"Capitán   : {capitan.Nombre}");
            Console.WriteLine("=====================================");
            Console.WriteLine();
            Console.WriteLine("¿Qué estadística desea ver?");
            Console.WriteLine("1. Edad");
            Console.WriteLine("2. Goles con la selección");
            Console.WriteLine("3. Club actual");
            Console.WriteLine("4. Ver todo");
            Console.WriteLine("0. Volver");
            Console.WriteLine();
            Console.Write("Seleccione una opción: ");

            opcion = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            switch (opcion)
            {
                case 1:
                    Console.WriteLine($"Edad: {capitan.Edad} años");
                    break;

                case 2:
                    Console.WriteLine($"Goles con selección: {capitan.Goles}");
                    break;

                case 3:
                    Console.WriteLine($"Club actual: {capitan.ClubActual}");
                    break;

                case 4:
                    Console.WriteLine($"Grupo        : {capitan.Grupo}");
                    Console.WriteLine($"Selección    : {capitan.Seleccion}");
                    Console.WriteLine($"Capitán      : {capitan.Nombre}");
                    Console.WriteLine($"Edad         : {capitan.Edad} años");
                    Console.WriteLine($"Goles        : {capitan.Goles}");
                    Console.WriteLine($"Club Actual  : {capitan.ClubActual}");
                    break;

                case 0:
                    return;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            Console.WriteLine();
            Console.Write("Presione una tecla para continuar...");
            Console.ReadKey();

        } while (opcion != 0);
    }
}