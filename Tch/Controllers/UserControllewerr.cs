using DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tch.Models;

namespace Tch.Controllers
{
    public class UserControllewerr : Controller
    {
        private readonly DataContext _context;

        public UserControllewerr(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            //var companyList = (from company in _context.Companies
            //                   orderby company.CName
            //                   select new SelectListItem()
            //                   {
            //                       Text = company.Came,
            //                       Value = company.Id.ToString(),
            //                   }).ToList();
            //ViewBag.CompanyToList = companyList;
            ////companyList.Insert(0, new SelectListItem()
            ////{
            ////    Text = company.Name,
            ////    Value = string.Empty
            ////});
            return View();
        }

        [HttpPost]
        public IActionResult Index(User user, CompanyViewModel companyViewModel)
        {

            if ((user.Name != null) &&(companyViewModel.ComId !=null) )
            {
                var selectedValue = companyViewModel.ComId;

                //user.Company.Id = Convert.ToInt32(selectedValue);
                _context.Add(user);
                _context.SaveChanges();
            }

            return RedirectToAction("Index", "Home");
        }

        //public IActionResult GetCompany()
        //{
   

        //    return Json(_context.Companies.Select(x => new
        //    {
        //        Id = x.Id,
        //        Name = x.Name
        //    }).ToList(), JsonRequestBehavior.AllowGet);
        //}
    }
}
