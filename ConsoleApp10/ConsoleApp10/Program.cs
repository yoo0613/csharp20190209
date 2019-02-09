using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            // int? a = null;   //int 뒤의 ?는 null값을 허용한다는 의미

            object a = null;
            object b = "abc";

            //??연산자는 null이 아닌 것을 반환해준다.
            object c = a ?? b;
            Console.WriteLine(c);

            object d;

            if (a != null)
                d = a;
            else
                d = b;
            Console.WriteLine(d);

            object e;
            e = (a != null) ? a : d;
            Console.WriteLine(e);
        }
    }
}
