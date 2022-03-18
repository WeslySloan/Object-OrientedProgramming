using System;

namespace Name
{
    internal class ProgramFirst
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());
            if (year < 1 && year > 4000) return;

            if (DateTime.IsLeapYear(year)) Console.WriteLine(year + "년은 윤년 입니다.");
            else Console.WriteLine(year + " 년은 윤년이 아닙니다.");

        }
    }
}