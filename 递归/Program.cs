using System;
using System.Collections;

namespace 递归
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Foo(30));
            //MaoPao();
            // B b = new B();
            //Console.WriteLine(b);
            //Console.Read();

            //select * from (select ROW_NUMBER() over(order by t.ID) curr,t.* from tableA t) a where a.curr between 31 and 40 
            MaoPao(一百个不重复的随机数());
            Console.Read();
        }
        /// <summary>
        /// 递归
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        private static int Foo(int i)
        {
            if (i <= 0)
            {
                return 0;
            }
            else if (i > 0 && i <= 2)
            {
                return 1;
            }
            else
            {
                return Foo(i - 1) + Foo(i - 2);
            }
        }

        private static void MaoPao(int[] num)
        {
            int a = 0;
            //int[] num = new int[] { 19, 1, 38, 49, 85, 16, 867, 282 };
            for (int i = 0; i < num.Length - 1; i++)
            {
                for (int j = 0; j < num.Length - 1 - i; j++)
                {
                    if (num[j] > num[j + 1])    //降序改为“<”
                    {
                        a = num[j];
                        num[j] = num[j + 1];
                        num[j + 1] = a;
                    }
                }
            }
            foreach (int number in num)
            {
                Console.Write(number + "   ");
            }
            Console.ReadKey();
        }

        private static int[] 一百个不重复的随机数()
        {
            int[] intArr = new int[100];
            ArrayList myList = new ArrayList();
            Random rnd = new Random();
            while (myList.Count < 100)
            {
                int num = rnd.Next(1, 101);

                if (!myList.Contains(num))
                {
                    myList.Add(num);
                }
            }

            for (int i = 0; i < myList.Count; i++)
            {
                intArr[i] = (int)myList[i];
            }

            return intArr;
        }
    }



    class A
    {
        public A()
        {
            PrintFields();
        }
        public virtual void PrintFields() { }
    }
    class B : A
    {
        int x = 1;
        int y;
        public B()
        {
            y = -1;
        }
        public override void PrintFields()
        {
            Console.WriteLine("x={0},y={1}", x, y);
            Console.Read();
        }
    }
}
