using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  
              int i = 0,j=0;
              i = ++j ;
              Console.WriteLine(i);
              Console.WriteLine(j);
              */
            /* int score = Convert.ToInt32(Console.ReadLine());
             if (score>=85) {
                 Console.WriteLine("优秀");
             }else if(score>=75)
             {
                 Console.WriteLine("良好");

             }else if (score>=60 ) {
                 Console.WriteLine("及格");
             }
             else
             {
                 Console.WriteLine("不及格");
             }*/
            /* int score_a = 90;
             int score_b = 90;
             if (score_a >= score_b)
             {
                 if (score_a == score_b)
                 {
                     Console.WriteLine("成绩相同{0}", score_a);
                 }
                 else
                 {
                     Console.WriteLine("较高的成绩{0}", score_b);
                 }
             }
             else {
                 Console.WriteLine("较高的成绩为{0}",score_b);
             }*/

            /*int score = Convert.ToInt32(Console.ReadLine());
            int i = score / 10;
            switch (i) {
                case 10:
                case 9:
                    Console.WriteLine("A");
                    break;
                case 8:
                case 7:
                    Console.WriteLine("B");
                    break;
                case 6:
                    Console.WriteLine("C");
                    break;
                case 5:
                case 4:
                case 3:
                case 2:
                case 1:
                case 0:
                    Console.WriteLine("D");
                    break;
                default:
                    Console.WriteLine("error!");
                    break;
            }*/
            /*double money = 10000;
            double interes = 1.0175;
            int i = 1;
            while (i <= 10)
            {
                money = money * interes;
                Console.WriteLine(money);
                i++;
            }
            Console.WriteLine(money);*/
            /*double money = 10000;
            double rese = 1.0175;
            int i = 1;
            do
            {
                money = money * rese;
                Console.WriteLine("{0}", money);

                i++;
            } while (i <= 10);
            Console.WriteLine("{0}",money);
        }*/

            double money = 10000;
            double rese = 1.0175;
            for (int i = 1; i <= 10; i++)
            {
                money = money * rese;
            }
            Console.WriteLine(money);
        }
    }
}
