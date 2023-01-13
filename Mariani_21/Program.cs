using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mariani_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[100];
            int index = 0;
            int scelta = 0;


            //strutura menu
            do
            {
                Console.Clear();
                //stampa opzioni
                Console.WriteLine("1 - aggiungi elemento");
                Console.WriteLine("2 - stampa elementi caricati");
                Console.WriteLine("0 - stampa elementi caricati");
                Console.WriteLine();
                //scelta opzione
                Console.WriteLine("Inserisci la scelta");
                scelta = int.Parse(Console.ReadLine());
                Console.WriteLine();
                //esecuzione
                switch (scelta)
                {
                    case 1:
                        Console.WriteLine("Inserire un valore: ");
                        int valore = int.Parse(Console.ReadLine());
                        if(InsertArray(valore, ref index, array) == true)
                        {
                            Console.WriteLine("Elemento Inserito Correttamente");
                        }
                        else
                        {
                            Console.WriteLine("Array Pieno");
                        }
                        Console.WriteLine();
                        Console.WriteLine("Premi un tasto per continuare...");
                        Console.ReadLine();
                        break;
                    case 2:
                        for (int i = 0; i < index; i++)
                        {
                            Console.Write(array[i] + " ");
                            
                        }
                        Console.WriteLine();
                        Console.WriteLine("Premi un tasto per continuare...");
                        Console.ReadLine();
                        break;
                }
            } while (scelta != 0);
        }

        static bool InsertArray(int x, ref int index, int[] array)
        {
            bool inserito = true;
            if (index < array.Length)
            {
                array[index] = x;

                index++;
            }
            else
            {
                inserito = false;   
            }

            return inserito;
        }

        static string StringaHTML(int[] array)
        {
            return "0";
        }

        static int TrovaArray()
        {
            return 0;
        }

        static int CancArray()
        {
            return 0;
        }

        static int InserimentoPosArray()
        {
            return 0;
        }
    }
}
