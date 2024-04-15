﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciplesExamples.OpenClosePrinciple.AfterApplying
{
    internal class Reactangle : IArea
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public int Area()
        {
            return Height * Width;
        }
    }
}
