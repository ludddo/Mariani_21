using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mariani_21
{
    internal class Program
    {
        static void Main()
        {
            // Dichiarazioni
            int scelta = 0;
            int dim = 0;
            int[] array = new int[100];
            int a, b;

            // Elaborazione
            Console.Write("Inserire la lunghezza dell'array: ");
            dim = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < dim; i++)
            {
                Console.Write($"Inserire elemento in posizione {i}: ");
                a = Convert.ToInt32(Console.ReadLine());
                array[i] = a;
            }

            // Menù
            do
            {
                Console.Clear();
                Console.WriteLine("Premere uno dei seguenti tasti per selezionare l'operazione desiderata: \n\t1 - Aggiungi elemento \n\t2 - Stampa elementi \n\t3 - Stampa stringa HTML \n\t4 - Ricerca elemento \n\t5 - Elimina elemento \n\t6 - Aggiungi elemento alla posizione desiderata \n\t0 - Uscita");
                scelta = Convert.ToInt32(Console.ReadLine());

                switch (scelta)
                {
                    case 1:
                        Console.Write("Inserire un elemento: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        if (Aggiunta(array, a, ref dim))
                        {
                            Console.WriteLine("Elemento inserito");
                        }
                        else
                        {
                            Console.WriteLine("Array completamente riempito");
                        }
                        break;
                    case 2:
                        for (int i = 0; i < dim; i++)
                        {
                            Console.Write(array[i] + " ");
                        }
                        break;
                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("<!DOCTYPE html>\r\n<html lang=\"it\">\r\n<head>\r\n    <title>Ripasso Array-21</title>\r\n</head>\r\n<body>");
                        Console.WriteLine(Html(array, ref dim));
                        Console.WriteLine("</body>\r\n</html>");
                        break;
                    case 4:
                        Console.Write("Inserire l'elemento che si desidera ricercare: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        if (Ricerca(array, a) == -1)
                        {
                            Console.WriteLine("L'elemento non è stato trovato");
                        }
                        else
                        {
                            Console.WriteLine($"L'elemento {a} è stato trovato in posizione {Ricerca(array, a)}");
                        }
                        break;
                    case 5:
                        Console.Write("Inserire l'elemento che si vuole eliminare: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        if (Cancellazione(array, a, ref dim))
                        {
                            Console.WriteLine("L'elemento è stato cancellato");
                        }
                        else
                        {
                            Console.WriteLine("Non è stato possibile cancellare l'elemento");
                        }
                        break;
                    case 6:
                        Console.Write("Inserire la posizione in cui si desidera immettere l'elemento: ");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Inserire l'elemento: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        if (Inserimento(array, a, b))
                            Console.WriteLine($"L'elemento {a} è stato inserito nella posizione {b}");
                        else
                            Console.WriteLine("L'elemento non è stato inserito");
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                }

                Thread.Sleep(1000);
            } while (scelta != 0);
        }

        // Funzione Aggiunta
        static bool Aggiunta(int[] array, int a, ref int index)
        {
            bool inserito = true;
            if (index < array.Length)
            {
                array[index] = a;
                index++;
            }
            else
            {
                inserito = false;
            }
            return inserito;
        }

        // Funzione Html
        static string Html(int[] array, ref int dim)
        {
            string code = "    <table>\n";
            for (int i = 0; i < dim; i++)
            {
                code += "         <tr>\n";
                code += "             <td>" + array[i] + "</td>\n";
                code += "         </tr>\n";
            }
            code += "   </table>";
            return code;
        }

        // Funzione Ricerca
        static int Ricerca(int[] array, int a)
        {
            int risulRicerca = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == a)
                {
                    risulRicerca = i;
                    break;
                }
                else
                {
                    risulRicerca = -1;
                }
            }

            return risulRicerca;
        }

        // Funzione Cancellazione
        static bool Cancellazione(int[] array, int a, ref int dim)
        {
            bool cancellazione = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == a)
                {
                    dim--;
                    for (int j = i; j < array.Length - 1; j++)
                    {
                        array[j] = array[j + 1];
                    }
                    cancellazione = true;
                    break;
                }
            }

            return cancellazione;
        }

        // Funzione Inserimento
        static bool Inserimento(int[] array, int a, int b)
        {
            bool inserimento = false;

            if (b < array.Length)
            {
                for (int i = 0; i < array.Length - 1; i++)
                    array[i] = array[i - 1];
                array[b] = a;
                inserimento = true;
            }

            return inserimento;
        }
    }
}
