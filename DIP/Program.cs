using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
    }

    /*
     * D — Dependency Inversion Principle

    The Dependency Inversion Principle (DIP) states that high-level modules should not depend on low-level modules.
    Instead, both should depend on abstractions.
    In other words, we should depend on abstractions, not on concrete implementations.
    For example, consider a class that depends on a concrete implementation of a database. 
    If we want to switch to a different type of database, we would need to modify the class.
    Instead, we should depend on an abstraction of the database, which can be implemented by different types of databases.
     */



    // Bad: Class depends on a concrete implementation of a database
    public class UserRepository
    {
        private SqlDatabase _database;

        public UserRepository()
        {
            _database = new SqlDatabase();
        }

        public List<User> GetUsers()
        {

            List<User> users = new List<User>();
            // Data retrieval logic using the SqlDatabase implementation
            return users;
        }
    }

    // Good: Class depends on an abstraction of a database


}
