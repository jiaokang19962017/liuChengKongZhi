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

            /*double money = 10000;
            double rese = 1.0175;
            for (int i = 1; i <= 10; i++)
            {
                money = money * rese;
            }
            Console.WriteLine(money);*/
            #region 1-10的和
            //int s = 0;
            //for (int i = 1;i<=10;i++)
            //{
            //    s = s + i;
            //}
            // Console.WriteLine(s);
            #endregion

            #region 10以内偶数的和
            /*  int sum =0;
          for (int i = 0;i<=10;i++)
          {
              if (i % 2 == 0)
              {
                  sum = sum + i;
              }
          }
          Console.WriteLine(sum);*/
            #endregion

            #region 学生平均成绩
            /* int count = 0;
              for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("请输入第{0}班级", i + 1);
                    //内层循环:学生成绩
                    int sum = 0;//存放每个班的学生成绩
                    int avg = 0;//存放每个班的平均成绩
                    for (int j = 0; j < 4; j++)
                    {
                        Console.WriteLine("第{0}名学生的成绩", j + 1);
                        int score = int.Parse(Console.ReadLine());//输入成绩
                        sum += score;//累加成绩
                     if (score < 85) {
                         continue;
                     }
                     count++;
                    }
                 /* avg = sum / 4;//平均成绩
                  Console.WriteLine("第{0}个班级的平均成绩:{1}", i + 1, avg);
                 Console.WriteLine("高于85分的人数为{0}人",count);
                }*/

            #endregion

            #region  打印*直角三角形图案
            /*  for (int i = 0; i <= 5; i++)
             {
                 for (int j = 0; j < i; j++)
                 {
                     Console.Write("*");
                 }
                 Console.WriteLine();
             }*/
            #endregion



            #region foreach循环,输出一个字符串
            //string str = Console.ReadLine();
            //foreach (char item in str)
            //{
            //    Console.Write(item + " ");
            //}
            #endregion
            #region 练习
            //for循环
            /*int sum = 0;
             for (int i = 0; i <= 100; i++) {
                 sum = sum + i;
             }
             Console.WriteLine(sum);*/
            //do-while循环
            /* int sum = 0;
             int i = 0;
             do
             {
                 sum = sum + i;
             } while (i++<100);
             Console.WriteLine(sum);*/

            //while循环
            /*int sum = 0;
            int i = 0;
            while (i++ < 100)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);*/

            //99乘法表
            /* for (int i = 0; i <= 9; i++)
             {
                 for (int j = 0; j <= i; j++)
                 {
                     Console.Write("{0}x{1}={2}\t", i, j, i * j);
                 }
                 Console.WriteLine();
             }*/

            /* for (int i=0;i<10;i++)//终止整个循环
             {
                 if (i == 5) {
                     break;
                 }
                 Console.WriteLine(i+"");
             }*/

            /*for (int i = 0; i < 10; i++)//终止当前循环,执行下一次循环
            {
                if (i == 5)
                {
                    continue;
                }
                Console.WriteLine(i + "");
            }*/


            //商店
            for (int i=0;i<5;i++)
            {
                int count = 0;
                Console.WriteLine("欢迎进入第{0}家专卖店",i+1);
                for(int j = 0; j < 3; j++) {
                Console.WriteLine("你要离开这家专卖店吗?y/n");
                string str = Console.ReadLine();
                    if (str == "y") {
                        break;
                    }
                    Console.WriteLine("买了一件衣服");
                    count++;
                }
                Console.WriteLine("商店结账,买了{0}件",count);
            }
            #endregion
        }
    }

}
