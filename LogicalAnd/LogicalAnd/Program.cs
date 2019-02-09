using System;

namespace LogicalAnd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("정상적인 AND");
            if(Method1() & Method2())   //두함수 모두의 결과 값을 받아서 연산
                Console.WriteLine("Both methods return True");
            else
                Console.WriteLine("둘중 하나의 메소드는 False");

            Console.WriteLine("\nShort-circuit AND");
            if (Method1() && Method2()) //두함수 중 한개라도 False라면 연산 결과가 나옴
                Console.WriteLine("Both methods return True");
            else
                Console.WriteLine("둘중 하나의 메소드는 False");

            Console.WriteLine("0x{0:x}", 0xf8 & 0x3f);
        }

        static bool Method1()
        {
            Console.WriteLine("메소드1...");
            return false;
        }

        static bool Method2()
        {
            Console.WriteLine("메소드2...");
            return true;
        }
    }
}
