using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_CLASE
{
    internal class desayuno
    {
        static void Main()
        {
            byte opcion;
            string vol;
            List<string> lista = new List<string>(); // Lista para almacenar elementos

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
                    case 0:
                        Environment.Exit(0);
                        break;

                    case 1: // Crear
                        Console.WriteLine("Ingrese el desayuno a la lista: ");
                        string desayunonuevo = Console.ReadLine();
                        lista.Add(desayunonuevo);
                        Console.WriteLine($"desayuno '{desayunonuevo}' agregado a la lista.");
                        break;

                    case 2: // Mostrar lista
                        Console.WriteLine("Lista de desayunos:");
                        if (lista.Count == 0)
                        {
                            Console.WriteLine("La lista está vacía.");
                        }
                        else
                        {
                            foreach (var item in lista)
                            {
                                Console.WriteLine(item);
                            }
                        }
                        break;

                    case 3: // Eliminar
                        Console.WriteLine("Ingrese el desayuno a eliminar de la lista: ");
                        string eliminardesayuno = Console.ReadLine();
                        if (lista.Remove(eliminardesayuno))
                        {
                            Console.WriteLine($"desayuno '{eliminardesayuno}' eliminado.");
                        }
                        else
                        {
                            Console.WriteLine("el desayuno  no encontrado en la lista.");
                        }
                        break;
                }

                Console.WriteLine("¿Volver al menú? [si]: ");
                vol = Console.ReadLine().ToLower();
                Console.Clear();

            } while (vol == "si");
        }
    }
}