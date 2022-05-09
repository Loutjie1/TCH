using DataAccess;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using Tch.Models;
using PowerArgs.Cli;

namespace Tch.Controllers
{
    public class UserController : Controller
    {
        private readonly DataContext _context;
        private readonly IWebHostEnvironment _iwebhost;
        private readonly Disposable _disposable;


        public UserController(DataContext context, IWebHostEnvironment iwebhost)
        {
            _context = context;
            _iwebhost = iwebhost;
            //_disposable = new RegisteredForDispose();
        }
        public IActionResult Index()
        {
            var companyList = (from company in _context.Companies
                               orderby company.Name
                               select new SelectListItem()
                               {
                                   Text = company.Name,
                                   Value = company.Id.ToString(),
                               }).ToList();
            ViewBag.CompanyToList = companyList;
            ViewBag.CompanyId = _context.Companies;
            return View();
        }

        [HttpGet]
        public IActionResult Index(int Id)
        {
            var companyList = (from company in _context.Companies
                               orderby company.Name
                               select new SelectListItem()
                               {
                                   Text = company.Name,
                                   Value = company.Id.ToString(),
                               }).ToList();
            ViewBag.CompanyToList = companyList;
            ViewBag.CompanyId = _context.Companies;
            var GetUser = (from u in _context.Users
                           where u.Id == Id
                           select u).ToList();


            if (Id != 0)
            {
                string dateformat = string.Empty;
                User use = new User();

                foreach (var item in GetUser)
                {
                    use.Id = item.Id;
                    use.Friendly_Name = item.Friendly_Name;
                    use.Name = item.Name;
                    use.Surname = item.Surname;
                    use.Contact_Number = item.Contact_Number;
                    use.Email_Address = item.Email_Address;
                    use.Date_of_Birth = item.Date_of_Birth.Date.Date;
                    use.Age = item.Age;
                    use.Company_name = item.Company_name;
                    if (item.Company != null)
                    {
                        use.Company.Active = item.Company.Active;
                        use.Company.Contact_Number = item.Company.Contact_Number;
                        use.Company.Id = item.Company.Id;
                        use.Company.Name = item.Company.Name;
                        use.Company.Registration_No = item.Company.Registration_No;
                    }
                    else
                    {
                        use.Company = null;
                    }
                    use.CompanyId = item.CompanyId;
                    use.Password = item.Password;
                    use.Picture = item.Picture;
                    use.Username = item.Username;
                    use.Can_Login = item.Can_Login;
                    use.PictureFileName = item.PictureFileName;


                }
                return View(use);
            }
            else
            {
                return View();
            }
           

        }
         [HttpPost]
        public new IActionResult User(User user)
        {
            MemoryStream stream = new MemoryStream();
            if (!String.IsNullOrEmpty(user.PictureFileName))
            {

                Image image = Bitmap.FromFile(user.PictureFileName);
                user.Picture = ConvertImageToByte(image);
            }
     

            if (user.Id != 0)
            {

                _context.Update(user);
            }
            else
            {
          
                _context.Add(user);
              
            }

             _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        private byte[] ConvertImageToByte(Image pictureFile)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                pictureFile.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        [HttpGet]
        public IActionResult GetUser(int Id)
        {
            return View();
        }

        [HttpGet]
        public IActionResult DeleteUser(int Id)
        {
            var GetUser = (from u in _context.Users
                           where u.Id == Id
                           select u).ToList();

            _context.RemoveRange(GetUser);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult UploadImage()
        {
            return View();
        }

    }
}
