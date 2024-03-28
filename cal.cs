using System;

namespace cal
{
    class cacul
    {
        static int add(ref int a, ref int b)
        {
            return a + b;
        }
        
        static int min(ref int q, ref int w)
        {
            return q - w;
        }
        
        static int mul(ref int e, ref int r)
        {
            return e * r;
        }
        
        static int dev(ref int t, ref int y)
        {
            return t / y;
        }

        40

        20 카메라
        15 교통비
        1 오티티
        3 데이트
        1 용돈



        static void Main(string[] args)
        {
            // 함수를 사용한 계산기 코드입니다.
            string oper = Console.ReadLine();
            string fst = Console.ReadLine();
            int num1 = int.Parse(fst);
            string sec = Console.ReadLine();
            int num2 = int.Parse(sec);

            int res = 0;

            if (oper == "+")
            {
                res = add(ref num1, ref num2);
            }
            else if (oper == "-")
            {
                res = min(ref num1, ref num2);
            }
            else if (oper == "*")
            {
                res = mul(ref num1, ref num2);
            }
            else if (oper == "/")
            {
                res = dev(ref num1, ref num2);
            }

            Console.WriteLine("결과: " + res);
        }
    }
}
