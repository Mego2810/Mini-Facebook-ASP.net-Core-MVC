using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_Facebook.DAL.Models
{
    public class Posts
    {
        [Key]
        public int PostID { get; set; }

        [Column("UserId")]
        public int UserId { get; set; }
        public DateTime DateOfCreation { get; set; }
        [Required]
        public string Content { get; set; }

        [ForeignKey("UseId")]
        public virtual User User { get; set; }

    }
}
