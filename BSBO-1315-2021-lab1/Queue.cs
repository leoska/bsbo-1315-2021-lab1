using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSBO_1315_2021_lab1
{
    internal class Queue
    {
        public Item? head = null;
        public Item? tail = null;
        public void Push(Item value)
        {
            if (head == null && tail == null)
            {
                head = value;
            }
            else
            {
                tail.next = value;
            }

            tail = value;
            tail.next = null;
        }
        public Item Pop()
        {
            if (head == null)
            {
                throw new Exception("Queue is empty");
            }
            if (head == tail)
            {
                tail = null;
            }
            Item? result = head;
            head = head.next;
            return result;
        }
        public int Get(int index)
        {
            Item oldHead = head;
            for (int i = 0; i < index; i++)
            {
                Push(Pop());
            }
            int result = head.value;
            while (head != oldHead)
            {
                Push(Pop());
            }
            return result;
        }

        public void Set(int index, int value)
        {
            Item oldHead = head;
            for (int i = 0; i < index; i++)
            {
                Push(Pop());
            }
            head.value = value;
            while (head != oldHead)
            {
                Push(Pop());
            }
        }

        public void Print()
        {
            Item current = head;
            while (current != null)
            {
                Console.Write(current.value + " ");
                current = current.next;
            }
            Console.WriteLine();
        }
    }
}
