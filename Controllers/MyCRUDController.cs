using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JsonServiceExample.Controllers
{
    public class MyCRUDController : ApiController
    {

        JsonServiceExampleDBEntities db = new JsonServiceExampleDBEntities();

        [HttpGet]
        public List<userinfo> GetAllUsers()
        {
            return db.userinfoes.ToList();
        }

        [HttpGet]
        public string GetUser(string fname, string lname)
        {
            userinfo u = new userinfo();
            u.fname = fname;
            u.lname = lname;
            db.userinfoes.Add(u);
            db.SaveChanges();
            return "Record Saved";
        }

    }
}
