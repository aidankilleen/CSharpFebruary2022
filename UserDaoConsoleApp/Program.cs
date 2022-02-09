using System;
using System.Collections.Generic;
using UserDaoLibrary;

namespace UserDaoConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("UserDao Console App");


            UserDao dao = new UserDao();
            List<User> users = dao.GetUsers();


            foreach(User u in users)
            {
                Console.WriteLine(u);
            }

            dao.Close();
        }
    }
}
