using DIP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Repository
{
    public class UserRepository
    {
        private IDatabase _database;
        public UserRepository(IDatabase database)
        {
            _database = database;
        }
        public List<User> GetAll()
        {
            return _database.GetUsers();
        }
    }
}
