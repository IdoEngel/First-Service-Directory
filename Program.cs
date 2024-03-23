using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//array fanctions
namespace myArrFamcs
{
    public class arrFancs
    {
        //gets the string & returns char array with the same charactters
        public static char[] stringToChar(string s)
        {
            char[] c = new char[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                c[i] = s[i];
            }

            return c;
        }

        //checks if array of ints is sorded
        public static bool isSorded(int[] ints)
        {
            bool sorded = true;

            for (int i = 0; i < ints.Length - 1; i++)
            {
                if (ints[i] > ints[i + 1])
                {
                    sorded = false;
                }
            }

            return sorded;
        }




        /// the top level fancions, so the other can work
        /// these here to serve a funcion to the bottom fantions
        /// /////////////////////////////////////////////////////////////////
        /// the top level fancions, so the other can work
        ///the accesuble fanctions




        //returns the num of words
        public static int numOfWords(string s)
        {
            const char SPACE = ' ';
            int spacesCounter = 0;
            char[] c = new char[s.Length];
            c = stringToChar(s);

            for (int i = 1; i < c.Length; i++)
            {
                //if there are 2 spaces or more in a row, its not more then one word
                if (c[i] == SPACE && c[i - 1] != SPACE)
                {
                    spacesCounter++;
                }
            }

            return spacesCounter + 1;
            //before the first space there was the first word
        }

        //returns sorted array
        public static int[] sortArr(int[] arr)
        {
            do
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int replacer = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = replacer;
                    }
                }
            }
            while (isSorded(arr));

            return arr;
        }

        public static char[] stringCut(string s, int start, int end, int step)
        {
            char[] c = new char[s.Length];
            char[] ret = new char[s.Length];
            c = stringToChar(s);

            //get fixed trush values
            if (end == 0)
                end = c.Length - 1;

            if (step == 0)
                step = 1;
            else if (step >= c.Length - start)
                step = c.Length - start - 1;

            //create the returned array
            for (int i = start; i < end; i += step)
            {
                int j = 0;

                c[i] = ret[j];
                j++;
            }

            return ret;
        }


    }

}


namespace culc
{

    //formulas of math
    public class formulas
    {
        public static double[] rootFormula (int a, int b, int c)
        {
            double[] ans = { 0, 0 };

            if (Math.Pow(b, 2.0) < 4 * a * c)
            {
                return null;        
            }
            
            //get the root
            double root = Math.Sqrt(Math.Pow(b, 2.0) - 4 * a * c);

            //get the two answers
            ans[0] = (-b + root) / 2*a;
            ans[1] = (-b - root) / 2*a;

            return ans;
        }
    }
}
