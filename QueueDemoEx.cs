using System;
using System.Collections;

namespace QueueDemoAss
{
    public class PrintQueueDemo
    {
        public void PrintQue()
        {
            Queue Q = new Queue();
            Q.Enqueue("VIVEK");
            Q.Enqueue("KRUNAL");
            Q.Enqueue("NIRBHAY");
            Q.Enqueue("SAMEER");
            Q.Enqueue("ABHI");

            Console.WriteLine("Numers of Items in Queue :" + Q.Count);

            Console.WriteLine("******Items in Queue******");
            IEnumerator IT = Q.GetEnumerator();
            while (IT.MoveNext())
            {
                Console.WriteLine(IT.Current);
            }

            Q.Dequeue();
            Console.WriteLine("Numers of Items in Queue after deleting Item :" + Q.Count);

            Console.WriteLine("******Items in Queue After deleting item******");
            IEnumerator ITE = Q.GetEnumerator();
            while (ITE.MoveNext())
            {
                Console.WriteLine(ITE.Current);
            }

        }
    }
    class QueueDemoEx
    {
        static void Main(string[] args)
        {
            PrintQueueDemo PQD = new PrintQueueDemo();
            PQD.PrintQue();
        }
    }
}
