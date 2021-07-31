using System;
using System.IO;
using Newtonsoft.Json;

namespace new1
{
    class Program
    {
        class datamodel{
            public string name{get; set;}
        }
        static void Main(string[] args)
        {
            StreamReader r = new StreamReader("./data.json");
            string jsonString = r.ReadToEnd();
            datamodel data = JsonConvert.DeserializeObject<datamodel>(jsonString);

            Console.WriteLine("Tên của bạn là gì?");
            string name = Console.ReadLine();
            if(name == data.name){
                string text = System.IO.File.ReadAllText("./text.txt");
                Console.WriteLine(text);
            } else {
                Console.WriteLine("Món quà này không dành cho bạn !!");
            }
            Console.ReadKey();
        }

        public class SchemaInfo
        {
            public string name { get; set; }
        }

    }
}
