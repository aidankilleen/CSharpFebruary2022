using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceTest
{
    class Tutor : Contractor, ITeacher
    {

        public Tutor(string firstName, string lastName, string agency)
            : base(firstName, lastName, agency)
        {

        }

        public void Teach()
        {
            Console.WriteLine("Please sit down, lesson is about to begin");
        }
    }
}
