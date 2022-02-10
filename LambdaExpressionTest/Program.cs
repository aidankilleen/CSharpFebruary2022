using System;
using System.Collections.Generic;
using System.Linq;
using UserDaoLibrary;

namespace LambdaExpressionTest
{
    class Program
    {

        static void DoSomething(int i)
        {
            Console.WriteLine(i);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Lambda Expressions");

            List<int> list = new List<int>();

            list.Add(2);
            list.Add(5);
            list.Add(6);
            list.Add(8);
            list.Add(1);
            list.Add(9);
            list.Add(7);
            list.Add(10);
            list.Add(3);


            //list.ForEach(DoSomething);

            list.ForEach((item) => {

                Console.WriteLine($"{ item }");
            });


            IEnumerable<int> evenList = list.Where(item => item % 2 == 0 );

            foreach(int n in evenList)
            {
                Console.WriteLine(n);
            }


            UserDao dao = new UserDao();
            List<User> users = dao.GetUsers();
            IEnumerable<User> activeUsers = users.Where(user => {

                return user.Active;
            });

            IOrderedEnumerable<User> sortedActiveUsers = activeUsers.OrderBy(user => user.Name);

            foreach (User user in sortedActiveUsers) {
                Console.WriteLine(user);
            }

            Console.WriteLine("==============================");

            IOrderedEnumerable<User> inactiveUsers = users.Where(user => !user.Active).OrderByDescending(user => user.Id);

            foreach(User u in inactiveUsers)
            {
                Console.WriteLine(u);
            }
            dao.Close();
        }
    }
}
