using System;

namespace Name
{
    internal class ProgramFirst
    {
        static void Main(string[] args)
        {
            //int year = int.Parse(Console.ReadLine());
            //if (year < 1 && year > 4000) return;

            //if (DateTime.IsLeapYear(year)) Console.WriteLine(year + "년은 윤년 입니다.");
            //else Console.WriteLine(year + " 년은 윤년이 아닙니다.");

            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i % 2 == 0)
            //        continue;
            //    Console.WriteLine(i + "");
            //}
            //Console.WriteLine();

            // 위의 for 문을 while 문으로 , 1 부터 10까지 짝수만, continue 있어야함

            int i = 0;
            while ( i < 10 )
            {
                i++;
                if(i % 2 == 0)
                    continue;
                Console.WriteLine(i + "");
            }

        }
    }
}