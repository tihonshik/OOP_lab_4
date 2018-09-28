using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab_4
{
    static class SuperMath
    {
        public static int getMax(List obj)
        {
            int x = 0;
            for(int i=0; i<10; i++)
            {
                if(x < obj[i])
                {
                    x = obj[i];
                }
            }
            return x;
        }
        public static int getMin(List obj)
        {
            int x=0;
            for (int i = 0; i < 9; i++)
            {
                if (obj[i+1] > obj[i])
                {
                    x = obj[i];
                }
            }
            return x;
        }
        public static int getCount(List obj)
        {
            int count = 0;
            for (int i=0; i< 10; i++)
            {
                if(obj[i] != -1)
                {
                    count++;
                }
            }
            return count;
        }
    }
    public static class Extensions
    {
        public static int countOfNulls(this List st, List obj)
        {
            int count = 0;
            for (int i = 0; i < 10; i++)
            {
                if (obj[i] == 0)
                {
                    count++;
                }
            }
            return count;
        }
        public static int countOfWords(this String st, string a)
        {
            int count = 0;
            foreach (char c in a)
            {
                if (c == ' ')
                {
                    count++;
                }
            }
            return count;
        }
    }
    public class List
    {
        public static readonly int size = 10;
        private int[] elem = new int[size];

        public int this[int i]
        {
            get
            {
                return elem[i];
            }
            set
            {
                elem[i] = value;
            }
        }

        public static List operator +(List obj, int i)
        {
            obj[size-1] = i;
            return obj;
        }

        public static List operator --(List obj)
        {

            obj[size-1] = -1;
            return obj;
        }


        public static bool operator !=(List obj, List obj1)
        {
            int q = 0;
            for (int i = 0; i < 10; i++)
            {
                if (obj[i] == obj1[i])
                {
                    q++;
                }
            }
            if (q == size)
            {
                return false;
            }
            return true;
        }


        public static bool operator ==(List obj, List obj1)
        {
            int q = 0;
            for( int i=0; i<10; i++)
            {
                if(obj[i] == obj1[i])
                {
                    q++;
                }
            }
            if(q == size)
            {
                return true;
            }
            return false;
        }

        public static bool operator true(List obj)
        {
            for(int i=0; i<9; i++)
            {
                if(obj[i] > obj[i+1])
                {
                    return false;
                }
            }
            return true;
        }

        public static bool operator false(List obj)
        {
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public class Owner
        {
            int id;
            string name;

            public Owner(int id, string name)
            {
                this.id = id;
                this.name = name;
            }

            public void Out()
            {
                Console.WriteLine($"{this.name} {this.id}");
            }
        }

        public class Date
        {
            int day;
            int month;

            public Date(int day, int month)
            {
                this.day = day;
                this.month = month;
            }

            public void Out()
            {
                Console.WriteLine($"{this.day} {this.month}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List Q = new List();
            List W = new List();
            for (int i=0; i<10; i++)
            {
                W[i] = i;
                Q[i] = i;
            }
            Q--;
            Q = Q + 20;

            Console.WriteLine(Q != W);
            if (Q)
            {
                Console.WriteLine("true");
            }

            for(int i=0; i<10; i++)
            {
                Console.WriteLine(Q[i]);
            }

            List.Owner A = new List.Owner(1, "Filipp");
            A.Out();
            List.Date B = new List.Date(8, 2);
            B.Out();

            Console.WriteLine(Q.countOfNulls(Q));
            Console.WriteLine(SuperMath.getMax(Q));
        }
    }
}
