using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace AddressBook
{
    class AddressBook
    {
        private List<Class1> list = new List<Class1>();
        private Dictionary<string, Class1> d = new Dictionary<string, Class1>();
        private Dictionary<string, Class1> cityDictionary = new Dictionary<string, Class1>();
        private Dictionary<string, Class1> stateDictionary = new Dictionary<string, Class1>();
       
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
        public List<Class1> ViewAddressBook(int input)
        {
            if (input == 1)
            {
                list = list.OrderBy(c => c.name).ToList();

            }
            else if (input == 1)
            {

                list = list.OrderBy(c => c.city).ToList();

            }
            else if (input == 3)
            {
                list = list.OrderBy(c => c.state).ToList();

            }
            else
            {
                list = list.OrderBy(c => c.zip).ToList();
            }
            return list;
           
        }
        public void EditNumber(String ename,String newnumber)
        {
            Boolean flag = false;
            foreach (Class1 cc in list)
            {
                if (cc.name.Equals(ename))
                {
                    flag = true;
                    cc.phoneNo=newnumber;
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
                if (cc.name.Equals(rname))
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
                if (c.name.Equals(name))
                {
                    return true;
                }
            }
            return false;
        }
       
        

        public List<Class1> UC8_SearchPeopleByCityOrState(string location)
        {
            
           
            foreach (Class1 c in list)
            {
                cityDictionary.Add(c.city, c);
                
            }
            foreach (Class1 c in list)
            {
                stateDictionary.Add(c.state, c);
                
            }

            List<Class1> listofpeople = new List<Class1>();
            foreach(KeyValuePair<string,Class1> kvp in cityDictionary)
            {
                if (kvp.Key.Equals(location))
                {
                    listofpeople.Add(kvp.Value);
                }
            }
            foreach (KeyValuePair<string, Class1> kvp in stateDictionary)
            {
                if (kvp.Key.Equals(location))
                {
                    listofpeople.Add(kvp.Value);
                }
            }
            return listofpeople;
        }
        public void AddressByCity()
        {

            HashSet<string> citySet = new HashSet<string>();
            foreach (Class1 c in list)
            {
                
                citySet.Add(c.city);
            }
            foreach(string s in citySet)
            {
                int count = 0;
                foreach (Class1 c in list)
                {
                    if (c.city.Equals(s))
                    {
                        count++;
                    }
                }
                Console.WriteLine("There are "+count+" contacts with address " + s);
                Console.WriteLine();
                foreach(Class1 cc in list) { 
                
                    if (cc.city.Equals(s))
                        Console.WriteLine("Name : " + cc.name + "  Address : " + cc.address + "  ZIP : " + cc.zip + "  Contact No : " + cc.phoneNo + "  EmailID : " + cc.email);

                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        public void AddressByState()
        {
            HashSet<string> stateSet = new HashSet<string>();
            foreach (Class1 c in list)
            {
                
                stateSet.Add(c.state);
            }
            foreach (string s in stateSet)
            {
                int count = 0;
                foreach (Class1 c in list)
                {
                    if (c.state.Equals(s))
                    {
                        count++;
                    }
                }
                Console.WriteLine("There are " + count + " contacts with address " + s);
                Console.WriteLine();
                foreach (Class1 cc in list)
                {

                    if (cc.state.Equals(s))
                        Console.WriteLine("Name : " + cc.name+ "  Address : " + cc.address+ "  ZIP : " + cc.zip + "  Contact No : " + cc.phoneNo + "  EmailID : " + cc.email);

                }
                Console.WriteLine();
                Console.WriteLine();
            }

        }


        public void ReadAllText()
        {
            string path = @"C:\Users\RUMANA\source\repos\AddressBook\AddressBook\CSV\export.json";
            List<Class1> list = JsonConvert.DeserializeObject<List<Class1>>(File.ReadAllText(path)).ToList();

                foreach (Class1 cc in list )
                {

                    Console.Write("Name : " + cc.name);
                    Console.Write(" Address : " + cc.address);
                    Console.Write(" City : " + cc.city);
                    Console.Write(" State : " + cc.state);
                    Console.Write(" zip : " + cc.zip);
                    Console.Write(" Contact No. : " + cc.phoneNo);
                    Console.Write(" Email ID : " + cc.email);
                    Console.WriteLine();

                }

            

        }




    }
}
