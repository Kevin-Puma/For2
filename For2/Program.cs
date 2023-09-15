Console.Write("Ingrese un numero limite: ");
int limite = int.Parse(Console.ReadLine());

for (int i = 0; i <= limite; i++)
{
    for (int j = 1; j <= i + 1; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

Console.ReadKey();