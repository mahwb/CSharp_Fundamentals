using System;
using System.Collections.Generic;

namespace mysql
{
    class Program
    {
        static void Main(string[] args)
        {
            Read();
            Create();
            Delete();
            Update();
            System.Console.WriteLine("Ending Program!");
        }

        static void Read() {
            List<Dictionary<string, object>> users = DbConnector.Query("select * from users");
            System.Console.WriteLine("---------------Users-------------------");
            foreach (Dictionary<string,object> user in users) {
                System.Console.WriteLine($"ID {user["id"]}: {user["first_name"]} {user["last_name"]}");
            }
            System.Console.WriteLine("---------------------------------------");
        }

        static void Create() {
            System.Console.WriteLine("Do you want to create new user?");
            string yes_no = Console.ReadLine();
            if (yes_no == "yes") {
                System.Console.WriteLine("First name of user?");
                string fname = Console.ReadLine();
                System.Console.WriteLine("Last name of user?");
                string lname = Console.ReadLine();
                System.Console.WriteLine("Favorite Number?");
                string number = Console.ReadLine();
                string query = $"INSERT INTO users (first_name, last_name, favorite_number) VALUES ('{fname}', '{lname}', '{number}')";
                DbConnector.Execute(query);
                System.Console.WriteLine($"{fname} {lname} created");
                Create();
            }
        }

        static void Delete() {
            System.Console.WriteLine("Do you want to delete a user?");
            string yes_no = Console.ReadLine();
            if (yes_no == "yes") {
                System.Console.WriteLine("ID you want to delete?");
                string id = Console.ReadLine();
                string query = $"DELETE FROM users WHERE id='{id}'";
                DbConnector.Execute(query);
                Delete();
            }
        }

        static void Update() {
            System.Console.WriteLine("Do you want to update a user?");
            string yes_no = Console.ReadLine();
            if (yes_no == "yes") {
                string query;
                System.Console.WriteLine("ID you want to update?");
                string id = Console.ReadLine();
                System.Console.WriteLine("Update first name to?");
                string fname = Console.ReadLine();
                query = $"UPDATE users SET first_name ='{fname}' WHERE id='{id}'";
                DbConnector.Execute(query);
                System.Console.WriteLine("Update last name to?");
                string lname = Console.ReadLine();
                query = $"UPDATE users SET last_name ='{lname}' WHERE id='{id}'";
                DbConnector.Execute(query);
                System.Console.WriteLine("Update favorite number to?");
                string number = Console.ReadLine();
                query = $"UPDATE users SET favorite_number ='{number}' WHERE id='{id}'";
                DbConnector.Execute(query);
                Update();
            }
        }
    }
}
