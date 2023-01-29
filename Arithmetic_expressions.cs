using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;



namespace ConsoleApp1
{
    class Result
    {
        // function to evaluate all the basics arithmetics
        public static int eval(int a, char op, int b)
        {
            if (op == '+')
            {
                return a + b;
            }
            if (op == '-')
            {
                return a - b;
            }
            if (op == '*')
            {
                return a * b;
            }
            return int.MaxValue;
        }
        /*
         *  'arithmeticexpressions' function below.
         * The function is expected to return a STRING.
         * The function accepts INTEGER_ARRAY arr as parameter.
         */
        //all the combinations of operation series
        public static char[] esigns3 = { '+', '*', '-' };
        public static char[] esigns3d = { '+', '-', '*' };
        public static char[] esigns3a = { '*', '+', '-' };
        public static char[] esigns3e = { '*', '-', '+' };
        public static char[] esigns3b = { '-', '+', '*' };
        public static char[] esigns3c = { '-', '*', '+' };
        public static char[] esigns2 = { '+', '*' };
        public static char[] esigns4 = { '+', '-' };
        public static char[] esigns5 = { '*', '-' };
        public static char[] esigns5a = { '*', '+' };
        public static int modchek = 101;
        
         /*main functional logic: as frist point - it will check the numbers imputed
          then it will handled in different way in accordance to the length, it will check 
         all the possible arithmetic combinations (one by one).
          */
        public static string arithmeticExpressions(List<int> arr)
        {
            string Result_expr = "";
            int lengthi = arr.Count;
            bool exprs = true;
            bool exprs2 = true;
            int tryi = 0;
            int resulti = 0;
            char[] new_esigns3 = esigns3;
            int tryi2 = 0;            

            while (exprs) {                               
                   resulti = 0;
                   Result_expr = "";
                if (lengthi <= 3)
                {
                    if (tryi == 0)
                    {
                        for (int i = 0; i < lengthi - 1; i++)
                        {
                            if (i == 0)
                            {   resulti += eval(arr[i], esigns2[i], arr[i + 1]);
                                Result_expr = arr[i].ToString() + esigns2[i]+ arr[i + 1].ToString();
                            }
                            else
                            {   resulti = eval(resulti, esigns2[i], arr[i + 1]);
                                Result_expr = Result_expr+ esigns2[i] + arr[i + 1].ToString();
                            }
                        }
                    }
                    else if (tryi == 1)
                    {
                        for (int i = 0; i < lengthi - 1; i++)
                        {
                            if (i == 0)
                            {  resulti += eval(arr[i], esigns2[esigns2.Length - 1 - i], arr[i + 1]);
                                Result_expr = arr[i].ToString() + esigns2[esigns2.Length - 1 - i] + arr[i + 1].ToString();
                            }
                            else {  resulti = eval(resulti, esigns2[esigns2.Length - 1 - i], arr[i + 1]);
                                Result_expr = Result_expr + esigns2[esigns2.Length - 1 - i] + arr[i + 1].ToString();
                            }
                        }
                    }
                    else if (tryi == 2)
                    {
                        for (int i = 0; i < lengthi - 1; i++)
                        {
                            if (i == 0)
                            {   resulti += eval(arr[i], esigns4[i], arr[i + 1]);
                                Result_expr = arr[i].ToString() + esigns4[i] + arr[i + 1].ToString();
                            }
                            else { resulti = eval(resulti, esigns4[i], arr[i + 1]);
                                Result_expr = Result_expr + esigns4[i] + arr[i + 1].ToString();
                            }
                        }
                    }
                    else if (tryi == 3)
                    {
                        for (int i = 0; i < lengthi - 1; i++)
                        {
                            if (i == 0)
                            {  resulti += eval(arr[i], esigns5[i], arr[i + 1]);
                                Result_expr = arr[i].ToString() + esigns5[i] + arr[i + 1].ToString();
                            }
                            else { resulti = eval(resulti, esigns5[i], arr[i + 1]);
                                Result_expr = Result_expr + esigns5[i] + arr[i + 1].ToString();
                            }
                        }
                    }
                    else if (tryi == 4)
                    {
                        for (int i = 0; i < lengthi - 1; i++)
                        {
                            if (i == 0)
                            {  resulti += eval(arr[i], esigns4[esigns4.Length - 1 - i], arr[i + 1]);
                                Result_expr = arr[i].ToString() + esigns4[esigns4.Length - 1 - i] + arr[i + 1].ToString();
                            }
                            else { resulti = eval(resulti, esigns4[esigns4.Length - 1 - i], arr[i + 1]);
                                Result_expr = Result_expr + esigns4[esigns4.Length - 1 - i] + arr[i + 1].ToString();
                            }
                        }
                    }
                    else if (tryi == 5)
                    {
                        for (int i = 0; i < lengthi - 1; i++)
                        {
                            if (i == 0)
                            {
                                resulti += eval(arr[i], esigns5[esigns5.Length - 1 - i], arr[i + 1]);
                                Result_expr = arr[i].ToString() + esigns5[esigns5.Length - 1 - i] + arr[i + 1].ToString();
                            }
                            else { resulti = eval(resulti, esigns5[esigns5.Length - 1 - i], arr[i + 1]); 
                                Result_expr = Result_expr + esigns5[esigns5.Length - 1 - i] + arr[i + 1].ToString();
                            }
                        }
                    }
                }
                else if (lengthi == 4)
                {
                    if (tryi == 0)
                    {
                        for (int i = 0; i < lengthi - 1; i++)
                        {
                            if (i == 0)
                            {  resulti += eval(arr[i], esigns3[i], arr[i + 1]);
                                Result_expr = arr[i].ToString() + esigns3[i] + arr[i + 1].ToString();
                            }
                            else { resulti = eval(resulti, esigns3[i], arr[i + 1]);
                                Result_expr = Result_expr + esigns3[i] + arr[i + 1].ToString();
                            }
                        }
                    }
                    if (tryi > 0)
                    {
                        char[] esigns3ve = { '+', '*', '-' };
                        if (tryi == 1)
                        {   esigns3ve[0] = esigns3[1];
                            esigns3ve[1] = esigns3[0];
                            for (int i = 0; i < lengthi - 1; i++)
                            {
                                if (i == 0)
                                {  resulti += eval(arr[i], esigns3ve[i], arr[i + 1]);
                                    Result_expr = arr[i].ToString() + esigns3ve[i] + arr[i + 1].ToString();
                                }
                                else { resulti = eval(resulti, esigns3ve[i], arr[i + 1]);
                                    Result_expr = Result_expr + esigns3ve[i] + arr[i + 1].ToString();
                                }
                            }
                        }
                        else if (tryi == 2)
                        {   esigns3ve[1] = esigns3[2];
                            esigns3ve[2] = esigns3[1];
                            for (int i = 0; i < lengthi - 1; i++)
                            {
                                if (i == 0)
                                {   resulti += eval(arr[i], esigns3ve[i], arr[i + 1]);
                                    Result_expr = arr[i].ToString() + esigns3ve[i] + arr[i + 1].ToString();
                                }
                                else { resulti = eval(resulti, esigns3ve[i], arr[i + 1]);
                                    Result_expr = Result_expr + esigns3ve[i] + arr[i + 1].ToString();
                                }
                            }
                        }
                        else if (tryi > 2 && tryi <= 4)
                        {
                            List<char> esigns4ve = new List<char>();
                            for (int k = 0; k <= new_esigns3.Length - 1; k++)
                            {
                                if (k == esigns3.Length - 1) esigns4ve.Add(new_esigns3[0]);
                                else esigns4ve.Add(new_esigns3[k + 1]);
                            }

                            for (int i = 0; i < lengthi - 1; i++)
                            {
                                if (i == 0)
                                {  resulti += eval(arr[i], esigns4ve[i], arr[i + 1]);
                                  Result_expr = arr[i].ToString() + esigns4ve[i] + arr[i + 1].ToString();
                                }
                                else { resulti = eval(resulti, esigns4ve[i], arr[i + 1]);
                                  Result_expr = Result_expr + esigns4ve[i] + arr[i + 1].ToString();
                                }
                            }
                            new_esigns3 = esigns4ve.ToArray<char>();
                        }
                        else if (tryi > 4)
                        {
                            esigns3ve[0] = esigns3[2];
                            esigns3ve[2] = esigns3[0];
                            for (int i = 0; i < lengthi - 1; i++)
                            {
                                if (i == 0)
                                {    resulti += eval(arr[i], esigns3ve[i], arr[i + 1]);
                                    Result_expr = arr[i].ToString() + esigns3ve[i] + arr[i + 1].ToString();
                                }
                                else { resulti = eval(resulti, esigns3ve[i], arr[i + 1]); 
                                    Result_expr = Result_expr + esigns3ve[i] + arr[i + 1].ToString();
                                }
                            }
                        }
                    }

                    if (tryi > lengthi * (lengthi - 1))
                    {  exprs = false;
                        Result_expr = "there is no possible operation for: " + modchek.ToString();
                    }
                }
                else if (lengthi > 4)
                {   /*when the length of the numbers is more than 4 - it will handled like a distinct way becasue the 
                     combinations arithmetics series will extends like a tree node using recursive list and dcitionary classes*/
                    List<char[]> tocheck = new List<char[]>();               
                    tocheck.Add(esigns3);                    
                    tocheck.Add(esigns3d);                    
                    tocheck.Add(esigns3a);                    
                    tocheck.Add (esigns3e);                    
                    tocheck.Add(esigns3b);                    
                    tocheck.Add(esigns3c);
                    
                   foreach (char[] itm in tocheck) {
                        int diff = (lengthi - 1) - itm.Length;
                        List<char> listrec = itm.ToList<char>();
                        bool pro_ver = false;
                        int trywhile = 0;
                        exprs2 = true;
                        
                        Recursiv rec1 = new Recursiv();
                        rec1 = Recursiv.retorna_hijas(listrec);

                        while (diff >= 0 && exprs2)
                        {                           
                            if (rec1 != null) {
                                Dictionary<int, List<char>> dict = new Dictionary<int, List<char>>();
                                dict.Add(dict.Count, rec1.lista_hij1);
                                dict.Add(dict.Count, rec1.lista_hij2);

                                foreach (List<char> itmls in dict.Values)
                                {
                                    if (itmls.Count < (lengthi - 1))
                                    {
                                        listrec = itmls;
                                        diff -= 1;
                                        pro_ver = false;
                                        rec1 = Recursiv.retorna_hijas(listrec);
                                    }
                                    else
                                    {
                                        pro_ver = true;
                                        new_esigns3 = itmls.ToArray<char>();
                                        Verifica ver = new Verifica();
                                        trywhile += 1;
                                        ver.verifica(new_esigns3, arr);
                                        if (ver.resulti % Result.modchek == 0)
                                        {
                                            exprs2 = false;
                                            return ver.Result_expr; //+ " = " + ver.resulti.ToString();
                                        }
                                    }                               
                                }
                            }
                            if (trywhile > lengthi * (lengthi - 1))
                            {
                                exprs2 = false;
                                Result_expr = "there is no possible operation for: " + modchek.ToString();
                            }
                        }
                    }                   
                }
                if (resulti % modchek == 0)
                {
                    exprs = false;
                }
                else { tryi += 1; }
            }

            return Result_expr; // +" = "+ resulti.ToString();
        }
    }
    // this class is used to verify all the possible calculations
    public class Verifica
    {
        public bool exprs { get; set; } = true;
        public bool exprs2 { get; set; } = true;
        public int tryi2 { get; set; } = 0;
        public int resulti { get; set; } = 0;
        public string Result_expr { get; set; } = "";

