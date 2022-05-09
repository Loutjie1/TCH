using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Tch.Models;

namespace Tch.Controllers
{
    public class UpLoadImgController : Controller
    {
        private readonly IWebHostEnvironment _iwebhost;

        public UpLoadImgController(IWebHostEnvironment iwebhost)
        {
            _iwebhost = iwebhost;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Index(int Id, string Fname, string Name, string sname, string cont, string Email, DateTime DOB, int Age, string CName, int CId, string Username, string Pass, bool Canlogin)
        {

            User imgup = new User();

            imgup.Age = Age;
            imgup.CompanyId = CId;
            imgup.Company_name = CName;
            imgup.Contact_Number = cont;
            imgup.Date_of_Birth = DOB;
            imgup.Email_Address = Email;
            imgup.Friendly_Name = Fname;
            imgup.Id = Id;
            imgup.Name = Name;
            imgup.Password = Pass;
            imgup.Surname = sname;
            imgup.Username = Username;
            imgup.Can_Login = Canlogin;

 




            return View(imgup);

        }

        [HttpPost]
        public async Task<IActionResult> ImageUpload(IFormFile formFile, User image)
        {
          
           string saveimg = Path.Combine(_iwebhost.WebRootPath, "Images", formFile.FileName);
           var stream = new FileStream(saveimg, FileMode.Create);
           await formFile.CopyToAsync(stream);

            image.PictureFileName = saveimg;
            stream.Close();
            return View(image);
        }
    }
}
