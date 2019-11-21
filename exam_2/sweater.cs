using System;
using System.Collections.Generic;
using System.Text;

namespace exam_2
{
    class sweater : clothes
    {
        private readonly string _clothingType;
        private double _price;
        private char _size;

        public sweater (double price, char size)
        {
            _clothingType = "Sweater";
            _price = price;
            _size = size;
        }

        public override string clothingType
        {
            get { return _clothingType; }
        }

        public override double price
        {
            get { return _price; }
            set { _price = value; }
        }

        public override char size
        {
            get { return _size; }
            set { _size = value; }
        }
    }

}
