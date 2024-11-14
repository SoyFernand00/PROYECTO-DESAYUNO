using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_CLASE
{
    internal class Desayuno
    {
      
            private HashSet<string> opciones; 

            public Desayuno()
            {
                opciones = new HashSet<string>();
            }

           
            public void Añadir(string elemento)
            {
                if (opciones.Add(elemento))
                {
                    Console.WriteLine("Elemento añadido.");
                }
                else
                {
                    Console.WriteLine("El elemento ya existe en el conjunto.");
                }
            }

           
            public void Listar()
            {
                Console.WriteLine("Lista de desayunos:");
                if (opciones.Count == 0)
                {
                    Console.WriteLine("No hay elementos en el conjunto.");
                }
                else
                {
                    foreach (var elemento in opciones)
                    {
                        Console.WriteLine("- " + elemento);
                    }
                }
            }

         
            public void Eliminar(string elemento)
            {
                if (opciones.Remove(elemento))
                {
                    Console.WriteLine("Elemento eliminado.");
                }
                else
                {
                    Console.WriteLine("El elemento no se encontró en el conjunto:(");
                }
            }
        }
}
