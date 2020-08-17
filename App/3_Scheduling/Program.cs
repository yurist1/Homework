using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _3_Scheduling
{
    class Program
    {
        public const int RRTYPE = 1;
        public const int SRTYPE = 2;
        public const int FCFSTYPE = 3;
        public const int SJFTYPE = 4;
        public const int TIMESLICE = 3;
        public static int TOTALTIME = 0;
        private static Queue<Item> schedule;
        static void Main(string[] args)
        {

            schedule = new Queue<Item>();
            Item a = new Item("a", 5);
            Item b = new Item("b", 2);
            Item c = new Item("c", 8);
            Item d = new Item("d", 3);



            var type = SJFTYPE;
            Thread thread = new Thread(() => doScheduling(type));
            thread.Start();
            schedule.Enqueue(a);
            Thread.Sleep(1 * 1000);
            schedule.Enqueue(b);
            schedule.Enqueue(c);
            Thread.Sleep(3 * 1000);
            schedule.Enqueue(d);


        }
        private static void RRSche()
        {
            while (schedule.Count() > 0)
            {
                int numProce = 0;
                //큐에서 꺼내고
                var proceItem = schedule.Dequeue();
                //time slice만큼 실행
                while (true)
                {
                    if (proceItem.count > 0 && numProce < TIMESLICE)
                    {
                        numProce++;
                        Console.WriteLine($"item name => {proceItem.itemName} / remain process => {--proceItem.count} / time {++TOTALTIME}");
                        Thread.Sleep(1000);

                    }
                    else
                        break;

                }

                //다시 큐에 넣어
                if (proceItem.count > 0)
                {
                    schedule.Enqueue(proceItem);
                }
            }


        }

        private static void SRTSche()
        {
            int queueCount = 0;
            Item proceItem = null;

            while (schedule.Count() > 0 || proceItem.count > 0)
            {
                //큐에 들어온게 있는지 확인
                if (queueCount != schedule.Count())
                {
                    //큐 갯수 저장
                    queueCount = schedule.Count();
                    //실행하던 아이템 다시 큐에 넣기 
                    if (proceItem != null)
                        schedule.Enqueue(proceItem);
                    //짧은 순서대로재 배치
                    schedule = new Queue<Item>(schedule.OrderBy(d => d.count));
                    //큐에서 꺼내고
                    proceItem = schedule.Dequeue();
                    //큐 아이템 갯수 갱신
                    queueCount--;
                }
                if (proceItem.count > 0)
                {
                    //실행
                    Console.WriteLine($"item name => {proceItem.itemName} / remain process => {--proceItem.count} / time {++TOTALTIME}");
                    Thread.Sleep(1000);
                }
                else
                {
                    //큐에서 꺼내고
                    proceItem = schedule.Dequeue();
                    //큐 아이템 갯수 갱신
                    queueCount--;
                }
            }
        }

        private static void FCFSSche()
        {
            while (schedule.Count() > 0)
            {
                Item proceItem = schedule.Dequeue();
                while (proceItem.count > 0)
                {
                    Console.WriteLine($"item name => {proceItem.itemName} / remain process => {--proceItem.count} / time {++TOTALTIME}");
                    Thread.Sleep(1000);
                }
            }
        }
        private static void SJFSche()
        {

            int queueCount = 0;
            Item proceItem = null;

            while (schedule.Count() > 0)
            {
                //짧은 순서대로재 배치
                schedule = new Queue<Item>(schedule.OrderBy(d => d.count));
                proceItem = schedule.Dequeue();
                queueCount--;
                while (proceItem.count > 0)
                {

                    Console.WriteLine($"item name => {proceItem.itemName} / remain process => {--proceItem.count} / time {++TOTALTIME}");
                    Thread.Sleep(1000);
                }
            }
        }
        private static void doScheduling(int type)
        {
            switch (type)
            {
                //RR
                case RRTYPE:
                    Console.WriteLine("RR 스케줄링");
                    RRSche();
                    break;

                //SRT
                case SRTYPE:
                    Console.WriteLine("SRT 스케줄링");
                    SRTSche();
                    break;

                //FCFS
                case FCFSTYPE:
                    Console.WriteLine("FCFS 스케줄링");
                    FCFSSche();
                    break;
                //SJF
                case SJFTYPE:
                    Console.WriteLine("SJF 스케줄링");
                    SJFSche();
                    break;
            }
            Console.Read();
        }


    }
    class Item
    {

        public Item(string mItemName, int mCount)
        {
            this.itemName = mItemName;
            this.count = mCount;
        }

        public string itemName { get; set; }
        public int count { get; set; }
    }
}
