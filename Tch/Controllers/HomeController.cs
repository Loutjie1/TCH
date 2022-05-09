using DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Tch.Models;
using Newtonsoft.Json;
using System.Linq.Dynamic.Core;
using System.Web.Mvc;
using System.Web.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Resources;

namespace Tch.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataContext _context;

        public HomeController(ILogger<HomeController> logger, DataContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Privacy()
        {

            return View();
        }

        [HttpGet]
        public IActionResult Company(int Id)
        {
            return RedirectToAction("GetCompany", "Company",new {id= Id});
        }

        [HttpGet]
        public ActionResult GetUserById(int Id)
        {
            string str = string.Format("The id passed as parameter is: {0}", Id);
            return RedirectToAction("GetUser", "User", new { id = Id });
        }
        public JsonResult GetCompanies()
        {
            string IsActive = string.Empty;
            try
            {

                List<Company> complist = new List<Company>();
                List<CompanyData> compData = new List<CompanyData>();

                complist = _context.Companies.ToList<Company>();

                foreach (var item in complist)
                {
                    if (item.Active == true)
                    {
                        IsActive = "Yes";
                    }
                    else
                    {
                        IsActive = "No";
                    }
                    compData.Add(new CompanyData() { Id= item.Id, Active=IsActive, Contact_Number=item.Contact_Number, Name=item.Name, Registration_No=item.Registration_No});
                }
                return Json(new { data = compData });
            }
            catch (Exception)
            {

                throw;

            }
        }

        public JsonResult GetUsers()
        {
            string IsLogin = string.Empty;
            try
            {

                List<Userdata> userdata = new List<Userdata>();

                var userlist = (from u in _context.Users
                                join c in _context.Companies on u.CompanyId
                                equals c.Id
                                where c.Id == u.CompanyId
                                select new User
                                {
                                    Id = u.Id,
                                    Friendly_Name = u.Friendly_Name,
                                    Name = u.Name,
                                    Surname = u.Surname,
                                    Contact_Number = u.Contact_Number,
                                    Email_Address = u.Email_Address,
                                    Date_of_Birth = u.Date_of_Birth.Date,
                                    Age = u.Age,
                                    Company_name = c.Name,
                                    Can_Login = u.Can_Login

                                }).ToList();

                foreach (var uitem in userlist)
                {

                    if (uitem.Can_Login == true)
                    {
                        IsLogin = "Yes";
                    }
                    else
                    {
                        IsLogin = "No";
                    }
                    userdata.Add(new Userdata() { Id = uitem.Id, Friendly_Name = uitem.Friendly_Name, Contact_Number = uitem.Contact_Number, Email_Address = uitem.Email_Address, Date_of_Birth = uitem.Date_of_Birth.ToString("dd/MM/yyyy"), Company_name = uitem.Company_name, Can_Login=IsLogin });

                }
                return Json(new { data = userdata });
            }
            catch (Exception)
            {

                throw;

            }
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

      }
}
