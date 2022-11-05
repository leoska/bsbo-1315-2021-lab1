// Pointers, Queue, Bubble sort

using BSBO_1315_2021_lab1;
using System;

class Program
{
    static void Main(string[] args)
    {
        Queue q = new Queue();
        Random rand = new Random();
        int N = 100;
        int t = 0;
        for (var i = 0; i < N; i++)
        {
            q.Push(new Item(rand.Next(1, 100)));
        }
        q.Print();
        for (var i = 0; i < N; i++)
        {
            bool flag = false;
            for (var j = 0; j < N-1-i; j++)
            {
                if (q.Get(j) > q.Get(j + 1))
                {
                    flag = true;
                    t = q.Get(j);
                    q.Set(j, q.Get(j + 1));
                    q.Set(j + 1, t);
                };
            }
            if(flag == false)
            {
                break;
            }
        }
        q.Print();
    }
}