using System;

namespace classstudy 
{
    class Program
    {
        static void Main(string[] args)
        {
            // 절대값 계산
            
            Console.WriteLine(Math.Abs(-52273)); // 출력: 52273
            
            // 올림
            Console.WriteLine(Math.Ceiling(52.273)); // 출력: 53
            
            // 내림
            Console.WriteLine(Math.Floor(52.273)); // 출력: 52
            
            // 두 수 중 큰 값 반환
            Console.WriteLine(Math.Max(52, 273)); // 출력: 273
            
            // 두 수 중 작은 값 반환
            Console.WriteLine(Math.Min(52, 273)); // 출력: 52
            
            // 반올림
            Console.WriteLine(Math.Round(52.273)); // 출력: 52
        }
    }
}
