using System;

namespace Labtest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("연산 식을 입력 하세요.");
            Console.WriteLine("예 : 3 * 5");
            string str = Console.ReadLine();
            str.Trim();
            string[] strarr = str.Split(' ');

            if(strarr.Length != 3)
            {
                Console.WriteLine("예시와 동일한 형태로 입력해주세요.");
                return;
            }

            int first, second;
            Int32.TryParse(strarr[0], out first);
            Int32.TryParse(strarr[2], out second);

            switch (strarr[1])
            {
                case"+":
                    Console.WriteLine($"{first} + {second} = {first + second}");
                    break;
                case "-":
                    Console.WriteLine($"{first} - {second} = {first - second}");
                    break;
                case "*":
                    Console.WriteLine($"{first} * {second} = {first * second}");
                    break;
                case "/":
                    Console.WriteLine($"{first} / {second} = {first / second}");
                    break;

            }
                
                


        }
    }
}
