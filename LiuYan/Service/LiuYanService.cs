using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiuYan;

namespace LiuYan.Service
{
    class LiuYanService
    {
        public IList<LiuYan> GetAll(User.User u)
        {
            if (1 == u.id)
            {
                return LiuYan.FindAll();
            }
            else
            {
                return LiuYan.FindByUserId(u.id);
            }
        }

        public void Add(LiuYan ly)
        {
            ly.Insert();
        }
        public void Delete(LiuYan ly)
        {
            ly.Delete();
        }
    }
}
