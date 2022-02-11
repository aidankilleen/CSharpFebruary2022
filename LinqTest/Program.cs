using System;
using System.Collections.Generic;
using System.Linq;
using UserDaoLibrary;

namespace LinqTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linq Test");

            List<int> list = new List<int>();

            Random rnd = new Random();

            for (int i=0; i<10; i++)
            {
                list.Add(rnd.Next(100));
            }

            list.ForEach(item => Console.WriteLine(item));

            Console.WriteLine("================================");


            // LINQ = Language Integrated Query

            IEnumerable<int> result = from item in list where item < 50 select item;
            foreach(int n in result)
            {

                Console.WriteLine(n);
            }
            /*
            IEnumerable<int> result2 = list.Where(item => item < 50);
            foreach(int n2 in result2)
            {
                Console.WriteLine(n2);
            }
            */


            UserDao dao = new UserDao();
            List<User> users = dao.GetUsers();

            IEnumerable<string> names = from user in users where user.Active select user.Name;

            foreach(string name in names)
            {
                Console.WriteLine(name);
            }

            IEnumerable<User> activeUsers = from user in users where user.Active select user;


            foreach(User user in activeUsers)
            {
                Console.WriteLine(user); 
            }

            IEnumerable<string> sortedActive = from user in users where user.Active orderby user.Name descending select user.Name;

            Console.WriteLine("===============================================");

            foreach(string user in sortedActive)
            {
                Console.WriteLine(user);
            }

            var res = from user in users where user.Active select new { user.Name, user.Email };


            foreach(var item in res)
            {
                Console.WriteLine($"{ item.Name } - { item.Email }");
            }

            int total = users.Count;
            Console.WriteLine($"total: { users.Count }");

            int count = (from user in users where user.Active select user).Count();

            Console.WriteLine($"There are { count } active users");
            IEnumerable<int> groupedResult = from user in users
                                             group user by user.Active into g
                                             select g.Count();

            foreach(int c in groupedResult)
            {
                Console.WriteLine(c);
            }

            dao.Close();














        }
    }
}
