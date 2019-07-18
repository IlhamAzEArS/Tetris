using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
//PhoneBook["Ilham"] <= array;
//PhoneBook["+994551998080"]
//PhoneBook["Name", "Surname"].Phone
//Phonebook, Contact
//Name, Surname, MiddleName, Full Name, Address, Phone.

namespace ConsoleApp3
{
    class PhoneBook
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string MiddleName { get; set; }
        public string Full_Name { get; set; }
        public string Address { get; set; }
        public long Phone { get; set; }
        public override string ToString()
        {
            return $"{name} {name} {MiddleName} {Full_Name} {Address} {Phone}";
        }
    }
    class Contact
    {
        private PhoneBook[] phones;
        public int Count
        {
            get => phones.Length;
        }
        public Contact(int l)
        {
            phones = new PhoneBook[l];
        }

        public PhoneBook this[int index]
        {
            set
            {
                if (index >= 0 && index < phones.Length)
                    phones[index] = value;
                else
                    throw new IndexOutOfRangeException("Out of range");
            }
        }

        public PhoneBook[] this[string name, string SurName_]
        {
            get
            {
                PhoneBook[] result1 = null;
                int sCount = 0;
                for (int i = 0; i < Count; i++)
                {
                    if (phones[i].name == name && phones[i].surname == SurName_)
                        sCount++;
                }
                if (sCount == 0) { return result1; }
                result1 = new PhoneBook[sCount];
                int count = 0;
                for (int i = 0; i < Count; i++)
                {
                    if (phones[i].name == name && phones[i].surname == SurName_)
                    {
                        result1[count] = phones[i];
                        count++;
                    }
                }
                return result1;
            }
        }
        public PhoneBook[] this[string name]
        {
            get
            {
                PhoneBook[] result1 = null;
                int sCount = 0;
                for (int i = 0; i < Count; i++)
                {
                    if (phones[i].name == name)
                        sCount++;
                }
                if (sCount == 0) return result1;
                result1 = new PhoneBook[sCount];
                int count = 0;
                for (int i = 0; i < Count; i++)
                {
                    if (phones[i].name == name)
                    {
                        result1[count] = phones[i];
                        count++;
                    }
                }
                return result1;
            }
        }
        public PhoneBook this[long Phone_]
        {
            get
            {
                for (int i = 0; i < Count; i++)
                {
                    if (phones[i].Phone == Phone_)
                    {
                        return phones[i];
                    }
                }
                return null;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Contact shop = new Contact(5);
            shop[0] = new PhoneBook() { name = "Ilham", surname = "bayramov", MiddleName = "", Full_Name = "Ilham Bayramov", Address = "Zaqatala", Phone = 0705310203 };
            shop[1] = new PhoneBook() { name = "Orxan", surname = "Mutelibov", MiddleName = "", Full_Name = "Orxan Mutelibov", Address = "Baku", Phone = 0516985978};
            shop[2] = new PhoneBook() { name = "Mahmud", surname = "Mahmudov", MiddleName = "", Full_Name = "Mahmud Mutelibov", Address = "Baku", Phone = 0512655487 };
            shop[3] = new PhoneBook() { name = "Mahmud", surname = "Shabanov", MiddleName = "", Full_Name = "Mahmud Shabanov", Address = "SHEKI", Phone = 0779854865 };
            shop[4] = new PhoneBook() { name = "Apple", surname = "iPhone 8 Plus", MiddleName = "", Full_Name = "", Address = "", Phone = 994551998080 };

       

            /*Name i Surname Src*/
            foreach (var item in shop["Mahmud", "bayramov"])
            {
                Console.WriteLine(item);
            }
            /*Name Src*/
            Console.WriteLine(" ======= ");
            foreach (var item in shop["Mahmud"])
            {
                Console.WriteLine(item);
            }
            /*Phone  Src*/
            Console.WriteLine(" +++++++++++ ");
            Console.WriteLine(shop[(long)0516985978]);

        }

    }
}
