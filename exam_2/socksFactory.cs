using System;
using System.Collections.Generic;
using System.Text;

namespace exam_2
{
    class socksFactory : clothingFactory
    {
        private double _price;
        private char _size;

        public socksFactory(double price, char size)
        {
            _price = price;
            _size = size;
        }

        public override clothes GetClothes()
        {
            return new socks(_price, _size);
        }
    }
}
