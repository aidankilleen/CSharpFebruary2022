using System;
using System.Collections.Generic;
using System.Text;

namespace TupleTest
{
    class Result
    {
        public int Total { get; set; }
        public double Average { get; set; }

        public Result(int total, double average)
        {
            Total = total;
            Average = average;
        }
    }
}
