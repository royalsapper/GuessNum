using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randint = new Random();
            int i = (int)Math.Round(randint.NextDouble() * 1000, 0);
            Console.WriteLine("정답: {0}\n", i); // 정답

            try
            {
                while (true)
                {
                    Console.Write("숫자를 입력하세요?");
                    string inputStr = Console.ReadLine();
                    int inputNum = Int32.Parse(inputStr);

                    if (inputNum == i)
                    {
                        Console.WriteLine("정답입니다.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("틀렸습니다.");
                    }
                }
            }
            catch (System.FormatException)
            {
                Console.WriteLine("정수가 아닌 입력값으로 인하여 프로그램을 종료합니다.");
                // Console.WriteLine(exception.GetType());       
            }
        }
    }
}