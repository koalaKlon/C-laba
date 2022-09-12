﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp7
{
    
    internal class Program
    {

        static void Print()
        {
            Console.WriteLine("Zadani 1 ");
            bool a1 = false;
            byte a2 = 2;
            sbyte a3 = 2;
            char a4 = 's';
            decimal a5 = 2;
            double a6 = 2.342;
            float a7 = 34;
            int a8 = int.Parse(Console.ReadLine());
            uint a9 = 4;
            long a10 = 123;
            ulong a11 = 5;
            short a12 = 6;
            ushort a13 = 3;
            object a14 = 4;
            string a15 = "fhsdkajlhsfk";
            dynamic a16 = 123;
            Console.WriteLine($"{a1} {a2} {a3} {a4} {a5} {a6} {a7} {a8} {a9} {a10} {a11} {a12} {a13} {a14} {a15} {a16}");
        }

        static void Conv()
        {
            Console.WriteLine("Convert");
            string a = "344";

            int n = Convert.ToInt32(a);
            Console.WriteLine(n);
        }

        static void NeIvn()
        {
            Console.WriteLine("Неявные:");
            byte a = 4;
            ushort b = a; // 1 ne
            Console.WriteLine(b);
            sbyte k = 4;
            short v = k;
            Console.WriteLine(v);
            sbyte h = -4;
            short l = h;
            Console.WriteLine(l);

            sbyte h1 = -22;
            short l3 = h1;
            Console.WriteLine(l3);

            sbyte hh = -83;
            short ll = hh;
            Console.WriteLine(ll);

        }

        static void Inv()
        {
            Console.WriteLine("Явные:");
            int a = 2;
            int b = 3;
            byte c = (byte)(a + b);
            Console.WriteLine(c);

            int v = 3;
            int g = 54;
            double hh = (double)(v + g);
            Console.WriteLine(hh);

            double gg = 3.3;
            double g1 = 3.3;
            int j = (int)(g + gg);
            Console.WriteLine(j);

            sbyte ds = 3;
            sbyte dsa = 23;
            int fd = (int)(ds+dsa);
        }


        static void Stroka()
        {
            string s = "sfd";
            string ss = "fsdsgssdg";
            int res = string.Compare(s, ss);
            Console.WriteLine(res);
          
        }

        static void Zvar()
        {
            var ka = '/';
           // ka = "32"
        }

        static void bub()
        {
            Console.WriteLine("сравнение Cтроки ");
            string s1 = "123";
            string s2 = "321";
            string s6 = "dfggsd";
            string s3 = s1 + " " + s2;
            string s4 = string.Concat(s3,"123");
            Console.WriteLine(s4);
            

            //поиск в строке
            string s5 = "hello world";
            char ch = 'o';
            int indexOfChar = s5.IndexOf(ch); // равно 4
            Console.WriteLine(indexOfChar);

            //разделение 
            string text = "ТУт можно написать что угодно и оно будет выводиться с переносом ";

            string[] words = text.Split(new char[] { ' ' });

            foreach (string s in words)
            {
                Console.WriteLine(s);
            }

            string fal = "";
            string gg = "fsd";
            bool res = string.IsNullOrEmpty(fal);
            bool res2 = string.IsNullOrEmpty(gg);
            if(res)
                Console.WriteLine("This element is empty");
            Console.WriteLine($"{res} {res2}");

            string kf = "gsg";
            StringBuilder sb = new StringBuilder("HEllo World!");
            sb.Remove(2,5);
            sb.Insert(2,kf);
            Console.WriteLine(sb.ToString());
        }
        
        static void Arr()
        {

            int[,] arrl = new int[4,4];
            for (int i = 0; i<4;i++)
            {
                for (int j = 0;j<4;j++)
                {
                    Console.Write($"{arrl[i,j]}\t");
                }
                Console.WriteLine();
            }

            int fak = Convert.ToInt32(Console.ReadLine());
            string[] str = { "dfs", "432", "jslk", "kw;lgw","das"};
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine($"{str[i]}");
            }
            Console.WriteLine(str.Length);
            
            Console.WriteLine("Какие элементы вы хотите поменять?");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            string str2 = "";
            str2 = str[num1];
            str[num1] = str[num2];
            str[num2] = str2;
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine($"{str[i]}");
            }

            //ступенчатые массивы(зубчатые массивы)
 
            int[][] arr = new int[4][];
            arr[0] = new int[4];
            arr[1] = new int[1];
            arr[2] = new int[2];
            arr[3] = new int[5];
            Random random = new Random();
            for (int i = 0;i < arr.Length;i++)
            {
                for (int j = 0; j < arr[i].Length;j++)
                {
                    arr[i][j] = random.Next(1,100);
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write($" {arr[i][j]}\t");     
                }
               Console.WriteLine();
             }


            //int[] ad = new int[4];
            //var C = new[] { 43, ad[4] , 4, '5', 'z' };

        }


        static void kortez()
        {
            Console.WriteLine("Создание кортежа с указаннвми типами: ");
            (ulong, int, string, char, string) tuple = (43, 3, "gal",'g',"hello");
            Console.WriteLine($"Кортеж {tuple.Item1} {tuple.Item2} {tuple.Item3} {tuple.Item4} {tuple.Item5}");
           
            
            Console.WriteLine("Какой элемент вы хотите вывести? ");
            int choice = int.Parse(Console.ReadLine());
            
            switch (choice)
            {
                case 1:Console.WriteLine(tuple.Item1); break;

                case 2: Console.WriteLine(tuple.Item2); break;


                case 3:  Console.WriteLine(tuple.Item3); break;

                case 4: Console.WriteLine(tuple.Item4); break;

                case 5: Console.WriteLine(tuple.Item5); break;
            }
            Console.WriteLine("РАспаковка кортежа в переменную: ");
            var c = ("Sindy", 43);
            (string name, int age) = c;
            Console.WriteLine($"Name: {name} Age: {age}");

            Console.WriteLine("Сравнение Кортежей: ");
            var firstTuple = (2,34,52,"fds") ;
            var secondTuple = (3,35,2,"435") ;
            Console.WriteLine(firstTuple == secondTuple);
        }
     
        static void Chek()
        {
            int a = 2147483647;
            Console.WriteLine(checked(a));
            try
            {
                int res = 0;
                checked
                {
                    res = a + 1;
                }
            }
            catch (OverflowException)
            {
                Console.Write("Переполнение\n\n");
            }
        }
        static void UnChek()
        {
            int a = 2147483647;
            Console.WriteLine(unchecked(a));
            try
            {
                int res = 0;
                checked
                {
                    res = a + 1;
                }
            }
            catch (OverflowException)
            {
                Console.Write("Переполнение\n\n");
            }
        }



        static void Main(string[] args)
        {
            Print();
            Conv();
            NeIvn();
            Inv();
            //nullable
            Console.WriteLine("\nZadanie nullable ");
            int? val = null;//значимому типу null
            Console.WriteLine(val);
            var k = 54;
            //k = "fdkl";

            Console.WriteLine("\nЗАДАНИЕ 2");
            Stroka();
            bub();
            Console.WriteLine("\nЗАДАНИЕ 3");

            Arr();

            Console.WriteLine("\nЗАдаине 4");
            kortez();

            Console.WriteLine("\nЗАдаине 5");
            (int,int,int,char) Glent(int[] arr, string str)
            {
                int minValue = 11;
                int maxValue = 0;
                int sumArr = 0;
                char firstSymbol = ' ';
                Random random = new Random();
                for (int j = 0; j < arr.Length; j++)
                {
                    arr[j] = random.Next(1, 10);
                }
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] < minValue)
                    {
                        minValue = arr[i];
                    }
                    if (arr[i] > maxValue)
                    {
                        maxValue = arr[i];
                    }

                    sumArr += arr[i];
                  
                }
                Console.WriteLine("MASSIV: ");

                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine($"{arr[i]}"); 
                }

                for(int g = 0; g < str.Length; g++)
                {
                    firstSymbol = str[0];
                }
                var result = (minValue,maxValue,sumArr,firstSymbol);
                return result;
            }
            int[] arr1 = new int[5];
            string str1 = "fsd";
            Console.WriteLine(Glent(arr1,str1));

            Console.WriteLine("Задание 6");
            Chek();
            UnChek();

        }
    }
}
