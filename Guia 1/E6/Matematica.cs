using System;

namespace E6
{
    public class Matematica
    {
        public void fibonacci(int num)
        {
            int i = 0;
            int fibo = 0;
            int fibo1 = 1;
            
            

            while (i < num)
            {
                
                
                fibo += fibo1;
                Console.WriteLine(fibo);

                if(fibo + fibo1 > num)
                {
                    break;
                }

                fibo1 += fibo;
                Console.WriteLine(fibo1);

                if(fibo + fibo1 > num)
                {
                    break;
                }
            }
        }

        public void factorial(int num)
        {
            int total = 1;
            int i = 1;

            while (i <= num)
            {
                total = total*i;
                
                i++;
            }
            Console.WriteLine(total);

        }

        public int mayor(int num, int num1)
        {
            if(num > num1)
            {
                return num;
            }
            else
            {
                return num1;
            }

        }
        public int menor(int num, int num1)
        {
            if(num < num1)
            {
                return num;
            }
            else
            {
                return num1;
            }

        }

        public int cubo(int num)
        {
            return num * num;
        }


    }   
}