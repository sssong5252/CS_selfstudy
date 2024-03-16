using System;

namespace hello {
    class HelloWorld {
        static void change(ref int x, ref int y) { //ref는 값을 전달하기 위해 쓰인다. 콜바이레퍼런스?? 그거 말하는 것 같음
            int tmp;
            tmp = x;
            x = y;
            y = tmp;
        }

        static void Main(string[] args) {
            Console.WriteLine("hellowol");
            int number;
            number = 6;
            Console.WriteLine(number);

            if (number == 7) {
                Console.WriteLine("hello number is 7");
            }

            while (true) {
                if (number == 7) {
                    Console.WriteLine("this code will return false");
                    break;
                } else {
                    Console.WriteLine("num is not 7");
                    break;
                }
            }

            int a = 10;
            int b = 0;
            change(ref a, ref b);
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
