using System;

namespace hw3 
{
    class forifwhile 
    {
        public static void Main(string[] args) {
            while (true)
            {
                Console.Write("숫자를 입력해주세요(짝수를 입력하면 종료): ");
                int input = int.Parse(Console.ReadLine());
                if (input % 2 == 0)
                {
                    break;
                }
            }
            System.Console.WriteLine("컴퓨터공학과, 20230850, 001, 송준용");
        }
    }
}