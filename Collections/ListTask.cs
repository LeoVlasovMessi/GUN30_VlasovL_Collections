using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class ListTask
    {
        public List<string> strings = new List<string>() { "string1", "string2", "string3" };

        public void TaskLoop()
        {
            //strings.Add("string4");
            for (int i = 0; i < strings.Count; i++)
            {
                Console.Write(strings[i] + " ");
            }
            Console.WriteLine("Введите ещё одну строку, которая добавится в конец:");
            string str = Console.ReadLine();
            strings.Add(str);
            for (int i = 0; i < strings.Count; i++) 
            {
                Console.Write(strings[i] + " ");
            }
            Console.WriteLine("Введите ещё одну строку, которая добавится в середину:");
            string value = Console.ReadLine();
            strings.Insert(strings.Count/2, value);
            for (int i = 0; i < strings.Count; i++)
            {
                Console.Write(strings[i] + " ");
            }
        }

    }
}
