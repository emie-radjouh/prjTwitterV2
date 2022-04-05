using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace prjTwitterV2.Models
{
    public class Follow
    {
        [Required]
        public string FollowerUsername { get; set; }

        [Required]
        public string FollowingUsername { get; set; }
    }
}
