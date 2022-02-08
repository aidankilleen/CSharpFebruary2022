using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceTest
{
    class Manager : Employee
    {
        public int HeadCount { get; set; }

        public Manager(string firstName, 
                       string lastName, 
                       string employeeId, 
                       int headCount)
            :base(firstName, lastName, employeeId)
        {
            HeadCount = headCount;
        }

        public override void Display()
        {
            Console.WriteLine("Manager:");
            base.Display();
            Console.WriteLine("HeadCount:" + HeadCount);
        }

    }
}
