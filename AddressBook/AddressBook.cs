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
        public void EditNumber(String ename,String newnumber)
        {
            foreach(Class1 cc in list)
            {
                if (cc.GetName().Equals(ename))
                {
                    cc.SetPhoneNo(newnumber);
                    Console.WriteLine("Number edited successfully");
                    break;
                }
            }
        }
        public void RemoveContact(String rname)
        {
            foreach (Class1 cc in list)
            {
                if (cc.GetName().Equals(rname))
                {
                    list.Remove(cc);
                    Console.WriteLine("Number removed successfully");
                    break;
                }
            }
        }
    }
}
