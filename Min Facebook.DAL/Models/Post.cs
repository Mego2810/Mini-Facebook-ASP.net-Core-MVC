using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_Facebook.DAL.Models
{
    public class Post
    {
        [Key]
        public int PostID { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        public DateTime DateOfCreation { get; set; }
        [Required]
        public string Content { get; set; }

        public virtual User User { get; set; }

    }
}
