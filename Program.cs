using System;

namespace Ex5_laborator5_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex 5
            //Un program care va normaliza un sir de caractere citit de la tastatura astfel incat fiecare cuvant din
            //sir sa inceapa cu MAJUSCULA, restul literelor fiind transformate in litere mici.
            //Exemplu:
            //Input: Ana ARE mErE
            //Rezultat: Ana Are Mere

            Console.WriteLine("Introduceti un sir de caractere");
            string sir = Console.ReadLine();

            string modificareSir = PrimaLiteraMare(sir);
            Console.WriteLine(modificareSir);
        }
        static string PrimaLiteraMare(string sir)
        {
            string modificat = string.Empty;
            for (int i = 0; i < sir.Length; i++)
            {
                if (i == 0)
                {
                    modificat += Char.ToUpper(sir[i]);
                }
                else
                {
                    if (Char.IsLetter(sir[i - 1]))
                    {
                        modificat += Char.ToLower(sir[i]);
                    }
                    else
                    {
                        modificat += Char.ToUpper(sir[i]);
                    }
                }
            }
            return modificat;
        }
    }
}
