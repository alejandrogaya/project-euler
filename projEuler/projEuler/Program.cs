using System;
using System.Collections.Generic;

namespace projEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex8();
        }

        public static void Ex1()
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

        public static void Ex2()
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

        public static void Ex3()
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


        public static void Ex5()
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

        public static void Ex6()
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

        public static void Ex7()
        {
            List<int> primes = new List<int>();
            primes.Add(2);
            primes.Add(3);
            primes.Add(5);
            primes.Add(7);
            primes.Add(11);
            primes.Add(13);
            Int64 i = 14;
            bool found = false;

            while (!found)
            {
                if (isPrime(i))
                {
                    primes.Add((int)i);
                }

                i++;

                if (primes.Count == 10001)
                {
                    found = true;
                }
            }

            Console.WriteLine("Solution: " + primes[primes.Count - 1]);
            Console.ReadLine();
        }

        public static void Ex8()
        {
            String number = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
            List<ulong> prod = new List<ulong>();
            int count;
            int inverse_counter = number.Length - 1;
            ulong multiply;

            for(int i = 0; i < number.Length; i++)
            {

                count = i;
                multiply = 1;

                if ((count + 30) < number.Length) { 
                    while (count <= i + 13)
                    {
                        multiply *= (ulong)Convert.ToInt64(number[count]);
                        count++;
                    }
                    prod.Add(multiply);
                    //Console.WriteLine(multiply);
                    //Console.ReadLine();
                }

                multiply = 1;

                if ((inverse_counter - 30) > 0)
                {
                    int j = inverse_counter;
                    while (inverse_counter >= j - 13)
                    {
                        multiply *= (ulong)Convert.ToInt64(number[inverse_counter]);
                        inverse_counter--;
                    }
                    inverse_counter = j - 1;

                }

            }
            //prod.Sort();
            ulong max = 0;
            foreach (ulong a in prod)
            {
                if (a > max)
                {
                    max = a;
                }
                
             
                
            }
            Console.WriteLine(max);
            Console.ReadLine();
            Console.WriteLine(prod[prod.Count - 1]);

            /*foreach (Int64 p in prod)
            {
                Console.WriteLine(p);
            }*/
            Console.ReadLine();
        }

        // HARD STUCK
        public static void Ex4()
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
