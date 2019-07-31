using MarktVille.Models;
using MarktVille.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace MarktVille.Controllers
{
    public class UserController : Controller
    {
        private List<User> _user;

        private IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public List<User> Index(int? id)
        {
            if (id != null)
            {
                _user = _userRepository.GetUserById(id).ToList();
                return _user;
            }
            var model = new HomeIndexViewModel();
            _user = _userRepository.GetUser().ToList();
            return _user;

        }

    }
}