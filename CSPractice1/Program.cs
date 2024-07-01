using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSPractice1
{

    class MyMath
    {
        public static int classVar = 1; //클래스 변수
        public int instanceVar = 2; //인스턴스 변수
        public static int Abs(int input) //클래스 메서드
        {
            Console.WriteLine(classVar);
            // 클래스 메서드에서 인스턴스 변수는 접근 불가
            // Console.WriteLine(instanceVar); 
            return (input >= 0) ? input : -input;
        }

        //메서드 시그네이쳐(이름, 매개변수)가 겹치면 안 됨
        // public static double Abs(int input) { return 0; }
        public static double Abs(double input) { return 0; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //컨텍스트 키워드
            /* var abc = "Hello World";
            int var = 10; // 예약어가... 된다?
            Console.WriteLine(var); //함쌤 왈 : 갑자기 풀렸는데 쓰지 말자.
            */

            // 한줄 주석
            /*
             여러줄 주석
             */
            /*** XML 주석 (문서화 주석) ***/

            //출력
            Console.WriteLine("Hello World");
            Console.Write("뉴라인(줄바꿈)x");

            // #1 12-3 기본 자료형
            //정수형
            Console.WriteLine(41 + 9 - 5);
            //사칙 연산자 = 산술 연산자 = Arithmetic Operator
            // + - * / %

            //실수형(Real Number)
            Console.WriteLine(52.3);

            //문자(Character)
            Console.WriteLine("Hello World");
            //이스케이프 문자
            Console.WriteLine("미림 : 가람아~\n가람\t왜\\");
            //문자열 연결 연산자(Concatenation Operator)
            Console.WriteLine("Hello" + " " + "World");
            //문자열 인덱스 접근[]
            Console.WriteLine("Hello World"[4]); //'o'
            //Console.WriteLine("Hello World"[50]); //예외 발생

            //주의
            Console.WriteLine('가' + '힣'); //문자라서 산술연산 처리가 된다.

            //논리(Boolean)
            Console.WriteLine(true);
            Console.WriteLine(false);
            //비교 연산자 (Comparison Operator)
            // == != > < >= <=
            //논리 연산자 (Logical Operator)
            // && || !
            Console.WriteLine(!true);
            Console.WriteLine(true && false);
            Console.WriteLine(true || false);

            // #1 12-4 변수
            // 변수(Variable)
            string name = "문자열 자료형";

            // #1 12-5 복합대입연산자
            // += -= *= /= %=
            string output = "Hello";
            output += " World";
            Console.WriteLine(output);

            // #1 12-6 증감연산자
            int number = 10;
            Console.WriteLine(number++); // 10
            Console.WriteLine(++number); // 12
            Console.WriteLine(number--); // 12
            Console.WriteLine(--number); // 10

            // #1 12-8 var 키워드
            var varnumber = 20;
            // var abc; // var키워드는 초기화를 통해 자료형을 판단하므로 반드시 초기화를 해야한다

            // #1 12-9 입력
            string input = Console.ReadLine();
            Console.WriteLine(input);

            // #1 12-10 자료형 변환
            // !중요!

            // #2 13-1 if 조건문
            bool condition = true;
            if (condition)
            {
                //true
            }else if(condition)
            {
                // true 2
            }
            else
            {
                // other
            }

            // #2 13-2 switch 조건문
            int v = 0;
            switch(v)
            {
                case 0: // case문은 상수여야 한다.
                    //0
                    break; //또한 C#은 break문을 꼭 써야 한다
                default:
                    //other
                    break;
            }

            // #2 13-6 삼항연산자
            Console.WriteLine(number % 2 == 0 ? "짝수" : "홀수");
            Console.WriteLine(number % 2 != 0 ? "홀수" : "짝수");
            Console.WriteLine(number % 2 != 1 ? "짝수" : "홀수");

            // #5 14-1 반복문과 배열
            int[] intArray = new int[100];
            Console.WriteLine(intArray[99]);

            // #5 14-2 while 반복문
            int i = 0;
            int[] intArray2 = { 52, 273, 32 };
            while(i < intArray2.Length)
            {
                Console.WriteLine(intArray2[i]);
                i++; // 탈출을 위한 변수
            }

            // #5 14-6 foreach 반복문
            string[] foreachArray = { "사과", "배", "포도" };
            foreach (var item in foreachArray)
            {
                Console.WriteLine(item);
            }

            // #3 21-2 클래스 사용
            Random random = new Random();
            Console.WriteLine(random.Next(1, 7)); // 두 번째 파라미터인 maxValue는 포함되지 않는 범위이다.

            Console.WriteLine(Math.Abs(-9)); //절댓값: 9
            Console.WriteLine(Math.Ceiling(52.273)); //올림: 53
            Console.WriteLine(Math.Floor(52.273)); //내림: 52
            Console.WriteLine(Math.Round(52.273)); //반올림: 52
            Console.WriteLine(Math.Max(52, 273)); //273
            Console.WriteLine(Math.Min(52, 273)); //52
            Console.WriteLine(Math.PI); //3.141592...

            // #3 21-3 클래스 생성

            // #3 21-4 인스턴스 변수
            User user1 = new User();
            user1.name = "김미림";
            user1.phoneNumber = "010-0101-0101";

            Product p1 = new Product();
            p1.name = "공책";
            p1.price = 1234;

            Product p2 = new Product() { name = "포켓몬 포켓파플레 대타출동 봉제인형", price = 42000 };
            Product p3 = new Product() { price = 4500 };

            // #3 21-5 클래스 변수
            Console.WriteLine(Product.TAX_RATIO);
            // Console.WriteLine(p1.TAX_RATIO);  // Java와 달리 C#에서 클래스 변수는 반드시 클래스로 접근해야 한다.

            // #4 22-3 클래스 메서드

            // #4 22-4 메서드 오버로딩
            Console.WriteLine(MyMath.Abs(-10)); // Abs(int)
            Console.WriteLine(MyMath.Abs(10.0)); // Abs(double)
            Console.WriteLine(MyMath.Abs(-10L)); // Abs(double)
            Console.WriteLine(MyMath.Abs(3.0f)); // Abs(double)
        }
    }
}
