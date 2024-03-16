using System;

namespace cal{
    class cacul {

        static void add(ref int a, ref int b) {
            a + b;
        }
        static void min(ref int a, ref int b) {
            a - b;
        }
        static void mul(ref int a, ref int b) {
            a * b;
        }
        static void dev(ref int a, ref int b) {
            a / b;
        }

        static void Main(String[] args){
            //함수를 사용한 계산기 코드입니다.
            string oper = Console.ReadLine();
            string fst = Console.Readline();
            int num1 = int.Parse(fst);
            string sec = Console.ReadLine();
            int num2 = int.Parse(sec);

            if(oper == '+') {
                int res = add(ref num1, ref num2);

            }
        }
    }
}