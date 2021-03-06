﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeWars.Kyu5;
using CodeWars.Kyu6;
using CodeWars.Kyu7;
using CodeWars.Kyu8;
using WoSew.TrainingLibrary.Test.Common.Training.Exceptions;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            HighestAndLowestKyu7.HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4");

            ReversedSequenceKyu8.ReverseSeq(5);

            GarbleSortKyu6.GarbleSort(new int[] {5, 6, 3});

            ConvertStringToCamelCaseKyu5.ToCamelCase("The-stealth-warrior");

            DescendingOrderKyu7.DescendingOrder(141267123);

            MumbligKyu7.Accum("abcd");

            MultiplesOf3Or5Kyu6.Solution(10);

            WoSewExceptions wsExceptions = new WoSewExceptions();
            wsExceptions.SelectiveExceptions();
            wsExceptions.TryCatchFinally();
            wsExceptions.TryCatchFinallyException();

            SumOfArraySinglesKyu7.SumOfArraySingles(new List<int> { 4, 5, 7, 5, 4, 8 });

            LoveVsFriendshipKyu7.LoveVsFriendship("love");
            LoveVsFriendshipKyu7.LoveVsFriendship("friendship");

            HumanReadableTimeKyu5.GetReadableTime(5458);
            HumanReadableTimeKyu5.GetReadableTime(0);

            YourOrderPleaseKyu6.YourOrderPlease("is2 Thi1s T4est 3a");
            YourOrderPleaseKyu6.YourOrderPlease("4of Fo1r pe6ople g3ood th5e the2");
            //"Fo1r the2 g3ood 4of th5e pe6ople"
        }
    }
}
