using ClosedXML.Excel;using DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using PowerArgs.Games;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Tch.Models;

namespace Tch.Controllers
{
    public class ExportUserController : Controller
    {
        private readonly DataContext _context;

        public ExportUserController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Export()
        {


            using (XLWorkbook wb = new XLWorkbook())
            {
                DataTable dt = this.GetUser().Tables[0];
                wb.Worksheets.Add(dt);

                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.ms-excel", "Users.csv");
                }
            }
        }

        private DataSet GetUser()
        {
            DataSet ds = new DataSet();
            string constr = @"Data Source=LOURENSV\ECLIPSE;Initial Catalog=Tch;Integrated Security=true";
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query = @"Select  u.Id , u.Friendly_Name AS""Friendly Name"" , u.Name ,  u.Surname,  u.Contact_Number AS "" Contact Number"", u.Email_Address AS ""Email Address"",FORMAT(u.Date_of_Birth, 'dd/MM/yyyy') AS ""Date of Birth"",c.Name AS ""Company"",u.Can_Login AS ""CanLogin""from Users u Join Companies c on c.Id = u.CompanyId";
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Connection = con;
                    DataTable UserTable = new DataTable("Users");
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        con.Open();
                        sda.Fill(ds);
                        con.Close();
                    }
                }
            }

            return ds;
        }
    }
}
