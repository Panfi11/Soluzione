using System;

namespace CalcolaLibrary
{
    public class Calcola
    {
        public static double Raddoppia(double num)
        {
            double riscalcolato = num * 2;
            return riscalcolato;
        }
        public static double SommaMonete(double[] monete)
        {
            double resp = 0;
            for (int i = 0; i<monete.Length; i++)
            {
                resp =+ monete[i];
            }
            return resp;
        }
    }
}
