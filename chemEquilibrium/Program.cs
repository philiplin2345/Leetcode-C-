using System;

namespace chemEquilibrium
{
    class Program
    {
        static void Main(string[] args)
        {
            string equation = "6CO2+6H2O=C6H12O6+6O2";
            bool balanced = false;
            balanced = IsEquilibrium(equation);
            Console.WriteLine("Hello World!");
        }

         static bool IsEquilibrium(string s)
        {
            string data= s;
            //string data="O34567890K4567890=34567890O+K4567890";

            string[] Data = data.Split("=");
            string left = Data[0];
            string right = Data[1];
            int limitLeft = 0, limitRight = 0;
            for (int i = 0; i < left.Length; i++)
            {
                if (Char.IsUpper(left[i]))
                    limitLeft++;
            }
            for (int i = 0; i < right.Length; i++)
            {
                if (Char.IsUpper(right[i]))
                    limitRight++;
            }

            string plus = "+";
            string[] Left = left.Split(plus);
            string[] Right = right.Split(plus);
            string[] lout = new string[limitLeft];
            double[] lout1 = new double[limitLeft];

            string[] rout = new string[limitRight];
            double[] rout1 = new double[limitRight];
            int lind = 0, rind = 0;
            for (int i = 0; i < Left.Length; i++)
            {
                string l = Left[i];
                double multiplier = 1;

                for (int j = 0; j < l.Length; j++)
                {
                    if (char.IsDigit(l[j]) && multiplier == 1)
                    {
                        multiplier = char.GetNumericValue(l[j]);
                        if (Char.IsDigit(l[j + 1]))
                        {
                            j++;
                            while (true)
                            {
                                if (j < l.Length && Char.IsDigit(l[j]))
                                {
                                    multiplier = multiplier * 10 + Char.GetNumericValue(l[j]);
                                    j++;

                                }
                                else
                                {
                                    j--;
                                    break;
                                }
                            }
                            //		System.out.println(multiplier);
                        }
                    }
                    if (char.IsUpper(l[j]))
                    {
                        int k = j + 1;
                        string temp = l[j] + "";
                        while (true)
                        {
                            if (k < l.Length)
                            {
                                if (Char.IsLower(l[k]))
                                {
                                    temp = temp + l[k];
                                }
                                if (Char.IsUpper(l[k]) || Char.IsDigit(l[k]))
                                {
                                    break;
                                }
                                k++;
                            }
                            else
                                break;
                        }

                        lout[lind] = temp;
                        double coff = 1;
                        if (k < l.Length)
                            if (Char.IsDigit(l[k]))
                            {
                                coff = Char.GetNumericValue(l[k]);
                                k++;
                                while (true)
                                {
                                    if (k < l.Length && Char.IsDigit(l[k]))
                                    {
                                        coff = coff * 10 + Char.GetNumericValue(l[k]);
                                        k++;

                                    }
                                    else
                                        break;
                                }
                            }
                        lout1[lind] = coff * multiplier;
                        j = k - 1;
                        lind++;

                    }
                }


            }
            for (int i = 0; i < Right.Length; i++)
            {
                string l = Right[i];
                double multiplier = 1;

                for (int j = 0; j < l.Length; j++)
                {
                    if (char.IsDigit(l[j]) && multiplier == 1)
                    {
                        multiplier = char.GetNumericValue(l[j]);
                        if (Char.IsDigit(l[j + 1]))
                        {
                            j++;
                            while (true)
                            {
                                if (j < l.Length && Char.IsDigit(l[j]))
                                {
                                    multiplier = multiplier * 10 + Char.GetNumericValue(l[j]);
                                    j++;

                                }
                                else
                                {
                                    j--;
                                    break;
                                }
                            }
                            //		System.out.println(multiplier);
                        }
                    }
                    if (char.IsUpper(l[j]))
                    {
                        int k = j + 1;
                        string temp = l[j] + "";
                        while (true)
                        {
                            if (k < l.Length)
                            {
                                if (Char.IsLower(l[k]))
                                {
                                    temp = temp + l[k];
                                }
                                if (Char.IsUpper(l[k]) || Char.IsDigit(l[k]))
                                {
                                    break;
                                }
                                k++;
                            }
                            else
                                break;
                        }

                        rout[rind] = temp;
                        double coff = 1;
                        if (k < l.Length)
                            if (Char.IsDigit(l[k]))
                            {
                                coff = Char.GetNumericValue(l[k]);
                                k++;
                                while (true)
                                {
                                    if (k < l.Length && Char.IsDigit(l[k]))
                                    {
                                        coff = coff * 10 + Char.GetNumericValue(l[k]);
                                        k++;

                                    }
                                    else
                                        break;
                                }
                            }
                        rout1[rind] = coff * multiplier;
                        j = k - 1;
                        rind++;

                    }
                }


            }
            for (int i = 0; i < limitLeft; i++)
            {
                for (int j = i + 1; j < limitLeft; j++)
                {
                    if (lout[i]==(lout[j]))
                    {
                        lout1[i] = lout1[i] + lout1[j];
                        lout1[j] = 0;
                        lout[j] = "xyzz";
                        limitLeft--;
                    }
                }
            }
            int r = limitRight;
            for (int i = 0; i < r; i++)
            {
                for (int j = i + 1; j < r; j++)
                {
                    if (rout[i]==(rout[j]))
                    {
                        rout1[i] = rout1[i] + rout1[j];
                        rout1[j] = 0;
                        rout[j] = "xyzz";
                        limitRight--;
                    }
                }
            }
           
            int res = 0;
            for (int i = 0; i < lout.Length; i++)
            {
                for (int j = 0; j < rout.Length; j++)
                {
                    if (lout[i]==(rout[j]))
                    {
                        if (lout1[i] != rout1[j])
                            res++;
                    }
                }
            }
            if (res == 0)
                return true;

            else
                return false;
        }
    }
}
/*
 * Test 2
Input:
s: "1000H2O = Au + Ag"
Output:
true
Expected Output:
false
Console Output:
Empty
 * 
 * Input:
s: "A = B"
Output:
true
Expected Output:
false
Console Output:
Empty
 * 
 * Input:
s: "NH3 + CO2 + H2O = NH4HCO3"
Output:
false
Expected Output:
true
Console Output:
Empty
 * 
 * Input:
s: "2Water + 5Sand = 7Wonders"
Output:
true
Expected Output:
false
Console Output:
Empty
 * 
 * Input:
s: "15Li = 2Li5 + Li + Li + 3Li + ExtraTrash"
Output:
true
Expected Output:
false
Console Output:
Empty
 * 
 */
