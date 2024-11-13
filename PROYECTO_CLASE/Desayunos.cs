using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_CLASE
{
    public class Desayunos
    {
        string[] Desayuno1 = new string[0];
        int posicion = 0;
        string seguir = "s";
        

        public void insertar()
        {
            do
            {
                string Respuesta;
                Console.Write("\n¿Ingresa el desayuno que te gustaria? : ");
                Respuesta = Console.ReadLine();
                Array.Resize(ref Desayuno1, Desayuno1.Length + 1);
                Desayuno1[posicion] = Respuesta;
                posicion++;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n!!Desayuno ingresado correctamente!! ");
                
            } while (seguir == "N");

        }
        public void crear()
        {
            Console.SetCursorPosition(10, 12);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("Servidos: ");
            Console.SetCursorPosition(30, 12);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("Desayunos: ");
            for(int i = 0; i<Desayuno1.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(10, 13 + i);
                Console.Write(i);
                Console.SetCursorPosition(30,  13 + i);
                Console.Write(Desayuno1[i]);

            }
        }
        public void eliminar1(string Desa)
        {
            int indice = Array.IndexOf(Desayuno1, Desa);
            if(indice != -1)
            {
                for (int i = indice; i < Desayuno1.Length - 1; i++)
                {
                    Desayuno1[i] = Desayuno1[i + 1];
                }
                Array.Resize(ref Desayuno1, Desayuno1.Length - 1);
                posicion--;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nUn desayuno fue eliminado correctamente");

            }
            else
            {
                Console.WriteLine("\nNo se puede eliminar Porque no Existe el parametro especifico !! ");
            }
        }
    }
}
//Fabrizzio Jair Llara Campano 12/11/2024 11:00pm