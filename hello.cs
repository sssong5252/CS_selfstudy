using System;
namespace hello {
class HelloWorld {
   static void Main(string[] args) {
      Console.WriteLine("hellowol");
      int number;
      number = 7;
      Console.WriteLine(number);

      if(number == 7) {
         Console.WriteLine("hello number is 7");
      }
      while(true) {
         if(number == 7) {
            Console.WriteLine("this code will return false");
            break;
         }
         else {
            Console.WriteLine("num is not 7");
         }
      }
   }
 }
}