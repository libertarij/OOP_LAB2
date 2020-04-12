using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    class Ration_numb
    {
        private int num;
        private int denum;

        //Индексирование полей класса Ration_numb 0-num 1-denum
        public int this[int index]
        {
            get
            {
                if (index == 0)
                {
                    return num;
                }
                else if (index == 1)
                {
                    return denum;
                }
                throw new Exception("Не верный индекс поля");
            }
            set
            {
                if(index == 0)
                {
                    num = value;
                }
                else if (index == 1)
                {
                    denum = value;
                }
                else
                {
                    throw new Exception("Не верный индекс поля");
                }
            }
        }

        //Стандартные геттеры сеттеры для класса Ration_numb
        public int Num
        {
            get
            {
                return num;
            }

            set
            {
                num = value;
            }
        }

        public int Denum
        {
            get
            {
                return denum;
            }

            set
            {
                if(denum != 0)
                {
                    denum = value;
                }
            }
        }

        //Коснтрукторы для класса Ration_numb
        public Ration_numb() : this(0, 1)
        {
        }

        public Ration_numb(int num, int denum)
        {
            this.num = num;
            this.denum = denum;
        }

        //Переопределение метода ToString()
        public override string ToString()
        {
            return String.Format("{0}/{1}", num, denum);
        }

        //Операции между рациональными числами
        public static Ration_numb operator + (Ration_numb A, Ration_numb B)
        {
            if (A.denum == B.denum)
            {
                return new Ration_numb(A[0] + B[0], A[1]);
            }
            return new Ration_numb(A[0] * B[1] + B[0] * A[1], A[1] * B[1]);
        }

        public static Ration_numb operator -(Ration_numb A, Ration_numb B)
        {
            if (A.denum == B.denum)
            {
                return new Ration_numb(A[0] - B[0], A[1]);
            }
            return new Ration_numb(A[0] * B[1] - B[0] * A[1], A[1] * B[1]);
        }

        public static Ration_numb operator *(Ration_numb A, Ration_numb B)
        {
            return new Ration_numb(A[0] * B[0], A[1] * B[1]);
        }

        public static Ration_numb operator /(Ration_numb A, Ration_numb B)
        {
            return new Ration_numb(A[0] * B[1], A[1] * B[0]);
        }

        //Инкремент для рационального числа
        public static Ration_numb operator ++(Ration_numb A)
        {
            A[0] = A[0] + 1;
            A[1] = A[1] + 1; 
            return A;
        }

        //Декремент для рационального числа
        public static Ration_numb operator --(Ration_numb A)
        {
            if (A.denum != 1)
            {
                A[0] = A[0] - 1;
                A[1] = A[1] - 1;
            }
            return A;
        }

        //Операции между рациональными и целыми числами
        public static Ration_numb operator +(Ration_numb A, int i_B)
        {
            Ration_numb B = new Ration_numb(i_B, 1);
            if (A.denum == B.denum)
            {
                return new Ration_numb(A.num + B.num, A.denum);
            }
            return new Ration_numb(A.num + B.num * A.denum, A.denum);
        }

        public static Ration_numb operator -(Ration_numb A, int i_B)
        {
            Ration_numb B = new Ration_numb(i_B, 1);
            if (A.denum == B.denum)
            {
                return new Ration_numb(A.num - B.num, A.denum);
            }
            return new Ration_numb(A.num - B.num * A.denum, A.denum);
        }

        public static Ration_numb operator *(Ration_numb A, int i_B)
        {
            Ration_numb B = new Ration_numb(i_B, 1);
            return new Ration_numb(A.num * B.num, A.denum);
        }

        public static Ration_numb operator /(Ration_numb A, int i_B)
        {
            Ration_numb B = new Ration_numb(i_B, 1);
            return new Ration_numb(A.num, A.denum * B.num);
        }

    }
}
