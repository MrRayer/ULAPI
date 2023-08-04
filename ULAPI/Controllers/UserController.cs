using Microsoft.AspNetCore.Mvc;
using ULAPI.Models;
using ULAPI.Utils;

namespace ULAPI.Controllers
{
    public class UserController : Controller
    {
        private IDataAccess DA;
        public UserController(IDataAccess _DA)
        {
            DA = _DA;
        }

        [Route("/UserController/addUser")]
        [HttpGet]
        public void addUser(string Name, string Password, string Email)
        {
            UserModel userToAdd = new UserModel(Name,Password,Email);
            DA.addUser(userToAdd);
            return;
        }

        [Route("/UserController/removeUser")]
        [HttpGet]
        public void removeUser(string Name, string Password)
        {
            UserModel userToAdd = new UserModel(Name, Password);
            DA.removeUser(userToAdd);
            return;
        }

        [Route("/UserController/updateUser")]
        [HttpGet]
        public void updateUser(string Name, string Password, string newName, string newPassword, string newEmail)
        {
            UserModel userToAdd = new UserModel(Name, Password);
            UserModel userToUpdate = new UserModel(newName, newPassword, newEmail);
            DA.updateUser(userToAdd, userToUpdate);
            return;
        }

        [Route("/UserController/validateUser")]
        [HttpPost]
        public bool validateUser(string Name, string Password)
        {
            UserModel userValidate = new UserModel(Name, Password);
            return DA.validateUser(userValidate);
        }
    }
}
