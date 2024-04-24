using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_Facebook.DAL.Models
{
    public class User: IdentityUser
    {
        public byte[] Photo { get; set; }
        [MaxLength(100)]

        public string BIO { get; set; }
        [Required(ErrorMessage = "Please Enter a Your BirthDate")]
        public DateTime BirthDate { get; set; }
        [Required(ErrorMessage = "Please Enter a Valid Number Phone")]
        [Phone]
        public string Phone { get; set; } 
        public string Gender { get; set; }
        public virtual List<Post> Posts { get; set; } = new List<Post>();





    }
}
