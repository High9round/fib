using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Numerics;

namespace fib
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("fib:{0}", fib(50));
            Console.WriteLine("fib_for:{0}", fib_for(99999999));
        }

        //재귀 함수
        static BigInteger fib(BigInteger n)
        {
            if (n < 2)
            {
                return n;
            }
            else
            {
                return fib(n - 1) + fib(n - 2);
            }
        }

        //반복문
        static BigInteger fib_for(BigInteger n)
        {
            if (n < 2)
            {
                return n;
            }
            else
            {
                BigInteger tmp = 0;
                BigInteger v1 = 1;
                BigInteger v2 = 1;

                for (int i = 3; i <= n; i++)
                {
                    tmp = v2;
                    v2 = v2 + v1;
                    v1 = tmp;
                }

                return v2;
            }
        }

    }
}
