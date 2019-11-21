using System;
using System.Collections.Generic;
using System.Text;

namespace exam_2
{
    class pantsFactory : clothingFactory
    {
        private double _price;
        private char _size;

        public pantsFactory(double price, char size)
        {
            _price = price;
            _size = size;
        }

        public override clothes GetClothes()
        {
            return new pants(_price, _size);
        }
    }
}
