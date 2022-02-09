using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace UserDaoTest
{
    class UserDao
    {
        private SqlConnection connection;
        private string connectionString = "xxx";

        public UserDao()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
        }
        public void Close()
        {
            connection.Close();
        }
        public List<User> GetUsers()
        {
            List<User> users = new List<User>();

            string sql = "select * from users";

            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader rs = command.ExecuteReader();

            while (rs.Read())
            {
                int id = rs.GetInt32(0);
                string name = rs.GetString(1);
                string email = rs.GetString(2);
                bool active = rs.GetInt32(3) == 1;

                User u = new User(id, name, email, active);
                users.Add(u);
            }
            rs.Close();
            return users;
        }


        public User GetUser(int id)
        {
            User u = null;

            string sql = $"select * from users where id = { id }";

            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader rs = command.ExecuteReader();

            if(rs.Read())
            {
                string name = rs.GetString(1);
                string email = rs.GetString(2);
                bool active = rs.GetInt32(3) == 1;

                u = new User(id, name, email, active);
            }

            rs.Close();
            return u;
        }

        public void DeleteUser(int id)
        {
            string sql = $"delete from users where id = { id }";
            SqlCommand command = new SqlCommand(sql, connection);
            command.ExecuteNonQuery();
        }

        public User UpdateUser(User userToUpdate)
        {
            string sql = $@"
                update users 
                set name = '{ userToUpdate.Name }', 
                    email = '{ userToUpdate.Email }', 
                    active = { (userToUpdate.Active ? 1 : 0)}
                where id = { userToUpdate.Id }
            ";

            Console.WriteLine(sql);

            SqlCommand command = new SqlCommand(sql, connection);

            command.ExecuteNonQuery();

            return userToUpdate;
        }

        public User AddUser(User userToAdd)
        {
            string sql = $@"
                insert into users
                (name, email, active)
                VALUES('{ userToAdd.Name }', '{ userToAdd.Email }', { (userToAdd.Active ? 1 : 0)}) 
            ";

            SqlCommand command = new SqlCommand(sql, connection);
            command.ExecuteNonQuery();

            // read the id of the newly generated object
            sql = "select @@IDENTITY";
            command = new SqlCommand(sql, connection);
            Decimal addedId = (Decimal)command.ExecuteScalar();
            userToAdd.Id = (int)addedId;

            return userToAdd;
        }
    }
}
