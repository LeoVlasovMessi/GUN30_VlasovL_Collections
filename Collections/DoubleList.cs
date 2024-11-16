using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class DoubleList
    {
        private Node head = null;
        private Node tail = null;

        public class Node(int value) 
        {
            public int value = value;
            public Node next = null;
            public Node prev = null;
        }

        public void Add(int data)
        {
            Node newNode = new Node(data);

            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.next = newNode;
                newNode.prev = tail;
                tail = newNode; 
            }
        }

        public void TaskLoop() 
        {
            Console.WriteLine("Сколько элементов будет в списке? (от 3 до 6): ");
            Int32.TryParse(Console.ReadLine(), out int kolvo);
            while (kolvo < 3 || kolvo > 6) 
            {
                Console.WriteLine("Неверно указано кол-во элементов в спике (от 3 до 6). Попробуйте ещё раз: ");
                Int32.TryParse(Console.ReadLine(), out int prov);
                kolvo = prov;
            }
            for (int i = 0; i < kolvo; i++) 
            {
                Console.WriteLine("Введите значение " + (i+1) + " элемента списка: ");
                Int32.TryParse(Console.ReadLine(), out int value);
                Add(value);
            }

            Console.WriteLine(" ");

            Node current = head;
            while (current != null) 
            {
                Console.Write(current.value + " ");
                current = current.next;
            }

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            
            current = tail;
            while (current != null)
            {
                Console.Write(current.value + " ");
                current = current.prev;
            }

            Console.WriteLine(" ");

        }
    }
}
