﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCRVisualizer.Model
{
    class TextValue
    {
        public string BoundingBox { get; set; }
        public int X;
        public int Y;
        public int Width;
        public int Height;
        public string Text { get; set; }
    }
}
