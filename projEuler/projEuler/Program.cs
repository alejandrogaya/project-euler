using System;
using System.Collections.Generic;

namespace projEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            ex6();
        }

        public static void ex1()
        {
            int i = 0;
            int sum = 0;

            while (i < 1000)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    //Console.WriteLine(i);
                    sum += i;
                }
                i++;
            }

            Console.WriteLine("The sum of all multiples of 3 or 5 below 1000 is:" + sum);
            Console.ReadLine();
        }

        public static void ex2()
        {
            Int64 sum = 2;
            List<int> fibbonacciSequence = new List<int>();
            bool exceed = false;

            fibbonacciSequence.Add(1);
            fibbonacciSequence.Add(2);

            while (!exceed)
            {
                if (fibbonacciSequence[fibbonacciSequence.Count - 1] > 4000000)
                {
                    exceed = true;
                }
                else
                {
                    fibbonacciSequence.Add((fibbonacciSequence[fibbonacciSequence.Count - 1]) + (fibbonacciSequence[fibbonacciSequence.Count - 2]));

                    if (fibbonacciSequence[fibbonacciSequence.Count - 1] % 2 == 0)
                    {
                        sum += fibbonacciSequence[fibbonacciSequence.Count - 1];
                    }
                }
            }

            Console.WriteLine("The sum of the even-valued terms in Fibonacci sequence < 4 million is:" + sum);
            Console.ReadLine();
        }

        public static void ex3()
        {
            Int64 number = 600851475143;
            Int64 limit = (Int64)(Math.Sqrt(number));
            Int64 prime = 0;

            for (Int64 i = limit; i >= 1; i--)
            {
                if (number % i == 0)
                {
                    if (isPrime(i))
                    {

                        prime = i;
                        break;
                    }

                    if (i != number / i)
                    {
                        if (isPrime(number / i))
                        {
                            prime = number / i;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine("largest prime: " + prime);
            Console.ReadLine();
        }


        public static void ex5()
        {
            int num = 1;
            bool found = false;
            while (!found)
            {
                if (isDivisibleFrom1To20(num)) found = true;
                num++;
            }

            Console.WriteLine("Solution: " + (num - 1));
            Console.ReadLine();
        }

        private static bool isDivisibleFrom1To20(int num)
        {
            for (int i = 1; i <= 20; i++)
            {
                if (num % i != 0) return false;
            }

            return true;
        }

        public static void ex6()
        {
            int[] solution = new int[2];
            solution = getSumOfSquaresAndSquareOfSum(100);

            Console.WriteLine("Solution: " + (solution[1] - solution[0]));
            Console.ReadLine();
        }

        private static int[] getSumOfSquaresAndSquareOfSum(int limit)
        {
            int[] sum = new int[2];

            for (int i = 1; i <= limit; i++)
            {
                sum[0] += (int)Math.Pow(i, 2);
                sum[1] += i;
            }

            sum[1] = (int)Math.Pow(sum[1], 2);

            return sum;

        }


        // HARD STUCK
        public static void ex4()
        {
            //int number1 = 999;
            //int number2 = number1;
            //List<int> num = new List<int>();

            /*for (int i = number1; i > 99; i--)
            {
                num = getDigitsArray(i * number2);
                if (isPalindrome(num.ToArray()))
                {
                    Console.Write("The largest palindrome made from the product of two 3-digit numbers is: " + i * number2);
                    Console.ReadLine();
                    break;
                }
            }*/

            int num = 999;
            int limit = num * num;
            int palindrome = 0;
            List<int> listNum = new List<int>();

            for (int i = limit; i > 0; i--)
            {
                listNum = getDigitsArray(i);
                if (isPalindrome(listNum.ToArray()))
                {
                    palindrome = i;
                    break;
                }
            }

            Console.WriteLine("Palindrome: " + palindrome);
            Console.ReadLine();


            //int[] prueba = new int[7] { 3, 0, 3, 8 , 3 , 0 , 3 };
            //Console.WriteLine(isPalindrome(prueba));
            //Console.ReadLine();
        }

        private static bool isPalindrome(int[] num)
        {
            int limit = (int)(num.Length / 2);

            for (int i = 0; i < limit; i++)
            {
                if (num[i] != num[num.Length - 1 - i]) return false;
            }

            return true;
        }

        private static List<int> getDigitsArray(int num)
        {
            List<int> list = new List<int>();
            while (num > 0)
            {
                list.Add(num % 10);
                num /= 10;
            }

            return list;
        }

        private static bool isPrime(Int64 number)
        {
            if (number <= 1) return false;
            if (number <= 3) return true;
            if (number % 2 == 0 || number % 3 == 0) return false;



            for (int i = 5; i * i <= number; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
