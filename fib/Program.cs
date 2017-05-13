using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Numerics;
using System.Threading;
using System.Threading.Tasks;

namespace fib
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("fib:{0}", fib(50));
            System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            Console.WriteLine("fib_for:{0}", fib_for(10));
            watch.Stop();
            Console.WriteLine("Elapsed Time:{0}",watch.Elapsed.ToString());
            Console.WriteLine("Press ENTER to EXIT");
            Console.ReadLine();
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

                //직렬
                while(tmp<=n)
                {
                    tmp = v2;
                    v2 = v2 + v1;
                    v1 = tmp;
                }
                /*
                //병렬
                Parallel.For(0, (int)n, (i) => {
                    tmp = v2;
                    v2 = v2 + v1;
                    v1 = tmp;
                });
                */

                return v2;
            }
        }

    }
}
