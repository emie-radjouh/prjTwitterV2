using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace prjTwitterV2.Models
{
    public class Tweet
    {
        public int ID { get; set; }

        [Required]
        public User Author { get; set; }

        [StringLength(140)]
        [Required]
        public string Message { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }
    }
}
