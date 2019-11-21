using System;

namespace exam_2
{
    public class Application
    {
        static void Main()
        {
            Employee _store = new Employee("Per", 01);
            Customer _customer1 = new Customer("Pål", 02, 500);
            InventorySingleton inventory = InventorySingleton.GetInventorySingleton();
            _store.AddWare("pants", 99.99, 'm');
            _store.AddWare("sweater", 199.99, 'l');
            _store.AddWare("socks", 99.99, 's');
            _customer1.Browse();
        }

        
    }

    
}
