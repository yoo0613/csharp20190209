using System;

namespace TypeCastExample1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(+3);
            Console.WriteLine(3+3);
            Console.WriteLine(3+.3);
            Console.WriteLine("3"+"3");
            Console.WriteLine(3.0 + "3");   //3.0이 문자열 3으로 변경 되어 결과는 "3"+"3"과 같음

            Console.WriteLine(!true);

            byte x = 10;
            Console.WriteLine(~x);

            Console.WriteLine(unchecked((short)50000));
        }
    }
}
