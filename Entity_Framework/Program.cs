using System;

namespace Entity_Framework
{
    static class Program
    {
        private static void Main()
        {
            using(var db = new UserContext())
            {
                //create 2 object User
                var user1 = new User { Name = "Anna", Age = 23 };
                var user2 = new User { Name = "Alex", Age = 30 };

                // put them to the database
                db.Users.Add(user1);
                db.Users.Add(user2);
                db.SaveChanges();
                Console.WriteLine("Save");

                //getting objects from the database and output them to the console
                var users = db.Users;
                Console.WriteLine("List of employees:");
                foreach(var u in users)
                {
                    Console.WriteLine($"{u.Id}. {u.Name}, age - {u.Age}");
                }
                Console.Read();
            }
        }
    }
}
