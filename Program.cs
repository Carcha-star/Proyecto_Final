using System;

// =================================================================
// CÓDIGO PRINCIPAL (Ejecución directa sin 'class' ni 'Main')
// =================================================================

// Inicialización del arreglo usando el struct Capitan
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
        ClubActual = "Real Madrid"
    }
};

// Validación inicial: Si el arreglo está vacío o es nulo, el programa no intenta arrancar
if (capitanes == null || capitanes.Length == 0)
{
    Console.WriteLine("Error crítico: No hay datos de capitanes cargados.");
    return;
}

// Llamada inicial al menú
MostrarMenu(capitanes);


// =================================================================
// FUNCIONES DEL PROGRAMA CON VALIDACIONES
// =================================================================

void MostrarMenu(Capitan[] listaCapitanes)
{
    int opcion;
    bool entradaValida;

    do
    {
        Console.Clear();
        Console.WriteLine("=====================================");
        Console.WriteLine("       RADAR DEL CAPITÁN");
        Console.WriteLine("=====================================");
        Console.WriteLine();

        // Muestra las selecciones desde el struct
        for (int i = 0; i < listaCapitanes.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {listaCapitanes[i].Seleccion}");
        }

        Console.WriteLine("0. Salir");
        Console.WriteLine();
        Console.Write("Seleccione una opción: ");

        // VALIDACIÓN 1: Capturar si el usuario presiona Enter sin escribir nada o escribe texto
        string entrada = Console.ReadLine();

        // int.TryParse evita que el programa se rompa si escriben letras o símbolos
        entradaValida = int.TryParse(entrada, out opcion);

        if (!entradaValida)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n[ERROR] El valor ingresado no es un número válido. Intente de nuevo.");
            Console.ResetColor();
            Console.Write("Presione una tecla para continuar...");
            Console.ReadKey();
            opcion = -1; // Forzamos el ciclo para que no se salga
            continue;
        }

        // VALIDACIÓN 2: Verificar si el número está dentro del rango del menú
        if (opcion < 0 || opcion > listaCapitanes.Length)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n[ERROR] Opción fuera de rango. Debe elegir entre 0 y {listaCapitanes.Length}.");
            Console.ResetColor();
            Console.Write("Presione una tecla para continuar...");
            Console.ReadKey();
            continue;
        }

        // Si pasa las validaciones y no es 0 (Salir), muestra la info
        if (opcion > 0)
        {
            MostrarInformacion(listaCapitanes[opcion - 1]);
        }

    } while (opcion != 0);
}

void MostrarInformacion(Capitan capitan)
{
    Console.Clear();
    Console.WriteLine("=====================================");
    Console.WriteLine("      INFORMACIÓN DEL CAPITÁN");
    Console.WriteLine("=====================================");

    // VALIDACIÓN 3: Control de nulos o textos vacíos dentro del struct por seguridad
    string seleccion = string.IsNullOrWhiteSpace(capitan.Seleccion) ? "Desconocida" : capitan.Seleccion;
    string nombre = string.IsNullOrWhiteSpace(capitan.Nombre) ? "Sin Nombre" : capitan.Nombre;
    string club = string.IsNullOrWhiteSpace(capitan.ClubActual) ? "Sin Club / Libre" : capitan.ClubActual;

    Console.WriteLine($"Selección   : {seleccion}");
    Console.WriteLine($"Capitán     : {nombre}");
    Console.WriteLine($"Edad        : {(capitan.Edad <= 0 ? "No registrada" : capitan.Edad + " años")}");
    Console.WriteLine($"Goles       : {(capitan.Goles < 0 ? 0 : capitan.Goles)}");
    Console.WriteLine($"Club Actual : {club}");
    Console.WriteLine("=====================================");

    Console.WriteLine();
    Console.Write("Presione una tecla para volver al menú...");
    Console.ReadKey();
}


// =================================================================
// STRUCT DE VARIABLES (Al final de todo el archivo)
// =================================================================
struct Capitan
{
    public string Nombre;
    public int Edad;
    public int Goles;
    public string ClubActual;
    public string Seleccion;
}