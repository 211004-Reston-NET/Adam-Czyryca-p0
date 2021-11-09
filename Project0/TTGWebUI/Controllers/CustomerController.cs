using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TTGBL;
using TTGWebUI.Models;
using TTGModel;

namespace TTGWebUI.Controllers
{
    public class CustomerController : Controller
    {
        private ICustomerBL _custBL;

        public CustomerController(ICustomerBL p_custBL)
        {
            _custBL = p_custBL;
        }

        // GET: CustomerController
        public ActionResult Index()
        {
            //get list of customers from BL
            //converted model customer into customerVM using select method
            //toList to change it into a list
            return View(_custBL.GetAllCustomers()
                .Select(cust => new CustomerVM(cust))
                .ToList()
            );
        }

        // GET: CustomerController/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        public IActionResult Create(CustomerVM custVM)
        {
            _custBL.AddCustomer(new Customer()
            {
                Name = custVM.Name,
                Address = custVM.Address,
                EmailPhone = custVM.EmailPhone
            });
            return RedirectToAction(nameof(Index));
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }



        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
