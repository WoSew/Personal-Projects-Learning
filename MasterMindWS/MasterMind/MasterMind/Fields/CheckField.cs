﻿using System.Drawing;
using MasterMind.Interfaces;

namespace MasterMind
{
    public class CheckField : IField
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public Color color { get; set; }
    }
}