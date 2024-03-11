using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using PharmaSafeChain.Models.UserManagementModels;
using System;

namespace PharmaSafeChain.Controllers.UserManagementControllers
{
    [Route ("User")]
    public class UserIdentityController : Controller
    {
        public static List<User_Information_Model> UserIdentity = new List<User_Information_Model>()
              {
             new User_Information_Model()
             {
              User_id = 1,
              UserName = "UmerFarooq",
              FirstName = "Umer",
              LastName = "Farooq",
              Email = "mumerfarooqlaghari@gmail.com",
              PhoneNumber ="+923009243063"

             }
    };

    [Route ("Identity")]
    public IActionResult UserIdentityIndex()
        {
            ViewBag.UserIdentity = UserIdentity;
            return View();
        }
    }
}
