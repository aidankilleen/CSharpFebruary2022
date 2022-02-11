using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LinqTest
{
    class AggregateTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aggregate Test");

            List<Record> records = new List<Record>()
            {
                new Record(1, "Alice", "red", 10),
                new Record(2, "Bob", "green", 12),
                new Record(3, "Carol", "blue", 14),
                new Record(4, "Dan", "red", 10),
                new Record(5, "Carol", "green", 16),
                new Record(6, "Dan", "blue", 10),
                new Record(7, "Bob", "green", 1),
                new Record(8, "Alice", "green", 20),
                new Record(9, "Bob", "green", 15),
                new Record(10, "Carol", "red", 10),
                new Record(11, "Alice", "red", 10),
                new Record(12, "Bob", "green", 12),
                new Record(13, "Carol", "blue", 14),
                new Record(14, "Dan", "red", 10),
                new Record(15, "Carol", "green", 16),
                new Record(16, "Dan", "blue", 10),
                new Record(17, "Bob", "green", 1),
                new Record(18, "Alice", "green", 20),
                new Record(19, "Bob", "green", 15),
                new Record(20, "Carol", "red", 10), 
                new Record(21, "Eve", "orange", 99)
            };
            IEnumerable<string> result = from record in records select record.Name;

            foreach(string s in result)
            {
                Console.WriteLine(s);
            }

            var res = from record in records
                      group record by record.Name into g
                      select new
                      {
                          Name = g.Key,
                          Count = g.Count()
                      };

            foreach (var r in res)
            {
                Console.WriteLine($"{r.Name} \t {r.Count}" );
            }

            var res2 = from record in records
                       group record by record.Colour into g
                       select new
                       {
                           Colour = g.Key,
                           Total = g.Sum(a => a.Count)
                       };

            foreach(var r in res2)
            {
                Console.WriteLine($"{ r.Colour } \t { r.Total }");
            }

            var lres = records.GroupBy(r => r.Colour)
                               .Select(g => new { Colour = g.Key, Total = g.Sum(i => i.Count) });

            foreach(var i in lres)
            {
                Console.WriteLine(i);
            }
        }
    }
}
