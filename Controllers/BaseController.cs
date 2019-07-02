using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarktVille.DAL;
using MarktVille.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;


namespace MarktVille.Controllers
{
    public class BaseController : Controller
    {
        protected DatabaseDb _context;
        public const string SessionKeyName = "_Name";

        public BaseController(DatabaseDb context)
        {
            _context = context;
        }



        public Cart GetCart()
        {
            HttpContext.Session.SetString(SessionKeyName, "carrinho");

            return (Cart)HttpContext.Session.Keys;
        }


    }
}