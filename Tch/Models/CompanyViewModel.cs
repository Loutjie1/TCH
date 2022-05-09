using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Tch.Models
{
    public class CompanyViewModel
    {
        [DisplayName("Company")]
        public string ComId { get; set; }
        public string CName { get; set; }
        public List<SelectListItem> ListOfCompanies { get; set; }
    }
}
