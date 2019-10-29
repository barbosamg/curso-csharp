﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Aula72Params
{
    class Calculator
    {
        //public static int Sum(int[] numbers)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        sum += numbers[i];
        //    }
        //    return sum;
        //}
        //OU
        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }
}