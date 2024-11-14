using PROYECTO_CLASE;

byte opcion;
string vol;


do
{
    Console.WriteLine("\tMENU");
    Console.WriteLine("Crear [1]:");
    Console.WriteLine("Lista [2]:");
    Console.WriteLine("Eliminar [3]:");
    Console.WriteLine("Salir [0]:");

    Console.WriteLine("Ingrese opcion: ");
    while (!byte.TryParse(Console.ReadLine(), out opcion) || opcion > 3)
    {
        Console.WriteLine("Error: Ingrese una opcion valida: ");
    }
    switch (opcion)
    {
        case 0: Environment.Exit(0); break;
        case 1: break;
        case 2: break;
        case 3:
            Console.Write("Ingrese el desayuno que desea eliminar: ");
            string desayunoEliminar = Console.ReadLine();
            desayuno.Eliminar(desayunoEliminar);  
            break;


            break;
    }
    Console.WriteLine("¿Volver al menú? [si]: ");
    vol = Console.ReadLine().ToLower();
    Console.Clear();
}while (vol=="si");

