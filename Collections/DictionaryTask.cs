using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class DictionaryTask
    {
        public Dictionary<string, int> journal = new Dictionary<string, int>();
        public void TaskLoop()
        {
            Console.WriteLine("Сколько студентов в классе: ");
            Int32.TryParse(Console.ReadLine(), out int value);
            for (int i = 0; i < value; i++)
            {
                Console.WriteLine("Введите имя студента: ");
                string name = Console.ReadLine();
                Console.WriteLine("Введите оценку студента: ");
                Int32.TryParse(Console.ReadLine(), out int mark);
                while (mark > 5 || mark < 2) 
                {
                    Console.WriteLine("Такой оценки не бывает у нас (оценка от 2 до 5). Попробуйте ещё раз: ");
                    Int32.TryParse(Console.ReadLine(), out int prov);
                    mark = prov;
                }
                journal[name] = mark;
            }

            Console.WriteLine("Введите имя студента, оценку которого хотите узнать:");
            string find = Console.ReadLine();
            if (journal.ContainsKey(find))
            {
                Console.WriteLine("Ученик " + find + " имеет оценку " + journal[find]);
            }
            else
            {
                Console.WriteLine($"Ключ {find} не найден в словаре.");
            }
        }
    }
}
