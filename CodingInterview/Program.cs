using System;

namespace CodingInterview
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ReverseSubList();
        }

        private static void ReverseSubList()
        {
            var obj = new ReverseSubList();
            var head = obj.CreateLL();
            Console.WriteLine("before reverse:");
            obj.PrintLL(head);
            Console.WriteLine("after reverse:");
            obj.PrintLL(obj.ReverseSubListFunction(head, 2, 10));
        }
    }
}
