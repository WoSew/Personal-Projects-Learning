﻿using System.Collections.Generic;

namespace CodeWars
{
    public class Kyu8
    {

        public static string Remove_char(string s)
        {
            string result = "";
            for (int i = 1; i < s.Length-1; i++)
            {
                result += s[i];
            }
            return result;

            //-----second solution-----
            //return s.Substring(1,(s.Length - 2));
        }

    }
}
 