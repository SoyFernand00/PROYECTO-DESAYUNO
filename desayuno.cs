using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_CLASE
{
    internal class desayuno
    {
        string[] Desayuno1 = new string[0];
        int posicion = 0;
        string seguir;


        public void Crear()
        {
            do
            {
                string Respuesta;
                Console.Write("\n¿Ingresa el desayuno que te gustaria? : ");
                Respuesta = Console.ReadLine();
                Array.Resize(ref Desayuno1, Desayuno1.Length + 1);
                Desayuno1[posicion] = Respuesta;
                posicion++;

                Console.WriteLine("\n!!Desayuno ingresado correctamente!! ");
                Console.WriteLine("Desea ingresar un nuevo desayuno? [s] [n]: ");
                seguir = Console.ReadLine().ToLower();
            } while (seguir == "s");

        }
        public void Lista()
        {
            Console.SetCursorPosition(10, 12);

            Console.Write("Servidos: ");
            Console.SetCursorPosition(30, 12);

            Console.Write("Desayunos: ");
            for (int i = 0; i < Desayuno1.Length; i++)
            {
                Console.SetCursorPosition(10, 13 + i);
                Console.Write(i);
                Console.SetCursorPosition(30, 13 + i);
                Console.WriteLine(Desayuno1[i]);

            }
        }
        public void Eliminar1(string Desa)
        {
            int indice = Array.IndexOf(Desayuno1, Desa);
            if (indice != -1)
            {
                for (int i = indice; i < Desayuno1.Length - 1; i++)
                {
                    Desayuno1[i] = Desayuno1[i + 1];
                }
                Array.Resize(ref Desayuno1, Desayuno1.Length - 1);
                posicion--;

                Console.WriteLine("\nUn desayuno fue eliminado correctamente");

            }
            else
            {
                Console.WriteLine("\nNo se puede eliminar Porque no Existe el parametro especifico !!");
            }
        }
    }
}
