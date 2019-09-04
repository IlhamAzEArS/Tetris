using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Drawing;
using Console = Colorful.Console;
using Colorful;

namespace ConsoleApp11
{
    class NewUser
    {
        public String User_Name { get; set; }
        public String User_Passworld { get; set; }
        public String User_Email { get; set; }
        public string Card_User_Name { get; set; }
        public string Card_Nomber { get; set; }
        public int Card_CCV { get; set; }
        public string Card_DataTime { get; set; }
        public string Vaule { get; set; }
        public void new_user()
        {
            NewUser k1 = new NewUser();
            {
                Console.WriteLine("Login");
                k1.User_Name = Console.ReadLine();
                Console.WriteLine("PASSWORLD");
                k1.User_Passworld = Console.ReadLine();
                Console.WriteLine("@Email");
                k1.User_Email = Console.ReadLine();

                List<NewUser> Personn2 = null;
                string json = File.ReadAllText("Person.json");
                Personn2 = JsonConvert.DeserializeObject<List<NewUser>>(json);
                Personn2.Add(k1);

                JsonSerializer ser = new JsonSerializer();
                using (var sw = new StreamWriter("Person.json"))
                {
                    using (var jw = new JsonTextWriter(sw))
                    {
                        jw.Formatting = Formatting.Indented;
                        ser.Serialize(jw, Personn2);
                    }
                }

            }//creat new user
            

        }
        public bool User_Login_Panel()
        {

            { 
            List<NewUser> Personn2 = null;
            string json = File.ReadAllText("Person.json");
            Personn2 = JsonConvert.DeserializeObject<List<NewUser>>(json);
            JsonSerializer ser = new JsonSerializer();
            System.Console.WriteLine("Enter User Name");
                string User_Name1 = Console.ReadLine();
            
            
            foreach (var item in Personn2)
            {
                if (item.User_Name == User_Name1)
                {
                    string User_Passworld1 = Console.ReadLine();
                    if (item.User_Passworld == User_Passworld1)
                    {
                        return true;
                    }

                    else
                        Console.WriteLine("Passworld Error",ColorTranslator.FromHtml("#00FFFF"));
                    
                }
                
            }
                System.Console.WriteLine("User Name Error");
            return false;
            }
        }
        public void new_card()
        {
            NewUser k1 = new NewUser();
            System.Console.WriteLine("Enter User LastName SurName");
            k1.Card_User_Name = Console.ReadLine();
            System.Console.WriteLine("Enter Valuta");
            System.Console.WriteLine("Euro");
            System.Console.WriteLine("USD");
            System.Console.WriteLine("AZN");
            string vaule = Console.ReadLine();
            if(vaule == "1")
            {
                k1.Vaule = "Euro";
            }
            if(vaule == "2" )
            {
                k1.Vaule = "USD";

            }
            if(vaule == "3")
            {
                k1.Vaule = "AZN";
            }
            /*
             * if() acib icine mausla valutani elave ele
             * 
             */
            Random rnd = new Random();
            //long cardNumber = rnd.Next(4012888888881881,4999999999999999);
            int card1 = rnd.Next(4000, 4999);
            int card2 = rnd.Next(9999);
            int card3 = rnd.Next(9999);
            int card4 = rnd.Next(9999);
             k1.Card_Nomber = card1.ToString() + " ";
            k1.Card_Nomber += card2.ToString() + " ";
            k1.Card_Nomber += card3.ToString() + " ";
            k1.Card_Nomber += card4.ToString();
            k1.Card_CCV = rnd.Next(100, 999);
            System.Console.WriteLine("Enter Year Card");
            System.Console.WriteLine("1 Year");
            System.Console.WriteLine("3 Year");
            System.Console.WriteLine("5 Year");
            string year = Console.ReadLine();
            if(year == "1")
            {
                int data = rnd.Next(1, 30);
                k1.Card_DataTime = data.ToString()+"/" +"20";
                
            }
            if (year == "3")
            {
                int data = rnd.Next(1, 30);
                k1.Card_DataTime = data.ToString() + "/" + "23";

            }
            if (year == "3")
            {
                int data = rnd.Next(1, 30);
                k1.Card_DataTime = data.ToString() + "/" + "25";

            }
            List<NewUser> Personn2 = null;
            string json = File.ReadAllText("Card_Bank.json");
            Personn2 = JsonConvert.DeserializeObject<List<NewUser>>(json);
            Personn2.Add(k1);

            JsonSerializer ser = new JsonSerializer();
            using (var sw = new StreamWriter("Card_Bank.json"))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Formatting.Indented;
                    ser.Serialize(jw, Personn2);
                }
            }

        }



    }


}
