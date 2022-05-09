using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Tch.Controllers
{
    public class ExportCompController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Export()
        {


            using (XLWorkbook wb = new XLWorkbook())
            {
                DataTable dt = this.GetCompany().Tables[0];
                wb.Worksheets.Add(dt);

                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.ms-excel", "Companies.csv");
                }
            }
        }

        private DataSet GetCompany()
        {
            DataSet ds = new DataSet();
            string constr = @"Data Source=LOURENSV\ECLIPSE;Initial Catalog=Tch;Integrated Security=true";
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query = @"SELECT c.Name,c.Contact_Number as 'Contact Number ',c.Registration_No as 'Registration No',CASE WHEN c.Active = 1 THEN 'Yes' ELSE 'No' END AS Active FROM Companies c (nolock)";
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Connection = con;
                    DataTable UserTable = new DataTable("Companies");
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
