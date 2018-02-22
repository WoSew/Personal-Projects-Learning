﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeWars.Kyu7;
using CodeWars.Kyu8;
using WoSew.TrainingLibrary.Test.Common.Training.Exceptions;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            WoSewExceptions wsExceptions = new WoSewExceptions();
            wsExceptions.SelectiveExceptions();
            wsExceptions.TryCatchFinally();
            wsExceptions.TryCatchFinallyException();

            SumOfArraySinglesKyu7.SumOfArraySingles(new List<int> { 4, 5, 7, 5, 4, 8 });
        }
    }
}
