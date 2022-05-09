using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tch.Models;
using DataAccess;
using Newtonsoft.Json;
using System.Linq.Dynamic.Core;

namespace Tch.Controllers
{  

    public class CompanyController : Controller
    {
        private readonly DataContext _context;

        public CompanyController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Index(int Id)
        {
            var GetCom = (from c in _context.Companies
                          where c.Id == Id
                          select c).ToList();
            Company com = new Company();

            foreach (var item in GetCom)
            {
                com.Id = item.Id;
                com.Name = item.Name;
                com.Registration_No = item.Registration_No;
                com.Contact_Number = item.Contact_Number;
                com.Active = item.Active;

            }
            return View(com);
        }
// Delete company Action
         [HttpGet]
         public IActionResult DeleteCompany(int Id)
        {
            var GetCom = (from c in _context.Companies
                          where c.Id == Id
                          select c).ToList();

            _context.RemoveRange(GetCom);
            _context.SaveChanges();

            return RedirectToAction("Privacy", "Home");
        }
 // Post company Action          
        [HttpPost]
        public IActionResult Company(Company company)
        {
           if (company.Id !=0)
            {
                _context.Update(company);
                
            }
            else
            {
                _context.Add(company);
            }
            _context.SaveChanges();


            return RedirectToAction("Privacy", "Home");
        }

       
   
     
    }
}
