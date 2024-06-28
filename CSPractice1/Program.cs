using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPractice1
{
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
        }
    }
}
