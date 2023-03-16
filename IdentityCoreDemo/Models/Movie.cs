using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace IdentityCoreDemo.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public int Rating { get; set; }
        public string Location { get; set; }
        public int Charges { get; set; }
        public string TheatreName { get; set; }
        public string Image { get; set; }
    }
}
