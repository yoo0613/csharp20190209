using System;

namespace TypeCastExample
{
    class Program
    {
        public static void Main(string[] args)
        {
            short a = 10;
            int b = a;

            int c = 50000;

            try
            {
                short d = checked((short)c);    //오버플로우 확인 checked()
                Console.WriteLine("Short:{0}", d);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message); 
                Console.WriteLine(e.StackTrace);
                //Console.WriteLine("예외 : {0}", e.StackTrace);
            }
            
        }
    }
}
