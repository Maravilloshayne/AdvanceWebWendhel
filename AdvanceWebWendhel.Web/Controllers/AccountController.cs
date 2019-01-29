using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdvanceWebWendhel.Web.Infrastructures.Data.Helpers;
using AdvanceWebWendhel.Web.ViewModels.Account;
using Microsoft.AspNetCore.Mvc;

namespace AdvanceWebWendhel.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly DefaultDbContext _context;


        public AccountController(DefaultDbContext context)
        {
            _context = context;
        }

       
    }
}