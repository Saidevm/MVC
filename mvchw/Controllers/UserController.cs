using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvchw.Data;
using mvchw.Models;
using mvchw.Data.Generic;

namespace mvchw.Controllers
{
    public class UserController : Controller
    {
        private IGenericRepo<User1> userEntity;
        public UserController()
        {
            this.userEntity = new GenericRepo<User1>(new userdbEntities());
        }

        // GET: User
        public ActionResult Index()
        {
            //var dbcon = new userdbEntities();
            //var userList = dbcon.User1.ToList();
            var userList = this.userEntity.GetUsers();
            List<UserModel> users = new List<UserModel>();
            foreach (var item in userList)
            {
                users.Add(new UserModel { Address = item.Address, Company = item.Company, Designation = item.Designation, Email = item.EMail, FirstName = item.FirstName, Id = item.Id });
            }

            ViewBag.Title1 = "Test Title1";
            ViewData["Title2"] = "Test Title2";
            TempData["Title3"] = "Test Title3";

            return View(users);
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            //UserModel user;
            //using (userdbEntities ent = new userdbEntities())
            //{
            //    var item = ent.User1.Find(id);
            var item = this.userEntity.GetUserById(id);
            var user = new UserModel { Address = item.Address, Company = item.Company, Designation = item.Designation, Email = item.EMail, FirstName = item.FirstName, Id = item.Id };
            //}
            return View(user);
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(UserModel collection)
        {
            try
            {
                this.userEntity.InsertUser(new User1 { FirstName = collection.FirstName, LastName = collection.LastName, EMail = collection.Email, Address = collection.Address, Company = collection.Company });
                this.userEntity.Commit();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            UserModel user = new UserModel();
            var userd = this.userEntity.GetUserById(id);
            user.FirstName = userd.FirstName;
            user.LastName = userd.LastName;
            user.Id = userd.Id;


            return View(user);
        }


        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, UserModel user)
        {
            try
            {
                var userd = this.userEntity.GetUserById(id);
                userd.FirstName = user.FirstName;
                userd.LastName = user.LastName;
                this.userEntity.Commit();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            UserModel user = new UserModel();
            var userd = this.userEntity.GetUserById(id);
            user.FirstName = userd.FirstName;
            user.LastName = userd.LastName;
            user.Id = userd.Id;


            return View(user);
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var userd = this.userEntity.GetUserById(id);
                this.userEntity.DeletedUser(userd);
                this.userEntity.Commit();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
