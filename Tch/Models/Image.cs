using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tch.Models
{
    public class Image
    {
        public int ID { get; set; }
        [Required]
        public byte[] Picture{ get; set; }
    }
}
