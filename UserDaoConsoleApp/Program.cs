using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using UserDaoLibrary;

namespace UserDaoConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("UserDao Console App");

            UserDao dao = new UserDao();
            try
            {
                User user = dao.GetUser(999);
                Console.WriteLine(user.Name);

            } catch (UserDaoException ex)
            {
                Console.WriteLine(ex.Message);
            }


            try
            {
                dao.DeleteUser(999);

            } catch (UserDaoException ex)
            {
                Console.WriteLine(ex.Message);
            }


            List<User> users = dao.GetUsers();


            foreach(User u in users)
            {
                Console.WriteLine(u);
            }

            dao.Close();
        }
    }
}
