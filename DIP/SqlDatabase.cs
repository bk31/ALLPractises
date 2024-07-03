using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIP.Interface;
namespace DIP
{
    public class SqlDatabase : IDatabase
    {
        public List<User> GetUsers()
        {
            throw new NotImplementedException();
        }
    }
}
