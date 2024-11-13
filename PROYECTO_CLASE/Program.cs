using PROYECTO_CLASE;

byte opcion;
string vol;
Desayunos t = new Desayunos();

do
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("*****MENU*****");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Crear [1]:");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Lista [2]:");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Eliminar [3]:");
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("Salir [0]:");

    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("\nIngrese opcion: ");
    while (!byte.TryParse(Console.ReadLine(), out opcion) || opcion > 3)
    {
        Console.WriteLine("Error: Ingrese una opcion valida: ");
    }
    switch (opcion)
    {
        case 0: Environment.Exit(0); break;
        case 1: t.insertar(); break;
        case 2: t.crear(); break;

        case 3:
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nIngrese el desayuno que desea eliminar: ");
                string Desa1 = (Console.ReadLine());
            t.eliminar1(Desa1);
            break;
    }
    Console.WriteLine();
    Console.WriteLine("\n   ¿Volver al menú? [si]: ");
    vol = Console.ReadLine().ToLower();
    Console.Clear();
}while (vol=="si");

