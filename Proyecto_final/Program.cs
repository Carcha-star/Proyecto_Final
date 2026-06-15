Console.WriteLine("=====================================");
Console.WriteLine(" COMPARADOR DE CAPITANES");
Console.WriteLine("=====================================");

for (int i = 0; i < capitanes.Length; i++)
{
    Console.WriteLine($"{i + 1}. {capitanes[i].Seleccion}");
}

Console.Write("\nSeleccione el primer capitán: ");
int op1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Seleccione el segundo capitán: ");
int op2 = Convert.ToInt32(Console.ReadLine());

if (op1 < 1 || op1 > capitanes.Length ||
    op2 < 1 || op2 > capitanes.Length)
{
    Console.WriteLine("\nSelección inválida.");
    Console.ReadKey();
    return;
}

Capitan c1 = capitanes[op1 - 1];
Capitan c2 = capitanes[op2 - 1];

Console.Clear();

Console.WriteLine("=====================================");
Console.WriteLine(" RESULTADO DE COMPARACIÓN");
Console.WriteLine("=====================================");

Console.WriteLine($"\n{c1.Seleccion} VS {c2.Seleccion}");

Console.WriteLine("\nCAPITANES");
Console.WriteLine($"{c1.Nombre}");
Console.WriteLine($"{c2.Nombre}");

Console.WriteLine("\nEDAD");
Console.WriteLine($"{c1.Nombre}: {c1.Edad} años");
Console.WriteLine($"{c2.Nombre}: {c2.Edad} años");

if (c1.Edad > c2.Edad)
    Console.WriteLine($"Mayor edad: {c1.Nombre}");
else if (c2.Edad > c1.Edad)
    Console.WriteLine($"Mayor edad: {c2.Nombre}");
else
    Console.WriteLine("Empate");

Console.WriteLine("\nGOLES");
Console.WriteLine($"{c1.Nombre}: {c1.Goles}");
Console.WriteLine($"{c2.Nombre}: {c2.Goles}");

if (c1.Goles > c2.Goles)
    Console.WriteLine($"Más goles: {c1.Nombre}");
else if (c2.Goles > c1.Goles)
    Console.WriteLine($"Más goles: {c2.Nombre}");
else
    Console.WriteLine("Empate");

Console.WriteLine("\nCLUB ACTUAL");
Console.WriteLine($"{c1.Nombre}: {c1.ClubActual}");
Console.WriteLine($"{c2.Nombre}: {c2.ClubActual}");

Console.WriteLine("\n=====================================");
Console.WriteLine("Presione una tecla para volver...");
Console.ReadKey();
    }
}