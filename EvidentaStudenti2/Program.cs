using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaStudenti2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Valentin");
            while(true)
            {
                foreach (string menu in s.Meniu())
                {
                    Console.WriteLine(menu);
                }
                Console.WriteLine();
                char optiune;
                if (args.Length != 0)
                {
                    optiune = 'C';
                    //Console.Write("Linia de comanda nu contine argumente");
                }
                else
                {
                    Console.Write("Dati optiunea:");
                    optiune = Console.ReadLine()[0];

                }

                switch (optiune)
                {
                    case 'S':

                        string note;
                        Console.WriteLine("Dati notele separate prin spatiu:");
                        note = Console.ReadLine();

                        //s.SetNote(note);
                        break;
                    case 'A':
                        //Console.WriteLine(s.ConversieLaSir());
                        s.ConversieLaSir();
                        break;
                    case 'T':
                        Console.Write("Dati numarul de note:");
                        int numar = Convert.ToInt32(Console.ReadLine());

                        int[] noteINT = new int[numar];
                        for (int i = 0; i < numar; i++)
                        {
                            Console.Write("Nota numarul {0}:", i);
                            noteINT[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        //s.SetNote(noteINT);
                        break;
                    case 'C':
                        // s.SetNote(args);
                        s.SetNote("1 2 3 4 5 , 4 5 6 7 8 , 3 4 5");
                       
                       // Console.WriteLine(s.ConversieLaSir());
                        break;
                    case 'X':
                        Environment.Exit(0);
                        break;
                    case 'I':
                        Console.WriteLine("Boghean Valentin, 3122A");
                        break;
                    default:
                        Console.WriteLine("Optiune inexistenta.");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
                //s.SetNote("1 2 3 10 9 10 4 5 6");       //Test Ex 1: Metoda SetNote()
                //s.SetNote("");
            }
        }
    }
}
