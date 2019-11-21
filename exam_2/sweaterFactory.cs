using System;
using System.Collections.Generic;
using System.Text;

namespace exam_2
{
    class sweaterFactory : clothingFactory
    {
        private double _price;
        private char _size;

        public sweaterFactory(double price, char size)
        {
            _price = price;
            _size = size;
        }

        public override clothes GetClothes()
        {
            return new sweater(_price, _size);
        }
    }
}
