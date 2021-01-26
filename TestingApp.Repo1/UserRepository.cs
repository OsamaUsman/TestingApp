using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingApp.Model;

namespace TestingApp.Repo1
{
    public class UserRepository : Repository<User>
    {
        TestingAppDbContext db = new TestingAppDbContext();
        public bool IsExist(string name , string pass) 
        {
            bool IsValid = db.Users.Any(p => p.Name == name && p.Password == pass);
            return IsValid;
        }

    }
}
