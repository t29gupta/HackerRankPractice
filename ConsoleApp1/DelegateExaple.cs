using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class DelegateExaple 
    {
        public delegate void MulticastExample();
        private int testVal = 10;
        public void Sum() => testVal += 5;
        public void Multiply() => testVal *= 5;
        public DelegateExaple()
        {
            MulticastExample muld = new MulticastExample(Multiply);
            muld += Sum;
            muld.Invoke();
            Console.WriteLine($"Multicast result : {testVal}");
            // Result is 55
        }
    }
}
