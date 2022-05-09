using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Http;

namespace Tch.Models
{
    public class User
    {
        public  int Id { get; set; }
        public string Friendly_Name { get; set; }
      [Required]
        public string Name { get; set; }
        [Required]
        public string  Surname { get; set; }
        public string Contact_Number { get; set; }

        public string Email_Address { get; set; }
 
        public DateTime Date_of_Birth { get; set; }
        [Required]
        public int Age { get; set; }
        [NotMapped]
        public string? Company_name { get; set; }
        [NotMapped]
         public Company? Company { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        public bool Can_Login { get; set; }
        public byte[] Picture { get; set; }
        [Required]
        [ForeignKey("Company")]
        public int CompanyId { get; set; }
        public string PictureFileName { get; set; }
        [NotMapped]
        public Image PictureFile { get; set; }

    }
}
