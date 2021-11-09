using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TTGBL;


namespace TTGWebUI.Controllers
{
    public class StoreController : Controller
    {
        IStoreBL _storBL;

        public StoreController(IStoreBL p_storeBL)
        {
            _storBL = p_storeBL;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
