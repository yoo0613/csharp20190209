using System;

namespace HelloWorld
{
    class Program
    {
        int i;  // 멤버. 필드, 인스턴스 변수
        static int j;   //멤버, 변수, 클래스 변수    new 사용 없이 다이렉트 접근 가능 ex) Program.j
        //클래스 = 설계도     객체 = 집

        static void Main(string[] args) //멤버, 메소드
        {
            string name = "유승훈";
            int k = 99;
            Console.WriteLine($"Hello {name}"); // 주로 사용
            Console.WriteLine("Hello " + name);
            Console.WriteLine("Hello {0}{1}", name, k);
        }
    }
}
