using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User;

namespace User
{
    class UserService
    {
        public User Login(User user)
        {
            return User.FindByUserPass(user);
        }

        public IList<User> GetAll()
        {
            return User.FindAll();
        }

        public User GetUserById(int id)
        {
            return User.Find("id", id);
        }

        public void Add(User user)
        {
            user.Insert();
        }
        public void Delete(User user)
        {
            user.Delete();
        }
        public void Update(User user)
        {
            user.Update();
        }
    }
}
