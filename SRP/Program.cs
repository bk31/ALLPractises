using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
    }

    /*
     The Single Responsibility Principle (SRP) states that a class should have only one reason to change.
    In other words, a class should be responsible for one and only one thing. This helps keep classes focused and makes them easier to maintain and test.
    For example, consider a class that is responsible for both user authentication and data retrieval.
    This violates the SRP because if we need to modify the authentication logic, we would also need to modify the data retrieval logic.
    Instead, we should create separate classes for authentication and data retrieval, each with its own responsibility.
     */


    // Bad: Authentication and data retrieval logic in the same class
    public class UserRepository
    {
        public bool Authenticate(string username, string password)
        {
            return false;
            // Authentication logic
        }

        public List<Users> GetUsers()
        {
            List<Users> users = new List<Users>();
            return users;

            // Data retrieval logic
        }
    }
    public class UserAuthentication
    {
        public bool Authenticate(string username, string password)
        {
            return true;
        }
    }
    public class UserrRepository
    {

        public List<Users> GetUsers()
        {
            // Data retrieval logic
            List<Users> users = new List<Users>();
            return users;
        }
    }

}
