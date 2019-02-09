using System;
namespace ClassTest
{
    class Emp
    {
        string name;
        void GotoOffice()
        {

        }
    }
    class Programmer : Emp  // :는 상속 연산자
    {
    }

    class EmpTest
    {
        static void Main(string[] args)
        {
            /*
            Programmer p = new Programmer();
       
            //is는 객체 타입을 비교하는 연산자이다.
            if(p is Emp)    //Programmer class는 Emp class를 상속 받으므로 True를 반환함 / 반대로 Emp is Programmer는 False
            {
                Console.WriteLine("Programmer is Emp");
            }
            else
            {
                Console.WriteLine("Programmer is not Emp");
            }
            */
            Emp e = new Emp();
            Programmer p = new Programmer();
            Emp e1 = p as Emp;  //p를 Emp로 형 변환. 만약 변환이 불가능하다면 Null이 출력됨
            Emp e2 = (Emp)p;    //p가 Emp로 형 변환. 만약 변환이 불가능하다면 프로그램이 죽는다.
        }
    }
}
