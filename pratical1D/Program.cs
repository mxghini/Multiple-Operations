using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratical1D
{
    class Pratical1D
    {
        public void GenerateFibo(int n)
        {
            int no = 0;
            int no1 = 1;
            Console.WriteLine(no + "\n" + no1);
            for (int i=3;i<=n;i++)
            {
                int no3 = no + no1;
                Console.WriteLine(no3);
                no = no1;
                no1 = no3;

            }
        }
        public bool CheckPrime(int n)
        {
            bool revalue = true;
            for(int i=2;i<n/2; i++)
            {
                if(n%i==0)
                {
                    revalue = false;
                    break;
                }
            }
            return revalue;
        }
        public bool Checkvowels(char c)
        {
            bool revalue = false;
            if(c=='a' || c=='A' || c=='e' || c=='E' || c=='i' || c=='I' || c=='o' || c=='O' || c=='u' || c=='U')
            {
                revalue= true;
            }
            return revalue;
        }
        public void DisplayArray(int[] arr )
        {
            foreach(int x in arr)
            {
                Console.WriteLine(x);
            }
        }
        public int ReverseNo(int n)
        {
            int rev = 0, rem = 0;  
            while(n>0)
            {
                rem = n % 10;
                rev = rev * 10 + rem;
                n = n / 10;
            }
            return rev; 
        }
        public int SumOfDigits(int n)
        {
            int sum = 0, rem = 0;
            while(n>0)
            {
                rem = n % 10;
                sum = sum + rem;
                n=n / 10;
            }
            return sum;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Pratical1D p1 = new Pratical1D();
            Console.WriteLine("1 Fibo \n2 Prime Number \n3 Vowels \n4 ForEach \n5 Reverse \n6 SumOf Dogits");
            Console.WriteLine("Enter Choice(1/2/3/4/5/6) ");
            int choice = int.Parse(Console.ReadLine());
            int n = 0;
            switch(choice)
            {
                case 1:
                    Console.Write("How many numbers  you want? ");
                    n = int.Parse(Console.ReadLine());
                    p1.GenerateFibo(n);
                    break;
                case 2:
                    Console.Write("Enter Number");
                    n = int.Parse(Console.ReadLine());
                    bool ans = p1.CheckPrime(n);
                    if (ans == true)
                        Console.WriteLine("Prime Number");
                    else
                        Console.WriteLine("Not a Prime Number");
                    break;
                case 3:
                    Console.WriteLine("Enter Character ");
                    char ch=Console.ReadKey().KeyChar;
                    if (p1.Checkvowels(ch) == true)
                        Console.WriteLine("\nIt is a vowel");
                    else
                        Console.WriteLine("\nIt is not a vowel");
                    break ;
                case 4:
                    int[] no = new int[] { 10, 20, 30, 40, 50, 60, 70, };
                    p1.DisplayArray(no);
                    break;
                case 5:
                    Console.Write("Enter Number ");
                    int x = int.Parse(Console.ReadLine());
                    int y = p1.ReverseNo(x);
                    Console.WriteLine("Reverse no is " + y);
                    break ;
                case 6:
                    Console.Write("enter number ");
                    x = int.Parse(Console.ReadLine());
                    Console.WriteLine("sum of digits " + p1.SumOfDigits(x));
                    break ;
                default:
                    Console.WriteLine("wrong choice");
                    break;
            }
            Console.ReadKey();
        }
    }
}
