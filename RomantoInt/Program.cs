using System;

namespace RomantoInt
{
    class Program
    {
        static void Main(string[] args)
        {
            string roman = "MCMXCIV";
            int number = 0;
            number = RomanToInt(roman);
            Console.WriteLine("Hello World!");
        }
        
            static int RomanToInt(string s)
            {
                string x = s;
                int number = 0;
                for (int i = 0; i < s.Length;)
                {
                    switch (s[i])
                    {
                        case 'M':
                            number += 1000;
                            i++;
                            break;
                        case 'D':
                            number += 500;
                            i++;
                            break;
                        case 'C':
                            if (x[i + 1] == 'M')
                            {
                                number += 900;
                                i += 2;
                            }
                            else if (x[i + 1] == 'D')
                            {
                                number += 400;
                                i += 2;
                            }

                            else
                            {
                                number += 100;
                                i++;
                            }
                            break;
                        case 'L':
                            number += 50;
                            i++;
                            break;
                        case 'X':
                            if (x[i + 1] == 'C')
                            {
                                number += 90;
                                i += 2;
                            }
                            else if (x[i + 1] == 'L')
                            {
                                number += 40;
                                i += 2;
                            }
                            else
                            {
                                number += 10;
                                i++;
                            }
                            break;
                        case 'V':
                            number += 5;
                            i++;
                            break;
                        case 'I':
                            if (x[i + 1] == 'X')
                            {
                                number += 9;
                                i += 2;
                            }
                            else if (x[i + 1] == 'V')
                            {
                                number += 4;
                                i += 2;
                            }
                            else
                            {
                                number++;
                                i++;
                            }
                            break;
                    }
                }
                return number;
            }
        
    }
}
