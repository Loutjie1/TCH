using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tch.Models
{
    public class Company
    {

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Contact_Number { get; set; }
        [Required]
        public string  Registration_No { get; set; }
        public bool Active { get; set; }
    }
}
