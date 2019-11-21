using System;
using System.Collections.Generic;
using System.Text;

namespace exam_2
{
    sealed class InventorySingleton
    {
        private static readonly InventorySingleton _instance = new InventorySingleton();

        private List<Server> _servers;
        private Random _random = new Random();
        private List<clothes> _pants;
        private List<clothes> _sweater;
        private List<clothes> _socks;

        private InventorySingleton()
        {
            _pants = new List<clothes>();
            _sweater = new List<clothes>();
            _socks = new List<clothes>();
            _servers = new List<Server>
            {
                new Server{ Name = "Server1", IP = "120.14.220.18"},
                new Server{ Name = "Server2", IP = "120.14.220.19"},
                new Server{ Name = "Server3", IP = "120.14.220.20"}
            };
        }

        public static InventorySingleton GetInventorySingleton()
        {
            return _instance;
        }

        public List<clothes> ClothesList(string clothingType)
        {
            if(clothingType == "pants")
            {
                return _pants;
            } else if (clothingType == "sweater")
            {
                return _sweater;
            } else if (clothingType == "socks")
            {
                return _socks;
            } else
            {
                Console.WriteLine("Wrong clothing type");
                return null;
            }
        }

        public void AddToInventory(clothes clothes)
        {
            if(clothes.clothingType.ToLower() == "pants")
            {
                _pants.Add(clothes);
            } else if (clothes.clothingType.ToLower() == "sweater") 
            {
                _sweater.Add(clothes);
            } else if (clothes.clothingType.ToLower() == "socks")
            {
                _socks.Add(clothes);
            } else
            {
                Console.WriteLine("Something went wrong");
            }
        }

        public void RemoveFromInventory(string clothingType, int index)
        {
            if(clothingType == "pants")
            {
                if(index >= _pants.Count)
                {
                    Console.WriteLine("Index out of bounds");
                } else
                {
                    _pants.RemoveAt(index);
                }
            } else if (clothingType == "sweater")
            {
                if (index >= _sweater.Count)
                {
                    Console.WriteLine("Index out of bounds");
                }
                else
                {
                    _sweater.RemoveAt(index);
                }
            } else if (clothingType == "socks")
            {
                if (index >= _socks.Count)
                {
                    Console.WriteLine("Index out of bounds");
                }
                else
                {
                    _socks.RemoveAt(index);
                }
            } else
            {
                Console.WriteLine("Clothing Type not found");
            }
        }

        public Server NextServer
        {
            get
            {
                int r = _random.Next(_servers.Count);
                return _servers[r];
            }
        }
    }   
}
