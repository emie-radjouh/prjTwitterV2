using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace prjTwitterV2.Models
{
    [Index(nameof(Email), IsUnique = true)]
    [Index(nameof(Phone), IsUnique = true)]
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [MinLength(8)]
        [StringLength(50)]
        [Key]
        public string Username{ get; set; }
        
        [Required]
        [MinLength(8)]
        [StringLength(100)]
        public string Password { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string Phone { get; set; }
        public string Banner { get; set; }
        public string Avatar { get; set; }
        
        [StringLength(250)]
        [Required]
        public string Name { get; set; }
        public string Bio { get; set; }
        public string Location { get; set; }
        public string Website { get; set; }
        
        [Required]
        public int Month { get; set; }
        
        [Required]
        public int Day { get; set; }
        
        [Required]
        public int Year { get; set; }
    }
}
