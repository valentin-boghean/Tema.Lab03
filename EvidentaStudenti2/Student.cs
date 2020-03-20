using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaStudenti2
{
    public class Student
    {
        // date membre private
        string nume;
        int[,] note;


        // contructor implicit
        public Student()
        {
        }

        // constructor cu parametri
        public Student(string _nume)
        {
            nume = _nume;
        }

        // Ex 1: Metoda SetNote utilizand split
        public void SetNote(string sirNote)
        {
            note = new int[4,15];
            //Eliminarea spatiilor dintre note 
            string[] notes = new string[4];
            notes = sirNote.Split(',');
            string[] temp;
            int i = 0;
            foreach(string notari in notes)
            {
                temp = notari.Split(' ');
               
                for (int j = 0; j < temp.Length; j++)
                {
                    Int32.TryParse(temp[j], out note[i, j]);
                    //Array.Resize(note[i], note[i].Length);
                    //Console.WriteLine(note[i, j]);
                }
                i++;
                
            }          
        }
        //Pentru citirea notelor de la tastatura pe rand
        public void SetNote(int[,] _note)
        {
            note = new int[4,15];
            note = _note;

        }
        public void ConversieLaSir()
        {
            string sNote = "Nu exista (Nu ati apelat metoda **setNote**)";
            if (note != null)
            {
                sNote = string.Join(",", note);
            }
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Notele pe anul {0} sunt: ", i + 1);
                for (int j = 0; j < 15; j++)
                    Console.Write("{0}", note[i, j]);
                Console.WriteLine();
            }
           // string s = string.Format("Studentul {0} are notele:.... {1}", nume, sNote);

            //return s;
        }
        //Pentru citirea din linia de comanda
       /* public void SetNote(string[] _note)
        {
            string noteF = String.Empty;
            foreach (string note in _note)
                noteF = noteF + note + " ";

            SetNote(noteF);

        }
        */
        //Ex 2: Meniu
        public string[] Meniu()
        {
            string[] Meniu;
            Meniu = new string[6];

            Meniu[0] = "S: Citire note de la tastatura ca un sir de caractere";
            Meniu[1] = "T: Citire note de la tastatura cate o nota pe rand";
            Meniu[2] = "C: Citire note din linia de comanda";
            Meniu[3] = "A: Afisare note";
            Meniu[4] = "I: Info autor";
            Meniu[5] = "X: Iesire";

            return Meniu;

        }
        //Ex 3
      
    }
}
