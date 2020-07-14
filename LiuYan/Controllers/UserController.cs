using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace User
{
    public class UserController : Controller
    {
        UserService userService = new UserService();

	    // Action
        public ActionResult Login(User user) {
            User u = userService.Login(user);
	    if (null != u) {
                Session["User"] = u;
                return Redirect("/LiuYan/LiuYanView");
            } else {
                return Redirect("/User/LoginView");
            }
        }
        public ActionResult Logout() {
            Session["User"] = null;
            return Redirect("/User/LoginView");
        }
        public ActionResult Add(User user) {
            userService.Add(user);
            return Redirect("/User/LoginView");
        }
        public ActionResult Delete(User user) {
            userService.Delete(user);
            return Redirect("/User/ManagerView");
        }
        public ActionResult Edit(User user) {
            userService.Update(user);
            return Redirect("/User/ManagerView");
        }

	    // View
        public ActionResult RegView() {
            return View("RegView");
        }
        public ActionResult LoginView() {
            return View("LoginView");
        }
        public ActionResult EditView(int id) {
            User user = userService.GetUserById(id);
            ViewData["User"] = user;
            return View("EditView");
        }
        public ActionResult ManagerView() {
            IList<User> userList = userService.GetAll();
            ViewData["data"] = userList;
            return View("ManagerView");
        }
    }
}