        public void verifica(char[] new_esigns3, List<int> arr)
        {
            int lengthi = arr.Count;
            for (int i = 0; i < lengthi - 1; i++)
            {
                if (i == 0)
                {    resulti += Result.eval(arr[i], new_esigns3[i], arr[i + 1]);
                    Result_expr = arr[i].ToString() + new_esigns3[i] + arr[i + 1].ToString();
                }
                else { resulti = Result.eval(resulti, new_esigns3[i], arr[i + 1]);
                    Result_expr = Result_expr + new_esigns3[i] + arr[i + 1].ToString();
                }
            }
            if (resulti % Result.modchek == 0)
            {
                exprs2 = false;
            }
            else
            {
                while (exprs2)
                {
                    resulti = 0;
                    List<char> esigns5ve = new List<char>();
                    for (int k = 0; k <= new_esigns3.Length - 1; k++)
                    {
                        if (k == new_esigns3.Length - 1) esigns5ve.Add(new_esigns3[0]);
                        else esigns5ve.Add(new_esigns3[k + 1]);
                    }

                    for (int i = 0; i < lengthi - 1; i++)
                    {
                        if (i == 0)
                        {    resulti += Result.eval(arr[i], esigns5ve[i], arr[i + 1]);
                            Result_expr = arr[i].ToString() + esigns5ve[i] + arr[i + 1].ToString();
                        }
                        else { resulti = Result.eval(resulti, esigns5ve[i], arr[i + 1]);
                            Result_expr = Result_expr + esigns5ve[i] + arr[i + 1].ToString();
                        }
                    }
                    if (resulti % Result.modchek == 0)
                    {
                        exprs2 = false;
                    }
                    else
                    {
                        new_esigns3 = esigns5ve.ToArray<char>();
                        tryi2 += 1;
                    }
                    if (tryi2 > lengthi + 2) exprs2 = false;
                }
            }
        }

    }

    // this class is used to handled the recursive call in order to build all the possible calculations
    public class Recursiv
    {
        public List<char> lista_hij1 { get;  set; }
        public List<char> lista_hij2 { get; set; }
      
        public static Recursiv retorna_hijas(List<char> list1)
        {
            Recursiv rec = new Recursiv();
            rec.lista_hij1 = new List<char>();
            rec.lista_hij2 = new List<char>();

            for (int k = 0; k <= list1.Count - 1; k++)
             {
                 rec.lista_hij1.Add(list1[k]);
                 rec.lista_hij2.Add(list1[k]);
                 if (k == list1.Count - 1) {
                 switch (list1[list1.Count - 1]) {
                        case '+':
                            rec.lista_hij1.Add('*');
                            rec.lista_hij2.Add('-');
                            break;
                        case '*':
                            rec.lista_hij1.Add('+');
                            rec.lista_hij2.Add('-');
                            break;
                        default:
                            rec.lista_hij1.Add('+');
                            rec.lista_hij2.Add('*');
                            break;
                    }             
                }
            }
            return rec;
        }
    }

    // basic main class to test and call the business class
     internal class Arithmetic_expressions
    {
        public static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            string result = Result.arithmeticExpressions(arr);

            Console.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
