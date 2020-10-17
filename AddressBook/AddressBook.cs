﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace AddressBook
{
    class AddressBook
    {
        private List<Class1> list = new List<Class1>();
        private Dictionary<string, Class1> d = new Dictionary<string, Class1>();
        public List<Class1> GetList()
        {
            return list;
        }
        public Dictionary<string, Class1> GetDictionary()
        {
            return d;
        }
        public void AddAddress(string kname,Class1 c)
        {
            list.Add(c);
            d.Add(kname, c);

        }
        public Class1 ViewByKeyName(string kname)
        {
            
            foreach (KeyValuePair<string, Class1> kvp in d)
            {
                if (kvp.Key == kname)
                    return kvp.Value;
            }
            return null;
        }
        public List<Class1> ViewAddressBook()
        {
            return list;
        }
        public void EditNumber(String ename,String newnumber)
        {
            Boolean flag = false;
            foreach (Class1 cc in list)
            {
                if (cc.GetName().Equals(ename))
                {
                    flag = true;
                    cc.SetPhoneNo(newnumber);
                    Console.WriteLine("Number edited successfully");
                    break;
                }
            }
                if (!flag)
                {
                    Console.WriteLine("No such name found!!!");
                }
            

        }
        public void RemoveContact(String rname)
        {
            Boolean flag = false;
            foreach (Class1 cc in list)
            {
                if (cc.GetName().Equals(rname))
                {
                    flag = true;
                    list.Remove(cc);
                    Console.WriteLine("Number removed successfully");
                    break;
                }
            }
            if (!flag)
            {
                Console.WriteLine("No such name found!!!");
            }
        }
        public bool UC7_CheckForDuplicateEntry(string name)
        {
            foreach (Class1 c in list)
            {
                if (c.GetName().Equals(name))
                {
                    return true;
                }
            }
            return false;
        }
        
        
            

        
    }
}
