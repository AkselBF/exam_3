using System;
using System.Collections.Generic;
using System.Text;

namespace exam_2
{
    class Employee : User
    {
        private string _name;
        private readonly int _ID;

        public Employee(string name, int ID)
        {
            _name = name;
            _ID = ID;
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

        public void AddWare(string clothingType, double price, char size)
        {
            clothingFactory factory = null;
            InventorySingleton inventory = InventorySingleton.GetInventorySingleton();

            switch (clothingType.ToLower())
            {
                case "pants":
                    factory = new pantsFactory(price, size);
                    inventory.AddToInventory(factory.GetClothes());
                    Console.WriteLine(name+" added new " + clothingType +" " + inventory.ClothesList(clothingType).Count + " for sale." );
                    break;
                case "sweater":
                    factory = new sweaterFactory(price, size);
                    inventory.AddToInventory(factory.GetClothes());
                    Console.WriteLine(name + " added new " + clothingType + " " + inventory.ClothesList(clothingType).Count + " for sale.");
                    break;
                case "socks":
                    factory = new socksFactory(price, size);
                    inventory.AddToInventory(factory.GetClothes());
                    Console.WriteLine(name + " added new " + clothingType + " " + inventory.ClothesList(clothingType).Count + " for sale.");
                    break;
                default:
                    Console.WriteLine("Nothing found");
                    break;
            }
        }
    }
}
