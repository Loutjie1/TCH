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

namespace Tch.Controllers
{
    [Route("/api/GetCompanies")]
    [ApiController]
    public class CompanyDBTController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataContext _context;

        public CompanyDBTController(ILogger<HomeController> logger, DataContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult GetCompanies()
        {
            try
            {
                var draw = Request.Form["draw"].FirstOrDefault();
                var start = Request.Form["start"].FirstOrDefault();
                var length = Request.Form["length"].FirstOrDefault();
                var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
                var sortColumnDirection = Request.Form["order[0][dir]"].FirstOrDefault();
                var searchValue = Request.Form["search[value"].FirstOrDefault();
                int pageSize = length != null ? Convert.ToInt32(length) : 0;
                int skip = start != null ? Convert.ToInt32(start) : 0;
                int recordsTotal = 0;

                var CompanyData = (from tempCompany in _context.Companies
                                   select tempCompany);
                if (!string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDirection))
                {
                    CompanyData = CompanyData.OrderBy(sortColumn + " " + sortColumnDirection);
                }
                if (!string.IsNullOrEmpty(searchValue))
                {
                    CompanyData = CompanyData.Where(m => m.Name.Contains(searchValue)
                                                || m.Contact_Number.Contains(searchValue)
                                                || m.Registration_No.Contains(searchValue));
                }
                recordsTotal = CompanyData.Count();
                var data = CompanyData.Skip(skip).Take(pageSize).ToList();
                var jsonData = new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data };
                return Ok(jsonData);

            }
            catch (Exception)
            {

                throw;

            }
        }
    }
}
