using PROYECTO_CLASE;

byte opcion;
string vol;

desayuno de=new desayuno();
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
        case 1:
            de.Crear();
            break;
        case 2:
            de.Lista();
            break;
        case 3:
            Console.Write("\nIngresar desayuno a eliminar: ");
            string Desa = Console.ReadLine();
            de.Eliminar1(Desa);
            break;
    }
    Console.WriteLine("\n¿Volver al menú? [si]: ");
    vol = Console.ReadLine().ToLower();
    Console.Clear();
}while (vol=="si");

