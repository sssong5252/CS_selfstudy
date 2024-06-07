using System;

namespace MethodWithOut
{
    static void NextPosition(int x, int y, int vx, int vy, out int rx, out int ry)
    {
        rx = x + vx;
        ry = y + vy;
    }
    static void Main(string[] args) 
    {
        int x = 0;
        int y = 0;
        int vx = 1;
        int vy = 1;

        System.Console.WriteLine("현재 좌표: ");
        NextPosition(x, y, vx, vy,out x, out y);
        System.Console.WriteLine("");

    }
}