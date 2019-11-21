using System;
using System.Collections.Generic;

namespace exam_2
{
    class Customer : User
    {
        private string _name;
        private readonly int _ID;
        private double _money;

        public Customer(string name, int ID, double money)
        {
            _name = name;
            _ID = ID;
            _money = money;
        }

        public override string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public override int ID
        {
            get { return _ID; }
        }

        public double money
        {
            get { return _money; }
            set { _money = value; }
        }

        public void Buy(string clothingType)
        {
            InventorySingleton inventory = InventorySingleton.GetInventorySingleton();
            List<clothes> wares = inventory.ClothesList(clothingType);
            for (int i = 0; i < wares.Count; i++)
            {
                if (wares[i].price < _money)
                {
                    _money = money - wares[i].price;
                    Console.WriteLine(name + " bought " + wares[i].clothingType.ToLower() + " " + inventory.ClothesList(clothingType).Count + " from the store.");
                    inventory.RemoveFromInventory(clothingType, i);
                    
                }
            }
        }

        public void Browse()
        {
            InventorySingleton inventory = InventorySingleton.GetInventorySingleton();
            bool bought = false;
            Random random = new Random();
            var list = new List<string> { "pants", "sweater", "socks" };
            int index = random.Next(list.Count);
            while (bought != true)
            {
                List<clothes> wares = inventory.ClothesList(list[index]);
                for (int i = 0; i < wares.Count; i++)
                {
                    int randomNumber = random.Next(0, 12);
                    if (randomNumber == 10)
                    {
                        Console.WriteLine(name + " bought a size " + wares[i].size + " " + wares[i].clothingType + " for " + wares[i].price + ".");
                        inventory.RemoveFromInventory(list[index], i);
                        bought = true;    
                    } else if (i == wares.Count)
                    {
                        i = 0;
                    }
                }
            }
            
        }
    }
}
