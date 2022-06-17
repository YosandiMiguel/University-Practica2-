using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajo2
{
    static class Solver
    {
        #region Separar dos digitos de un entero
        public static void DigitSeparator(int value1) => Console.WriteLine("Main value: {0}\nFirst digit: {1} \nsecond digit: {2}", value1, value1 / 10, value1 % 10);
        #endregion

        #region Sumar dos digitos de un entero
        public static void Sum(int value1) => Console.WriteLine("Main value: {0}\nTotal: " + (value1 / 10 + value1 % 10), value1);
        #endregion

        #region Sumar 3 digitos de un entero
        public static void Sum3Digits(int value1) => Console.WriteLine("Main value: {0}\nTotal: {1}", value1, (value1 / 100) + ((value1 / 10) % 10) + (value1 % 10));
        #endregion

        #region Separar entero de cuatro digitos
        public static void Digits4Separator(int value1) => Console.WriteLine("Main value: {0}\nFirst digit: {1}\nSecond digit: {2}\nThird digit: {3}\nFourth digit: {4}",value1, value1 / 1000, (value1 / 100) % 10, (value1 / 10) % 10, value1 % 10);
        #endregion

        #region Suma total, promedio, maxima y minima edad
        public static void Ages(int age1, int age2, int age3)
        {
            int ageTotal = age1 + age2 + age3;
            Console.WriteLine("Age total: {0}\nAverage: {1}\nThe oldest: {2}\nThe youngest: {3}",ageTotal,ageTotal/3,Math.Max(age1,Math.Max(age2,age3)),Math.Min(age1,Math.Min(age2,age3)));
        }
        #endregion

        #region Dividir(para no mezclar los ejercicios)
        public static void Divider() => Console.WriteLine("---------------------------------------------------------------------------------");
        #endregion




    }
}
