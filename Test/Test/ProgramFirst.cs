using System;
using System.Collections.Generic;
namespace Stack
{
    interface Stack
    {
        bool isEmpty();
        void push(char item);
        char pop();
        void delete();
        char peek();
    }

    class StackNode
    {
        public char data;
        StackNode link;
    }


    public class LinkedStack : Stack
    {
        StackNode top = null;

        public bool isEmpty()
        {
            return (top == null);
        }

        public void push(char item)
        {
            StackNode newNode = new StackNode();
            newNode.data = item;
            newNode.link = top;
            top = newNode;
            // System.out.println("Inserted Item : " + item);
        }

        public char pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("Deleting fail! Linked Stack is empty!!");
                return 0;
            }
            else
            {
                char item = top.data;
                top = top.link;
                return item;
            }
        }

        public void delete()
        {
            if (isEmpty())
            {
                Console.WriteLine("Deleting fail! Linked Stack is empty!!");

            }
            else
            {
                top = top.link;
            }
        }

        public char peek()
        {
            if (isEmpty())
            {
                Console.WriteLine("Peeking fail! Linked Stack is empty!!");
                return 0;
            }
            else
                return top.data;
        }

        public void printStack()
        {
            if (isEmpty())
                Console.WriteLine("Linked Stack is empty!! %n %n");
            else
            {
                StackNode temp = top;
                Console.WriteLine("Linked Stack>> ");
                while (temp != null)
                {
                    Console.WriteLine("\t %c \n", temp.data);
                    temp = temp.link;
                }
                Console.WriteLine();
            }
        }
    }

    public class OptExp
    {
        private String exp;
        private int expSize;
        private char testCh, openPair;

        public bool testPair(String exp)
        {
            this.exp = exp;
            LinkedStack S = new LinkedStack();
            expSize = this.exp.length();
            for (int i = 0; i < expSize; i++)
            {
                testCh = this.exp.charAt(i);
                switch (testCh)
                {
                    case '(':
                    case '{':
                    case '[':
                        S.push(testCh);
                        break;
                    case ')':
                    case '}':
                    case ']':
                        if (S.isEmpty())
                            return false;
                        else
                        {
                            openPair = S.pop();
                            if ((openPair == '(' && testCh != ')') || (openPair == '{' && testCh != '}')
                                    || (openPair == '[' && testCh != ']'))
                                return false;
                            else
                                break;
                        }
                }
            }
            if (S.isEmpty())
                return true;
            else
                return false;
        }
    }

public static class Test
    {
        public static void Main(String[] args)
        {
            OptExp opt = new OptExp();
            String exp = "(3*5)-6/2)";

            Console.WriteLine(exp);

            if (opt.testPair(exp))
                Console.WriteLine("괄호 맞음!!");

            else
                Console.WriteLine("괄호 틀림!!");
        }
    }
    
}

//namespace Name

//internal class ProgramnFirst
//{
//    static void SumAvg(int[] a)
//    {
//        int sum = 0;
//        for (int i = 0; i < a.Length; i++)
//        {
//            sum += a[i];
//        }
//        Console.WriteLine("합계 : " + sum);
//        Console.WriteLine("평균 : " + sum / a.Length);

//        static void Main(string[] args)
//        {
//            int[] array = { 1, 2, 3, 4, 5 };
//            SumAvg(array);
//        }
//    }
//}

//namespace Name
//{
//    class GPU
//    {
//        public String MyGPU = "RTX 3080";

//        public GPU()
//        {
//            Console.WriteLine("Parent 생성");
//        }
//    }

//    class PC : GPU
//    {
//        public PC (String gpu)
//        {
//            this.MyGPU += gpu;
//            Console.WriteLine("gpu 자식 클래스 생성");
//        }

//        public void showGPU()
//        {
//            Console.WriteLine(MyGPU);
//        }
//    }
//    internal class ProgramFirst
//    {
//        static void Main(string[] args)
//        {
//            PC pc = new PC("RTX3080");
//            pc.showGPU();

//            //int num = 6;

//            //for (int i = 0; i < num; i++)
//            //{
//            //    for (int j = 0; j < (num - i - 1); j++)
//            //    {
//            //        Console.Write(" ");
//            //    }
//            //    for (int k = 0; k <= i; k++)
//            //    {
//            //        Console.Write("*");
//            //    }
//            //    for (int l = 0; l < i; l++)
//            //    {
//            //        Console.Write("*");
//            //    }
//            //    Console.WriteLine();
//            //}

//            //int year = int.Parse(Console.ReadLine());
//            //if (year < 1 && year > 4000) return;

//            //if (DateTime.IsLeapYear(year)) Console.WriteLine(year + "년은 윤년 입니다.");
//            //else Console.WriteLine(year + " 년은 윤년이 아닙니다.");

//            //for (int i = 1; i <= 10; i++)
//            //{
//            //    if (i % 2 == 0)
//            //        continue;
//            //    Console.WriteLine(i + "");
//            //}
//            //Console.WriteLine();

//            // 위의 for 문을 while 문으로 , 1 부터 10까지 짝수만, continue 있어야함

//            //int i = 0;
//            //while (i < 10)
//            //{
//            //    i++;
//            //    if (i % 2 == 0)
//            //        continue;
//            //    Console.WriteLine(i + "");
//            //}

//        }
//    }
//}



