using System;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Nop.Web.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Nop.Web.Controllers
{
    public partial class brandController : BasePublicController
    {
        private readonly bankcontex _dbContext;

        public brandController(bankcontex dbContext)

        {
            _dbContext = dbContext;
        }
        public virtual IActionResult Index()
        {
            var _emplst = _dbContext.Manufacturer.Find(1);
            return View(_emplst);
        }
    }
}
