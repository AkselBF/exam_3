using System;
using System.Collections.Generic;
using System.Text;

namespace exam_2
{
    abstract class clothes
    {
        public abstract string clothingType { get; }
        public abstract double price { get; set; }
        public abstract char size { get; set; }
    }
}
