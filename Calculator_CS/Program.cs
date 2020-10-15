﻿using System;
using System.Runtime.InteropServices;

namespace Calculator_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    public class Calculate
    {
        public int Add(int a, int b)
        {
            long longA = (long)a;
            long longB = (long)b;
            var sum = longA + longB;
            if (sum > int.MaxValue) throw new ArgumentOutOfRangeException();
            return a + b;
        }
    }
}
