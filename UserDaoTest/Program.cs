using System;
using System.Collections.Generic;

namespace UserDaoTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("UserDao Test");

            UserDao dao = new UserDao();

            User newUser = new User();
            newUser.Name = "New User";
            newUser.Email = "new.user@gmail.com";
            newUser.Active = false;

            Console.WriteLine(newUser);

            User addedUser = dao.AddUser(newUser);

            Console.WriteLine(addedUser);





            List<User> users = dao.GetUsers();


            
            
            foreach(User u in users)
            {
                Console.WriteLine(u);
            }

            User userToUpdate = users[0];

            Console.WriteLine(userToUpdate);


            userToUpdate.Name = "CHANGED";
            userToUpdate.Email = "changed@gmail.com";
            userToUpdate.Active = !userToUpdate.Active;

            dao.UpdateUser(userToUpdate);

            User updatedUser = dao.GetUser(userToUpdate.Id);

            Console.WriteLine(updatedUser);





            /*
            Console.WriteLine("=====================================");

            User user = dao.GetUser(5);

            Console.WriteLine(user);

            User user56 = dao.GetUser(56);
            Console.WriteLine(user56);

            dao.DeleteUser(56);

            user56 = dao.GetUser(56);

            Console.WriteLine(user56 == null);
            */
            dao.Close();
        }
    }
}
