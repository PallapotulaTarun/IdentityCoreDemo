using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IdentityCoreDemo.Models
{
    public class BookTicket
    {
        [Key]
        public int BookId { get; set; }
        
        public int SeatNum { get; set; }
        public string Slot { get; set; }
        public DateTime Date { get; set; }
    }
}
