using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogItla.Models.ViewModels
{
    public class PostViewModel
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string SubTitle { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string PostBody { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime? PostDate { get; set; }

        public string UserId { get; set; }

        //public int? WallId { get; set; }
    }
}
