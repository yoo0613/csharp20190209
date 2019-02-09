using System;
using System.Runtime.InteropServices;       //Marshal.SizeOf()을 사용하기 위해

namespace TypeCastExample1
{
    class TypeCastExample1
    {
        static void Main(string[] args)
        {
            Console.WriteLine(default(int));

            int iSize = sizeof(int);
            Console.WriteLine($"int형 바이트 길이 : {iSize}");

            Type myType1 = typeof(int);
            Console.WriteLine($"typeof(int) : {myType1}");

            int i = 10;
            Type myType2 = i.GetType();
            Console.WriteLine($"i.GetType() : {myType2}");

            var k = 'a';
            Type myType3 = k.GetType();
            Console.WriteLine($"k.GetType() : {myType3}");

            int j = 99;
            Console.WriteLine($"Size of j : {Marshal.SizeOf(j)}");  //변수의 사이즈
        }
    }
}
