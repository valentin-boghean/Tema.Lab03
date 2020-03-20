using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] cuvinte = new string[26][];
            for (int i = 0; i < 26; i++)
                cuvinte[i] = new string[20];
           
            if (args.Length == 0)
                Console.Write("Linia de comanda nu contine argumente");
            else
            {
                // afisarea numarului de argumente
                Console.WriteLine("Numarul de argumente este: {0}", args.Length);

                int count=0;
                foreach (string cuvant in args)
                {
                    
                    switch (cuvant.ToUpper()[0])
                    {
                        case 'A':
                           
                            cuvinte[0][count++] = cuvant;
                            break;
                        case 'B':
                            cuvinte[1][count++] = cuvant;
                            break;

                        case 'C':
                            cuvinte[2][count++] = cuvant;
                            break;
                        default:
                            Console.WriteLine("Comanda necunoscuta");
                            break;
                    }
                }
            }
            for (int i = 0; i < cuvinte.Length; i++)
            {
                for (int j = 0; j < cuvinte[i].Length; j++)
                    Console.Write("{0}\t", cuvinte[i][j]);
                Console.WriteLine();
            }
                Console.ReadKey();

        }
    }
}
