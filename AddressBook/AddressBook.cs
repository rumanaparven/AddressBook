using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace AddressBook
{
    class AddressBook
    {
        private List<Class1> list = new List<Class1>();
        public List<Class1> GetList()
        {
            return list;
        }
        public void AddAddress(Class1 c)
        {
            list.Add(c);
        
        }
        public List<Class1> ViewAddressBook()
        {
            return list;
        }
    }
}
