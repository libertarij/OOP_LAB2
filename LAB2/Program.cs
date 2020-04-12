using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Ration_numb rn1 = new Ration_numb();
                Console.WriteLine(rn1);

                rn1[0] = 2;
                rn1[1] = 3;
                Console.WriteLine(rn1);

                Ration_numb rn2 = new Ration_numb(1, 2);
                Console.WriteLine(rn2);

                //Операции между рациональными числами
                Console.WriteLine(rn1 + rn2);
                Console.WriteLine(rn1 - rn2);
                Console.WriteLine(rn1 * rn2);
                Console.WriteLine(rn1 / rn2);

                //Инкремент для рационального числа
                Console.WriteLine(++rn1);

                //Декремент для рационального числа
                //Console.WriteLine(--rn1);

                //Операции между рациональным и целым числом
                Console.WriteLine(rn1 + 3);
                Console.WriteLine(rn1 - 3);
                Console.WriteLine(rn1 * 3);
                Console.WriteLine(rn1 / 3);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nОшибка брошена из класса: " + ex.TargetSite.DeclaringType.Name + ", при использовании метода: " + ex.TargetSite + ", строка " + new System.Diagnostics.StackTrace(ex, true).GetFrame(0).GetFileLineNumber());
                Console.WriteLine("Ошибка вызвана в методе: " + new System.Diagnostics.StackTrace(ex, true).GetFrame(1).GetMethod() + ", строка " + new System.Diagnostics.StackTrace(ex, true).GetFrame(1).GetFileLineNumber());
            }
            Console.ReadKey();
        }
    }
}
