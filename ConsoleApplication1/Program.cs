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
            //int i = 0,j=0;
            //i = ++j ;
            //Console.WriteLine(i);
            //Console.WriteLine(j);
            int score = Convert.ToInt32(Console.ReadLine());
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
            }
        }
    }
}
