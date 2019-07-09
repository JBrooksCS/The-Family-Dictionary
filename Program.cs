using System;
using System.Collections.Generic;

namespace The_Family_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();
            myFamily.Add("sister", new Dictionary<string, string>(){
            {"name", "Krista"},
            {"age", "42"}
            });
            foreach (KeyValuePair<string, Dictionary<string, string>> familyMember in myFamily)
            {
                var phrase = familyMember.Value["name"];
                phrase += " is my " + familyMember.Key + " and is " + familyMember.Value["age"] + " years old";
                //Krista is my sister and is 42 years old
                Console.WriteLine(phrase);
            }
        }
    }
}
