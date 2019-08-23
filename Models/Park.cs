using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NationParkAPI.Models
{
    [Table("parks")]
    public class Park
    {
        [Key]
        public int ParkId { get; set; }
        public string parkName { get; set; }

    
    }
}