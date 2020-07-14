using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LiuYan.Service;

namespace LiuYan
{
    public class LiuYanController : Controller
    {
        LiuYanService liuYanService = new LiuYanService();

        // View
        public ActionResult LiuYanView()
        {
            User.User user = (User.User) Session["User"];
            if (null == user)
            {
                return Redirect("/User/LoginView");
            }
            else
            {
                IList<LiuYan> lyList = liuYanService.GetAll(user);
                ViewData["data"] = lyList;
                ViewData["User"] = user;
                return View("LiuYanView");
            }
        }

        // Action
        public ActionResult Add(LiuYan ly)
        {
            liuYanService.Add(ly);
            return Redirect("/LiuYan/LiuYanView");
        }
        public ActionResult Delete(LiuYan ly)
        {
            liuYanService.Delete(ly);
            return Redirect("/LiuYan/LiuYanView");
        }
    }
}
